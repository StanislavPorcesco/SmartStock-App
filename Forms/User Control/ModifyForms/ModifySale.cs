using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using System.ComponentModel;

namespace SmartStock.Forms.User_Control
{
    /// <summary>
    /// Passive View: Doar colectează date din controale și afișează mesaje.
    /// Logica de business este delegată SaleService.
    /// </summary>
    public partial class ModifySale : UserControl
    {
        private SaleService _saleService;
        private int _currentSaleId;
        private BindingList<SaleDetails> saleItemsList = new BindingList<SaleDetails>();

        public ModifySale()
        {
            InitializeComponent();
            InitializeService();
            LoadUI();
        }

        private void InitializeService()
        {
            var repository = new GenericRepository<Sale>(new SmartStockContext());
            var saleDetailsRepo = new GenericRepository<SaleDetails>(new SmartStockContext());
            var productRepo = new GenericRepository<Product>(new SmartStockContext());

            _saleService = new SaleService(repository, saleDetailsRepo, productRepo);
        }

        private void LoadUI()
        {
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenModifyInstanceForm(this, selector_cb);
            DataLayer.PopulatePaymentMethodSelector(payment_method_cb);
            DataLayer.PopulatePaymentStatusSelector(payment_status_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(sale_id_tb.Text, out int saleId))
            {
                MessageBox.Show("Please enter a valid Sale ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SearchAndLoadSale(saleId);
        }

        /// <summary>
        /// Caută și încarcă vânzarea.
        /// </summary>
        private async void SearchAndLoadSale(int saleId)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var sale = await _saleService.GetWithDetailsAsync(saleId);

                if (sale != null)
                {
                    _currentSaleId = sale.SaleId;
                    DisplaySaleData(sale);
                }
                else
                {
                    sale_id_tb.BackColor = Color.DarkRed;
                    sale_id_tb.ForeColor = Color.White;
                    MessageBox.Show("Sale not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearSaleFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearSaleFields();
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// Afișează datele vânzării în controale.
        /// </summary>
        private void DisplaySaleData(Sale sale)
        {
            customer_id_tb.Text = sale.CustomerId.ToString();
            user_id_tb.Text = sale.UserId.ToString();
            date_picker.Value = sale.SaleDate;
            payment_method_cb.SelectedItem = sale.PaymentMethod;
            payment_status_cb.SelectedItem = sale.PaymentStatus;

            saleItemsList = new BindingList<SaleDetails>(sale.SaleDetails.ToList());
            sales_dgv.DataSource = saleItemsList;
            sales_dgv.AllowUserToAddRows = false;
            sales_dgv.ReadOnly = true;

            if (sales_dgv.Columns["Sale"] != null) sales_dgv.Columns["Sale"].Visible = false;
            if (sales_dgv.Columns["Product"] != null) sales_dgv.Columns["Product"].Visible = false;

            if (sale.IsActive)
            {
                sale_id_tb.BackColor = Color.DarkGreen;
                sale_id_tb.ForeColor = Color.White;
            }
            else
            {
                sale_id_tb.BackColor = Color.DarkOrange;
                sale_id_tb.ForeColor = Color.White;
                MessageBox.Show("This sale is currently inactive (Soft Deleted).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(sale_id_tb.Text, out int saleId))
                return;

            if (MessageBox.Show("Deactivate this sale? Historical data will be preserved.",
                "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DeactivateSale(saleId);
            }
        }

        /// <summary>
        /// Deactivează vânzarea.
        /// </summary>
        private async void DeactivateSale(int saleId)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                bool success = await _saleService.DeactivateSaleAsync(saleId);

                if (success)
                {
                    MessageBox.Show("Sale has been deactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearSaleFields();
                }
                else
                {
                    MessageBox.Show("Sale not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearSaleFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during deactivation: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(sale_id_tb.Text, out int saleId))
            {
                MessageBox.Show("Please search for a sale first using a valid ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(payment_status_cb.Text))
            {
                MessageBox.Show("Please select a Payment Status.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UpdateSaleStatus(saleId, payment_status_cb.SelectedItem.ToString());
        }

        /// <summary>
        /// Actualizează status de plată al vânzării.
        /// </summary>
        private async void UpdateSaleStatus(int saleId, string newStatus)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                bool success = await _saleService.UpdatePaymentStatusAsync(saleId, newStatus);

                if (success)
                {
                    MessageBox.Show("Sale status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearSaleFields();
                }
                else
                {
                    MessageBox.Show("Failed to update sale status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Validation error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Validation error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating sale: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ClearSaleFields()
        {
            sale_id_tb.Clear();
            customer_id_tb.Clear();
            user_id_tb.Clear();
            sales_dgv.DataSource = null;
            saleItemsList.Clear();
            ThemeManager.Apply(this);
        }
    }
}
