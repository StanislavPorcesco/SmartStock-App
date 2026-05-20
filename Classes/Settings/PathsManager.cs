namespace SmartStock.Classes.Settings
{
    /// <summary>
    /// Manages the two user-configurable file paths:
    ///   • SettingsFilePath — where appSettings.json lives
    ///   • DatabasePath     — where SmartStock.db lives
    ///
    /// These are persisted in <c>Resources/paths.cfg</c> — a tiny bootstrap file
    /// that always lives at a fixed location relative to the executable.
    /// Loading it first lets every other component use the correct paths.
    /// </summary>
    public static class PathsManager
    {
        private static readonly string DataDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
            "SmartStock");

        private static readonly string BootstrapPath = Path.Combine(DataDir, "paths.cfg");

        public static string SettingsFilePath { get; private set; } = DefaultSettingsPath;
        public static string DatabasePath     { get; private set; } = DefaultDatabasePath;

        public static string DefaultSettingsPath =>
            Path.Combine(DataDir, "appSettings.json");

        public static string DefaultDatabasePath =>
            Path.Combine(DataDir, "SmartStock.db");

        // ── Load ──────────────────────────────────────────────────────────────

        public static void Load()
        {
            if (!Directory.Exists(DataDir)) Directory.CreateDirectory(DataDir);

            SettingsFilePath = DefaultSettingsPath;
            DatabasePath     = DefaultDatabasePath;

            if (!File.Exists(BootstrapPath)) return;

            foreach (var raw in File.ReadAllLines(BootstrapPath))
            {
                var line = raw.Trim();
                if (line.StartsWith('#') || !line.Contains('=')) continue;

                var sep = line.IndexOf('=');
                var key = line[..sep].Trim();
                var val = line[(sep + 1)..].Trim();
                if (string.IsNullOrWhiteSpace(val)) continue;

                if (key.Equals("SettingsPath", StringComparison.OrdinalIgnoreCase))
                    SettingsFilePath = val;
                else if (key.Equals("DatabasePath", StringComparison.OrdinalIgnoreCase))
                    DatabasePath = val;
            }
        }

        // ── Save ──────────────────────────────────────────────────────────────

        public static void Save(string settingsPath, string databasePath)
        {
            SettingsFilePath = settingsPath;
            DatabasePath     = databasePath;

            var dir = Path.GetDirectoryName(BootstrapPath)!;
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);

            File.WriteAllLines(BootstrapPath,
            [
                "# SmartStock path configuration — do not move this file",
                $"SettingsPath={settingsPath}",
                $"DatabasePath={databasePath}"
            ]);
        }
    }
}
