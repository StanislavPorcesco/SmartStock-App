using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.DTOs
{
    public class AnalyticsResult
    {
        public EconometricModel EconometricModel { get; set; } = new EconometricModel();
        public List<AiForecast> Forecasts { get; set; } = new();
        public List<decimal> HistoricalSales { get; set; } = new();
        public List<decimal> TrendValues { get; set; } = new();
        public List<decimal> UpperBond { get; set; } = new();
        public List<decimal> LowerBond { get; set; } = new();
        public List<decimal> UpperBound
        {
            get => UpperBond;
            set => UpperBond = value ?? new List<decimal>();
        }
        public List<decimal> LowerBound
        {
            get => LowerBond;
            set => LowerBond = value ?? new List<decimal>();
        }
        public decimal StandardError { get; set; }
        public int ConfidencePercent { get; set; } = 95;

        /// <summary>
        /// Coeficientul de corelație Pearson între vânzări și factorii externi,
        /// aliniate pe dată (bucket de agregare). Interval [-1, 1].
        /// </summary>
        public decimal Correlation { get; set; }

        /// <summary>
        /// P-value bilateral al corelației (testul t cu n-2 grade de libertate).
        /// Corelația e semnificativă statistic dacă &lt; 0.05.
        /// </summary>
        public decimal CorrelationPValue { get; set; } = 1m;

        /// <summary>
        /// Numărul de perechi (sales, factor) aliniate pe dată folosite în corelație.
        /// </summary>
        public int CorrelationSampleSize { get; set; }
        public List<string> ChartLabels { get; set; } = new();
        public List<ExternalFactor> Factors { get; set; } = new();
        public string AiInsights { get; set; } = string.Empty;
        public decimal Reliability { get; set; }
        public string TrendLabel { get; set; } = "Stable";
        public decimal AiConfidence { get; set; }

        /// <summary>
        /// Populat doar când AnalysisType = "Stock Optimization".
        /// Conține toate rezultatele modelului EOQ.
        /// </summary>
        public EoqResult? Eoq { get; set; }

        /// <summary>
        /// Populat doar când AnalysisType = "Anomaly Detection".
        /// Lista punctelor de date identificate ca anomalii Z-score.
        /// </summary>
        public List<AnomalyPoint> Anomalies { get; set; } = new();

        /// <summary>
        /// Scorul Z maxim (în valoare absolută) din toate anomaliile detectate.
        /// </summary>
        public decimal MaxSeverityZScore { get; set; }

        // ── Demand Forecast: modelul folosit ────────────────────────────────────
        /// <summary>
        /// "Multivariate (sales ~ factors)" când s-au selectat factori şi regresia a reuşit,
        /// altfel "Univariate (sales ~ time)".
        /// </summary>
        public string ModelType { get; set; } = "Univariate (sales ~ time)";

        /// <summary>R² ajustat (penalizează numărul de regresori) — pentru regresia multiplă.</summary>
        public decimal AdjustedRSquared { get; set; }

        /// <summary>Statistica F pentru semnificaţia globală a modelului multivariat.</summary>
        public decimal FStatistic { get; set; }

        /// <summary>p-value al testului F (modelul e semnificativ global dacă &lt; 0.05).</summary>
        public decimal FPValue { get; set; } = 1m;

        /// <summary>Coeficienţii modelului multivariat (intercept + factori), cu p-value.</summary>
        public List<FactorCoefficient> FactorCoefficients { get; set; } = new();
    }

    /// <summary>Un coeficient al modelului de regresie multiplă, pentru afişare.</summary>
    public sealed class FactorCoefficient
    {
        public string Name { get; set; } = string.Empty;
        public decimal Coefficient { get; set; }
        public decimal PValue { get; set; } = 1m;
    }
}
