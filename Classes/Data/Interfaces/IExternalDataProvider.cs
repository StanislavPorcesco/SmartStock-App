using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.Interfaces
{
    public interface IExternalDataProvider
    {
        Task<List<ExternalFactor>> GetFactorsAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default);

        /// <summary>
        /// Returnează opțiunile distincte de factor pentru selecția în Correlation Analysis,
        /// la nivel de <c>Description</c> (metrica specifică, ex. "Daily Max Temperature"),
        /// NU la nivel de FactorType. Motiv: temperatura și precipitația au ambele
        /// FactorType="Weather"; corelația le-ar media împreună dacă s-ar selecta tipul.
        /// </summary>
        Task<List<string>> GetDistinctFactorOptionsAsync(CancellationToken cancellationToken = default);
    }
}
