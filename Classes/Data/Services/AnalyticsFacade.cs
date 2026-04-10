using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;
using System.Text;

namespace SmartStock.Classes.Data.Services
{
    public class AnalyticsFacade
    {
        private readonly IEconometricEngine _econometricEngine;
        private readonly IExternalDataProvider _externalDataProvider;
        private readonly IAIReasoningProvider _aiReasoningProvider;
        private readonly ILLMPromptBuilder _promptBuilder;
        private readonly IRepository<SaleDetails> _saleDetailsRepository;
        private readonly IRepository<AiForecast> _forecastRepository;
        private readonly IRepository<Product> _productRepository;
        private readonly IRepository<EconometricModel> _econometricModelRepository;
        private readonly IRepository<AiStockRecommendation> _stockRecommendationRepository;

        public AnalyticsFacade(
            IEconometricEngine econometricEngine,
            IExternalDataProvider externalDataProvider,
            IAIReasoningProvider aiReasoningProvider,
            ILLMPromptBuilder promptBuilder,
            IRepository<SaleDetails> saleDetailsRepository,
            IRepository<AiForecast> forecastRepository,
            IRepository<Product> productRepository,
            IRepository<EconometricModel> econometricModelRepository,
            IRepository<AiStockRecommendation> stockRecommendationRepository)
        {
            _econometricEngine = econometricEngine ?? throw new ArgumentNullException(nameof(econometricEngine));
            _externalDataProvider = externalDataProvider ?? throw new ArgumentNullException(nameof(externalDataProvider));
            _aiReasoningProvider = aiReasoningProvider ?? throw new ArgumentNullException(nameof(aiReasoningProvider));
            _promptBuilder = promptBuilder ?? throw new ArgumentNullException(nameof(promptBuilder));
            _saleDetailsRepository = saleDetailsRepository ?? throw new ArgumentNullException(nameof(saleDetailsRepository));
            _forecastRepository = forecastRepository ?? throw new ArgumentNullException(nameof(forecastRepository));
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _econometricModelRepository = econometricModelRepository ?? throw new ArgumentNullException(nameof(econometricModelRepository));
            _stockRecommendationRepository = stockRecommendationRepository ?? throw new ArgumentNullException(nameof(stockRecommendationRepository));
        }

        public async Task<AnalyticsResult> RunAnalysisAsync(AnalysisContext context, CancellationToken cancellationToken = default)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            if (context.ProductId <= 0)
                throw new InvalidOperationException("A valid product must be selected.");

            var aggregationLevel = context.Parameters.TryGetValue("AggregationLevel", out var agg) ? agg.ToString() : "Daily";
            var selectedFactors = GetSelectedFactors(context.Parameters);
            var primaryFactor = GetStringParameter(context.Parameters, "PrimaryFactor");
            var lagDays = GetIntParameter(context.Parameters, "LagDays");
            var forecastHorizonDays = GetIntParameter(context.Parameters, "ForecastHorizonDays", 30);
            var confidencePercent = GetConfidencePercent(context.Parameters);
            var isDemandForecast = context.AnalysisType.Equals("Demand Forecast", StringComparison.OrdinalIgnoreCase);
            var isStockOptimization = context.AnalysisType.Equals("Stock Optimization", StringComparison.OrdinalIgnoreCase);

            var product = await _productRepository
                .GetAll()
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.ProductId == context.ProductId, cancellationToken)
                ?? throw new InvalidOperationException("Selected product was not found.");
            var rawSalesData = await _saleDetailsRepository
                .GetAll()
                .Include(sd => sd.Sale)
                .Where(sd => sd.ProductId == context.ProductId &&
                             sd.Sale.SaleDate >= context.StartDate &&
                             sd.Sale.SaleDate <= context.EndDate)
                .Select(sd => new { sd.Sale.SaleDate, sd.Quantity })
                .ToListAsync(cancellationToken);

            // ── EOQ branch — skip the OLS pipeline entirely ──────────────────────
            if (isStockOptimization)
            {
                var dailyDemandSeries = rawSalesData
                    .GroupBy(sd => sd.SaleDate.Date)
                    .Select(g => (decimal)g.Sum(x => x.Quantity))
                    .ToList();

                var orderingCost      = GetDecimalParameter(context.Parameters, "OrderingCost", 50m);
                var holdingCostPct    = GetDecimalParameter(context.Parameters, "HoldingCostPercent", 20m);
                var leadTimeDays      = GetIntParameter(context.Parameters, "LeadTimeDays", 7);
                var riskTolerance     = GetStringParameter(context.Parameters, "RiskTolerance");
                if (string.IsNullOrWhiteSpace(riskTolerance)) riskTolerance = "Medium";

                var eoq = ComputeEoq(dailyDemandSeries, product, orderingCost, holdingCostPct, leadTimeDays, riskTolerance)
                    ?? throw new InvalidOperationException(
                        "Nu există suficiente date de vânzări pentru calculul EOQ. " +
                        "Selectați un interval cu cel puțin 7 zile de vânzări și introduceți parametri valizi (S > 0, h > 0).");

                var eoqPrompt = BuildEoqPrompt(product, eoq);
                var eoqReco   = await _aiReasoningProvider.GetRecommendationAsync(eoqPrompt);

                await PersistStockRecommendationAsync(context.ProductId, eoq, eoqReco.Reasoning, product, cancellationToken);

                return new AnalyticsResult
                {
                    Eoq             = eoq,
                    AiInsights      = eoqReco.Reasoning,
                    Reliability     = eoq.ServiceLevel,
                    TrendLabel      = $"{eoq.EoqQuantity:F0}",
                    AiConfidence    = eoq.ServiceLevel,
                    ChartLabels     = eoq.QuantityLabels,
                    HistoricalSales = eoq.TotalCostCurve.Select(v => (decimal)v).ToList(),
                    TrendValues     = eoq.OrderingCostCurve.Select(v => (decimal)v).ToList(),
                    UpperBond       = eoq.HoldingCostCurve.Select(v => (decimal)v).ToList()
                };
            }
            var aggregatedData = rawSalesData
                .GroupBy(sd => {
                    var d = sd.SaleDate.Date;
                    return aggregationLevel switch
                    {
                        "Weekly" => d.AddDays(-(int)d.DayOfWeek), // Grupează pe prima zi a săptămânii
                        "Monthly" => new DateTime(d.Year, d.Month, 1), // Grupează pe prima zi a lunii
                        _ => d // Daily
                    };
                })
                .Select(g => new { Date = g.Key, TotalQuantity = g.Sum(x => x.Quantity) })
                .OrderBy(g => g.Date)
                .ToList();

            var historicalDates = aggregatedData.Select(x => x.Date).ToList();
            var historicalSales = aggregatedData.Select(x => (decimal)x.TotalQuantity).ToList();

            var forecastEndDate = isDemandForecast
                ? context.EndDate.AddDays(Math.Max(1, forecastHorizonDays))
                : context.EndDate;

            var forecasts = await _forecastRepository
                .GetAll()
                .Where(f => f.ProductId == context.ProductId &&
                            f.ForecastDate >= context.StartDate &&
                            f.ForecastDate <= forecastEndDate)
                .OrderBy(f => f.ForecastDate)
                .AsNoTracking()
                .ToListAsync(cancellationToken);

            var factors = await _externalDataProvider.GetFactorsAsync(context.StartDate, context.EndDate, cancellationToken);
            factors = FilterFactors(factors, selectedFactors, primaryFactor);

            if (lagDays != 0)
            {
                factors = factors
                    .Select(f => new ExternalFactor
                    {
                        FactorId = f.FactorId,
                        FactorType = f.FactorType,
                        Description = f.Description,
                        Region = f.Region,
                        ImpactValue = f.ImpactValue,
                        ValueType = f.ValueType,
                        Date = f.Date.AddDays(lagDays),
                        IsActive = f.IsActive
                    })
                    .ToList();
            }

            var econometricModel = await _econometricEngine.GetTrendAnalysisAsync(
                context.ProductId,
                factors,
                context.StartDate,
                context.EndDate,
                historicalSales);

            var trendBands = BuildTrendValues(
                historicalSales,
                econometricModel.CoefficientValue,
                isDemandForecast,
                forecasts,
                context.EndDate,
                forecastHorizonDays,
                confidencePercent);

            var chartDates = BuildChartDates(historicalDates, context.EndDate, isDemandForecast, forecastHorizonDays);
            var chartLabels = chartDates.Select(d => d.ToString("dd MMM")).ToList();

            var basePrompt = _promptBuilder.BuildInventoryPrompt(product, factors, forecasts);
            var prompt = BuildAnalysisAwarePrompt(
                basePrompt,
                context,
                historicalSales,
                trendBands.TrendValues,
                econometricModel,
                forecasts);

            var recommendation = await _aiReasoningProvider.GetRecommendationAsync(prompt);

            await PersistEconometricModelAsync(econometricModel, cancellationToken);
            if (isDemandForecast)
                await PersistForecastsAsync(context.ProductId, trendBands.TrendValues, historicalSales.Count, context.EndDate, forecastHorizonDays, econometricModel.RSquared, cancellationToken);

            return new AnalyticsResult
            {
                EconometricModel = econometricModel,
                Forecasts = forecasts,
                Factors = factors,
                HistoricalSales = historicalSales,
                TrendValues = trendBands.TrendValues,
                UpperBond = trendBands.UpperBond,
                LowerBond = trendBands.LowerBond,
                StandardError = trendBands.StandardError,
                ConfidencePercent = confidencePercent,
                ChartLabels = chartLabels,
                AiInsights = recommendation.Reasoning,
                Reliability = econometricModel.RSquared,
                TrendLabel = GetTrendPercentageLabel(historicalSales, trendBands.TrendValues, isDemandForecast),
                AiConfidence = forecasts.Count == 0 ? 0m : forecasts.Average(f => f.ConfidenceScore)
            };
        }

        private static TrendBandResult BuildTrendValues(
            List<decimal> historicalSales,
            decimal slope,
            bool isDemandForecast,
            List<AiForecast> forecasts,
            DateTime endDate,
            int forecastHorizonDays,
            int confidencePercent)
        {
            // CRITICAL FIX: Evităm crash-ul dacă nu avem vânzări în intervalul selectat
            if (historicalSales == null || historicalSales.Count < 2)
            {
                var emptyTrend = historicalSales ?? new List<decimal>();
                return new TrendBandResult
                {
                    TrendValues = emptyTrend,
                    UpperBond = emptyTrend.ToList(),
                    LowerBond = emptyTrend.Select(v => Math.Max(0m, v)).ToList(),
                    StandardError = 0m
                };
            }

            // Calculăm intercept-ul (b) pentru y = ax + b
            var meanX = (historicalSales.Count + 1) / 2m;
            var meanY = historicalSales.Average();
            var intercept = meanY - (slope * meanX);

            var trendValues = new List<decimal>();

            // 1. Calculăm linia de trend pentru datele istorice
            for (var i = 0; i < historicalSales.Count; i++)
            {
                trendValues.Add((slope * (i + 1)) + intercept);
            }

            // 2. Extindem trendul în viitor (Prognoză)
            if (isDemandForecast)
            {
                var horizon = Math.Max(1, forecastHorizonDays);
                for (var i = 1; i <= horizon; i++)
                {
                    var futureX = historicalSales.Count + i;
                    trendValues.Add((slope * futureX) + intercept);
                }
            }

            var historicalTrendValues = trendValues.Take(historicalSales.Count).ToList();
            var standardError = CalculateStandardError(historicalSales, historicalTrendValues);
            var zScore = MapConfidenceToZScore(confidencePercent);
            var (upperBond, lowerBond) = BuildConfidenceBounds(trendValues, zScore, standardError, historicalSales.Count);

            return new TrendBandResult
            {
                TrendValues = trendValues,
                UpperBond = upperBond,
                LowerBond = lowerBond,
                StandardError = standardError
            };
        }

        private static List<DateTime> BuildChartDates(
            List<DateTime> historicalDates,
            DateTime endDate,
            bool isDemandForecast,
            int forecastHorizonDays)
        {
            var chartDates = new List<DateTime>(historicalDates ?? new List<DateTime>());

            if (!isDemandForecast)
                return chartDates;

            var horizon = Math.Max(1, forecastHorizonDays);

            for (var i = 1; i <= horizon; i++)
            {
                var date = endDate.Date.AddDays(i);
                chartDates.Add(date);
            }

            return chartDates.OrderBy(d => d).ToList();
        }

        private static List<ExternalFactor> FilterFactors(List<ExternalFactor> factors, List<string> selectedFactors, string primaryFactor)
        {
            if (factors == null || factors.Count == 0)
                return new List<ExternalFactor>();

            if (!string.IsNullOrWhiteSpace(primaryFactor) &&
                !primaryFactor.Equals("No Factors Available", StringComparison.OrdinalIgnoreCase))
            {
                return factors
                    .Where(f => !string.IsNullOrWhiteSpace(f.FactorType) &&
                                f.FactorType.Equals(primaryFactor, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            if (selectedFactors.Count == 0)
                return factors;

            return factors
                .Where(f => selectedFactors.Any(selected =>
                    (!string.IsNullOrWhiteSpace(f.Description) &&
                     f.Description.Contains(selected, StringComparison.OrdinalIgnoreCase)) ||
                    (!string.IsNullOrWhiteSpace(f.FactorType) &&
                     f.FactorType.Contains(selected, StringComparison.OrdinalIgnoreCase))))
                .ToList();
        }

        private static string GetStringParameter(Dictionary<string, object> parameters, string key)
        {
            if (parameters == null || !parameters.TryGetValue(key, out var rawValue) || rawValue == null)
                return string.Empty;

            return rawValue.ToString() ?? string.Empty;
        }

        private static List<string> GetSelectedFactors(Dictionary<string, object> parameters)
        {
            if (parameters == null || !parameters.TryGetValue("SelectedFactors", out var selectedFactorsValue) || selectedFactorsValue == null)
                return new List<string>();

            if (selectedFactorsValue is List<string> stringList)
                return stringList.Where(v => !string.IsNullOrWhiteSpace(v)).ToList();

            if (selectedFactorsValue is IEnumerable<object> objectList)
                return objectList.Select(x => x?.ToString() ?? string.Empty)
                                 .Where(v => !string.IsNullOrWhiteSpace(v))
                                 .ToList();

            return new List<string>();
        }

        private static int GetIntParameter(Dictionary<string, object> parameters, string key, int defaultValue = 0)
        {
            if (parameters == null || !parameters.TryGetValue(key, out var rawValue) || rawValue == null)
                return defaultValue;

            if (rawValue is int intValue)
                return intValue;

            if (int.TryParse(rawValue.ToString(), out var parsed))
                return parsed;

            return defaultValue;
        }

        private static int GetConfidencePercent(Dictionary<string, object> parameters)
        {
            var value = GetIntParameter(parameters, "ConfidenceInterval", 0);
            if (value <= 0)
            {
                value = GetIntParameter(parameters, "ConfidencePercent", 95);
            }

            return Math.Max(50, Math.Min(99, value));
        }

        private static decimal CalculateStandardError(List<decimal> historicalSales, List<decimal> historicalTrendValues)
        {
            if (historicalSales == null || historicalTrendValues == null)
                return 0m;

            var n = Math.Min(historicalSales.Count, historicalTrendValues.Count);
            if (n < 2)
                return 0m;

            decimal sumSquaredResiduals = 0m;
            for (var i = 0; i < n; i++)
            {
                var residual = historicalSales[i] - historicalTrendValues[i];
                sumSquaredResiduals += residual * residual;
            }

            var divisor = Math.Max(1, n - 2);
            var variance = sumSquaredResiduals / divisor;
            return (decimal)Math.Sqrt((double)variance);
        }

        private static decimal MapConfidenceToZScore(int confidencePercent)
        {
            return confidencePercent switch
            {
                >= 99 => 2.58m,
                >= 98 => 2.33m,
                >= 95 => 1.96m,
                >= 90 => 1.645m,
                >= 85 => 1.44m,
                >= 80 => 1.282m,
                _ => 1.0m
            };
        }

        private static (List<decimal> upperBond, List<decimal> lowerBond) BuildConfidenceBounds(
            List<decimal> trendValues,
            decimal zScore,
            decimal standardError,
            int historicalCount)
        {
            if (trendValues == null || trendValues.Count == 0)
                return (new List<decimal>(), new List<decimal>());

            // Benzi de confidență / predicție OLS standard
            //
            // Datele istorice: x = [1, 2, ..., n], deci:
            //   x̄  = (n + 1) / 2
            //   Sxx = Σ(xᵢ - x̄)² = n(n² - 1) / 12
            //
            // Interval de confidență pentru puncte istorice (media răspunsului):
            //   margin = z · SEE · √(1/n + (xᵢ - x̄)² / Sxx)
            //
            // Interval de predicție pentru puncte viitoare (o nouă observație):
            //   margin = z · SEE · √(1 + 1/n + (x₀ - x̄)² / Sxx)
            //
            // Banda se îngustează la x̄ și se lărgește spre extremele seriei,
            // apoi continuă să se lărgească pe măsură ce orizontul de prognoză crește.

            int n = historicalCount;
            if (n < 2 || standardError <= 0m)
            {
                var flat = trendValues.Select(v => v).ToList();
                return (flat, flat.ToList());
            }

            double meanX = (n + 1) / 2.0;
            double sxx = n * ((double)n * n - 1.0) / 12.0; // Sxx exact pentru x=1..n

            var upper = new List<decimal>(trendValues.Count);
            var lower = new List<decimal>(trendValues.Count);

            for (var i = 0; i < trendValues.Count; i++)
            {
                double xi = i + 1;                   // indice temporal (1-bazat)
                bool isFuture = i >= n;

                double leverage = 1.0 / n + Math.Pow(xi - meanX, 2) / sxx;
                double intervalMultiplier = isFuture
                    ? Math.Sqrt(1.0 + leverage)      // PI — include variabilitatea unei noi obs.
                    : Math.Sqrt(leverage);             // CI — doar incertitudinea mediei ajustate

                var margin = zScore * standardError * (decimal)intervalMultiplier;
                upper.Add(trendValues[i] + margin);
                lower.Add(Math.Max(0m, trendValues[i] - margin));
            }

            return (upper, lower);
        }

        private sealed class TrendBandResult
        {
            public List<decimal> TrendValues { get; set; } = new();
            public List<decimal> UpperBond { get; set; } = new();
            public List<decimal> LowerBond { get; set; } = new();
            public decimal StandardError { get; set; }
        }

        private static string GetTrendPercentageLabel(List<decimal> historicalSales, List<decimal> trendValues, bool isDemandForecast)
        {
            if (historicalSales == null || historicalSales.Count == 0)
                return "0.00%";

            var firstWeekCount = Math.Min(7, historicalSales.Count);
            if (firstWeekCount == 0)
                return "0.00%";

            var firstWeekAverage = historicalSales.Take(firstWeekCount).Average();

            decimal comparisonAverage;
            if (isDemandForecast && trendValues != null && trendValues.Count > historicalSales.Count)
            {
                var forecastSegment = trendValues.Skip(historicalSales.Count).ToList();
                var forecastWindow = Math.Min(7, forecastSegment.Count);
                if (forecastWindow == 0)
                    return "0.00%";

                comparisonAverage = forecastSegment.Take(forecastWindow).Average();
            }
            else
            {
                var lastWeekCount = Math.Min(7, historicalSales.Count);
                comparisonAverage = historicalSales.Skip(historicalSales.Count - lastWeekCount).Average();
            }

            if (Math.Abs(firstWeekAverage) < 0.0001m)
                return "0.00%";

            var trendPercentage = ((comparisonAverage - firstWeekAverage) / Math.Abs(firstWeekAverage)) * 100m;
            return trendPercentage >= 0
                ? $"+{trendPercentage:F2}%"
                : $"{trendPercentage:F2}%";
        }

        private static string BuildAnalysisAwarePrompt(
            string basePrompt,
            AnalysisContext context,
            List<decimal> historicalSales,
            List<decimal> trendValues,
            EconometricModel econometricModel,
            List<AiForecast> forecasts)
        {
            var firstHistorical = historicalSales.Count > 0 ? historicalSales.First() : 0m;
            var lastHistorical = historicalSales.Count > 0 ? historicalSales.Last() : 0m;
            var firstTrend = trendValues.Count > 0 ? trendValues.First() : 0m;
            var lastTrend = trendValues.Count > 0 ? trendValues.Last() : 0m;
            var avgForecastConfidence = forecasts.Count > 0 ? forecasts.Average(f => f.ConfidenceScore) : 0m;

            var parameterSummary = BuildParameterSummary(context.Parameters);

            var builder = new StringBuilder(basePrompt);
            builder.AppendLine();
            builder.AppendLine();
            builder.AppendLine("analysisContext:");
            builder.AppendLine($"- analysisType: {context.AnalysisType}");
            builder.AppendLine($"- period: {context.StartDate:yyyy-MM-dd} to {context.EndDate:yyyy-MM-dd}");
            builder.AppendLine($"- selectedParameters: {parameterSummary}");
            builder.AppendLine("- computedMetrics:");
            builder.AppendLine($"  - rSquared: {econometricModel.RSquared:F4}");
            builder.AppendLine($"  - slope: {econometricModel.CoefficientValue:F4}");
            builder.AppendLine($"  - firstHistoricalDailyTotal: {firstHistorical:F2}");
            builder.AppendLine($"  - lastHistoricalDailyTotal: {lastHistorical:F2}");
            builder.AppendLine($"  - firstTrendValue: {firstTrend:F2}");
            builder.AppendLine($"  - lastTrendValue: {lastTrend:F2}");
            builder.AppendLine($"  - averageForecastConfidence: {avgForecastConfidence:F4}");
            builder.AppendLine("instructions:");
            builder.AppendLine($"- Tailor reasoning specifically for '{context.AnalysisType}'.");
            builder.AppendLine("- Mention how selected parameters influenced the recommendation.");
            builder.AppendLine("- Keep the recommendation consistent with the computed metrics above.");

            return builder.ToString();
        }

        private static string BuildParameterSummary(Dictionary<string, object> parameters)
        {
            if (parameters == null || parameters.Count == 0)
                return "none";

            var entries = parameters.Select(p => $"{p.Key}={FormatParameterValue(p.Value)}");
            return string.Join(", ", entries);
        }

        private static string FormatParameterValue(object? value)
        {
            if (value == null)
                return "null";

            if (value is string s)
                return s;

            if (value is IEnumerable<string> stringEnumerable)
                return $"[{string.Join("|", stringEnumerable)}]";

            if (value is System.Collections.IEnumerable enumerable)
            {
                var values = enumerable.Cast<object?>().Select(v => v?.ToString() ?? "null");
                return $"[{string.Join("|", values)}]";
            }

            return value.ToString() ?? string.Empty;
        }

        // ── Persistence helpers ───────────────────────────────────────────────────

        private async Task PersistEconometricModelAsync(EconometricModel model, CancellationToken cancellationToken)
        {
            try
            {
                _econometricModelRepository.Add(new EconometricModel
                {
                    ModelName        = model.ModelName,
                    CoefficientValue = model.CoefficientValue,
                    PValue           = model.PValue,
                    RSquared         = model.RSquared,
                    LastTrainedDate  = DateTime.Now
                });
                await _econometricModelRepository.SaveAsync(cancellationToken);
            }
            catch
            {
                // Clear the change tracker so the stuck entity doesn't contaminate
                // the subsequent PersistForecastsAsync call on the same shared context.
                _econometricModelRepository.ClearChanges();
            }
        }

        private async Task PersistForecastsAsync(
            int productId,
            List<decimal> allTrendValues,
            int historicalCount,
            DateTime endDate,
            int horizonDays,
            decimal rSquared,
            CancellationToken cancellationToken)
        {
            try
            {
                var horizon      = Math.Max(1, horizonDays);
                var forecastStart = endDate.Date.AddDays(1);
                var forecastEnd   = endDate.Date.AddDays(horizon);

                var existing = await _forecastRepository.FindAsync(
                    f => f.ProductId == productId &&
                         f.ForecastDate >= forecastStart &&
                         f.ForecastDate <= forecastEnd);

                if (existing.Count > 0)
                    _forecastRepository.DeleteRange(existing);

                var futureTrend = allTrendValues.Skip(historicalCount).ToList();
                var confidenceScore = Math.Max(0m, Math.Min(1m, rSquared));

                var newForecasts = futureTrend
                    .Take(horizon)
                    .Select((value, i) => new AiForecast
                    {
                        ProductId       = productId,
                        ForecastDate    = forecastStart.AddDays(i),
                        PredictedDemand = Math.Max(0m, Math.Round(value, 2)),
                        ConfidenceScore = Math.Round(confidenceScore, 4),
                        ModelVersion    = "OLS-v1"
                    })
                    .ToList();

                if (newForecasts.Count > 0)
                    _forecastRepository.AddRange(newForecasts);

                await _forecastRepository.SaveAsync(cancellationToken);
            }
            catch
            {
                _forecastRepository.ClearChanges();
            }
        }

        private async Task PersistStockRecommendationAsync(
            int productId,
            EoqResult eoq,
            string aiReasoning,
            Product product,
            CancellationToken cancellationToken)
        {
            try
            {
                var priorityLevel = product.CurrentStock < (double)eoq.ReorderPoint
                    ? "High"
                    : product.CurrentStock < (double)(eoq.ReorderPoint * 1.5m)
                        ? "Medium"
                        : "Low";

                var reasoning = string.IsNullOrWhiteSpace(aiReasoning)
                    ? $"EOQ={eoq.EoqQuantity:F0} units, ROP={eoq.ReorderPoint:F0} units, SS={eoq.SafetyStock:F0} units."
                    : aiReasoning.Length > 500 ? aiReasoning[..500] : aiReasoning;

                _stockRecommendationRepository.Add(new AiStockRecommendation
                {
                    ProductId        = productId,
                    SuggestedQuantity = (int)Math.Round(eoq.EoqQuantity),
                    PriorityLevel    = priorityLevel,
                    Reasoning        = reasoning,
                    CreatedAt        = DateTime.Now
                });
                await _stockRecommendationRepository.SaveAsync(cancellationToken);
            }
            catch
            {
                _stockRecommendationRepository.ClearChanges();
            }
        }

        // ── EOQ ───────────────────────────────────────────────────────────────────

        /// <summary>
        /// Calculează modelul EOQ complet cu stoc de siguranță statistic.
        ///
        /// Formule:
        ///   Q* = √(2 × D × S / H)          — Wilson (1913)
        ///   SS = z × σ_d × √L              — Normality assumption pe cererea în lead time
        ///   ROP = d̄ × L + SS
        ///   TC  = (D/Q*) × S + (Q*/2 + SS) × H
        /// </summary>
        private static EoqResult? ComputeEoq(
            List<decimal> dailySales,
            Product product,
            decimal orderingCost,
            decimal holdingCostPercent,
            int leadTimeDays,
            string riskTolerance)
        {
            if (dailySales == null || dailySales.Count < 7) return null;
            if (orderingCost <= 0 || holdingCostPercent <= 0 || product.UnitPrice <= 0) return null;

            // ── Statistici cerere zilnică ──────────────────────────────────────
            decimal dMean = dailySales.Average();
            if (dMean <= 0) return null;

            // Abatere standard eșantion (Bessel correction: n-1)
            decimal sumSqDev = dailySales.Sum(x => (x - dMean) * (x - dMean));
            decimal sigma = (decimal)Math.Sqrt((double)(sumSqDev / Math.Max(1, dailySales.Count - 1)));

            decimal annualDemand = dMean * 365m;

            // ── Parametri cost ─────────────────────────────────────────────────
            // H = h × P (cost de deținere per unitate per an)
            decimal H = (holdingCostPercent / 100m) * product.UnitPrice;

            // ── Q* — formula Wilson ───────────────────────────────────────────
            decimal eoqQty = (decimal)Math.Sqrt((double)(2m * annualDemand * orderingCost / H));
            eoqQty = Math.Round(Math.Max(1m, eoqQty), 0);

            // ── Nivel de serviciu → z-score ────────────────────────────────────
            var (z, svcLevel) = riskTolerance switch
            {
                "Low"  => (1.282m, 0.90m),
                "High" => (2.326m, 0.99m),
                _      => (1.645m, 0.95m)   // Medium (default)
            };

            // ── Stoc de siguranță & punct de reaprovizionare ───────────────────
            // SS = z × σ_d × √L  — presupune cererea pe lead time ~ N(d̄·L, σ²·L)
            decimal ss  = z * sigma * (decimal)Math.Sqrt(Math.Max(1, leadTimeDays));
            ss           = Math.Round(Math.Max(0m, ss), 0);
            decimal rop = Math.Round(dMean * leadTimeDays + ss, 0);

            // ── Descompunere cost anual la Q* ──────────────────────────────────
            decimal ocYear   = (annualDemand / eoqQty) * orderingCost;
            decimal hcYear   = (eoqQty / 2m + ss) * H;
            decimal totalCost = ocYear + hcYear;

            decimal ordersPerYear = Math.Round(annualDemand / eoqQty, 1);
            decimal cycleDays     = Math.Round(eoqQty / dMean, 1);

            // ── Curba de cost: 60 puncte Q ∈ [0.15·Q*, 3·Q*] ──────────────────
            // Demonstrează vizual că Q* minimizează costul total (curba U).
            var totalCostCurve    = new List<double>(60);
            var orderingCostCurve = new List<double>(60);
            var holdingCostCurve  = new List<double>(60);
            var qtyLabels         = new List<string>(60);

            decimal qMin = Math.Max(1m, eoqQty * 0.15m);
            decimal qMax = eoqQty * 3m;
            decimal step = (qMax - qMin) / 59m;

            for (int i = 0; i < 60; i++)
            {
                decimal q  = qMin + i * step;
                double oc  = (double)((annualDemand / q) * orderingCost);
                double hc  = (double)((q / 2m + ss) * H);
                orderingCostCurve.Add(oc);
                holdingCostCurve.Add(hc);
                totalCostCurve.Add(oc + hc);
                qtyLabels.Add(((int)Math.Round(q)).ToString());
            }

            return new EoqResult
            {
                OrderingCostPerOrder = orderingCost,
                HoldingCostPerUnit   = Math.Round(H, 4),
                LeadTimeDays         = leadTimeDays,
                ServiceLevel         = svcLevel,
                ZScore               = z,

                DailyDemandMean   = Math.Round(dMean, 2),
                DailyDemandStdDev = Math.Round(sigma, 2),
                AnnualDemand      = Math.Round(annualDemand, 0),

                EoqQuantity    = eoqQty,
                SafetyStock    = ss,
                ReorderPoint   = rop,
                OrdersPerYear  = ordersPerYear,
                CycleTimeDays  = cycleDays,

                OrderingCostPerYear = Math.Round(ocYear, 2),
                HoldingCostPerYear  = Math.Round(hcYear, 2),
                TotalAnnualCost     = Math.Round(totalCost, 2),

                TotalCostCurve    = totalCostCurve,
                OrderingCostCurve = orderingCostCurve,
                HoldingCostCurve  = holdingCostCurve,
                QuantityLabels    = qtyLabels
            };
        }

        private static string BuildEoqPrompt(Product product, EoqResult eoq)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"product: {product.ProductName}");
            sb.AppendLine($"currentStock: {product.CurrentStock} {product.UnitOfMeasure}");
            sb.AppendLine($"unitPrice: {product.UnitPrice}");
            sb.AppendLine();
            sb.AppendLine("demandStatistics:");
            sb.AppendLine($"  dailyMean: {eoq.DailyDemandMean:F2} units/day");
            sb.AppendLine($"  dailyStdDev: {eoq.DailyDemandStdDev:F2} units/day");
            sb.AppendLine($"  annualDemand: {eoq.AnnualDemand:F0} units/year");
            sb.AppendLine();
            sb.AppendLine("eoqParameters:");
            sb.AppendLine($"  orderingCost: {eoq.OrderingCostPerOrder} per order");
            sb.AppendLine($"  holdingCostPerUnit: {eoq.HoldingCostPerUnit:F4} per unit/year");
            sb.AppendLine($"  leadTimeDays: {eoq.LeadTimeDays}");
            sb.AppendLine($"  serviceLevel: {eoq.ServiceLevel:P0} (z = {eoq.ZScore})");
            sb.AppendLine();
            sb.AppendLine("eoqResults:");
            sb.AppendLine($"  optimalOrderQty (Q*): {eoq.EoqQuantity:F0} units");
            sb.AppendLine($"  safetyStock (SS): {eoq.SafetyStock:F0} units");
            sb.AppendLine($"  reorderPoint (ROP): {eoq.ReorderPoint:F0} units");
            sb.AppendLine($"  ordersPerYear: {eoq.OrdersPerYear:F1}");
            sb.AppendLine($"  cycleTimeDays: {eoq.CycleTimeDays:F1}");
            sb.AppendLine();
            sb.AppendLine("costBreakdown:");
            sb.AppendLine($"  orderingCostPerYear: {eoq.OrderingCostPerYear:F2}");
            sb.AppendLine($"  holdingCostPerYear: {eoq.HoldingCostPerYear:F2}");
            sb.AppendLine($"  totalAnnualCost: {eoq.TotalAnnualCost:F2}");
            sb.AppendLine();
            sb.AppendLine("instructions:");
            sb.AppendLine("- Explain what Q* means for this product and whether it's practical.");
            sb.AppendLine("- Comment on the safety stock level relative to demand variability.");
            if (product.CurrentStock < (double)eoq.ReorderPoint)
                sb.AppendLine($"- WARN: current stock ({product.CurrentStock}) is BELOW the reorder point ({eoq.ReorderPoint:F0}). Immediate action recommended.");
            sb.AppendLine("- Assess whether the ordering cost and holding cost inputs seem realistic.");
            sb.AppendLine("- Keep the recommendation actionable and concise.");
            return sb.ToString();
        }

        private static decimal GetDecimalParameter(Dictionary<string, object> parameters, string key, decimal defaultValue = 0m)
        {
            if (parameters == null || !parameters.TryGetValue(key, out var rawValue) || rawValue == null)
                return defaultValue;
            if (rawValue is decimal dec) return dec;
            if (decimal.TryParse(rawValue.ToString(), out var parsed)) return parsed;
            return defaultValue;
        }
    }
}
