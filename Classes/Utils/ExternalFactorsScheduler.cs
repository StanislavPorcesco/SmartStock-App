using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Settings;

namespace SmartStock.Classes.Utils
{
    /// <summary>
    /// Background timer that checks every 5 minutes whether the daily external-factors
    /// fetch should run. Scheduling logic:
    ///   - Fetch runs at most once per calendar day.
    ///   - Fires when the current time matches <see cref="AppSettings.ExternalFactorsFetchTime"/>
    ///     within a ±5-minute window.
    /// </summary>
    public static class ExternalFactorsScheduler
    {
        private static System.Threading.Timer? _timer;
        private static readonly ExternalFactorsFetchService _fetchService = new();

        public static void Start()
        {
            // Poll every 5 minutes; first check after 2 minutes to let the app fully load.
            _timer = new System.Threading.Timer(
                CheckAndFetchAsync,
                null,
                TimeSpan.FromMinutes(2),
                TimeSpan.FromMinutes(5));
        }

        public static void Stop()
        {
            _timer?.Dispose();
            _timer = null;
        }

        // ── Callback ──────────────────────────────────────────────────────────

        private static async void CheckAndFetchAsync(object? _)
        {
            var settings = SettingsManager.Current;

            if (!settings.ExternalFactorsFetchEnabled) return;

            var now = DateTime.Now;

            // Enforce 1-day cooldown between fetches
            if (settings.LastExternalFactorsFetched.HasValue)
            {
                var hoursSinceLast = (now - settings.LastExternalFactorsFetched.Value).TotalHours;
                if (hoursSinceLast < 23) return;
            }

            // Match scheduled time within ±5 minutes
            if (!TimeSpan.TryParse(settings.ExternalFactorsFetchTime, out var scheduledTime)) return;
            var scheduledDateTime = now.Date.Add(scheduledTime);
            if (Math.Abs((now - scheduledDateTime).TotalMinutes) > 5) return;

            await RunFetchAsync();
        }

        // ── Fetch logic (shared by scheduler + "Fetch Now" button) ────────────

        public static async Task<(int Added, List<string> Errors)> RunFetchAsync(
            CancellationToken ct = default)
        {
            return await _fetchService.FetchAllAsync(ct);
        }
    }
}
