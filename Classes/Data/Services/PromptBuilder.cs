using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.Services
{
    public class PromptBuilder : ILLMPromptBuilder
    {
        public string BuildInventoryPrompt(Product product, List<ExternalFactor> factors, List<AiForecast> forecasts)
        {
            if (product == null)
                throw new ArgumentNullException(nameof(product));

            factors ??= new List<ExternalFactor>();
            forecasts ??= new List<AiForecast>();

            var limitedFactors = factors
                .OrderByDescending(f => f.Date)
                .Take(6)
                .ToList();

            var avgDemand        = forecasts.Count == 0 ? 0m : Math.Round(forecasts.Average(f => f.PredictedDemand), 1);
            var peakDemand       = forecasts.Count == 0 ? 0m : Math.Round(forecasts.Max(f => f.PredictedDemand), 1);
            var trendDescription = BuildTrendSlopeDescription(forecasts);
            var stockGap         = product.CurrentStock - product.SafetyStock;

            var upcomingForecasts = forecasts
                .OrderBy(f => f.ForecastDate)
                .Take(7)
                .Select(f => $"{f.ForecastDate:MMM d}: {Math.Round(f.PredictedDemand, 1)}")
                .ToList();

            var factorLines = limitedFactors.Count == 0
                ? "none"
                : string.Join("; ", limitedFactors.Select(f =>
                {
                    var label = string.IsNullOrWhiteSpace(f.Description) ? f.FactorType : f.Description;
                    return f.ImpactValue != 0 ? $"{label} ({(f.ImpactValue > 0 ? "+" : "")}{f.ImpactValue})" : label;
                }));

            var forecastLine = upcomingForecasts.Count > 0
                ? string.Join(", ", upcomingForecasts)
                : "no forecast data";

            return
                $"Product: {product.ProductName}\n" +
                $"Current stock: {product.CurrentStock} {product.UnitOfMeasure} | Safety stock: {product.SafetyStock} | Gap: {(stockGap >= 0 ? "+" : "")}{stockGap}\n" +
                $"Demand — avg: {avgDemand}, peak: {peakDemand}, trend: {trendDescription}\n" +
                $"Upcoming forecast ({upcomingForecasts.Count} days): {forecastLine}\n" +
                $"Active external factors: {factorLines}\n\n" +
                "Recommend restock quantity and priority. State the specific risk or opportunity driving your decision, " +
                "then give a precise action. Do not repeat the numbers above — explain what they mean.";
        }

        private static string BuildTrendSlopeDescription(List<AiForecast> forecasts)
        {
            if (forecasts == null || forecasts.Count < 2)
                return "Stabil";

            var ordered = forecasts.OrderBy(f => f.ForecastDate).ToList();
            var start = ordered.First().PredictedDemand;
            var end = ordered.Last().PredictedDemand;
            var delta = end - start;

            if (delta >= 10m)
                return "Creștere puternică";
            if (delta >= 2m)
                return "Creștere moderată";
            if (delta <= -10m)
                return "Scădere puternică";
            if (delta <= -2m)
                return "Scădere moderată";

            return "Stabil";
        }
    }
}
