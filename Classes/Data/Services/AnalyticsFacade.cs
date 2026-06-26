using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
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
            var isAnomalyDetection = context.AnalysisType.Equals("Anomaly Detection", StringComparison.OrdinalIgnoreCase);
            var sensitivityThreshold = (double)GetDecimalParameter(context.Parameters, "SensitivityThreshold", 2.0m);

            var product = await _productRepository
                .GetAll()
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.ProductId == context.ProductId, cancellationToken)
                ?? throw new InvalidOperationException("Selected product was not found.");
            // EndDate vine ca dată la miezul nopții (00:00). Vânzările au oră (ex. 14:30),
            // deci `SaleDate <= EndDate` ar exclude TOATE vânzările din chiar ziua de end date
            // → ultima zi din grafic apărea mereu 0. Folosim margine superioară EXCLUSIVĂ la
            // începutul zilei următoare ca să includem întreaga zi de end date.
            var endExclusive = context.EndDate.Date.AddDays(1);
            var rawSalesData = await _saleDetailsRepository
                .GetAll()
                .Include(sd => sd.Sale)
                .Where(sd => sd.ProductId == context.ProductId &&
                             sd.Sale.SaleDate >= context.StartDate &&
                             sd.Sale.SaleDate < endExclusive)
                .Select(sd => new { sd.Sale.SaleDate, sd.Quantity })
                .ToListAsync(cancellationToken);

            // ── EOQ branch — skip the OLS pipeline entirely ──────────────────────
            if (isStockOptimization)
            {
                // ZERO-FILL pe grila calendaristică zilnică: media cererii trebuie să includă
                // și zilele FĂRĂ vânzări, altfel d̄ supraestimează și σ subestimează cererea
                // (→ Q*, SS, ROP deplasate). Vezi docs/ANALYSIS_MODULE_REVIEW.md (A4).
                var salesByDay = rawSalesData
                    .GroupBy(sd => sd.SaleDate.Date)
                    .ToDictionary(g => g.Key, g => (decimal)g.Sum(x => x.Quantity));

                var dailyDemandSeries = BuildBucketGrid(context.StartDate, context.EndDate, "Daily")
                    .Select(d => salesByDay.TryGetValue(d, out var v) ? v : 0m)
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

                // The EOQ analysis is already complete; the AI only adds a written summary.
                // Its failure (e.g. no credits) must NOT abort the analysis.
                string eoqInsights;
                AiStockRecommendation eoqReco = null;
                try
                {
                    eoqReco = await _aiReasoningProvider.GetRecommendationAsync(eoqPrompt);
                    eoqInsights = eoqReco.Reasoning;
                }
                catch (Exception ex)
                {
                    eoqInsights = $"AI summary unavailable: {ExtractProviderError(ex)}";
                }

                // Persist a recommendation only when the AI produced one — keeps error text
                // out of AiStockRecommendations (which the weekly report reads).
                if (eoqReco != null)
                    await PersistStockRecommendationAsync(context.ProductId, eoq, eoqReco.Reasoning, product, cancellationToken);

                ActivityLogger.LogAiAction("STOCK_OPTIMIZATION",
                    $"Product: \"{product.ProductName}\" → EOQ: {eoq.EoqQuantity:F0} units, ROP: {eoq.ReorderPoint:F0}" +
                    (eoqReco != null ? $", Priority: {eoqReco.PriorityLevel}" : " (AI summary unavailable)"));

                return new AnalyticsResult
                {
                    Eoq             = eoq,
                    AiInsights      = eoqInsights,
                    Reliability     = eoq.ServiceLevel,
                    TrendLabel      = $"{eoq.EoqQuantity:F0}",
                    AiConfidence    = eoq.ServiceLevel,
                    ChartLabels     = eoq.QuantityLabels,
                    HistoricalSales = eoq.TotalCostCurve.Select(v => (decimal)v).ToList(),
                    TrendValues     = eoq.OrderingCostCurve.Select(v => (decimal)v).ToList(),
                    UpperBond       = eoq.HoldingCostCurve.Select(v => (decimal)v).ToList()
                };
            }
            var salesByBucket = rawSalesData
                .GroupBy(sd => BucketOf(sd.SaleDate.Date, aggregationLevel))
                .ToDictionary(g => g.Key, g => (decimal)g.Sum(x => x.Quantity));

            // ── Anomaly Detection: foloseşte DOAR bucket-urile cu vânzări ────────────
            // Intenționat NU aplicăm zero-fill aici: inundarea seriei cu zerouri pentru
            // produse cu vânzări sporadice ar prăbuși media și ar umfla σ, transformând
            // fiecare zi de vânzare într-un "spike" și rupând semantica pragului σ
            // (1.5/2.0/2.5/3.0) documentată. Vezi docs/ANALYSIS_MODULE_REVIEW.md (A4/B2).
            if (isAnomalyDetection)
            {
                var sellingBuckets = salesByBucket
                    .OrderBy(kv => kv.Key)
                    .ToList();
                var anomalyResult = ComputeAnomalyDetection(
                    sellingBuckets.Select(kv => kv.Value).ToList(),
                    sellingBuckets.Select(kv => kv.Key).ToList(),
                    sensitivityThreshold);

                // The deterministic report is the analysis output; the agent then adds a summary
                // on top of it. AI failure is non-fatal — the error is shown after the report.
                var deterministicReport = anomalyResult.AiInsights;
                string aiSummary;
                try
                {
                    var reco = await _aiReasoningProvider.GetRecommendationAsync(
                        BuildAnomalyPrompt(product, anomalyResult, sensitivityThreshold));
                    aiSummary = reco.Reasoning;
                }
                catch (Exception ex)
                {
                    aiSummary = $"AI summary unavailable: {ExtractProviderError(ex)}";
                }

                anomalyResult.AiInsights = $"{deterministicReport}\n\n— AI Summary —\n{aiSummary}";
                return anomalyResult;
            }

            // ── Trend / Correlation / Forecast: ZERO-FILL pe grila calendaristică ────
            // Seria are puncte echidistante în timp calendaristic (nu indexate pe eveniment),
            // ceea ce face panta și prognoza valide pe orizont calendaristic. (A4)
            var historicalDates = BuildBucketGrid(context.StartDate, context.EndDate, aggregationLevel);
            var historicalSales = historicalDates
                .Select(d => salesByBucket.TryGetValue(d, out var v) ? v : 0m)
                .ToList();

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

            // ── Corelație vânzări ↔ factori, ALINIATĂ PE DATĂ ───────────────────────
            // Factorii au fost deja decalați cu lagDays mai sus, deci alinierea pe bucket
            // respectă lag-ul (lagDays nu mai e no-op). Agregăm impactul factorilor pe
            // același nivel (Daily/Weekly/Monthly) și facem inner-join pe bucket-urile
            // care au un factor. Vezi docs/ANALYSIS_MODULE_REVIEW.md (A1/A2).
            var factorByBucket = factors
                .Where(f => f.IsActive)
                .GroupBy(f => BucketOf(f.Date.Date, aggregationLevel))
                .ToDictionary(g => g.Key, g => g.Average(x => x.ImpactValue));

            var alignedSales = new List<decimal>();
            var alignedFactors = new List<decimal>();
            for (var i = 0; i < historicalDates.Count; i++)
            {
                if (factorByBucket.TryGetValue(historicalDates[i], out var factorValue))
                {
                    alignedSales.Add(historicalSales[i]);
                    alignedFactors.Add(factorValue);
                }
            }

            var (correlation, correlationPValue, correlationN) =
                _econometricEngine.AnalyzeFactorCorrelation(alignedSales, alignedFactors);

            // ── Multiplicator t-Student pentru benzile CI/PI (B1) ───────────────────
            // SEE e estimat din reziduuri ⇒ multiplicatorul corect e t_{α/2, n-2}, nu z normal.
            var degreesOfFreedom = historicalSales.Count - 2;
            var confidenceMultiplier = degreesOfFreedom >= 1
                ? _econometricEngine.GetConfidenceMultiplier(confidencePercent, degreesOfFreedom)
                : MapConfidenceToZScore(confidencePercent);

            // ── REGRESIE MULTIPLĂ pentru Demand Forecast ────────────────────────────
            // Când utilizatorul bifează factori în DemandForecast, prognoza devine
            // CONDIȚIONATĂ de aceștia: vânzări ~ intercept + Σ factori. Termenul de TIMP
            // este omis intenționat (temperatura e coliniară cu timpul, VIF mare, și
            // încorporează deja deriva sezonieră). Fără factori bifați sau la matrice
            // singulară → fallback la modelul univariat vânzări~timp.
            // Vezi docs/ANALYSIS_MODULE_REVIEW.md, „Regresie multiplă".
            string modelType = "Univariate (sales ~ time)";
            decimal adjustedRSquared = 0m, fStatistic = 0m, fPValue = 1m;
            var factorCoefficients = new List<FactorCoefficient>();

            // R² al modelului EFECTIV folosit (multivariat sau univariat), pentru badge +
            // confidence forecast. NU mutăm econometricModel (persistat) — acela rămâne
            // descriptorul coerent al trendului univariat (pantă + p-value-ul pantei + R² trend).
            decimal displayRSquared = econometricModel.RSquared;

            var factorColumns = (isDemandForecast && selectedFactors.Count > 0)
                ? BuildFactorColumns(factors, historicalDates, aggregationLevel)
                : new List<(string Name, List<decimal> Values)>();

            MultipleRegressionResult? mlr = factorColumns.Count > 0
                ? _econometricEngine.FitMultipleRegression(
                    historicalSales, factorColumns.Select(c => c.Values).ToList())
                : null;

            TrendBandResult trendBands;
            if (mlr is { IsValid: true })
            {
                int mvDf = historicalSales.Count - mlr.P;
                decimal mvMultiplier = mvDf >= 1
                    ? _econometricEngine.GetConfidenceMultiplier(confidencePercent, mvDf)
                    : MapConfidenceToZScore(confidencePercent);

                trendBands = BuildMultivariateTrend(
                    historicalSales, factorColumns, mlr, forecastHorizonDays, mvMultiplier);

                modelType = $"Multivariate (sales ~ {string.Join(" + ", factorColumns.Select(c => c.Name))})";
                adjustedRSquared = (decimal)mlr.AdjustedRSquared;
                fStatistic = (decimal)mlr.FStatistic;
                fPValue = (decimal)mlr.FPValue;

                factorCoefficients.Add(new FactorCoefficient
                {
                    Name = "Intercept",
                    Coefficient = (decimal)mlr.Coefficients[0],
                    PValue = (decimal)mlr.CoefficientPValues[0]
                });
                for (int j = 0; j < factorColumns.Count; j++)
                    factorCoefficients.Add(new FactorCoefficient
                    {
                        Name = factorColumns[j].Name,
                        Coefficient = (decimal)mlr.Coefficients[j + 1],
                        PValue = (decimal)mlr.CoefficientPValues[j + 1]
                    });

                // Badge-ul „Reliability (R²)" reflectă modelul efectiv folosit, FĂRĂ a
                // contamina rândul EconometricModel persistat (rămâne univariat coerent).
                displayRSquared = (decimal)mlr.RSquared;
            }
            else
            {
                trendBands = BuildTrendValues(
                    historicalSales,
                    econometricModel.CoefficientValue,
                    isDemandForecast,
                    forecasts,
                    context.EndDate,
                    forecastHorizonDays,
                    confidenceMultiplier);
            }

            var chartDates = BuildChartDates(historicalDates, context.EndDate, isDemandForecast, forecastHorizonDays);
            var chartLabels = chartDates.Select(d => d.ToString("dd MMM")).ToList();

            // Promptul AI este specific tipului de analiză. Correlation Analysis cere o
            // INTERPRETARE a relaţiei factor↔vânzări, NU o recomandare de reaprovizionare —
            // altfel prompt-ul de inventar (restock + date forecast) face AI-ul să răspundă
            // ca la Demand Forecast ("avoid overstocking", "no replenishment").
            string prompt;
            if (isDemandForecast)
            {
                var basePrompt = _promptBuilder.BuildInventoryPrompt(product, factors, forecasts);
                prompt = BuildAnalysisAwarePrompt(
                    basePrompt,
                    context,
                    historicalSales,
                    trendBands.TrendValues,
                    econometricModel,
                    forecasts,
                    correlation,
                    correlationPValue,
                    correlationN);

                if (mlr is { IsValid: true })
                    prompt += BuildMultivariatePromptSection(modelType, adjustedRSquared, fStatistic, fPValue, factorCoefficients);
            }
            else
            {
                prompt = BuildCorrelationPrompt(
                    product, primaryFactor, correlation, correlationPValue, correlationN, context);
            }

            // Analysis is already complete; the AI only writes a summary. A failure here
            // (e.g. no credits) must NOT abort the analysis — surface the error in the AI
            // section instead, and still persist the econometric model + forecasts below.
            string aiInsights;
            try
            {
                var recommendation = await _aiReasoningProvider.GetRecommendationAsync(prompt);
                aiInsights = recommendation.Reasoning;
            }
            catch (Exception ex)
            {
                aiInsights = $"AI summary unavailable: {ExtractProviderError(ex)}";
            }

            await PersistEconometricModelAsync(econometricModel, context.ProductId, cancellationToken);
            if (isDemandForecast)
                await PersistForecastsAsync(context.ProductId, trendBands.TrendValues, historicalSales.Count, context.EndDate, forecastHorizonDays, displayRSquared, cancellationToken);

            var analysisLabel = isDemandForecast ? "DEMAND_FORECAST" : "CORRELATION";
            ActivityLogger.LogAiAction(analysisLabel,
                $"Product: \"{product.ProductName}\" → R²: {displayRSquared:F3}, " +
                (isDemandForecast
                    ? $"Horizon: {forecastHorizonDays}d, Model: {modelType}" +
                      (mlr is { IsValid: true } ? $" (adjR²: {adjustedRSquared:F3}, F p: {fPValue:E1})" : "")
                    : $"Factor: {primaryFactor}, r: {correlation:F3} (p: {correlationPValue:F3}, n: {correlationN})"));

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
                Correlation = correlation,
                CorrelationPValue = correlationPValue,
                CorrelationSampleSize = correlationN,
                ModelType = modelType,
                AdjustedRSquared = adjustedRSquared,
                FStatistic = fStatistic,
                FPValue = fPValue,
                FactorCoefficients = factorCoefficients,
                ChartLabels = chartLabels,
                AiInsights = aiInsights,
                Reliability = displayRSquared,
                TrendLabel = GetTrendPercentageLabel(historicalSales, trendBands.TrendValues, isDemandForecast),
                AiConfidence = forecasts.Count == 0 ? 0m : forecasts.Average(f => f.ConfidenceScore)
            };
        }

        // ── Multivariate forecast helpers (sales ~ intercept + Σ factori) ──────────

        /// <summary>
        /// Construiește câte o coloană de regresor per Description de factor, agregată pe
        /// același bucket ca vânzările și aliniată la <paramref name="historicalDates"/>
        /// (0-fill pe bucket-urile fără observație). Coloanele constante sunt sărite
        /// (varianță nulă → ar face XᵀX singulară și nu aduc informație).
        /// </summary>
        private static List<(string Name, List<decimal> Values)> BuildFactorColumns(
            List<ExternalFactor> factors,
            List<DateTime> historicalDates,
            string aggregationLevel)
        {
            var columns = new List<(string Name, List<decimal> Values)>();
            if (factors == null || factors.Count == 0)
                return columns;

            foreach (var group in factors
                .Where(f => f.IsActive && !string.IsNullOrWhiteSpace(f.Description))
                .GroupBy(f => f.Description)
                .OrderBy(g => g.Key))
            {
                var perBucket = group
                    .GroupBy(f => BucketOf(f.Date.Date, aggregationLevel))
                    .ToDictionary(b => b.Key, b => b.Average(x => x.ImpactValue));

                var values = historicalDates
                    .Select(d => perBucket.TryGetValue(d, out var v) ? v : 0m)
                    .ToList();

                if (values.Distinct().Count() > 1) // skip zero-variance columns
                    columns.Add((group.Key, values));
            }

            return columns;
        }

        private static TrendBandResult BuildMultivariateTrend(
            List<decimal> historicalSales,
            List<(string Name, List<decimal> Values)> factorColumns,
            MultipleRegressionResult mlr,
            int forecastHorizonDays,
            decimal multiplier)
        {
            int n = historicalSales.Count;
            int p = mlr.P;
            double see = mlr.StandardError;

            var trend = new List<decimal>(n + Math.Max(1, forecastHorizonDays));
            var upper = new List<decimal>(trend.Capacity);
            var lower = new List<decimal>(trend.Capacity);

            // Istoric: valori ajustate + bandă de încredere a mediei răspunsului (√leverage)
            for (var i = 0; i < n; i++)
            {
                var x = BuildRow(factorColumns, p, j => (double)factorColumns[j].Values[i]);
                double yhat = mlr.Predict(x);
                double leverage = Math.Max(0, mlr.Leverage(x));
                var margin = multiplier * (decimal)(see * Math.Sqrt(leverage));
                trend.Add((decimal)yhat);
                upper.Add((decimal)yhat + margin);
                lower.Add(Math.Max(0m, (decimal)yhat - margin));
            }

            // Viitor: extrapolăm fiecare factor, prezicem, interval de PREDICȚIE (√(1+leverage))
            var horizon = Math.Max(1, forecastHorizonDays);
            var futureColumns = factorColumns
                .Select(c => ExtrapolateFactor(c.Values, horizon))
                .ToList();

            for (var i = 0; i < horizon; i++)
            {
                var x = BuildRow(factorColumns, p, j => (double)futureColumns[j][i]);
                double yhat = mlr.Predict(x);
                double leverage = Math.Max(0, mlr.Leverage(x));
                var margin = multiplier * (decimal)(see * Math.Sqrt(1.0 + leverage));
                trend.Add(Math.Max(0m, (decimal)yhat));
                upper.Add((decimal)yhat + margin);
                lower.Add(Math.Max(0m, (decimal)yhat - margin));
            }

            return new TrendBandResult
            {
                TrendValues = trend,
                UpperBond = upper,
                LowerBond = lower,
                StandardError = (decimal)see
            };
        }

        private static double[] BuildRow(
            List<(string Name, List<decimal> Values)> factorColumns, int p, Func<int, double> valueAt)
        {
            var x = new double[p];
            x[0] = 1.0; // intercept
            for (var j = 0; j < factorColumns.Count; j++)
                x[j + 1] = valueAt(j);
            return x;
        }

        /// <summary>
        /// Proiectează un factor în viitor: trend liniar propriu + reziduul istoric ciclat.
        /// Reziduul ciclat păstrează oscilația sezonieră (ex. valul de temperatură), astfel
        /// prognoza condiționată de vreme oscilează vizibil în loc să colapseze într-o dreaptă.
        /// </summary>
        private static List<decimal> ExtrapolateFactor(List<decimal> values, int horizon)
        {
            int n = values.Count;
            var future = new List<decimal>(horizon);
            if (n == 0)
            {
                for (var i = 0; i < horizon; i++) future.Add(0m);
                return future;
            }

            // OLS al factorului în funcție de timp (1..n)
            double sx = 0, sy = 0, sxy = 0, sxx = 0;
            for (var i = 0; i < n; i++)
            {
                double t = i + 1, v = (double)values[i];
                sx += t; sy += v; sxy += t * v; sxx += t * t;
            }
            double denom = n * sxx - sx * sx;
            double slope = denom == 0 ? 0 : (n * sxy - sx * sy) / denom;
            double intercept = (sy - slope * sx) / n;

            for (var i = 1; i <= horizon; i++)
            {
                int w = (n + i - 1) % n; // index istoric ciclat
                double residual = (double)values[w] - (slope * (w + 1) + intercept);
                double projected = slope * (n + i) + intercept + residual;
                future.Add((decimal)projected);
            }

            return future;
        }

        private static string BuildMultivariatePromptSection(
            string modelType,
            decimal adjustedRSquared,
            decimal fStatistic,
            decimal fPValue,
            List<FactorCoefficient> coefficients)
        {
            var sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("multivariateForecastModel:");
            sb.AppendLine($"- specification: {modelType}");
            sb.AppendLine($"- adjustedRSquared: {adjustedRSquared:F4}");
            sb.AppendLine($"- fStatistic: {fStatistic:F2} (overall significance p: {fPValue:E2})");
            sb.AppendLine("- coefficients:");
            foreach (var c in coefficients)
                sb.AppendLine($"  - {c.Name}: {c.Coefficient:F4} (p: {c.PValue:E2})");
            sb.AppendLine("- note: the forecast is CONDITIONED on these external factors, not a pure time trend.");
            sb.AppendLine("- Explain which factors drive demand and whether each is statistically significant (p < 0.05).");
            return sb.ToString();
        }

        /// <summary>
        /// Prompt pentru Correlation Analysis: interpretarea relaţiei factor↔vânzări.
        /// NU cere reaprovizionare şi NU foloseşte date de forecast — altfel AI-ul răspunde
        /// ca la Demand Forecast (recomandări de stoc), nu ca la o analiză de corelaţie.
        /// </summary>
        private static string BuildCorrelationPrompt(
            Product product,
            string primaryFactor,
            decimal correlation,
            decimal correlationPValue,
            int correlationN,
            AnalysisContext context)
        {
            decimal rSquared = correlation * correlation;
            string strength = Math.Abs(correlation) switch
            {
                >= 0.8m => "very strong",
                >= 0.6m => "strong",
                >= 0.4m => "moderate",
                >= 0.2m => "weak",
                _ => "negligible"
            };
            string direction = correlation > 0
                ? "positive (sales rise as the factor rises)"
                : correlation < 0
                    ? "negative (sales fall as the factor rises)"
                    : "none";
            bool significant = correlationN >= 4 && correlationPValue < 0.05m;
            string factorLabel = string.IsNullOrWhiteSpace(primaryFactor) ? "the selected factor" : primaryFactor;

            var sb = new StringBuilder();
            sb.AppendLine("task: Interpret a CORRELATION ANALYSIS between a product's daily sales and an external factor.");
            sb.AppendLine("This is NOT an inventory or restock decision — do NOT recommend order quantities, stock levels, or replenishment, and do NOT invent forecast figures.");
            sb.AppendLine();
            sb.AppendLine($"product: {product.ProductName}");
            sb.AppendLine($"factor: {factorLabel}");
            sb.AppendLine($"period: {context.StartDate:yyyy-MM-dd} to {context.EndDate:yyyy-MM-dd}");
            sb.AppendLine("computedStatistics:");
            sb.AppendLine($"  - pearsonR: {correlation:F3} ({strength}, {direction})");
            sb.AppendLine($"  - rSquared: {rSquared:F3} (share of sales variance associated with the factor)");
            sb.AppendLine($"  - pValue: {correlationPValue:E2} ({(significant ? "statistically significant at α=0.05" : "NOT significant at α=0.05")})");
            sb.AppendLine($"  - sampleSize: {correlationN} date-aligned day pairs");
            sb.AppendLine();
            sb.AppendLine("instructions:");
            sb.AppendLine("- Explain, in plain business terms, what this relationship means for this product.");
            sb.AppendLine("- State the direction and strength, and whether it is statistically reliable (cite the p-value and sample size).");
            sb.AppendLine("- Give one practical implication (e.g., how sensitive demand planning for this product is to this factor).");
            sb.AppendLine("- Keep it concise. Do NOT give restock/replenishment advice.");
            return sb.ToString();
        }

        private static TrendBandResult BuildTrendValues(
            List<decimal> historicalSales,
            decimal slope,
            bool isDemandForecast,
            List<AiForecast> forecasts,
            DateTime endDate,
            int forecastHorizonDays,
            decimal confidenceMultiplier)
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
            var (upperBond, lowerBond) = BuildConfidenceBounds(trendValues, confidenceMultiplier, standardError, historicalSales.Count);

            return new TrendBandResult
            {
                TrendValues = trendValues,
                UpperBond = upperBond,
                LowerBond = lowerBond,
                StandardError = standardError
            };
        }

        /// <summary>
        /// Cheia de bucket pentru o dată, la nivelul de agregare dat.
        /// Weekly = prima zi a săptămânii (Duminică), Monthly = prima zi a lunii.
        /// </summary>
        private static DateTime BucketOf(DateTime date, string aggregationLevel)
        {
            var d = date.Date;
            return aggregationLevel switch
            {
                "Weekly" => d.AddDays(-(int)d.DayOfWeek),
                "Monthly" => new DateTime(d.Year, d.Month, 1),
                _ => d
            };
        }

        /// <summary>
        /// Generează TOATE bucket-urile calendaristice din [start, end] la nivelul dat —
        /// inclusiv cele fără vânzări (necesare pentru zero-fill). Echidistante în timp.
        /// </summary>
        private static List<DateTime> BuildBucketGrid(DateTime start, DateTime end, string aggregationLevel)
        {
            var grid = new List<DateTime>();
            if (end < start)
                return grid;

            var cursor = BucketOf(start, aggregationLevel);
            var last = BucketOf(end, aggregationLevel);

            while (cursor <= last)
            {
                grid.Add(cursor);
                cursor = aggregationLevel switch
                {
                    "Weekly" => cursor.AddDays(7),
                    "Monthly" => cursor.AddMonths(1),
                    _ => cursor.AddDays(1)
                };
            }

            return grid;
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
                // PrimaryFactor is a factor Description (e.g. "Daily Max Temperature"),
                // not a FactorType — see IExternalDataProvider.GetDistinctFactorOptionsAsync.
                // This keeps temperature and precipitation (both FactorType="Weather")
                // as separate, un-mixed correlation targets.
                return factors
                    .Where(f => !string.IsNullOrWhiteSpace(f.Description) &&
                                f.Description.Equals(primaryFactor, StringComparison.OrdinalIgnoreCase))
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
            decimal confidenceMultiplier,
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

                var margin = confidenceMultiplier * standardError * (decimal)intervalMultiplier;
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
            List<AiForecast> forecasts,
            decimal correlation,
            decimal correlationPValue,
            int correlationN)
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
            builder.AppendLine($"  - slopePValue: {econometricModel.PValue:F4}");
            builder.AppendLine($"  - factorCorrelation: {correlation:F4} (date-aligned Pearson r)");
            builder.AppendLine($"  - correlationPValue: {correlationPValue:F4}");
            builder.AppendLine($"  - correlationSampleSize: {correlationN}");
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

        private async Task PersistEconometricModelAsync(EconometricModel model, int productId, CancellationToken cancellationToken)
        {
            try
            {
                _econometricModelRepository.Add(new EconometricModel
                {
                    ProductId        = productId,
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

        // ── Anomaly Detection ────────────────────────────────────────────────────

        private static AnalyticsResult ComputeAnomalyDetection(
            List<decimal> sales,
            List<DateTime> dates,
            double threshold)
        {
            if (sales.Count < 3)
                throw new InvalidOperationException(
                    "Insufficient data for anomaly detection. Select a date range with at least 3 data points.");

            var mean     = sales.Average();
            var variance = sales.Sum(x => (x - mean) * (x - mean)) / Math.Max(1, sales.Count - 1);
            var stdDev   = (decimal)Math.Sqrt((double)variance);

            var anomalies = new List<AnomalyPoint>();
            for (var i = 0; i < sales.Count; i++)
            {
                var zScore = stdDev > 0 ? (sales[i] - mean) / stdDev : 0m;
                if (Math.Abs(zScore) >= (decimal)threshold)
                {
                    var deviationPct = mean > 0 ? ((sales[i] - mean) / mean) * 100m : 0m;
                    var description  = zScore > 0
                        ? $"Unexpected sales spike (+{deviationPct:F0}% vs. average). Check for active promotions."
                        : $"Unusual drop ({deviationPct:F0}% vs. average). Possible stockout or reporting error.";

                    anomalies.Add(new AnomalyPoint
                    {
                        Date          = dates[i],
                        ActualValue   = sales[i],
                        ExpectedValue = Math.Round(mean, 2),
                        ZScore        = Math.Round(zScore, 2),
                        Description   = description,
                        DataIndex     = i
                    });
                }
            }

            var upperBand  = Enumerable.Repeat(mean + (decimal)threshold * stdDev, sales.Count).ToList();
            var lowerBand  = Enumerable.Repeat(Math.Max(0m, mean - (decimal)threshold * stdDev), sales.Count).ToList();
            var meanLine   = Enumerable.Repeat(mean, sales.Count).ToList();
            var maxZScore  = anomalies.Count > 0 ? anomalies.Max(a => Math.Abs(a.ZScore)) : 0m;
            ActivityLogger.LogAiAction("ANOMALY_DETECTION",
                $"{anomalies.Count} anomalies detected, max Z-score: {maxZScore:F2}, threshold: {threshold}");

            return new AnalyticsResult
            {
                HistoricalSales   = sales,
                TrendValues       = meanLine,
                UpperBond         = upperBand,
                LowerBond         = lowerBand,
                ChartLabels       = dates.Select(d => d.ToString("dd MMM")).ToList(),
                Anomalies         = anomalies,
                MaxSeverityZScore = maxZScore,
                Reliability       = 1m,
                TrendLabel        = anomalies.Count.ToString(),
                AiConfidence      = maxZScore > 0 ? Math.Min(1m, 1m - (maxZScore - (decimal)threshold) / 5m) : 1m,
                AiInsights        = BuildAnomalyInsightsText(anomalies, mean, stdDev, threshold, sales.Count)
            };
        }

        private static string BuildAnomalyInsightsText(
            List<AnomalyPoint> anomalies,
            decimal mean,
            decimal stdDev,
            double threshold,
            int totalCount)
        {
            var sb = new StringBuilder();
            sb.AppendLine("ANOMALY DETECTION REPORT");
            sb.AppendLine($"Tolerance Band: [{Math.Max(0m, mean - (decimal)threshold * stdDev):F1}, {mean + (decimal)threshold * stdDev:F1}] units  ({threshold}σ threshold)");
            sb.AppendLine();
            sb.AppendLine($"• Total Anomalies Detected: {anomalies.Count}");

            if (anomalies.Count == 0)
            {
                sb.AppendLine("• No anomalies detected. All data points fall within the expected tolerance band.");
                return sb.ToString();
            }

            var maxSeverity   = anomalies.Max(a => Math.Abs(a.ZScore));
            var severityLabel = maxSeverity >= 3.0m ? "Critical" : maxSeverity >= 2.5m ? "High" : "Medium";
            var anomalyRate   = totalCount > 0 ? (decimal)anomalies.Count / totalCount * 100m : 0m;

            sb.AppendLine($"• Maximum Severity: {maxSeverity:F1} Z-Score ({severityLabel})");
            sb.AppendLine($"• Anomaly Rate: {anomalyRate:F1}% of all data points");
            sb.AppendLine();
            sb.AppendLine("DETECTED ANOMALIES:");
            sb.AppendLine();

            foreach (var a in anomalies.OrderBy(x => x.Date))
            {
                var dir = a.ZScore > 0 ? "↑ SPIKE" : "↓ DROP";
                sb.AppendLine($"{dir}  {a.Date:MMM dd, yyyy}");
                sb.AppendLine($"   Actual: {a.ActualValue:F0} units  |  Expected: {a.ExpectedValue:F0} units  |  Z = {a.ZScore:+0.00;-0.00}");
                sb.AppendLine($"   {a.Description}");
                sb.AppendLine();
            }

            return sb.ToString();
        }

        /// <summary>
        /// Builds a concise prompt asking the agent to interpret the detected anomalies.
        /// The deterministic numbers come from <see cref="ComputeAnomalyDetection"/>.
        /// </summary>
        private static string BuildAnomalyPrompt(Product product, AnalyticsResult result, double threshold)
        {
            var anomalies = result.Anomalies ?? new List<AnomalyPoint>();

            var sb = new StringBuilder();
            sb.AppendLine($"Product: {product.ProductName}");
            sb.AppendLine($"Z-score anomaly detection on the sales series at a {threshold}σ threshold.");
            sb.AppendLine($"Anomalies detected: {anomalies.Count}; maximum severity |Z|: {result.MaxSeverityZScore:F2}.");

            if (anomalies.Count > 0)
            {
                sb.AppendLine("Most severe points:");
                foreach (var a in anomalies.OrderByDescending(x => Math.Abs(x.ZScore)).Take(5))
                    sb.AppendLine($"- {a.Date:MMM d}: actual {a.ActualValue:F0} vs expected {a.ExpectedValue:F0} (Z={a.ZScore:F2})");
            }

            sb.AppendLine();
            sb.AppendLine("Summarize what these anomalies imply about demand and recommend concrete actions. " +
                          "Do not restate the numbers verbatim — interpret them.");
            return sb.ToString();
        }

        /// <summary>
        /// Extracts a clean, user-facing message from an AI provider exception. Provider errors
        /// are surfaced as JSON (e.g. {"error":{"message":"Insufficient Balance"}}); when present
        /// the inner message is returned, otherwise the raw exception message.
        /// </summary>
        private static string ExtractProviderError(Exception ex)
        {
            var raw = ex.Message ?? "Unknown error";

            var braceIdx = raw.IndexOf('{');
            if (braceIdx >= 0)
            {
                try
                {
                    using var doc = System.Text.Json.JsonDocument.Parse(raw[braceIdx..]);
                    if (doc.RootElement.TryGetProperty("error", out var err) &&
                        err.TryGetProperty("message", out var m) &&
                        m.ValueKind == System.Text.Json.JsonValueKind.String)
                    {
                        var msg = m.GetString();
                        if (!string.IsNullOrWhiteSpace(msg)) return msg;
                    }
                }
                catch { /* not JSON — fall through to the raw message */ }
            }

            return raw;
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
