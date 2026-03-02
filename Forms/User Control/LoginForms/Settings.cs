using SmartStock.Classes.Settings;
using SmartStock.Classes.Utils;
using SmartStock.Forms.User_Control;

namespace SmartStock.Forms.AddForms
{
    public partial class Settings : UserControl
    {
        public Settings()
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

        private void return_btn_Click(object sender, EventArgs e)
        {
            DataLayer.OpenUserControl(this.FindForm(), new Login());
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            string selectedTheme = themes_cb.SelectedItem?.ToString() ?? "Light";
            SettingsManager.Current.Theme = selectedTheme;
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
