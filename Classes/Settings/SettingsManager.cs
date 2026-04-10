namespace SmartStock.Classes.Settings
{
    using System;
    using System.IO;
    using System.Text.Json;

    public static class SettingsManager
    {
        private static readonly string FilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources/appSettings.json");

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

            // If no API key is persisted in appSettings.json, try loading it from .env
            if (string.IsNullOrWhiteSpace(Current.DeepSeekApiKey))
            {
                var envKey = ReadKeyFromDotEnv("DEEPSEEK_API_KEY");
                if (!string.IsNullOrWhiteSpace(envKey))
                {
                    Current.DeepSeekApiKey = envKey;
                    Console.WriteLine("DeepSeek API key loaded from .env file.");
                }
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

        /// <summary>
        /// Searches for a .env file starting from the runtime output directory and
        /// walking up to the repository root (up to 4 levels). Parses KEY=VALUE pairs.
        /// Lines beginning with # are treated as comments and ignored.
        /// </summary>
        private static string? ReadKeyFromDotEnv(string key)
        {
            var searchDir = AppDomain.CurrentDomain.BaseDirectory;

            for (var depth = 0; depth < 5; depth++)
            {
                if (string.IsNullOrEmpty(searchDir)) break;

                var envPath = Path.Combine(searchDir, ".env");
                if (File.Exists(envPath))
                {
                    foreach (var line in File.ReadAllLines(envPath))
                    {
                        var trimmed = line.Trim();
                        if (trimmed.StartsWith('#') || !trimmed.Contains('='))
                            continue;

                        var separatorIndex = trimmed.IndexOf('=');
                        var lineKey   = trimmed[..separatorIndex].Trim();
                        var lineValue = trimmed[(separatorIndex + 1)..].Trim();

                        if (lineKey.Equals(key, StringComparison.OrdinalIgnoreCase) &&
                            !string.IsNullOrWhiteSpace(lineValue))
                        {
                            return lineValue;
                        }
                    }

                    // Found the .env file but key was missing or empty — stop searching.
                    break;
                }

                searchDir = Path.GetDirectoryName(searchDir);
            }

            return null;
        }
    }
}
