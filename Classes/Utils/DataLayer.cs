using SmartStock.Classes.Settings;
using SmartStock.Forms.AddForms;
using SmartStock.Forms.User_Control;

namespace SmartStock.Classes.Utils
{
    public class DataLayer
    {
        public static void PopulateSelector(ComboBox selector)
        {
            if (selector != null)
            {
                selector.Items.Clear();
                selector.Items.AddRange(new string[] { "Product", "Category", "Supplier", "Transaction", "Customer", "Sale", "ExternalFactor", "User" });
                selector.Text = "Select an option";
            }            
        }

        public static void PopulateRoleSelector(ComboBox selector)
        {
            if (selector != null)
            {
                selector.Items.Clear();
                selector.Items.AddRange(new string[] { "Admin", "Agent" });
                selector.Text = "Select a role";
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

        public static System.EventHandler OpenAddInstanceForm(UserControl container, ComboBox selector_cb)
        {
            return (sender, e) =>
            {
                string selectedOption = selector_cb.SelectedItem as string;
                if (selectedOption == null) return;
                if (selectedOption == "User" && (SessionManager.CurrentUser == null || SessionManager.CurrentUser.Role != "Admin"))
                {
                    MessageBox.Show("Unauthorized access! Only administrators can manage user accounts.",
                                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                container.SuspendLayout();
                container.Controls.Clear();
                UserControl controlToOpen = selectedOption switch
                {
                    "Product" => new AddProduct(),
                    "Category" => new AddCategory(),
                    "Supplier" => new AddSupplier(),
                    "Transaction" => new AddTransaction(),
                    "Customer" => new AddCustomer(),
                    "Sale" => new AddSale(),
                    "ExternalFactor" => new AddExternalFactor(),
                    "User" => new AddUser()
                };

                if (controlToOpen != null)
                {
                    controlToOpen.Dock = DockStyle.Fill;
                    container.Controls.Add(controlToOpen);
                    ThemeManager.Apply(controlToOpen);
                }

                container.ResumeLayout(true);
            };
        }

        public static System.EventHandler OpenModifyInstanceForm(UserControl container, ComboBox selector_cb)
        {
            return (sender, e) =>
            {
                string selectedOption = selector_cb.SelectedItem as string;
                if (selectedOption == null) return;
                if (selectedOption == "User" && (SessionManager.CurrentUser == null || SessionManager.CurrentUser.Role != "Admin"))
                {
                    MessageBox.Show("Unauthorized access! Only administrators can manage user accounts.",
                                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return; // Oprim execuția aici
                }
                container.SuspendLayout();
                container.Controls.Clear();
                UserControl controlToOpen = selectedOption switch
                {
                    "Product" => new ModifyProduct(),
                    "Category" => new ModifyCategory(),
                    "Supplier" => new ModifySupplier(),
                    "Transaction" => new ModifyTransaction(),
                    "Customer" => new ModifyCustomer(),
                    "Sale" => new ModifySale(),
                    "ExternalFactor" => new ModifyExternalFactor(),
                    "User" => new ModifyUser()
                };

                if (controlToOpen != null)
                {
                    controlToOpen.Dock = DockStyle.Fill;
                    container.Controls.Add(controlToOpen);
                    ThemeManager.Apply(controlToOpen);
                }
                container.ResumeLayout(true);
            };
        }
    }
}
