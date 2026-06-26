namespace SmartStock.Classes.Settings
{
    using System;
    using System.IO;
    using System.Text.Json;

    public static class SettingsManager
    {
        private static string FilePath => PathsManager.SettingsFilePath;

        public static AppSettings Current { get; private set; } = new AppSettings();

        public static void Load()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    Current = JsonSerializer.Deserialize<AppSettings>(json) ?? new AppSettings();
                }
                else
                {
                    Save();
                    Console.WriteLine("Succes: Settings file created!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading the settings: {ex.Message}");
                Current = new AppSettings();
            }

            // Secrets live ONLY in .env. Load it (creating the example on first run),
            // migrate any keys still embedded in an old appSettings.json, then hydrate
            // the in-memory AppSettings so consumers keep reading Current.*ApiKey.
            EnvManager.Load();
            MigrateLegacyKeys();
            HydrateSecrets();
        }

        /// <summary>
        /// Copies the secret values from <see cref="EnvManager"/> into <see cref="Current"/>.
        /// Public so callers (e.g. SettingsForm) can refresh after editing keys at runtime,
        /// which lets call-time key resolution pick up new values without a restart.
        /// </summary>
        public static void HydrateSecrets()
        {
            Current.DeepSeekApiKey     = EnvManager.Get(EnvManager.DeepSeekKey);
            Current.OpenAIApiKey       = EnvManager.Get(EnvManager.OpenAIKey);
            Current.ClaudeApiKey       = EnvManager.Get(EnvManager.ClaudeKey);
            Current.AlphaVantageApiKey = EnvManager.Get(EnvManager.AlphaVantageKey);
            Current.PredictHQApiKey    = EnvManager.Get(EnvManager.PredictHQKey);
        }

        /// <summary>
        /// One-time migration: copies any API keys still stored in appSettings.json into
        /// .env (only when .env doesn't already have them). Idempotent — once a setting save
        /// rewrites the JSON without the now-[JsonIgnore]d key fields, this finds nothing.
        /// </summary>
        private static void MigrateLegacyKeys()
        {
            if (!File.Exists(FilePath)) return;

            try
            {
                using var doc = JsonDocument.Parse(File.ReadAllText(FilePath));
                var root = doc.RootElement;

                var map = new (string Json, string Env)[]
                {
                    ("DeepSeekApiKey",     EnvManager.DeepSeekKey),
                    ("OpenAIApiKey",       EnvManager.OpenAIKey),
                    ("ClaudeApiKey",       EnvManager.ClaudeKey),
                    ("AlphaVantageApiKey", EnvManager.AlphaVantageKey),
                    ("PredictHQApiKey",    EnvManager.PredictHQKey),
                };

                var migrated = false;
                foreach (var (jsonName, envName) in map)
                {
                    if (root.TryGetProperty(jsonName, out var el) &&
                        el.ValueKind == JsonValueKind.String)
                    {
                        var val = el.GetString();
                        if (!string.IsNullOrWhiteSpace(val) &&
                            string.IsNullOrWhiteSpace(EnvManager.Get(envName)))
                        {
                            EnvManager.Set(envName, val);
                            migrated = true;
                        }
                    }
                }

                if (migrated) EnvManager.Save();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error migrating legacy API keys: {ex.Message}");
            }
        }

        public static void Save()
        {
            try
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(Current, options);
                File.WriteAllText(FilePath, json);
                Console.WriteLine("Succes: Settings were saved!");
                Console.WriteLine("Path: " + FilePath);
                Console.WriteLine("Current Theme: " + Current.Theme.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving the settings: {ex.Message}");
            }
        }

    }
}
