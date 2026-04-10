using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.Services
{
    /// <summary>
    /// Serviciu pentru logica de business a predicțiilor AI pe baza modelelor econometrice.
    /// Gestionează crearea, preluarea și analiza predicțiilor de vânzări.
    /// </summary>
    public class ForecastService
    {
        private readonly IRepository<AiForecast> _forecastRepository;

        public ForecastService(IRepository<AiForecast> forecastRepository)
        {
            _forecastRepository = forecastRepository ?? throw new ArgumentNullException(nameof(forecastRepository));
        }

        /// <summary>
        /// Adaugă o nouă predicție AI în baza de date.
        /// </summary>
        /// <param name="forecast">Predicția de adăugat</param>
        public async Task AddForecastAsync(AiForecast forecast)
        {
            if (forecast == null)
                throw new ArgumentNullException(nameof(forecast));

            _forecastRepository.Add(forecast);
            await _forecastRepository.SaveAsync();
        }

        /// <summary>
        /// Adaugă mai multe predicții în batch.
        /// </summary>
        /// <param name="forecasts">Colecția de predicții de adăugat</param>
        public async Task AddForecastsAsync(IEnumerable<AiForecast> forecasts)
        {
            if (forecasts == null)
                throw new ArgumentNullException(nameof(forecasts));

            _forecastRepository.AddRange(forecasts);
            await _forecastRepository.SaveAsync();
        }

        /// <summary>
        /// Obține cea mai recentă predicție pentru un produs specific.
        /// </summary>
        /// <param name="productId">ID-ul produsului</param>
        /// <returns>Predicția cea mai recentă sau null dacă nu există</returns>
        public async Task<AiForecast> GetLatestForecastAsync(int productId)
        {
            var forecasts = await _forecastRepository
                .FindAsync(f => f.ProductId == productId);

            return forecasts
                .OrderByDescending(f => f.ForecastDate)
                .FirstOrDefault();
        }

        /// <summary>
        /// Obține toate predicțiile cu încredere ridicată (peste un prag specificat).
        /// </summary>
        /// <param name="minConfidenceScore">Scorul minim de încredere (0-1)</param>
        /// <returns>Lista predicțiilor cu încredere ridicată</returns>
        public async Task<List<AiForecast>> GetHighConfidenceforecastsAsync(decimal minConfidenceScore)
        {
            if (minConfidenceScore < 0 || minConfidenceScore > 1)
                throw new ArgumentException("Confidence score must be between 0 and 1", nameof(minConfidenceScore));

            var forecasts = await _forecastRepository
                .FindAsync(f => f.ConfidenceScore >= minConfidenceScore);

            return forecasts
                .OrderByDescending(f => f.ConfidenceScore)
                .ToList();
        }

        /// <summary>
        /// Obține predicții pentru un produs specific într-un interval de dată.
        /// </summary>
        /// <param name="productId">ID-ul produsului</param>
        /// <param name="startDate">Data de început</param>
        /// <param name="endDate">Data de final</param>
        /// <returns>Lista predicțiilor în intervalul specificat</returns>
        public async Task<List<AiForecast>> GetForecastsByDateRangeAsync(int productId, DateTime startDate, DateTime endDate)
        {
            var forecasts = await _forecastRepository
                .FindAsync(f => f.ProductId == productId && 
                               f.ForecastDate >= startDate && 
                               f.ForecastDate <= endDate);

            return forecasts
                .OrderBy(f => f.ForecastDate)
                .ToList();
        }

        /// <summary>
        /// Obține toți factorii externi pentru un produs.
        /// </summary>
        /// <param name="productId">ID-ul produsului</param>
        /// <returns>Lista tuturor predicțiilor pentru produs</returns>
        public async Task<List<AiForecast>> GetAllForecastsForProductAsync(int productId)
        {
            return await _forecastRepository
                .FindAsync(f => f.ProductId == productId);
        }

        /// <summary>
        /// Obține statistica predicțiilor (medie, min, max de încredere) pentru un produs.
        /// </summary>
        /// <param name="productId">ID-ul produsului</param>
        /// <returns>Tuplu cu statistici (media încrederii, min, max)</returns>
        public async Task<(decimal avgConfidence, decimal minConfidence, decimal maxConfidence)?> GetForecastStatisticsAsync(int productId)
        {
            var forecasts = await _forecastRepository
                .FindAsync(f => f.ProductId == productId);

            if (forecasts.Count == 0)
                return null;

            return (
                forecasts.Average(f => f.ConfidenceScore),
                forecasts.Min(f => f.ConfidenceScore),
                forecasts.Max(f => f.ConfidenceScore)
            );
        }
    }
}
