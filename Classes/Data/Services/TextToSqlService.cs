using System.Data;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Microsoft.Data.Sqlite;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Utils;

namespace SmartStock.Classes.Data.Services
{
    public class TextToSqlService : ITextToSqlProvider
    {
        private const string DefaultModel = "deepseek-chat";
        private static readonly TimeSpan RequestTimeout = TimeSpan.FromSeconds(60);

        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _systemPrompt;
        private readonly string _dbPath;

        public TextToSqlService(HttpClient httpClient, string apiKey)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _httpClient.BaseAddress ??= new Uri("https://api.deepseek.com/");
            _apiKey = apiKey;
            _systemPrompt = LoadSystemPrompt();
            _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "SmartStock.db");
        }

        private static string LoadSystemPrompt()
        {
            // Production: Resources folder next to the executable
            var resourcesPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "Resources", "sql-expert.md");
            if (File.Exists(resourcesPath))
                return File.ReadAllText(resourcesPath);

            // Development: project root → .claude/agents/sql-expert.md (3 levels up from bin/Debug/net8.0-windows/)
            var devPath = Path.GetFullPath(Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..",
                ".claude", "agents", "sql-expert.md"));
            if (File.Exists(devPath))
                return File.ReadAllText(devPath);

            throw new FileNotFoundException(
                "sql-expert.md schema file not found. Expected at Resources/sql-expert.md or .claude/agents/sql-expert.md.",
                resourcesPath);
        }

        public async Task<string> GenerateSqlAsync(string naturalLanguageQuery, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(naturalLanguageQuery))
                throw new ArgumentException("Query cannot be empty.", nameof(naturalLanguageQuery));

            using var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            cts.CancelAfter(RequestTimeout);

            var body = new
            {
                model = DefaultModel,
                messages = new[]
                {
                    new { role = "system", content = _systemPrompt },
                    new { role = "user", content = naturalLanguageQuery }
                },
                temperature = 0.1
            };

            using var request = new HttpRequestMessage(HttpMethod.Post, "chat/completions")
            {
                Content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json")
            };
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _apiKey);

            using var response = await _httpClient.SendAsync(
                request, HttpCompletionOption.ResponseHeadersRead, cts.Token);
            var content = await response.Content.ReadAsStringAsync(cts.Token);

            if (!response.IsSuccessStatusCode)
                throw new InvalidOperationException(
                    $"DeepSeek API error {(int)response.StatusCode}: {content}");

            using var doc = JsonDocument.Parse(content);
            var aiMessage = doc.RootElement
                .GetProperty("choices")[0]
                .GetProperty("message")
                .GetProperty("content")
                .GetString() ?? string.Empty;

            var sql = ExtractSql(aiMessage);
            ActivityLogger.LogAiAction("TEXT_TO_SQL",
                $"Query: \"{(naturalLanguageQuery.Length > 100 ? naturalLanguageQuery[..100] + "…" : naturalLanguageQuery)}\"");
            return sql;
        }

        public async Task<DataTable> ExecuteQueryAsync(string sql, CancellationToken cancellationToken = default)
        {
            ValidateSql(sql);

            var table = new DataTable();
            await using var connection = new SqliteConnection($"Data Source={_dbPath}");
            await connection.OpenAsync(cancellationToken);

            await using var command = connection.CreateCommand();
            command.CommandText = sql;

            await using var reader = await command.ExecuteReaderAsync(cancellationToken);
            table.Load(reader);

            return table;
        }

        private static string ExtractSql(string aiResponse)
        {
            // Try ```sql ... ``` block first (preferred output format per sql-expert.md)
            var sqlBlock = Regex.Match(aiResponse, @"```sql\s*([\s\S]*?)```", RegexOptions.IgnoreCase);
            if (sqlBlock.Success)
                return sqlBlock.Groups[1].Value.Trim();

            // Try generic ``` ... ``` block
            var codeBlock = Regex.Match(aiResponse, @"```\s*([\s\S]*?)```");
            if (codeBlock.Success)
                return codeBlock.Groups[1].Value.Trim();

            // Last resort: grab the SELECT statement directly from the text
            var selectMatch = Regex.Match(
                aiResponse, @"(SELECT\b[\s\S]+?)(?:;|\z)", RegexOptions.IgnoreCase);
            if (selectMatch.Success)
                return selectMatch.Groups[1].Value.Trim();

            throw new InvalidOperationException(
                "Could not extract a SQL query from the AI response. " +
                "The model may have refused the request or returned an unexpected format.\n\n" +
                "AI response: " + aiResponse[..Math.Min(300, aiResponse.Length)]);
        }

        private static void ValidateSql(string sql)
        {
            if (!sql.TrimStart().StartsWith("SELECT", StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException(
                    "Only SELECT statements are permitted for safety. " +
                    "The generated query does not begin with SELECT.");

            string[] forbidden = ["DROP", "DELETE", "UPDATE", "INSERT", "ALTER", "CREATE", "TRUNCATE"];
            var upper = sql.ToUpperInvariant();
            foreach (var kw in forbidden)
            {
                if (Regex.IsMatch(upper, $@"\b{kw}\b"))
                    throw new InvalidOperationException(
                        $"Forbidden keyword '{kw}' detected. Only SELECT statements are allowed.");
            }
        }
    }
}
