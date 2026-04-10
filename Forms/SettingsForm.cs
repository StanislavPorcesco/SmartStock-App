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
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
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
            SettingsManager.Current.Theme = selectedTheme;
            SettingsManager.Current.DeepSeekApiKey = apiKey;
            SettingsManager.Save();
            ThemeManager.SetTheme(selectedTheme);
            ThemeManager.Apply(this);
            this.Invalidate(true);
            this.Update();
            this.Refresh();

            ThemeManager.ApplyThemeToParentForm();

            MessageBox.Show("Settings saved successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
