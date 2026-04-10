using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.Services
{
    public class FallbackAiReasoningProvider : IAIReasoningProvider
    {
        public Task<AiStockRecommendation> GetRecommendationAsync(string prompt)
        {
            var recommendation = new AiStockRecommendation
            {
                ProductId = 0,
                SuggestedQuantity = 0,
                PriorityLevel = "Medium",
                Reasoning = "AI provider is not configured. Please add API key in settings and retry.",
                CreatedAt = DateTime.Now
            };

            return Task.FromResult(recommendation);
        }
    }
}
