using SmartStock.Classes.Settings;

namespace SmartStock.Classes.Utils
{
    /// <summary>
    /// Thread-safe append-only activity logger.
    /// Supports log level filtering (Info/Warning/Error) and automatic
    /// file rotation when the log exceeds LogMaxSizeMb.
    /// Failures are silently swallowed — logging must never crash the app.
    /// </summary>
    public static class ActivityLogger
    {
        private static readonly object _fileLock = new();

        // Actions considered Warning-level (state changes) — shown at Warning and Info.
        private static readonly HashSet<string> WarningActions =
            new(StringComparer.OrdinalIgnoreCase) { "ARCHIVE", "RESTORE", "DELETE" };

        // ── Public API ────────────────────────────────────────────────────────────

        /// <summary>Logs a CRUD action performed by the current user.</summary>
        public static void LogUserAction(string action, string entityType, string entityName, int? entityId = null)
        {
            if (!SettingsManager.Current.LoggingEnabled) return;
            if (!PassesLevelFilter(action)) return;

            var user   = SessionManager.CurrentUser?.Username ?? "unknown";
            var idPart = entityId.HasValue ? $" (ID:{entityId})" : string.Empty;
            Write($"[USER:{user}] [{action}] {entityType}: \"{entityName}\"{idPart}");
        }

        /// <summary>
        /// Logs a background system event (scheduler, batch fetch, etc.).
        /// Respects LoggingEnabled and level filter; does not require a logged-in user.
        /// </summary>
        public static void LogSystemAction(string operation, string details, bool isError = false)
        {
            if (!SettingsManager.Current.LoggingEnabled) return;

            var action = isError ? "ERROR" : "SYSTEM";
            if (!PassesLevelFilter(action)) return;

            Write($"[{action}] [{operation}] {details}");
        }

        /// <summary>Logs an AI operation. Only written when both LoggingEnabled and AiLoggingEnabled are true.</summary>
        public static void LogAiAction(string operation, string details)
        {
            if (!SettingsManager.Current.LoggingEnabled) return;
            if (!SettingsManager.Current.AiLoggingEnabled) return;
            if (!PassesLevelFilter("AI")) return;

            Write($"[AI] [{operation}] {details}");
        }

        // ── Internals ─────────────────────────────────────────────────────────────

        /// <summary>
        /// Level filter:
        ///   Info    — all actions pass
        ///   Warning — only ARCHIVE/RESTORE/DELETE and AI actions pass
        ///   Error   — nothing passes (reserved for future exception entries)
        /// </summary>
        private static bool PassesLevelFilter(string action)
        {
            // ERROR-level system events always pass regardless of the configured level.
            if (action == "ERROR") return true;

            return SettingsManager.Current.LogLevel switch
            {
                "Warning" => WarningActions.Contains(action) || action == "AI" || action == "SYSTEM",
                "Error"   => false,
                _         => true   // "Info" — everything
            };
        }

        private static void Write(string message)
        {
            try
            {
                var path = ResolveLogPath();
                var line = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}";

                lock (_fileLock)
                {
                    RotateIfNeeded(path);
                    File.AppendAllText(path, line + Environment.NewLine);
                }
            }
            catch
            {
                // Swallow — logging failures must never propagate to the caller.
            }
        }

        /// <summary>
        /// If the log file exceeds LogMaxSizeMb, renames it to
        /// activity_backup_yyyyMMdd_HHmmss.log in the same directory
        /// so the next write starts a fresh file.
        /// </summary>
        private static void RotateIfNeeded(string path)
        {
            var maxBytes = (long)SettingsManager.Current.LogMaxSizeMb * 1024 * 1024;
            if (maxBytes <= 0) return;

            if (!File.Exists(path)) return;

            var info = new FileInfo(path);
            if (info.Length < maxBytes) return;

            var dir       = Path.GetDirectoryName(path) ?? string.Empty;
            var name      = Path.GetFileNameWithoutExtension(path);
            var ext       = Path.GetExtension(path);
            var timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            var backup    = Path.Combine(dir, $"{name}_backup_{timestamp}{ext}");

            File.Move(path, backup);
        }

        private static string ResolveLogPath()
        {
            var configured = SettingsManager.Current.LogFilePath;
            if (!string.IsNullOrWhiteSpace(configured))
                return configured;

            return Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Resources",
                "activity.log");
        }
    }
}
