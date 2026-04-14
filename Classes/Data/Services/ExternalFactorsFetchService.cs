using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
using SmartStock.Classes.Settings;
using SmartStock.Classes.Utils;

namespace SmartStock.Classes.Data.Services
{
    /// <summary>
    /// Fetches external factors from four API sources and persists new records.
    /// Sources:
    ///   - Alpha Vantage  : commodity price % changes (monthly)
    ///   - World Bank     : economic indices — inflation, GDP growth, unemployment (free, no key)
    ///   - PredictHQ      : public holidays and local events
    ///   - Open-Meteo     : daily weather — temperature and precipitation (free, no key)
    ///
    /// Deduplication: a factor is skipped when an existing record with the same
    /// Date (date-part) + FactorType + Description already exists in the database.
    /// </summary>
    public class ExternalFactorsFetchService
    {
        // Shared client — one instance per process is the correct pattern for HttpClient
        private static readonly HttpClient _http = new() { Timeout = TimeSpan.FromSeconds(30) };

        // Alpha Vantage: function name → human-readable label
        private static readonly (string Function, string Label)[] _commodities =
        {
            ("WTI",         "WTI Crude Oil"),
            ("BRENT",       "Brent Crude Oil"),
            ("NATURAL_GAS", "Natural Gas"),
            ("COPPER",      "Copper"),
            ("ALUMINUM",    "Aluminum"),
            ("WHEAT",       "Wheat"),
            ("CORN",        "Corn"),
        };

        // World Bank: indicator code → human-readable label
        private static readonly (string Id, string Label)[] _wbIndicators =
        {
            ("FP.CPI.TOTL.ZG",   "Inflation (CPI)"),
            ("NY.GDP.MKTP.KD.ZG","GDP Growth Rate"),
            ("SL.UEM.TOTL.ZS",   "Unemployment Rate"),
        };

        // ── Public entry point ────────────────────────────────────────────────

        /// <summary>
        /// Runs all four provider fetches and persists new factors.
        /// Returns (number added, list of per-source error messages).
        /// </summary>
        public async Task<(int Added, List<string> Errors)> FetchAllAsync(
            CancellationToken ct = default)
        {
            var bucket = new List<ExternalFactor>();
            var errors = new List<string>();

            await RunSafe(() => FetchAlphaVantageAsync(bucket, ct), "Alpha Vantage", errors);
            await RunSafe(() => FetchWorldBankAsync(bucket, ct),    "World Bank",    errors);
            await RunSafe(() => FetchPredictHQAsync(bucket, ct),    "PredictHQ",     errors);
            await RunSafe(() => FetchOpenMeteoAsync(bucket, ct),    "Open-Meteo",    errors);

            int added = await SaveNewFactorsAsync(bucket, ct);

            ActivityLogger.LogSystemAction("EXTERNAL_FETCH",
                $"Completed — {added} factor(s) added, {errors.Count} source error(s)",
                isError: errors.Count > 0 && added == 0);

            return (added, errors);
        }

        // ── Alpha Vantage ─────────────────────────────────────────────────────

        private static async Task FetchAlphaVantageAsync(
            List<ExternalFactor> bucket, CancellationToken ct)
        {
            var apiKey = SettingsManager.Current.AlphaVantageApiKey;
            if (string.IsNullOrWhiteSpace(apiKey)) return;

            foreach (var (function, label) in _commodities)
            {
                ct.ThrowIfCancellationRequested();

                var url = $"https://www.alphavantage.co/query" +
                          $"?function={function}&interval=monthly&apikey={apiKey}";

                using var resp = await _http.GetAsync(url, ct);
                if (!resp.IsSuccessStatusCode) continue;

                using var doc = JsonDocument.Parse(await resp.Content.ReadAsStringAsync(ct));
                var root = doc.RootElement;

                // Skip rate-limit / error messages
                if (root.TryGetProperty("Note", out _) ||
                    root.TryGetProperty("Information", out _)) continue;

                if (!root.TryGetProperty("data", out var data)) continue;

                var entries = data.EnumerateArray()
                    .Where(e => e.TryGetProperty("value", out var v) &&
                                v.GetString() != "." &&
                                v.GetString() != "")
                    .Take(2)
                    .ToList();

                if (entries.Count < 2) continue;

                var latestStr  = entries[0].GetProperty("value").GetString() ?? "";
                var previousStr = entries[1].GetProperty("value").GetString() ?? "";

                if (!decimal.TryParse(latestStr,  NumberStyles.Any, CultureInfo.InvariantCulture, out var latest))   continue;
                if (!decimal.TryParse(previousStr, NumberStyles.Any, CultureInfo.InvariantCulture, out var previous)) continue;
                if (previous == 0) continue;

                if (!DateTime.TryParse(entries[0].GetProperty("date").GetString(), out var date)) continue;

                var pctChange = Math.Round((latest - previous) / previous * 100m, 2);

                bucket.Add(new ExternalFactor
                {
                    FactorType  = "CommodityPrice",
                    Description = $"{label} monthly change",
                    Region      = "Global",
                    ImpactValue = pctChange,
                    ValueType   = "Percentage",
                    Date        = date,
                    IsActive    = true
                });

                // Free tier: max 5 req/min → 12-second gap between calls
                await Task.Delay(12_000, ct);
            }
        }

        // ── World Bank ────────────────────────────────────────────────────────

        private static async Task FetchWorldBankAsync(
            List<ExternalFactor> bucket, CancellationToken ct)
        {
            var country = SettingsManager.Current.WorldBankCountryCode;
            if (string.IsNullOrWhiteSpace(country)) country = "RO";

            foreach (var (id, label) in _wbIndicators)
            {
                ct.ThrowIfCancellationRequested();

                var url = $"https://api.worldbank.org/v2/country/{country}" +
                          $"/indicator/{id}?format=json&mrv=2&per_page=2";

                using var resp = await _http.GetAsync(url, ct);
                if (!resp.IsSuccessStatusCode) continue;

                using var doc = JsonDocument.Parse(await resp.Content.ReadAsStringAsync(ct));
                var root = doc.RootElement;

                // Response is a 2-element array: [metadata, [records...]]
                if (root.ValueKind != JsonValueKind.Array || root.GetArrayLength() < 2) continue;

                var records = root[1];
                if (records.ValueKind != JsonValueKind.Array) continue;

                var first = records.EnumerateArray()
                    .FirstOrDefault(e =>
                        e.TryGetProperty("value", out var v) &&
                        v.ValueKind != JsonValueKind.Null);

                if (first.ValueKind == JsonValueKind.Undefined) continue;

                var value   = first.GetProperty("value").GetDouble();
                var dateStr = first.GetProperty("date").GetString() ?? "";
                if (!int.TryParse(dateStr, out var year)) continue;

                var countryName = first
                    .GetProperty("country")
                    .GetProperty("value")
                    .GetString() ?? country;

                countryName = countryName.Length > 95
                    ? countryName[..95]
                    : countryName;

                bucket.Add(new ExternalFactor
                {
                    FactorType  = "EconomicIndex",
                    Description = $"{label} ({countryName})",
                    Region      = countryName,
                    ImpactValue = (decimal)value,
                    ValueType   = "Percentage",
                    Date        = new DateTime(year, 1, 1),
                    IsActive    = true
                });
            }
        }

        // ── PredictHQ ─────────────────────────────────────────────────────────

        private static async Task FetchPredictHQAsync(
            List<ExternalFactor> bucket, CancellationToken ct)
        {
            var apiKey = SettingsManager.Current.PredictHQApiKey;
            if (string.IsNullOrWhiteSpace(apiKey)) return;

            var country = SettingsManager.Current.WorldBankCountryCode;
            if (string.IsNullOrWhiteSpace(country)) country = "RO";

            var from = DateTime.Today.ToString("yyyy-MM-dd");
            var to   = DateTime.Today.AddDays(90).ToString("yyyy-MM-dd");

            var url = "https://api.predicthq.com/v1/events/" +
                      $"?country={country}" +
                      $"&category=public-holidays,school-holidays,observances" +
                      $"&start.gte={from}&start.lte={to}" +
                      $"&limit=50&sort=rank";

            using var req = new HttpRequestMessage(HttpMethod.Get, url);
            req.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            req.Headers.Add("Accept", "application/json");

            using var resp = await _http.SendAsync(req, ct);
            if (!resp.IsSuccessStatusCode) return;

            using var doc = JsonDocument.Parse(await resp.Content.ReadAsStringAsync(ct));
            if (!doc.RootElement.TryGetProperty("results", out var results)) return;

            foreach (var evt in results.EnumerateArray())
            {
                var title    = evt.TryGetProperty("title",    out var t) ? t.GetString() ?? "Event" : "Event";
                var category = evt.TryGetProperty("category", out var c) ? c.GetString() ?? "event"  : "event";
                var rank     = evt.TryGetProperty("phq_rank", out var r) ? r.GetDecimal() : 50m;
                var dateStr  = evt.TryGetProperty("start",    out var s) ? s.GetString()  : null;

                if (dateStr == null || !DateTime.TryParse(dateStr, out var date)) continue;

                // Truncate to fit Description(250) and FactorType(50) constraints
                var description = $"{title} ({category})";
                if (description.Length > 248) description = description[..248];

                bucket.Add(new ExternalFactor
                {
                    FactorType  = "Event",
                    Description = description,
                    Region      = country,
                    ImpactValue = Math.Round(rank / 100m, 2),
                    ValueType   = "Multiplier",
                    Date        = date,
                    IsActive    = true
                });
            }
        }

        // ── Open-Meteo ────────────────────────────────────────────────────────

        private static async Task FetchOpenMeteoAsync(
            List<ExternalFactor> bucket, CancellationToken ct)
        {
            var lat    = SettingsManager.Current.WeatherLatitude
                             .ToString(CultureInfo.InvariantCulture);
            var lon    = SettingsManager.Current.WeatherLongitude
                             .ToString(CultureInfo.InvariantCulture);
            var region = SettingsManager.Current.WeatherRegion;
            if (string.IsNullOrWhiteSpace(region)) region = "Unknown";

            var url = "https://api.open-meteo.com/v1/forecast" +
                      $"?latitude={lat}&longitude={lon}" +
                      "&daily=temperature_2m_max,temperature_2m_min,precipitation_sum" +
                      "&timezone=auto&past_days=7&forecast_days=7";

            using var resp = await _http.GetAsync(url, ct);
            if (!resp.IsSuccessStatusCode) return;

            using var doc = JsonDocument.Parse(await resp.Content.ReadAsStringAsync(ct));
            if (!doc.RootElement.TryGetProperty("daily", out var daily)) return;

            var times    = daily.GetProperty("time")
                               .EnumerateArray().Select(e => e.GetString()).ToArray();
            var maxTemps = daily.GetProperty("temperature_2m_max").EnumerateArray().ToArray();
            var minTemps = daily.GetProperty("temperature_2m_min").EnumerateArray().ToArray();
            var precip   = daily.GetProperty("precipitation_sum").EnumerateArray().ToArray();

            for (int i = 0; i < times.Length; i++)
            {
                if (!DateTime.TryParse(times[i], out var date)) continue;

                if (maxTemps[i].ValueKind != JsonValueKind.Null)
                    bucket.Add(Factor("Weather", "Daily Max Temperature", region,
                        maxTemps[i].GetDecimal(), "Absolute", date));

                if (minTemps[i].ValueKind != JsonValueKind.Null)
                    bucket.Add(Factor("Weather", "Daily Min Temperature", region,
                        minTemps[i].GetDecimal(), "Absolute", date));

                if (precip[i].ValueKind != JsonValueKind.Null && precip[i].GetDecimal() > 0)
                    bucket.Add(Factor("Weather", "Daily Precipitation", region,
                        precip[i].GetDecimal(), "Absolute", date));
            }
        }

        // ── Persistence ───────────────────────────────────────────────────────

        private static async Task<int> SaveNewFactorsAsync(
            List<ExternalFactor> factors, CancellationToken ct)
        {
            if (factors.Count == 0) return 0;

            using var context = new SmartStockContext();

            var minDate = factors.Min(f => f.Date).AddDays(-1);

            // Load existing keys for deduplication (client-side to avoid SQLite translation issues)
            var existingRaw = await context.ExternalFactors
                .Where(f => f.Date >= minDate)
                .AsNoTracking()
                .Select(f => new { f.Date, f.FactorType, f.Description })
                .ToListAsync(ct);

            var existingKeys = existingRaw
                .Select(f => $"{f.Date:yyyy-MM-dd}|{f.FactorType}|{f.Description}")
                .ToHashSet(StringComparer.OrdinalIgnoreCase);

            var toAdd = new List<ExternalFactor>();
            foreach (var factor in factors)
            {
                ct.ThrowIfCancellationRequested();
                var key = $"{factor.Date:yyyy-MM-dd}|{factor.FactorType}|{factor.Description}";
                if (existingKeys.Add(key)) // Add returns false if already present → dedupes within batch too
                    toAdd.Add(factor);
            }

            if (toAdd.Count == 0) return 0;

            context.ExternalFactors.AddRange(toAdd);
            await context.SaveChangesAsync(ct);

            ActivityLogger.LogUserAction("ADD", "ExternalFactor",
                $"API batch fetch ({toAdd.Count} factors)", null);

            SettingsManager.Current.LastExternalFactorsFetched = DateTime.Now;
            SettingsManager.Save();

            return toAdd.Count;
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static ExternalFactor Factor(
            string type, string desc, string region,
            decimal value, string valueType, DateTime date) => new()
        {
            FactorType  = type,
            Description = desc,
            Region      = region,
            ImpactValue = value,
            ValueType   = valueType,
            Date        = date,
            IsActive    = true
        };

        private static async Task RunSafe(
            Func<Task> action, string source, List<string> errors)
        {
            try   { await action(); }
            catch (OperationCanceledException) { throw; }
            catch (Exception ex)
            {
                var msg = $"{source}: {ex.Message}";
                errors.Add(msg);
                ActivityLogger.LogSystemAction("EXTERNAL_FETCH", msg, isError: true);
            }
        }
    }
}
