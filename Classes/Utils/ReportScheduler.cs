using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Settings;

namespace SmartStock.Classes.Utils
{
    /// <summary>
    /// Background timer that checks every 5 minutes whether the weekly report
    /// should be dispatched. Scheduling logic:
    ///   - Reports are sent at most once every 7 days.
    ///   - The send fires when the current clock time matches <see cref="AppSettings.ReportScheduleTime"/>
    ///     within a ±5-minute window.
    /// </summary>
    public static class ReportScheduler
    {
        private static System.Threading.Timer? _timer;

        /// Path of the last chart snapshot saved by AnalyzeForm (best-effort).
        public static string LastChartSnapshotPath { get; set; } = string.Empty;

        public static void Start()
        {
            // Poll every 5 minutes; first check happens after 1 minute to let the app fully load.
            _timer = new System.Threading.Timer(
                CheckAndSendAsync,
                null,
                TimeSpan.FromMinutes(1),
                TimeSpan.FromMinutes(5));
        }

        public static void Stop()
        {
            _timer?.Dispose();
            _timer = null;
        }

        // ── Callback ──────────────────────────────────────────────────────────

        private static async void CheckAndSendAsync(object? _)
        {
            var settings = SettingsManager.Current;

            if (!settings.WeeklyReportsEnabled) return;
            if (string.IsNullOrWhiteSpace(settings.ReportRecipientEmail)) return;

            var now = DateTime.Now;

            // Enforce 7-day cooldown between reports
            if (settings.LastWeeklyReportSent.HasValue)
            {
                var daysSinceLast = (now - settings.LastWeeklyReportSent.Value).TotalDays;
                if (daysSinceLast < 7) return;
            }

            // Match scheduled time within ±5 minutes
            if (!TimeSpan.TryParse(settings.ReportScheduleTime, out var scheduledTime)) return;
            var scheduledDateTime = now.Date.Add(scheduledTime);
            if (Math.Abs((now - scheduledDateTime).TotalMinutes) > 5) return;

            await SendReportAsync(settings.ReportRecipientEmail, isTest: false);
        }

        // ── Send logic (shared by scheduler + "Send Test" button) ─────────────

        public static async Task SendReportAsync(string recipientEmail, bool isTest = false)
        {
            var service = new WeeklyReportService();
            var html    = await service.BuildReportHtmlAsync();

            var chartPath = ResolveChartPath();
            var subject   = isTest
                ? $"[TEST] SmartStock Weekly Report — {DateTime.Now:dd MMM yyyy}"
                : $"SmartStock Weekly Report — {DateTime.Now:dd MMM yyyy}";

            EmailService.SendReport(recipientEmail, subject, html, chartPath);

            if (!isTest)
            {
                SettingsManager.Current.LastWeeklyReportSent = DateTime.Now;
                SettingsManager.Save();
            }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static string ResolveChartPath()
        {
            // Prefer the live snapshot saved by AnalyzeForm
            if (!string.IsNullOrEmpty(LastChartSnapshotPath) && File.Exists(LastChartSnapshotPath))
                return LastChartSnapshotPath;

            // Fall back to the fixed Resources path
            var defaultPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Resources", "last_chart.png");

            return File.Exists(defaultPath) ? defaultPath : string.Empty;
        }
    }
}
