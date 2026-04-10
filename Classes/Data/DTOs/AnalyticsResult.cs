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
    }
}
