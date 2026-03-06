using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class AddTransaction : UserControl
    {
        public AddTransaction()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            DataLayer.PopulateTransactionTypeSelector(type_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenAddInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(product_id_tb.Text, out int productId) || type_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a valid numeric Product ID and select a transaction type.",
                                "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(quantity_tb.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid positive quantity.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                using (var db = new SmartStockContext())
                {
                    // Preluăm ID-ul produsului selectat
                    productId = int.Parse(product_id_tb.Text);
                    string transType = type_cb.SelectedItem.ToString();

                    // 3. Găsim produsul în DB pentru a-i actualiza stocul
                    var product = db.Products.FirstOrDefault(p => p.ProductId == productId);

                    if (product == null)
                    {
                        MessageBox.Show("Product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // 4. Verificăm dacă avem suficient stoc pentru ieșiri
                    if (transType == "Stock Out" && product.CurrentStock < qty)
                    {
                        MessageBox.Show($"Insufficient stock! Current stock: {product.CurrentStock}",
                                        "Stock Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int? entityId = null;

                    // TryParse încearcă să convertească textul și returnează true dacă reușește
                    if (int.TryParse(entity_id_tb.Text, out int parsedValue))
                    {
                        entityId = parsedValue;
                    }

                    // 5. Creăm înregistrarea tranzacției
                    Transaction newTrans = new Transaction
                    {
                        ProductId = productId,
                        EntityId = entityId,
                        UserId = SessionManager.CurrentUser.UserId,
                        Quantity = qty,      
                        Type = transType,
                        Date = DateTime.Now
                    };

                    // 6. Actualizăm stocul real al produsului
                    if (transType == "Stock In")
                        product.CurrentStock += qty;
                    else
                        product.CurrentStock -= qty;

                    // 7. Salvăm ambele modificări într-o singură operațiune
                    db.Transactions.Add(newTrans);
                    db.SaveChanges();

                    MessageBox.Show($"Transaction completed! New stock for {product.UnitOfMeasure}: {product.CurrentStock}",
                                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ClearFields()
        {
            product_id_tb.Clear();
            entity_id_tb.Clear();
            quantity_tb.Clear();
            phone_tb.Clear();
            adress_tb.Clear();
            type_cb.SelectedIndex = 0;
        }

        private void type_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Verificăm dacă există o selecție validă
            if (type_cb.SelectedItem == null) return;

            string selectedType = type_cb.SelectedItem.ToString();

            // 2. Schimbăm textul label-ului în funcție de selecție
            // Presupunem că label-ul tău se numește 'entity_lbl'
            if (selectedType == "Stock In")
            {
                entity_lbl.Text = "Supplier ID";
                // Opțional: Poți apela aici funcția de populare pentru furnizori
                // PopulateSupplierSelector(entity_cb);
            }
            else if (selectedType == "Stock Out")
            {
                entity_lbl.Text = "Customer ID";
                // Opțional: Poți apela aici funcția de populare pentru clienți
                // PopulateCustomerSelector(entity_cb);
            }
        }
    }
}
