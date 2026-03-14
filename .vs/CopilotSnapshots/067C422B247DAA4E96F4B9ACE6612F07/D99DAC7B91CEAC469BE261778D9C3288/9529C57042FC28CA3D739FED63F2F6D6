using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class AddSupplier : UserControl
    {
        public AddSupplier()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenAddInstanceForm(this, selector_cb);

            ThemeManager.Apply(this);
            this.Refresh();
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            string sName = supplier_name_tb.Text.Trim();
            string sEmail = email_tb.Text.Trim();

            if (string.IsNullOrWhiteSpace(sName))
            {
                MessageBox.Show("Please enter the Supplier Name.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(sEmail) && (!sEmail.Contains("@") || !sEmail.Contains(".")))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                using (var db = new SmartStockContext())
                {
                    bool exists = db.Suppliers.Any(s => s.SupplierName.ToLower() == sName.ToLower());

                    if (exists)
                    {
                        MessageBox.Show("A supplier with this name already exists.", "Duplicate Entry",
                                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    // 4. Creăm obiectul Supplier
                    Supplier newSupplier = new Supplier
                    {
                        SupplierName = sName,
                        ContactPerson = contact_person_tb.Text.Trim(),
                        Email = sEmail,
                        Phone = phone_tb.Text.Trim(),
                        Address = adress_tb.Text.Trim(),
                        IsActive = true
                    };

                    // 5. Salvare în baza de date
                    db.Suppliers.Add(newSupplier);
                    db.SaveChanges();

                    MessageBox.Show($"Supplier '{sName}' has been added successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving supplier: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ClearFields()
        {
            supplier_name_tb.Clear();
            contact_person_tb.Clear();
            email_tb.Clear();
            phone_tb.Clear();
            adress_tb.Clear();
        }
    }
}
