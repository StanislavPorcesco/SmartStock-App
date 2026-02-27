using SmartStock.Classes.Settings;
using SmartStock.Forms.AddForms;
using SmartStock.Forms.User_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.Classes.Utils
{
    public class DataLayer
    {
        public static void PopulateSelector(ComboBox selector)
        {
            if (selector != null)
            {
                selector.Items.Clear();
                selector.Items.AddRange(new string[] { "Product", "Category", "Supplier", "Transaction", "Customer", "Sale", "ExternalFactor" });
            }
        }

        public static void OpenUserControl(Form form, UserControl controlToOpen) {
            try
            {
                form.Controls.Clear();
                form.SuspendLayout();
                if (controlToOpen != null)
                {
                    controlToOpen.Dock = DockStyle.Fill;
                    form.Controls.Add(controlToOpen);
                    ThemeManager.Apply(controlToOpen);
                }
                form.ResumeLayout(true);

                controlToOpen?.Invalidate(true);
                form.Invalidate(true);
                controlToOpen?.Update();
                form.Update();
                controlToOpen?.Refresh();
                form.Refresh();
                controlToOpen?.Focus();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error opening AddAccount: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Stack trace: {ex.StackTrace}");
                MessageBox.Show($"Error opening Create Account form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void populateOptions(ComboBox themes_cb)
        {
            themes_cb.Items.Clear();
            themes_cb.Items.AddRange(new object[] {
                "Dark", "Light"
            });
        }

        public static void setRightIndex(ComboBox themes_cb)
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
    }
}
