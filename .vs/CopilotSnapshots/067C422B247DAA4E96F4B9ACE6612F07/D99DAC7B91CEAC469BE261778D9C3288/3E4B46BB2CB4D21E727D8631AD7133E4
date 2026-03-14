using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class AddProduct : UserControl
    {
        public AddProduct()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            DataLayer.PopulateCategorySelector(category_selector_cb);
            DataLayer.PopulateSupplierSelector(supplier_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenAddInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            // 1. Validare: Câmpurile obligatorii nu pot fi goale
            if (string.IsNullOrWhiteSpace(product_name_tb.Text) ||
                category_selector_cb.SelectedIndex == -1 ||
                supplier_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields (Name, Category, Supplier).",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validare numerică pentru preț și stoc
            if (!decimal.TryParse(unit_price_tb.Text, out decimal unitPrice) ||
                !int.TryParse(current_stock_tb.Text, out int currentStock) ||
                !int.TryParse(safety_stock_tb.Text, out int safetyStock))
            {
                MessageBox.Show("Please enter valid numbers for Price and Stock levels.",
                                "Numeric Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                using (var db = new SmartStockContext())
                {
                    // 3. Preluăm ID-urile din obiectele selectate în ComboBox
                    // Presupunem că ai populat ComboBox-urile cu obiecte de tip Category/Supplier
                    int selectedSupplierId = (int)supplier_cb.SelectedValue;
                    int selectedCategoryId = (int)category_selector_cb.SelectedValue;

                    // 4. Creăm instanța noului produs
                    Product newProduct = new Product
                    {
                        ProductName = product_name_tb.Text.Trim(), // Adaugă proprietatea Name dacă o ai în model
                        CategoryId = selectedCategoryId,
                        SupplierId = selectedSupplierId,
                        UnitPrice = unitPrice,
                        CurrentStock = currentStock,
                        SafetyStock = safetyStock,
                        UnitOfMeasure = unit_measure_tb.Text.Trim() ?? "pcs",
                        IsActive = true
                    };

                    db.Products.Add(newProduct);
                    db.SaveChanges();

                    MessageBox.Show("Product added successfully to inventory!", "Success",
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
            product_name_tb.Clear();
            unit_price_tb.Clear();
            current_stock_tb.Clear();
            safety_stock_tb.Clear();
            unit_measure_tb.Clear();
            category_selector_cb.SelectedIndex = -1;
            supplier_cb.SelectedIndex = -1;
        }
    }
}
