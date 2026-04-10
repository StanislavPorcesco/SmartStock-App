using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.Interfaces
{
    public interface IExternalDataProvider
    {
        Task<List<ExternalFactor>> GetFactorsAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default);
        Task<List<string>> GetDistinctFactorTypesAsync(CancellationToken cancellationToken = default);
    }
}
