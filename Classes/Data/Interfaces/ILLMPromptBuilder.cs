using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.Interfaces
{
    /// <summary>
    /// Interfață pentru construirea prompt-urilor contextualizate pentru modelele LLM.
    /// Responsabilă pentru formatarea datelor în prompt-uri optimizate pentru AI.
    /// </summary>
    public interface ILLMPromptBuilder
    {
        /// <summary>
        /// Construiește un prompt optimizat pentru recomandări de inventar pe baza datelor produsului.
        /// </summary>
        /// <param name="product">Produsul pentru care se construiește prompt-ul</param>
        /// <param name="factors">Lista factorilor externi relevanți</param>
        /// <param name="forecasts">Lista predicțiilor AI pentru produs</param>
        /// <returns>Prompt-ul formatat gata pentru LLM</returns>
        string BuildInventoryPrompt(Product product, List<ExternalFactor> factors, List<AiForecast> forecasts);
    }
}
