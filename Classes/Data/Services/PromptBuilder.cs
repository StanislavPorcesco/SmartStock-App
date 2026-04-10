using System.Text.Json;
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
                .Take(12)
                .ToList();

            var averageHistoricalDemand = forecasts.Count == 0 ? 0m : forecasts.Average(f => f.PredictedDemand);
            var maxDemandObserved = forecasts.Count == 0 ? 0m : forecasts.Max(f => f.PredictedDemand);
            var trendSlopeDescription = BuildTrendSlopeDescription(forecasts);

            var factorDescriptions = limitedFactors.Count == 0
                ? "None"
                : string.Join("; ", limitedFactors
                    .Select(f => string.IsNullOrWhiteSpace(f.Description) ? f.FactorType : f.Description));

            var latestForecast = forecasts
                .OrderByDescending(f => f.ForecastDate)
                .FirstOrDefault();

            var predictedDemand = latestForecast?.PredictedDemand ?? 0m;

            var userMessage =
                $"Current inventory for {product.ProductName} is {product.CurrentStock}. " +
                $"External factors identified: {factorDescriptions}. " +
                $"Predicted demand: {predictedDemand}. " +
                "Provide a recommended restock quantity and reasoning.";

            var payload = new
            {
                task = "InventoryRestockRecommendation",
                format = "json",
                outputSchema = new
                {
                    suggestedQuantity = "int",
                    priorityLevel = "Low|Medium|High",
                    reasoning = "string"
                },
                context = new
                {
                    product = new
                    {
                        id = product.ProductId,
                        name = product.ProductName,
                        stock = product.CurrentStock,
                        safetyStock = product.SafetyStock,
                        unitOfMeasure = product.UnitOfMeasure
                    },
                    externalFactors = limitedFactors.Select(f => new
                    {
                        f.FactorId,
                        f.FactorType,
                        f.Description,
                        f.ImpactValue,
                        f.ValueType,
                        f.Date,
                        f.IsActive
                    }),
                    meta = new
                    {
                        AverageHistoricalDemand = averageHistoricalDemand,
                        MaxDemandObserved = maxDemandObserved,
                        TrendSlopeDescription = trendSlopeDescription
                    },
                    forecasts = forecasts.Select(f => new
                    {
                        f.ForecastId,
                        f.ProductId,
                        f.ForecastDate,
                        f.PredictedDemand,
                        f.ConfidenceScore,
                        f.ModelVersion
                    })
                },
                prompt = userMessage,
                instructions = new[]
                {
                    "Return only valid JSON.",
                    "Use numeric suggestedQuantity.",
                    "Keep reasoning concise and operational."
                }
            };

            return JsonSerializer.Serialize(payload, new JsonSerializerOptions
            {
                WriteIndented = true
            });
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
