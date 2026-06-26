namespace SmartStock.Classes.Settings
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// Single source of truth for application secrets (API keys + email passwords).
    /// Secrets live ONLY in a <c>.env</c> file — never in appSettings.json or source code.
    ///
    /// File location (priority order on <see cref="Load"/>):
    ///   1. Canonical path: <see cref="PathsManager.EnvFilePath"/> — the shared data folder,
    ///      alongside appSettings.json. This is where an installed copy keeps its .env.
    ///   2. Dev fallback: a .env found by walking up from the executable directory,
    ///      so the project-root .env keeps working during development.
    ///
    /// On first run, when no .env exists anywhere, an example file listing every available
    /// field (empty placeholders) is written to the canonical path.
    /// </summary>
    public static class EnvManager
    {
        // Canonical key names written to the example template.
        public const string DeepSeekKey         = "DEEPSEEK_API_KEY";
        public const string OpenAIKey           = "OPENAI_API_KEY";
        public const string ClaudeKey           = "ANTHROPIC_API_KEY";
        public const string AlphaVantageKey     = "ALPHAVANTAGE_API_KEY";
        public const string PredictHQKey        = "PREDICTHQ_API_KEY";
        public const string AuthEmailPassword    = "AUTH_EMAIL_PASSWORD";
        public const string ReportsEmailPassword = "REPORTS_EMAIL_PASSWORD";

        // Legacy alias still honoured on read, so an older .env keeps working.
        private const string ClaudeKeyAlias = "CLAUDE_API_KEY";

        // Ordered field definition: (key, human comment). Drives the example template.
        private static readonly (string Key, string Comment)[] Fields =
        {
            (DeepSeekKey,          "DeepSeek (default AI provider) - https://platform.deepseek.com/api_keys"),
            (OpenAIKey,            "OpenAI - https://platform.openai.com/api-keys"),
            (ClaudeKey,            "Anthropic / Claude - https://console.anthropic.com/settings/keys"),
            (AlphaVantageKey,      "Alpha Vantage (commodity prices) - https://www.alphavantage.co/support/#api-key"),
            (PredictHQKey,         "PredictHQ (events) - https://control.predicthq.com/"),
            (AuthEmailPassword,    "Gmail app password for smartstock.auth@gmail.com (login verification codes)"),
            (ReportsEmailPassword, "Gmail app password for smartstock.reports@gmail.com (weekly reports)"),
        };

        private static readonly Dictionary<string, string> _values =
            new(StringComparer.OrdinalIgnoreCase);

        // Path the values were loaded from / will be saved back to.
        private static string _activePath = PathsManager.EnvFilePath;

        /// <summary>
        /// Loads the .env into memory. Creates the example file on first run when no
        /// .env exists at the canonical path or anywhere up the executable tree.
        /// </summary>
        public static void Load()
        {
            _values.Clear();

            var sourcePath = ResolveSourcePath();   // null when no .env exists anywhere
            if (sourcePath == null)
            {
                EnsureTemplate();                    // write the example to the data folder
                sourcePath = PathsManager.EnvFilePath;
            }

            _activePath = sourcePath;

            if (File.Exists(sourcePath))
                ParseInto(sourcePath, _values);
        }

        /// <summary>
        /// Resolves a secret. Falls back to the legacy Claude alias and, last of all,
        /// to a real process environment variable of the same name.
        /// </summary>
        public static string Get(string key)
        {
            if (_values.TryGetValue(key, out var v) && !string.IsNullOrWhiteSpace(v))
                return v;

            if (key == ClaudeKey &&
                _values.TryGetValue(ClaudeKeyAlias, out var alias) &&
                !string.IsNullOrWhiteSpace(alias))
                return alias;

            return Environment.GetEnvironmentVariable(key) ?? string.Empty;
        }

        /// <summary>Updates a key in memory. Call <see cref="Save"/> to persist to disk.</summary>
        public static void Set(string key, string value)
        {
            _values[key] = value?.Trim() ?? string.Empty;
        }

        /// <summary>
        /// Persists in-memory values back to the active .env with a line-merge:
        /// matched keys are replaced in place, missing keys appended, and every other
        /// line (comments, blanks, unknown keys) is left untouched.
        /// </summary>
        public static void Save()
        {
            try
            {
                var dir = Path.GetDirectoryName(_activePath);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                var lines = File.Exists(_activePath)
                    ? File.ReadAllLines(_activePath).ToList()
                    : new List<string>();

                var written = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

                for (var i = 0; i < lines.Count; i++)
                {
                    var trimmed = lines[i].TrimStart();
                    if (trimmed.StartsWith('#') || !trimmed.Contains('=')) continue;

                    var sep = lines[i].IndexOf('=');
                    var lineKey = lines[i][..sep].Trim();

                    if (_values.TryGetValue(lineKey, out var newVal))
                    {
                        lines[i] = $"{lineKey}={newVal}";
                        written.Add(lineKey);
                    }
                }

                // Append keys not already present (skip empties — no point writing blank unknowns).
                foreach (var kvp in _values)
                {
                    if (written.Contains(kvp.Key) || string.IsNullOrEmpty(kvp.Value)) continue;
                    lines.Add($"{kvp.Key}={kvp.Value}");
                }

                File.WriteAllLines(_activePath, lines);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving .env: {ex.Message}");
            }
        }

        /// <summary>
        /// Writes the example .env (full field set, empty placeholders) to the canonical
        /// data-folder path. No-op when any .env already exists, so it never overwrites a
        /// populated dev or installed file.
        /// </summary>
        public static void EnsureTemplate()
        {
            var path = PathsManager.EnvFilePath;
            if (File.Exists(path)) return;

            try
            {
                var dir = Path.GetDirectoryName(path);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                var lines = new List<string>
                {
                    "# SmartStock secrets - API keys and Gmail app passwords.",
                    "# This file is the ONLY place secrets are read from. Keep it out of source control.",
                    "# Fill in the values after each '='. Lines starting with # are comments.",
                    string.Empty
                };

                foreach (var (key, comment) in Fields)
                {
                    lines.Add($"# {comment}");
                    lines.Add($"{key}=");
                    lines.Add(string.Empty);
                }

                File.WriteAllLines(path, lines);
                Console.WriteLine($"Example .env created at {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating example .env: {ex.Message}");
            }
        }

        // --- helpers ---

        private static string? ResolveSourcePath()
        {
            // 1. Canonical data-folder file wins.
            if (File.Exists(PathsManager.EnvFilePath))
                return PathsManager.EnvFilePath;

            // 2. Walk up from the executable directory (dev project root).
            var dir = AppDomain.CurrentDomain.BaseDirectory;
            for (var depth = 0; depth < 5 && !string.IsNullOrEmpty(dir); depth++)
            {
                var candidate = Path.Combine(dir, ".env");
                if (File.Exists(candidate)) return candidate;
                dir = Path.GetDirectoryName(dir);
            }

            return null;
        }

        private static void ParseInto(string path, IDictionary<string, string> target)
        {
            foreach (var raw in File.ReadAllLines(path))
            {
                var line = raw.Trim();
                if (line.StartsWith('#') || !line.Contains('=')) continue;

                var sep = line.IndexOf('=');
                var key = line[..sep].Trim();
                var val = line[(sep + 1)..].Trim();
                if (!string.IsNullOrEmpty(key))
                    target[key] = val;
            }
        }
    }
}
