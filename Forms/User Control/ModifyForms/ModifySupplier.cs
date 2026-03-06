using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class ModifySupplier : UserControl
    {
        public ModifySupplier()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenModifyInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(supplier_id_tb.Text, out int suppId) || string.IsNullOrWhiteSpace(supplier_name_tb.Text))
            {
                MessageBox.Show("Please select a valid Supplier ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new SmartStockContext())
                {
                    var supplier = db.Suppliers.FirstOrDefault(s => s.SupplierId == suppId);

                    if (supplier != null)
                    {
                        supplier.SupplierName = supplier_name_tb.Text.Trim();
                        supplier.ContactPerson = contact_person_tb.Text.Trim();
                        supplier.Email = email_tb.Text.Trim();
                        supplier.Phone = phone_tb.Text.Trim();
                        supplier.Address = address_tb.Text.Trim();

                        db.SaveChanges();

                        MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearSupplierFields();
                    }
                    else
                    {
                        MessageBox.Show("Supplier not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating supplier: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(supplier_id_tb.Text, out int suppId)) return;

            DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate this supplier? Historical sales data will be preserved.",
                                                 "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var db = new SmartStockContext())
                    {
                        var supplier = db.Suppliers.FirstOrDefault(s => s.SupplierId == suppId);
                        if (supplier != null)
                        {
                            supplier.IsActive = false;
                            db.SaveChanges();
                            MessageBox.Show("Supplier deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearSupplierFields();   
                        } else
                        {
                            MessageBox.Show("Supplier not found", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearSupplierFields();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during deactivation: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(supplier_id_tb.Text, out int suppId))
            {
                MessageBox.Show("Please enter a valid Supplier ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new SmartStockContext())
                {
                    var supplier = db.Suppliers.AsNoTracking().FirstOrDefault(s => s.SupplierId == suppId);

                    if (supplier != null)
                    {
                        supplier_name_tb.Text = supplier.SupplierName;
                        contact_person_tb.Text = supplier.ContactPerson;
                        email_tb.Text = supplier.Email;
                        phone_tb.Text = supplier.Phone;
                        address_tb.Text = supplier.Address;

                        if (supplier.IsActive)
                        {
                            supplier_id_tb.BackColor = Color.DarkGreen;
                            supplier_id_tb.ForeColor = Color.White;
                        }
                        else
                        {
                            supplier_id_tb.BackColor = Color.DarkOrange;
                            supplier_id_tb.ForeColor = Color.White;
                            MessageBox.Show("This supplier is currently inactive (Soft Deleted).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        supplier_id_tb.BackColor = Color.DarkRed;
                        supplier_id_tb.ForeColor = Color.White;
                        MessageBox.Show("Supplier ID not found!", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearSupplierFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearSupplierFields()
        {
            supplier_id_tb.Clear();
            supplier_name_tb.Clear();
            contact_person_tb.Clear();
            email_tb.Clear();
            phone_tb.Clear();
            address_tb.Clear();
            ThemeManager.Apply(this);
        }
    }
}
