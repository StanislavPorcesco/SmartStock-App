using System.Net.Http;
using System.Net.Http.Headers;
using SmartStock.Classes.Settings;
using SmartStock.Classes.Utils;
using SmartStock.Utils;

namespace SmartStock
{
    public partial class SettingsForm : Form
    {
        // Per-provider key storage (in-memory, not persisted until Apply)
        private readonly Dictionary<string, string> _providerKeys = new();
        private string _currentProvider = "DeepSeek";
        private bool _apiKeyVisible = false;

        public SettingsForm()
        {
            InitializeComponent();
            DataLayer.populateOptions(themes_cb);
            DataLayer.setRightIndex(themes_cb);

            // --- AI Provider setup ---
            provider_cb.Items.AddRange(new object[] { "DeepSeek", "OpenAI", "Claude" });

            _currentProvider = SettingsManager.Current.SelectedAiProvider is "DeepSeek" or "OpenAI" or "Claude"
                ? SettingsManager.Current.SelectedAiProvider
                : "DeepSeek";

            _providerKeys["DeepSeek"] = SettingsManager.Current.DeepSeekApiKey ?? string.Empty;
            _providerKeys["OpenAI"] = SettingsManager.Current.OpenAIApiKey ?? string.Empty;
            _providerKeys["Claude"] = SettingsManager.Current.ClaudeApiKey ?? string.Empty;

            provider_cb.SelectedItem = _currentProvider;

            // Mask key by default; admin-only reveal button
            api_tb.UseSystemPasswordChar = true;
            api_tb.Text = _providerKeys.GetValueOrDefault(_currentProvider, string.Empty);

            bool isAdmin = PermissionService.CanViewApiKey;
            view_api_btn.Enabled = isAdmin;
            view_api_btn.IconColor = isAdmin ? Color.White : Color.Gray;

            view_api_btn.Click += ToggleApiKeyVisibility;
            provider_cb.SelectedIndexChanged += Provider_SelectedIndexChanged;

            // Temperature
            temperature_numeric.Minimum = (decimal)0.0;
            temperature_numeric.Maximum = (decimal)2.0;
            temperature_numeric.DecimalPlaces = 2;
            temperature_numeric.Increment = (decimal)0.1;
            temperature_numeric.Value = (decimal)Math.Clamp(SettingsManager.Current.AiTemperature, 0.0, 2.0);

            // Fire API status check on open
            _ = CheckApiStatusAsync();

            // File paths — default values on first start come from PathsManager
            settings_tb.Text = PathsManager.SettingsFilePath;
            db_tb.Text = PathsManager.DatabasePath;

            browse_settings_btn.Click += (_, __) =>
                BrowseForFile(settings_tb, "JSON files|*.json|All files|*.*");
            browse_db_btn.Click += (_, __) =>
                BrowseForFile(db_tb, "SQLite databases|*.db|All files|*.*");
            browse_logs_btn.Click += (_, __) =>
                BrowseForFile(logs_tb, "Log files|*.log|Text files|*.txt|All files|*.*");

            // Load logging settings into UI
            enable_logging_chk.Checked = SettingsManager.Current.LoggingEnabled;
            ai_logs_ck.Checked = SettingsManager.Current.AiLoggingEnabled;
            logs_tb.Text = !string.IsNullOrWhiteSpace(SettingsManager.Current.LogFilePath)
                ? SettingsManager.Current.LogFilePath
                : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "activity.log");

            log_level_cb.Items.AddRange(new object[] { "Info", "Warning", "Error" });
            log_level_cb.SelectedItem = SettingsManager.Current.LogLevel is "Warning" or "Error"
                ? SettingsManager.Current.LogLevel
                : "Info";

            max_size_numeric.Minimum = 1;
            max_size_numeric.Maximum = 999;
            max_size_numeric.Value = Math.Max(1, Math.Min(999, SettingsManager.Current.LogMaxSizeMb));

            open_log_btn.Click += (_, __) => OpenLogFile();

            // Load report settings into UI
            enable_reports_chk.Checked = SettingsManager.Current.WeeklyReportsEnabled;
            email_recipient_tb.Text = !string.IsNullOrWhiteSpace(SettingsManager.Current.ReportRecipientEmail)
                ? SettingsManager.Current.ReportRecipientEmail
                : SessionManager.CurrentUser?.Email ?? string.Empty;

            // Time-only picker: show HH:mm with spin buttons, no calendar dropdown
            time_picker.Format = DateTimePickerFormat.Custom;
            time_picker.CustomFormat = "HH:mm";
            time_picker.ShowUpDown = true;
            if (TimeSpan.TryParse(SettingsManager.Current.ReportScheduleTime, out var t))
                time_picker.Value = DateTime.Today.Add(t);

            sent_test_btn.Click += sent_test_btn_Click;

            UpdateNextReportLabel();

            // Load external factors fetch settings into UI
            enable_daily_fetching.Checked = SettingsManager.Current.ExternalFactorsFetchEnabled;

            fetching_time.Format = DateTimePickerFormat.Custom;
            fetching_time.CustomFormat = "HH:mm";
            fetching_time.ShowUpDown = true;
            if (TimeSpan.TryParse(SettingsManager.Current.ExternalFactorsFetchTime, out var ft))
                fetching_time.Value = DateTime.Today.Add(ft);

            manual_fetch_btn.Click += manual_fetch_btn_Click;

            UpdateNextFetchLabel();
            ToolTipHelp.AddToolTip(commodity_api_lbl, "Alpha Vantage");
            ToolTipHelp.AddToolTip(economic_api_lbl, "World Bank");
            ToolTipHelp.AddToolTip(events_api_lbl, "PredictHQ");
            ToolTipHelp.AddToolTip(weather_api_lbl, "Open-Meteo");
            _ = CheckCommodityApiAsync();
            _ = CheckEconomicApiAsync();
            _ = CheckEventsApiAsync();
            _ = CheckWeatherApiAsync();

            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;

            // MUST be last: every control value is loaded above; we only now restrict access,
            // so gating never races with a load (and never blanks a field before it is read).
            ApplyRolePermissions();
        }

        /// <summary>
        /// Restricts the UI to what the current role may see, per <see cref="PermissionService"/>.
        /// Whole sections the role cannot use are HIDDEN; partially-allowed sections keep only
        /// their permitted controls. Save-side enforcement lives in <see cref="apply_btn_Click"/>.
        /// </summary>
        private void ApplyRolePermissions()
        {
            // ── Whole-section gating (hidden = no access) ──────────────────────
            reporting_pnl.Visible = PermissionService.CanAccessReporting;
            paths_pnl.Visible     = PermissionService.CanAccessFilePaths;
            factors_pnl.Visible   = PermissionService.CanAccessExternalFactors;
            ai_pnl.Visible        = PermissionService.CanAccessAiSettings;

            // ── Theme & Preferences: visible to all; Currency Symbol gated ─────
            currency_symbol_tb.Text = SettingsManager.Current.CurrencySymbol;
            currency_symbol_tb.Visible = PermissionService.CanEditCurrencySymbol;
            label4.Visible = true;

            // ── AI Settings: Provider + Temperature allowed for Manager/Admin,
            //    but the API Key (view AND edit) is Admin-only → hide the key controls.
            if (ai_pnl.Visible && !PermissionService.CanViewApiKey)
            {
                api_tb.Visible       = false;
                api_lbl.Visible      = false;
                view_api_btn.Visible = false;
            }

            // ── Logging: the Operator may toggle ONLY "Enable Logging"; the rest of
            //    the section is locked. Disable every leaf control except that checkbox
            //    (robust — no reliance on control names / layout cells).
            if (!PermissionService.CanAccessAdvancedLogging)
                LockLoggingExceptEnable(logging_body);
        }

        private void LockLoggingExceptEnable(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c.HasChildren)
                    LockLoggingExceptEnable(c);
                else if (c != enable_logging_chk && 
                    c != open_log_btn && 
                    c != logging_icon && 
                    c != logging_title_lbl &&
                    c != enable_logging_lbl &&
                    c != log_level_lbl &&
                    c != log_level_cb)
                    c.Enabled = false;
            }
        }

        private void OpenLogFile()
        {
            var path = logs_tb.Text.Trim();
            if (string.IsNullOrWhiteSpace(path))
                path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "activity.log");

            if (!File.Exists(path))
            {
                MessageBox.Show($"Log file not found:\n{path}\n\nIt will be created when the first action is logged.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = path,
                UseShellExecute = true   // opens with the default .log / .txt association (Notepad)
            });
        }

        private static void BrowseForFile(TextBox target, string filter)
        {
            using var dlg = new OpenFileDialog
            {
                Filter = filter,
                FileName = target.Text,
                Title = "Select file location"
            };
            // Start in the file's current directory if it exists
            var dir = Path.GetDirectoryName(target.Text);
            if (!string.IsNullOrEmpty(dir) && Directory.Exists(dir))
                dlg.InitialDirectory = dir;

            if (dlg.ShowDialog() == DialogResult.OK)
                target.Text = dlg.FileName;
        }

        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            // Theme and the "Enable Logging" toggle are available to every role.
            string selectedTheme = themes_cb.SelectedItem?.ToString() ?? "Light";
            SettingsManager.Current.Theme = selectedTheme;
            SettingsManager.Current.LoggingEnabled = enable_logging_chk.Checked;

            // Currency symbol is gated like its control: only persist when the role may edit it,
            // and never store an empty symbol (fall back to "$").
            if (PermissionService.CanEditCurrencySymbol)
            {
                var symbol = currency_symbol_tb.Text.Trim();
                SettingsManager.Current.CurrencySymbol = string.IsNullOrEmpty(symbol) ? "$" : symbol;
            }

            // SAVE-SIDE ENFORCEMENT: hiding a control does NOT stop Apply from reading it, so
            // each block is gated by the same capability that controls its visibility. Without
            // this, a restricted role could overwrite (blank out) a setting it never saw.

            if (PermissionService.CanViewApiKey)
            {
                // Flush the visible key into per-provider memory, then persist all three to
                // .env (the only store for secrets) and re-hydrate Current so call-time key
                // resolution picks up the change without a restart.
                _providerKeys[_currentProvider] = api_tb.Text.Trim();
                EnvManager.Set(EnvManager.DeepSeekKey, _providerKeys.GetValueOrDefault("DeepSeek", string.Empty));
                EnvManager.Set(EnvManager.OpenAIKey,   _providerKeys.GetValueOrDefault("OpenAI", string.Empty));
                EnvManager.Set(EnvManager.ClaudeKey,   _providerKeys.GetValueOrDefault("Claude", string.Empty));
                EnvManager.Save();
                SettingsManager.HydrateSecrets();
            }

            if (PermissionService.CanAccessAiSettings)
            {
                SettingsManager.Current.SelectedAiProvider = _currentProvider;
                SettingsManager.Current.AiTemperature = (double)temperature_numeric.Value;
            }

            if (PermissionService.CanAccessFilePaths)
            {
                // Paths section (settings/db → paths.cfg; log file path → settings store)
                PathsManager.Save(settings_tb.Text.Trim(), db_tb.Text.Trim());
                SettingsManager.Current.LogFilePath = logs_tb.Text.Trim();
            }

            if (PermissionService.CanAccessAdvancedLogging)
            {
                SettingsManager.Current.AiLoggingEnabled = ai_logs_ck.Checked;
                SettingsManager.Current.LogLevel = log_level_cb.SelectedItem?.ToString() ?? "Info";
                SettingsManager.Current.LogMaxSizeMb = (int)max_size_numeric.Value;
            }

            if (PermissionService.CanAccessReporting)
            {
                SettingsManager.Current.WeeklyReportsEnabled = enable_reports_chk.Checked;
                SettingsManager.Current.ReportRecipientEmail = email_recipient_tb.Text.Trim();
                SettingsManager.Current.ReportScheduleTime = time_picker.Value.ToString("HH:mm");
            }

            if (PermissionService.CanAccessExternalFactors)
            {
                SettingsManager.Current.ExternalFactorsFetchEnabled = enable_daily_fetching.Checked;
                SettingsManager.Current.ExternalFactorsFetchTime = fetching_time.Value.ToString("HH:mm");
            }

            SettingsManager.Save();
            UpdateNextReportLabel();
            UpdateNextFetchLabel();

            ThemeManager.SetTheme(selectedTheme);
            ThemeManager.Apply(this);
            this.Invalidate(true);
            this.Update();
            this.Refresh();

            ThemeManager.ApplyThemeToParentForm();

            MessageBox.Show("Settings saved successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateNextReportLabel()
        {
            if (!SettingsManager.Current.WeeklyReportsEnabled)
            {
                next_report_date_time_lbl.Text = "Disabled";
                return;
            }

            next_report_date_time_lbl.Text = ComputeNextReportDateTime().ToString("dd MMM yyyy  HH:mm");
        }

        private static DateTime ComputeNextReportDateTime()
        {
            TimeSpan.TryParse(SettingsManager.Current.ReportScheduleTime, out var scheduledTime);

            var lastSent = SettingsManager.Current.LastWeeklyReportSent;
            if (lastSent.HasValue)
                return lastSent.Value.Date.AddDays(7).Add(scheduledTime);

            // Never sent — use the next upcoming occurrence of the scheduled time
            var candidate = DateTime.Today.Add(scheduledTime);
            return candidate < DateTime.Now ? candidate.AddDays(1) : candidate;
        }

        private void UpdateNextFetchLabel()
        {
            if (!SettingsManager.Current.ExternalFactorsFetchEnabled)
            {
                next_fetch_lbl.Text = "Disabled";
                return;
            }

            next_fetch_lbl.Text = ComputeNextFetchDateTime().ToString("dd MMM yyyy  HH:mm");
        }

        private static DateTime ComputeNextFetchDateTime()
        {
            TimeSpan.TryParse(SettingsManager.Current.ExternalFactorsFetchTime, out var scheduledTime);

            var lastFetched = SettingsManager.Current.LastExternalFactorsFetched;
            if (lastFetched.HasValue)
                return lastFetched.Value.Date.AddDays(1).Add(scheduledTime);

            // Never fetched — use the next upcoming occurrence of the scheduled time
            var candidate = DateTime.Today.Add(scheduledTime);
            return candidate < DateTime.Now ? candidate.AddDays(1) : candidate;
        }

        private async void manual_fetch_btn_Click(object? sender, EventArgs e)
        {
            manual_fetch_btn.Enabled = false;
            manual_fetch_btn.Text = "Fetching...";
            try
            {
                var (added, errors) = await ExternalFactorsScheduler.RunFetchAsync();

                var msg = $"Fetch complete. {added} new factor(s) added.";
                if (errors.Count > 0)
                    msg += $"\n\nWarnings:\n{string.Join("\n", errors)}";

                MessageBox.Show(msg, "External Factors Fetch",
                    MessageBoxButtons.OK,
                    errors.Count > 0 ? MessageBoxIcon.Warning : MessageBoxIcon.Information);

                UpdateNextFetchLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fetch failed:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                manual_fetch_btn.Enabled = true;
                manual_fetch_btn.Text = "Fetch Now";
            }
        }

        private async void sent_test_btn_Click(object? sender, EventArgs e)
        {
            var recipient = email_recipient_tb.Text.Trim();
            if (string.IsNullOrWhiteSpace(recipient))
            {
                MessageBox.Show("Please enter a recipient email address first.",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sent_test_btn.Enabled = false;
            sent_test_btn.Text = "Sending...";
            try
            {
                await ReportScheduler.SendReportAsync(recipient, isTest: true);
                MessageBox.Show("Test report sent successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send test report:\n{ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sent_test_btn.Enabled = true;
                sent_test_btn.Text = "Send Test Report";
            }
        }

        // --- AI key visibility toggle (admin only) ---
        private void ToggleApiKeyVisibility(object? sender, EventArgs e)
        {
            _apiKeyVisible = !_apiKeyVisible;
            api_tb.UseSystemPasswordChar = !_apiKeyVisible;
            view_api_btn.IconChar = _apiKeyVisible
                ? FontAwesome.Sharp.IconChar.Eye
                : FontAwesome.Sharp.IconChar.EyeSlash;
        }

        // --- Provider switching ---
        private void Provider_SelectedIndexChanged(object? sender, EventArgs e)
        {
            var newProvider = provider_cb.SelectedItem?.ToString() ?? "DeepSeek";
            if (newProvider == _currentProvider) return;

            // Stash the key currently shown back to in-memory store
            _providerKeys[_currentProvider] = api_tb.Text;

            _currentProvider = newProvider;

            // Restore key for the newly selected provider
            api_tb.Text = _providerKeys.GetValueOrDefault(_currentProvider, string.Empty);

            // Reset visibility — key should be masked again on provider change
            _apiKeyVisible = false;
            api_tb.UseSystemPasswordChar = true;
            view_api_btn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;

            _ = CheckApiStatusAsync();
        }

        // --- External factors API status checks ---
        private async Task CheckCommodityApiAsync()
        {
            SetStatus(commodity_status_color_lbl, commodity_status_lbl, null, "Checking...");
            var key = SettingsManager.Current.AlphaVantageApiKey?.Trim();
            if (string.IsNullOrWhiteSpace(key)) { SetStatus(commodity_status_color_lbl, commodity_status_lbl, false, "No Key"); return; }
            try
            {
                using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
                var response = await client.GetAsync($"https://www.alphavantage.co/query?function=WTI&interval=monthly&apikey={key}");
                bool active = response.IsSuccessStatusCode;
                SetStatus(commodity_status_color_lbl, commodity_status_lbl, active, active ? "Active" : "Inactive");
            }
            catch { SetStatus(commodity_status_color_lbl, commodity_status_lbl, false, "Error"); }
        }

        private async Task CheckEconomicApiAsync()
        {
            SetStatus(economic_status_color_lbl, economic_status_lbl, null, "Checking...");
            try
            {
                using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
                var response = await client.GetAsync("https://api.worldbank.org/v2/country/RO/indicator/FP.CPI.TOTL.ZG?format=json&mrv=1&per_page=1");
                bool active = response.IsSuccessStatusCode;
                SetStatus(economic_status_color_lbl, economic_status_lbl, active, active ? "Active" : "Inactive");
            }
            catch { SetStatus(economic_status_color_lbl, economic_status_lbl, false, "Error"); }
        }

        private async Task CheckEventsApiAsync()
        {
            SetStatus(events_status_color_lbl, events_status_lbl, null, "Checking...");
            var key = SettingsManager.Current.PredictHQApiKey?.Trim();
            if (string.IsNullOrWhiteSpace(key)) { SetStatus(events_status_color_lbl, events_status_lbl, false, "No Key"); return; }
            try
            {
                using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", key);
                var response = await client.GetAsync("https://api.predicthq.com/v1/events/?limit=1");
                bool active = response.IsSuccessStatusCode;
                SetStatus(events_status_color_lbl, events_status_lbl, active, active ? "Active" : "Inactive");
            }
            catch { SetStatus(events_status_color_lbl, events_status_lbl, false, "Error"); }
        }

        private async Task CheckWeatherApiAsync()
        {
            SetStatus(weather_status_color_lbl, weather_status_lbl, null, "Checking...");
            try
            {
                using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };
                var response = await client.GetAsync("https://api.open-meteo.com/v1/forecast?latitude=44.43&longitude=26.10&daily=temperature_2m_max&timezone=auto&forecast_days=1");
                bool active = response.IsSuccessStatusCode;
                SetStatus(weather_status_color_lbl, weather_status_lbl, active, active ? "Active" : "Inactive");
            }
            catch { SetStatus(weather_status_color_lbl, weather_status_lbl, false, "Error"); }
        }

        private void SetStatus(Label colorLbl, Label textLbl, bool? active, string text)
        {
            if (InvokeRequired) { BeginInvoke(() => SetStatus(colorLbl, textLbl, active, text)); return; }
            textLbl.Text = text;
            colorLbl.ForeColor = active switch
            {
                true => Color.LimeGreen,
                false => Color.Red,
                null => Color.Gray
            };
        }

        // --- AI agent API status check ---
        private async Task CheckApiStatusAsync()
        {
            SetApiStatus(null, "Checking...");

            var key = api_tb.Text.Trim();
            if (string.IsNullOrWhiteSpace(key))
            {
                SetApiStatus(false, "No Key");
                return;
            }

            try
            {
                bool active = await PingProviderAsync(_currentProvider, key);
                SetApiStatus(active, active ? "Active" : "Inactive");
            }
            catch
            {
                SetApiStatus(false, "Error");
            }
        }

        private void SetApiStatus(bool? active, string text) =>
            SetStatus(status_color_lbl, api_status_lbl, active, text);

        private static async Task<bool> PingProviderAsync(string provider, string apiKey)
        {
            using var client = new HttpClient { Timeout = TimeSpan.FromSeconds(10) };

            HttpRequestMessage request = provider switch
            {
                "OpenAI" => BuildRequest(HttpMethod.Get, "https://api.openai.com/v1/models",
                                bearer: apiKey),
                "Claude" => BuildRequest(HttpMethod.Get, "https://api.anthropic.com/v1/models",
                                apiKeyHeader: ("x-api-key", apiKey),
                                extraHeaders: new[] { ("anthropic-version", "2023-06-01") }),
                _ => BuildRequest(HttpMethod.Get, "https://api.deepseek.com/models",
                                bearer: apiKey),
            };

            var response = await client.SendAsync(request);
            return response.IsSuccessStatusCode;
        }

        private static HttpRequestMessage BuildRequest(
            HttpMethod method,
            string url,
            string? bearer = null,
            (string name, string value)? apiKeyHeader = null,
            (string name, string value)[]? extraHeaders = null)
        {
            var req = new HttpRequestMessage(method, url);
            if (bearer is not null)
                req.Headers.Authorization = new AuthenticationHeaderValue("Bearer", bearer);
            if (apiKeyHeader.HasValue)
                req.Headers.Add(apiKeyHeader.Value.name, apiKeyHeader.Value.value);
            if (extraHeaders is not null)
                foreach (var (name, value) in extraHeaders)
                    req.Headers.Add(name, value);
            return req;
        }
    }
}
