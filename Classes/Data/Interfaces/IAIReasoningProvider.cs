using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.Interfaces
{
    /// <summary>
    /// Interfață pentru furnizarea recomandărilor AI pe baza unui prompt.
    /// Responsabilă pentru integrarea cu serviciile de LLM (Language Learning Model).
    /// </summary>
    public interface IAIReasoningProvider
    {
        /// <summary>
        /// Obține o recomandare de stock AI pe baza unui prompt dat.
        /// </summary>
        /// <param name="prompt">Prompt-ul care conține context pentru generarea recomandării</param>
        /// <returns>Task cu recomandarea AI generată</returns>
        Task<AiStockRecommendation> GetRecommendationAsync(string prompt);
    }
}
