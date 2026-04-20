using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Classes.Data.Interfaces;
using System.ComponentModel;

namespace SmartStock.Forms.User_Control
{
    /// <summary>
    /// Passive View: Doar colectează date din controale și afișează mesaje.
    /// Logica de business este delegată SaleService.
    /// Add mode: creates a new sale with line items entered in the grid.
    /// Modify mode: updates the payment status of an existing sale.
    /// </summary>
    public partial class ModifySale : UserControl, ISaveableControl
    {
        private SaleService _saleService;
        private ProductService _productService;
        private int _currentSaleId;
        private BindingList<SaleDetails> _saleItemsList = new BindingList<SaleDetails>();

        public DataGridView CartGrid { get; set; }

        public ModifySale()
        {
            InitializeComponent();
            InitializeService();
            DataLayer.PopulatePaymentMethodSelector(payment_method_cb);
            DataLayer.PopulatePaymentStatusSelector(payment_status_cb);
        }

        private void InitializeService()
        {
            var repository = new GenericRepository<Sale>(new SmartStockContext());
            var saleDetailsRepo = new GenericRepository<SaleDetails>(new SmartStockContext());
            var productRepo = new GenericRepository<Product>(new SmartStockContext());
            _saleService = new SaleService(repository, saleDetailsRepo, productRepo);
            _productService = new ProductService(new GenericRepository<Product>(new SmartStockContext()));
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(sale_id_tb.Text, out int saleId))
            {
                MessageBox.Show("Please enter a valid Sale ID.", "Search Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SearchAndLoadSale(saleId);
        }

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
                    MessageBox.Show("Sale not found.", "Search Error",
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

        private void DisplaySaleData(Sale sale)
        {
            customer_id_tb.Text = sale.CustomerId.ToString();
            user_id_tb.Text = sale.UserId.ToString();
            date_picker.Value = sale.SaleDate;
            payment_method_cb.SelectedItem = sale.PaymentMethod;
            payment_status_cb.SelectedItem = sale.PaymentStatus;

            // Populate ProductName for display
            foreach (var d in sale.SaleDetails)
                d.ProductName = d.Product?.ProductName ?? $"Product #{d.ProductId}";

            _saleItemsList = new BindingList<SaleDetails>(sale.SaleDetails.ToList());
            BindCartGrid();

            sale_id_tb.BackColor = sale.IsActive ? Color.DarkGreen : Color.DarkOrange;
            sale_id_tb.ForeColor = Color.White;

            UpdateCartTotal();

            if (!sale.IsActive)
                MessageBox.Show("This sale is currently inactive (Soft Deleted).", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ── Cart ─────────────────────────────────────────────────────────────

        private async void add_to_cart_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(product_id_tb.Text.Trim(), out int productId) || productId <= 0)
            {
                MessageBox.Show("Please enter a valid Product ID.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(qty_tb.Text.Trim(), out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity (> 0).", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                var product = await _productService.GetProductWithDetailsAsync(productId);

                if (product == null)
                {
                    MessageBox.Show($"Product ID {productId} not found.", "Not Found",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!product.IsActive)
                {
                    MessageBox.Show($"'{product.ProductName}' is inactive and cannot be sold.", "Inactive Product",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Merge with existing cart line for the same product
                var existing = _saleItemsList.FirstOrDefault(d => d.ProductId == productId);
                int totalQty = (existing?.Quantity ?? 0) + qty;

                if (product.CurrentStock < totalQty)
                {
                    MessageBox.Show(
                        $"Insufficient stock for '{product.ProductName}'.\n" +
                        $"Available: {product.CurrentStock}, Requested: {totalQty}",
                        "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (existing != null)
                    existing.Quantity = totalQty;
                else
                    _saleItemsList.Add(new SaleDetails
                    {
                        ProductId   = product.ProductId,
                        ProductName = product.ProductName,
                        Quantity    = qty,
                        UnitPrice   = product.UnitPrice
                    });

                // Always rebind: DataSource may be null after ClearControls,
                // and BindingList doesn't raise ListChanged for property mutations.
                BindCartGrid();
                product_id_tb.Clear();
                qty_tb.Clear();
                UpdateCartTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error looking up product: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void remove_from_cart_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(product_id_tb.Text.Trim(), out int productId) || productId <= 0)
            {
                MessageBox.Show("Please enter a valid Product ID to remove.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var toRemove = _saleItemsList.Where(d => d.ProductId == productId).ToList();

            if (toRemove.Count == 0)
            {
                MessageBox.Show($"Product ID {productId} is not in the cart.", "Not Found",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var item in toRemove)
                _saleItemsList.Remove(item);

            BindCartGrid();
            product_id_tb.Clear();
            qty_tb.Clear();
            UpdateCartTotal();
        }

        private void BindCartGrid()
        {
            if (CartGrid == null) return;

            CartGrid.DataSource = null;
            CartGrid.DataSource = _saleItemsList;
            CartGrid.AllowUserToAddRows = false;
            CartGrid.ReadOnly = true;

            foreach (var col in new[] { "DetailId", "SaleId", "Sale", "Product" })
                if (CartGrid.Columns[col] != null)
                    CartGrid.Columns[col].Visible = false;

            if (CartGrid.Columns["ProductId"]   != null) { CartGrid.Columns["ProductId"].DisplayIndex   = 0; CartGrid.Columns["ProductId"].HeaderText   = "Product ID"; }
            if (CartGrid.Columns["ProductName"] != null) { CartGrid.Columns["ProductName"].DisplayIndex = 1; CartGrid.Columns["ProductName"].HeaderText = "Product Name"; }
            if (CartGrid.Columns["Quantity"]    != null) { CartGrid.Columns["Quantity"].DisplayIndex    = 2; CartGrid.Columns["Quantity"].HeaderText    = "Qty"; }
            if (CartGrid.Columns["UnitPrice"]   != null) { CartGrid.Columns["UnitPrice"].DisplayIndex   = 3; CartGrid.Columns["UnitPrice"].HeaderText   = "Unit Price"; }
            if (CartGrid.Columns["LineTotal"]   != null) { CartGrid.Columns["LineTotal"].DisplayIndex   = 4; CartGrid.Columns["LineTotal"].HeaderText   = "Line Total"; }
        }

        private void UpdateCartTotal()
        {
            decimal total = _saleItemsList.Sum(d => d.LineTotal);
            total_amount_tb.Text = total.ToString("F2");
        }

        // ── ISaveableControl ──────────────────────────────────────────────────

        public async Task<bool> PerformSave(bool isAddMode)
        {
            try
            {
                if (isAddMode)
                {
                    if (!int.TryParse(customer_id_tb.Text, out int custId) || custId <= 0)
                    {
                        MessageBox.Show("Please enter a valid Customer ID.", "Input Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    if (payment_method_cb.SelectedIndex == -1 || payment_status_cb.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select Payment Method and Status.", "Input Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    if (_saleItemsList.Count == 0)
                    {
                        MessageBox.Show("Please add at least one item to the sale.", "Input Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    var sale = new Sale
                    {
                        CustomerId    = custId,
                        SaleDate      = date_picker.Value,
                        PaymentMethod = payment_method_cb.SelectedItem.ToString(),
                        PaymentStatus = payment_status_cb.SelectedItem.ToString(),
                        TotalAmount   = (decimal)_saleItemsList.Sum(d => d.LineTotal),
                        IsActive      = true
                    };

                    int userId = SessionManager.CurrentUser?.UserId ?? 0;
                    return await _saleService.AddSaleWithDetailsAsync(sale, _saleItemsList.ToList(), userId);
                }
                else
                {
                    if (payment_status_cb.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a Payment Status.", "Input Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                    return await _saleService.UpdatePaymentStatusAsync(
                        _currentSaleId,
                        payment_status_cb.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> PerformArchive(int saleId)
        {
            bool success = false;
            try
            {
                Cursor = Cursors.WaitCursor;

                success = await _saleService.DeactivateSaleAsync(saleId);

                if (success)
                {
                    MessageBox.Show("Sale has been deactivated successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Sale not found.", "Error",
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
            var searchButton  = this.Controls.Find("search_btn",           true).FirstOrDefault();
            var idTextBox     = this.Controls.Find("sale_id_tb",           true).FirstOrDefault();
            var addBtn        = this.Controls.Find("add_to_cart_btn",      true).FirstOrDefault();
            var removeBtn     = this.Controls.Find("remove_from_cart_btn", true).FirstOrDefault();
            var productIdTb   = this.Controls.Find("product_id_tb",        true).FirstOrDefault();
            var qtyTb         = this.Controls.Find("qty_tb",               true).FirstOrDefault();

            if (searchButton != null) searchButton.Enabled = !isAddMode;
            if (idTextBox    != null) idTextBox.Enabled    = !isAddMode;

            // user_id_tb is always read-only — filled from session on save
            user_id_tb.Enabled = false;

            if (addBtn      != null) addBtn.Enabled      = isAddMode;
            if (removeBtn   != null) removeBtn.Enabled   = isAddMode;
            if (productIdTb != null) productIdTb.Enabled = isAddMode;
            if (qtyTb       != null) qtyTb.Enabled       = isAddMode;

            ClearControls();
        }

        public int GetCurrentId()
        {
            return int.TryParse(sale_id_tb.Text, out int id) ? id : -1;
        }

        public void LoadById(int id)
        {
            sale_id_tb.Text = id.ToString();
            SearchAndLoadSale(id);
        }

        public void ClearControls()
        {
            sale_id_tb.Clear();
            customer_id_tb.Clear();
            user_id_tb.Clear();
            product_id_tb.Clear();
            qty_tb.Clear();
            total_amount_tb.Clear();
            _saleItemsList.Clear();
            if (CartGrid != null) CartGrid.DataSource = null;
            ThemeManager.Apply(this);
        }
    }
}
