using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;

namespace SmartStock.Classes.Data.Services
{
    public class ExternalDataProvider : IExternalDataProvider
    {
        private readonly IRepository<ExternalFactor> _externalFactorRepository;

        public ExternalDataProvider(IRepository<ExternalFactor> externalFactorRepository)
        {
            _externalFactorRepository = externalFactorRepository ?? throw new ArgumentNullException(nameof(externalFactorRepository));
        }

        public async Task<List<ExternalFactor>> GetFactorsAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
        {
            return await _externalFactorRepository
                .GetAll()
                .Where(f => f.IsActive && f.Date >= startDate && f.Date <= endDate)
                .OrderBy(f => f.Date)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }

        public async Task<List<string>> GetDistinctFactorOptionsAsync(CancellationToken cancellationToken = default)
        {
            // Distinct by Description (the specific metric), so "Daily Max Temperature" and
            // "Daily Precipitation" — both FactorType="Weather" — are separately selectable.
            return await _externalFactorRepository
                .GetAll()
                .Where(f => f.IsActive && !string.IsNullOrWhiteSpace(f.Description))
                .Select(f => f.Description)
                .Distinct()
                .OrderBy(f => f)
                .AsNoTracking()
                .ToListAsync(cancellationToken);
        }
    }
}
