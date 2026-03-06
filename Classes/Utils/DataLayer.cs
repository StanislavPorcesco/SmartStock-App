using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
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

        public static void PopulatePaymentMethodSelector(ComboBox selector)
        {
            if (selector != null)
            {
                selector.Items.Clear();
                selector.Items.AddRange(new string[] { "Cash", "Card", "Transfer" });
                selector.Text = "Select a payment method";
            }
        }

        public static void PopulatePaymentStatusSelector(ComboBox selector)
        {
            if (selector != null)
            {
                selector.Items.Clear();
                selector.Items.AddRange(new string[] { "Paid", "Pending", "Overdue" });
                selector.Text = "Select a payment status";
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
        public static void PopulateCategorySelector(ComboBox selector)
        {
            using (var db = new SmartStockContext())
            {
                // 1. Luăm toată lista de obiecte Category, nu doar numele
                var categories = db.Categories
                                   .AsNoTracking()
                                   .OrderBy(c => c.CategoryName)
                                   .ToList();

                // 2. Curățăm sursa de date anterioară
                selector.DataSource = null;
                selector.Items.Clear();

                if (categories.Count > 0)
                {
                    // 3. Setăm lista de obiecte ca sursă de date
                    selector.DataSource = categories;

                    // 4. Îi spunem ce să afișeze (Numele) și ce să țină în spate (ID-ul)
                    selector.DisplayMember = "CategoryName";
                    selector.ValueMember = "CategoryId";

                    selector.SelectedIndex = 0;
                }
            }
        }
        public static void PopulateSupplierSelector(ComboBox selector)
        {
            using (var db = new SmartStockContext())
            {
                // 1. Preluăm lista completă de obiecte Supplier
                var suppliers = db.Suppliers
                                  .AsNoTracking()
                                  .OrderBy(s => s.SupplierName)
                                  .ToList();

                // 2. Resetăm sursa de date pentru a evita conflicte
                selector.DataSource = null;
                selector.Items.Clear();

                if (suppliers.Count > 0)
                {
                    // 3. Legăm lista de obiecte la ComboBox
                    selector.DataSource = suppliers;

                    // 4. Definim ce vede utilizatorul și ce procesează codul
                    selector.DisplayMember = "SupplierName"; // Numele afișat în listă
                    selector.ValueMember = "SupplierId";     // ID-ul ascuns în spate

                    selector.SelectedIndex = 0;
                }
            }
        }

        public static void PopulateTransactionTypeSelector(ComboBox selector)
        {
            // 1. Definim opțiunile fixe pentru tipul tranzacției
            // "Stock In" pentru intrări de marfă, "Stock Out" pentru ieșiri/ajustări
            string[] transactionTypes = { "Stock In", "Stock Out", "Adjustment" };

            // 2. Curățăm selectorul pentru a evita duplicatele la reîncărcare
            selector.DataSource = null;
            selector.Items.Clear();

            // 3. Adăugăm opțiunile
            selector.Items.AddRange(transactionTypes);

            // 4. Setăm o valoare implicită și blocăm editarea manuală (recomandat)
            if (selector.Items.Count > 0)
            {
                selector.SelectedIndex = 0;
            }

            // Forțăm utilizatorul să aleagă doar din listă, nu să scrie text liber
            selector.DropDownStyle = ComboBoxStyle.DropDownList;
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
