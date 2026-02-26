using SmartStock.Classes.Settings;
using SmartStock.Classes.Utils;

namespace SmartStock
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            populateOptions();
            setRightIndex();
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
        }

        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void setRightIndex()
        {
            if (SettingsManager.Current.Theme == "Dark")
            {
                themes_cb.SelectedIndex = 0;
            }
            else if (SettingsManager.Current.Theme == "Light")
            {
                themes_cb.SelectedIndex = 1;
            }
        }
        public void populateOptions()
        {
            themes_cb.Items.Clear();
            themes_cb.Items.AddRange(new object[] {
                "Dark", "Light"
            });
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

            ApplyThemeToParentForm();

            MessageBox.Show("Settings saved successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ApplyThemeToParentForm()
        {
            try
            {
                foreach (Form form in Application.OpenForms)
                {
                    if (form.Name == "MenuForm" || form.GetType().Name == "MenuForm")
                    {
                        ThemeManager.Apply(form);
                        form.Invalidate(true);
                        form.Update();
                        form.Refresh();

                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error updating parent form: {ex.Message}");
            }
        }
    }
}
