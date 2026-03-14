using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class ModifyCustomer : UserControl
    {
        public ModifyCustomer()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenModifyInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(customer_id_tb.Text, out int custId))
            {
                MessageBox.Show("Please enter a valid Customer ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new SmartStockContext())
                {
                    var customer = db.Customers.AsNoTracking().FirstOrDefault(c => c.CustomerId == custId);

                    if (customer != null)
                    {
                        full_name_tb.Text = customer.FullName;
                        email_tb.Text = customer.Email;
                        phone_tb.Text = customer.Phone;
                        city_tb.Text = customer.City;

                        if (customer.IsActive)
                        {
                            customer_id_tb.BackColor = Color.DarkGreen;
                            customer_id_tb.ForeColor = Color.White;
                        }
                        else
                        {
                            customer_id_tb.BackColor = Color.DarkOrange;
                            customer_id_tb.ForeColor = Color.White;
                            MessageBox.Show("This customer is currently inactive (Soft Deleted).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        customer_id_tb.BackColor = Color.DarkRed;
                        MessageBox.Show("Customer not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearCustomerFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(customer_id_tb.Text, out int custId)) return;
            DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate this customer? Historical sales data will be preserved.",
                                                 "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var db = new SmartStockContext())
                    {
                        var customer = db.Customers.FirstOrDefault(c => c.CustomerId == custId);

                        if (customer != null)
                        {
                            customer.IsActive = false;
                            db.SaveChanges();
                            MessageBox.Show("Customer has been deactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearCustomerFields();
                        }
                        else
                        {
                            MessageBox.Show("Customer not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearCustomerFields();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during deactivation: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(customer_id_tb.Text, out int custId) || string.IsNullOrWhiteSpace(full_name_tb.Text))
            {
                MessageBox.Show("Please search for a customer first using a valid ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (var db = new SmartStockContext())
                {
                    var customer = db.Customers.FirstOrDefault(c => c.CustomerId == custId);

                    if (customer != null)
                    {
                        customer.FullName = full_name_tb.Text.Trim();
                        customer.Email = email_tb.Text.Trim();
                        customer.Phone = phone_tb.Text.Trim();
                        customer.City = city_tb.Text.Trim();
                        db.SaveChanges();
                        MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearCustomerFields();
                    }
                    else
                    {
                        MessageBox.Show("Customer not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating customer: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearCustomerFields()
        {
            customer_id_tb.Clear();
            full_name_tb.Clear();
            email_tb.Clear();
            phone_tb.Clear();
            city_tb.Clear();
            ThemeManager.Apply(this);
        }
    }
}
