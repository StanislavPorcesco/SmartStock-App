using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Classes.Data.Interfaces;

namespace SmartStock.Forms.User_Control
{
    /// <summary>
    /// Passive View: Doar colectează date din controale și afișează mesaje.
    /// Logica de business este delegată CustomerService.
    /// </summary>
    public partial class ModifyCustomer : UserControl, ISaveableControl
    {
        private CustomerService _customerService;
        private int _currentCustomerId;
        private Customer _loadedCustomer;

        public ModifyCustomer()
        {
            InitializeComponent();
            InitializeService();
        }

        private void InitializeService()
        {
            var repository = new GenericRepository<Customer>(new SmartStockContext());
            _customerService = new CustomerService(repository);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!FormValidator.RequireId(customer_id_tb.Text, "Customer ID", out int custId)) return;

            SearchAndLoadCustomer(custId);
        }

        private async void SearchAndLoadCustomer(int customerId)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var customer = await _customerService.GetByIdAsync(customerId);

                if (customer != null)
                {
                    _currentCustomerId = customer.CustomerId;
                    _loadedCustomer    = customer;
                    DisplayCustomerData(customer);
                }
                else
                {
                    customer_id_tb.BackColor = Color.DarkRed;
                    customer_id_tb.ForeColor = Color.White;
                    MessageBox.Show("Customer not found.", "Search Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearControls();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void DisplayCustomerData(Customer customer)
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
                MessageBox.Show("This customer is currently inactive (Soft Deleted).", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool TryCollectCustomerData(out Customer customer)
        {
            customer = null;

            if (!FormValidator.RequireText(full_name_tb.Text, "Customer Name")) return false;
            if (!FormValidator.RequireEmail(email_tb.Text)) return false;

            customer = new Customer
            {
                FullName = full_name_tb.Text.Trim(),
                Email    = email_tb.Text.Trim(),
                Phone    = phone_tb.Text.Trim(),
                City     = city_tb.Text.Trim(),
                IsActive = true
            };

            return true;
        }

        // ── ISaveableControl ──────────────────────────────────────────────────

        public async Task<SaveOutcome> PerformSave(bool isAddMode)
        {
            if (!TryCollectCustomerData(out var customer)) return SaveOutcome.Handled;

            // Email must be unique across customers (unlike the name, which may repeat).
            int? excludeId = isAddMode ? (int?)null : _currentCustomerId;
            if (await _customerService.CustomerEmailExistsAsync(customer.Email, excludeId))
            {
                FormValidator.ShowError("A customer with this email address already exists.");
                return SaveOutcome.Handled;
            }

            try
            {
                bool ok;
                if (isAddMode)
                {
                    ok = await _customerService.AddCustomerAsync(customer);
                }
                else
                {
                    // Mutate the tracked entity — avoids EF duplicate-key tracking conflict
                    _loadedCustomer.FullName = customer.FullName;
                    _loadedCustomer.Email    = customer.Email;
                    _loadedCustomer.Phone    = customer.Phone;
                    _loadedCustomer.City     = customer.City;
                    ok = await _customerService.UpdateCustomerAsync(_loadedCustomer);
                }

                return ok ? SaveOutcome.Success : SaveOutcome.Failed;
            }
            catch (Exception ex)
            {
                FormValidator.ShowDbError(ex);
                return SaveOutcome.Handled;
            }
        }

        public async Task<bool> PerformArchive(int customerId)
        {
            bool success = false;
            try
            {
                Cursor = Cursors.WaitCursor;

                success = await _customerService.DeactivateCustomerAsync(customerId);

                if (success)
                {
                    MessageBox.Show("Customer has been deactivated successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Customer not found.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during deactivation: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return success;
        }

        public void UpdateUIState(bool isAddMode)
        {
            var searchButton = this.Controls.Find("search_btn", true).FirstOrDefault();
            var idTextBox    = this.Controls.Find("customer_id_tb", true).FirstOrDefault();
            if (searchButton != null) searchButton.Enabled = !isAddMode;
            if (idTextBox    != null) idTextBox.Enabled    = !isAddMode;
            ClearControls();
        }

        public int GetCurrentId()
        {
            return int.TryParse(customer_id_tb.Text, out int id) ? id : -1;
        }

        public void LoadById(int id)
        {
            customer_id_tb.Text = id.ToString();
            SearchAndLoadCustomer(id);
        }

        public void ClearControls()
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
