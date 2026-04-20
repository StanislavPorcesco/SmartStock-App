using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Classes.Data.Interfaces;

namespace SmartStock.Forms.User_Control
{
    /// <summary>
    /// Passive View: Doar colectează date din controale și afișează mesaje.
    /// Logica de business este delegată ProductService.
    /// </summary>
    public partial class ModifyProduct : UserControl, ISaveableControl
    {
        private ProductService _productService;
        private int _currentProductId;

        public ModifyProduct()
        {
            InitializeComponent();
            InitializeService();
            DataLayer.PopulateCategorySelector(product_category_cb);
        }

        private void InitializeService()
        {
            var repository = new GenericRepository<Product>(new SmartStockContext());
            _productService = new ProductService(repository);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(product_id_tb.Text, out int productId))
            {
                MessageBox.Show("Please enter a valid Product ID.", "Search Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SearchAndLoadProduct(productId);
        }

        /// <summary>
        /// Caută și încarcă datele produsului.
        /// </summary>
        private async void SearchAndLoadProduct(int productId)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var product = await _productService.GetProductWithDetailsAsync(productId);

                if (product != null)
                {
                    _currentProductId = product.ProductId;
                    DisplayProductData(product);
                }
                else
                {
                    product_id_tb.BackColor = Color.DarkRed;
                    product_id_tb.ForeColor = Color.White;
                    MessageBox.Show("Product not found.", "Search Error", 
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

        /// <summary>
        /// Afișează datele produsului în controale.
        /// </summary>
        private void DisplayProductData(Product product)
        {
            product_name_tb.Text = product.ProductName;
            unit_price_tb.Text = product.UnitPrice.ToString();
            current_stock_tb.Text = product.CurrentStock.ToString();
            safety_stock_tb.Text = product.SafetyStock.ToString();
            unit_measure_tb.Text = product.UnitOfMeasure;
            supplier_id_tb.Text = product.SupplierId.ToString();
            product_category_cb.SelectedValue = product.CategoryId;

            if (product.IsActive)
            {
                product_id_tb.BackColor = Color.DarkGreen;
                product_id_tb.ForeColor = Color.White;
            }
            else
            {
                product_id_tb.BackColor = Color.DarkOrange;
                product_id_tb.ForeColor = Color.White;
                MessageBox.Show("This product is currently inactive (Soft Deleted).", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Colectează datele din controale și creează un obiect Product.
        /// </summary>
        private bool TryCollectProductData(out Product product)
        {
            product = null;

            // Validare numerică
            if (!decimal.TryParse(unit_price_tb.Text, out decimal price) ||
                !int.TryParse(current_stock_tb.Text, out int stock) ||
                !int.TryParse(safety_stock_tb.Text, out int safetyStock) ||
                !int.TryParse(supplier_id_tb.Text, out int supplierId))
            {
                MessageBox.Show("Please enter valid numbers.", "Numeric Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            product = new Product
            {
                ProductName = product_name_tb.Text.Trim(),
                UnitPrice = price,
                CurrentStock = stock,
                SafetyStock = safetyStock,
                UnitOfMeasure = unit_measure_tb.Text.Trim(),
                SupplierId = supplierId,
                CategoryId = (int)product_category_cb.SelectedValue,
                IsActive = true
            };

            return true;
        }
        public async Task<bool> PerformSave(bool isAddMode)
        {
            if (string.IsNullOrWhiteSpace(product_name_tb.Text)) return false;
            try
            {
                if (isAddMode)
                {
                    TryCollectProductData(out var newProduct);
                    return await _productService.AddProductAsync(newProduct);
                }
                else
                {
                    TryCollectProductData(out var updatedProduct);
                    return await _productService.UpdateProductAsync(updatedProduct);
                }
            }
            catch { return false; }
        }
        void ISaveableControl.UpdateUIState(bool isAddMode)
        {
            var searchButton = this.Controls.Find("search_btn", true).FirstOrDefault();
            var idTextBox = this.Controls.Find("product_id_tb", true).FirstOrDefault();
            if (searchButton != null) searchButton.Enabled = !isAddMode;
            if (idTextBox != null) idTextBox.Enabled = !isAddMode;
            ClearControls();
        }
        async Task<bool> ISaveableControl.PerformArchive(int productId)
        {
            bool success = false;
            try
            {
                Cursor = Cursors.WaitCursor;

                success = await _productService.DeactivateProductAsync(productId);

                if (success)
                {
                    MessageBox.Show("Product has been deactivated successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                    return success;
                }
                else
                {
                    MessageBox.Show("Product not found.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                    return success;
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
        public void ClearControls()
        {
            product_id_tb.Clear();
            product_name_tb.Clear();
            product_category_cb.SelectedValue = "";
            supplier_id_tb.Clear();
            unit_price_tb.Clear();
            current_stock_tb.Clear();
            safety_stock_tb.Clear();
            unit_measure_tb.Clear();
            ThemeManager.Apply(this);
        }

        int ISaveableControl.GetCurrentId()
        {
            if (int.TryParse(product_id_tb.Text, out int id))
            {
                return id;
            }
            return -1;
        }

        public void LoadById(int id)
        {
            product_id_tb.Text = id.ToString();
            SearchAndLoadProduct(id);
        }
    }
}
