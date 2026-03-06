using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class AddCustomer : UserControl
    {
        public AddCustomer()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            // Wire up the ComboBox event handler here (not in Designer)
            selector_cb.SelectedIndexChanged += DataLayer.OpenAddInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            // 1. Validare: Numele clientului este obligatoriu
            string cName = full_name_tb.Text.Trim();
            string cEmail = email_tb.Text.Trim();

            if (string.IsNullOrWhiteSpace(cName))
            {
                MessageBox.Show("Please enter the Customer Name.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validare format Email (dacă a fost completat)
            if (!string.IsNullOrWhiteSpace(cEmail) && (!cEmail.Contains("@") || !cEmail.Contains(".")))
            {
                MessageBox.Show("The email format is invalid.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                using (var db = new SmartStockContext())
                {
                    // 3. Verificăm dacă există deja un client cu același nume
                    // Folosim AsNoTracking pentru o verificare rapidă
                    bool exists = db.Customers.Any(c => c.FullName.ToLower() == cName.ToLower());

                    if (exists)
                    {
                        MessageBox.Show("This customer is already registered.", "Duplicate Entry",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // 4. Creăm obiectul Customer bazat pe modelul tău
                    Customer newCustomer = new Customer
                    {
                        FullName = cName,
                        Email = cEmail,
                        Phone = phone_tb.Text.Trim(),
                        City = city_tb.Text.Trim(),
                        RegistrationDate = DateTime.Now,
                        IsActive = true
                    };

                    // 5. Adăugăm și salvăm în baza de date
                    db.Customers.Add(newCustomer);
                    db.SaveChanges();

                    MessageBox.Show($"Customer '{cName}' has been added successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ClearFields()
        {
            full_name_tb.Clear();
            email_tb.Clear();
            phone_tb.Clear();
            city_tb.Clear();
        }
    }
}
