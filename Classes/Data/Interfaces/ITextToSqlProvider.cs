using System.Data;

namespace SmartStock.Classes.Data.Interfaces
{
    public interface ITextToSqlProvider
    {
        Task<string> GenerateSqlAsync(string naturalLanguageQuery, CancellationToken cancellationToken = default);
        Task<DataTable> ExecuteQueryAsync(string sql, CancellationToken cancellationToken = default);
    }
}
