using SmartStock.Classes.Settings;
using SmartStock.Classes.Utils;

namespace SmartStock
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            DataLayer.populateOptions(themes_cb);
            DataLayer.setRightIndex(themes_cb);
            api_tb.Text = SettingsManager.Current.DeepSeekApiKey;

            // File paths — default values on first start come from PathsManager
            settings_tb.Text = PathsManager.SettingsFilePath;
            db_tb.Text       = PathsManager.DatabasePath;

            browse_settings_btn.Click += (_, __) =>
                BrowseForFile(settings_tb, "JSON files|*.json|All files|*.*");
            browse_db_btn.Click += (_, __) =>
                BrowseForFile(db_tb, "SQLite databases|*.db|All files|*.*");
            browse_logs_btn.Click += (_, __) =>
                BrowseForFile(logs_tb, "Log files|*.log|Text files|*.txt|All files|*.*");

            // Load logging settings into UI
            enable_logging_chk.Checked = SettingsManager.Current.LoggingEnabled;
            ai_logs_ck.Checked         = SettingsManager.Current.AiLoggingEnabled;
            logs_tb.Text = !string.IsNullOrWhiteSpace(SettingsManager.Current.LogFilePath)
                ? SettingsManager.Current.LogFilePath
                : Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "activity.log");

            log_level_cb.Items.AddRange(new object[] { "Info", "Warning", "Error" });
            log_level_cb.SelectedItem = SettingsManager.Current.LogLevel is "Warning" or "Error"
                ? SettingsManager.Current.LogLevel
                : "Info";

            max_size_numeric.Minimum = 1;
            max_size_numeric.Maximum = 999;
            max_size_numeric.Value   = Math.Max(1, Math.Min(999, SettingsManager.Current.LogMaxSizeMb));

            open_log_btn.Click += (_, __) => OpenLogFile();

            // Load report settings into UI
            enable_reports_chk.Checked = SettingsManager.Current.WeeklyReportsEnabled;
            email_recipient_tb.Text = !string.IsNullOrWhiteSpace(SettingsManager.Current.ReportRecipientEmail)
                ? SettingsManager.Current.ReportRecipientEmail
                : SessionManager.CurrentUser?.Email ?? string.Empty;

            // Time-only picker: show HH:mm with spin buttons, no calendar dropdown
            time_picker.Format       = DateTimePickerFormat.Custom;
            time_picker.CustomFormat = "HH:mm";
            time_picker.ShowUpDown   = true;
            if (TimeSpan.TryParse(SettingsManager.Current.ReportScheduleTime, out var t))
                time_picker.Value = DateTime.Today.Add(t);

            sent_test_btn.Click += sent_test_btn_Click;

            UpdateNextReportLabel();

            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
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
                FileName        = path,
                UseShellExecute = true   // opens with the default .log / .txt association (Notepad)
            });
        }

        private static void BrowseForFile(TextBox target, string filter)
        {
            using var dlg = new OpenFileDialog
            {
                Filter   = filter,
                FileName = target.Text,
                Title    = "Select file location"
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
            string selectedTheme = themes_cb.SelectedItem?.ToString() ?? "Light";
            string apiKey = api_tb.Text.Trim();
            SettingsManager.Current.Theme          = selectedTheme;
            SettingsManager.Current.DeepSeekApiKey = apiKey;

            // Persist file paths (written to paths.cfg, takes effect on next app start)
            PathsManager.Save(settings_tb.Text.Trim(), db_tb.Text.Trim());

            // Persist logging settings
            SettingsManager.Current.LoggingEnabled   = enable_logging_chk.Checked;
            SettingsManager.Current.AiLoggingEnabled = ai_logs_ck.Checked;
            SettingsManager.Current.LogFilePath      = logs_tb.Text.Trim();
            SettingsManager.Current.LogLevel         = log_level_cb.SelectedItem?.ToString() ?? "Info";
            SettingsManager.Current.LogMaxSizeMb     = (int)max_size_numeric.Value;

            // Persist report settings
            SettingsManager.Current.WeeklyReportsEnabled  = enable_reports_chk.Checked;
            SettingsManager.Current.ReportRecipientEmail  = email_recipient_tb.Text.Trim();
            SettingsManager.Current.ReportScheduleTime    = time_picker.Value.ToString("HH:mm");

            SettingsManager.Save();
            UpdateNextReportLabel();

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
            sent_test_btn.Text    = "Sending...";
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
                sent_test_btn.Text    = "Send Test Report";
            }
        }
    }
}
