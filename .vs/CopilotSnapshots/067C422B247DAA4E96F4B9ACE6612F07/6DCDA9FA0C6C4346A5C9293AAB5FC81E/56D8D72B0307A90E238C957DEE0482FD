using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class AddSale : UserControl
    {
        public AddSale()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenAddInstanceForm(this, selector_cb);
            DataLayer.PopulatePaymentMethodSelector(payment_method_cb);
            DataLayer.PopulatePaymentStatusSelector(payment_status_cb);
            ThemeManager.Apply(this);
            this.Refresh();
            sales_dgv.EnableHeadersVisualStyles = false;
        }
        private List<SaleDetails> cart = new List<SaleDetails>();
        private void add_btn_Click(object sender, EventArgs e)
        {
            // 1. Validări de bază pentru input
            if (!int.TryParse(customer_id_tb.Text, out int customerId))
            {
                MessageBox.Show("Please enter a valid numeric Customer ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(total_amount_tb.Text, out decimal totalAmount))
            {
                MessageBox.Show("Invalid total amount format.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (payment_method_cb.SelectedIndex == -1 || payment_status_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both Payment Method and Payment Status.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Presupunem că ai o listă 'cart' populată cu SaleDetails dintr-un DataGridView
            if (cart == null || cart.Count == 0)
            {
                MessageBox.Show("The sale must contain at least one product.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;

                // 2. Pregătirea obiectului Sale
                Sale newSale = new Sale
                {
                    CustomerId = customerId,
                    UserId = SessionManager.CurrentUser.UserId,
                    TotalAmount = totalAmount,
                    SaleDate = date_picker.Value,
                    PaymentMethod = payment_method_cb.SelectedItem.ToString(),
                    PaymentStatus = payment_status_cb.SelectedItem.ToString()
                };

                // 3. Procesarea vânzării prin metoda clasei Sale
                // Această metodă scade deja stocul automat
                newSale.ProcessSale(newSale, cart);

                // 4. Generarea tranzacțiilor de tip "Out" pentru fiecare produs din vânzare
                using (var db = new SmartStockContext())
                {
                    foreach (var item in cart)
                    {
                        Transaction saleTransaction = new Transaction
                        {
                            ProductId = item.ProductId,
                            EntityId = customerId, // Legăm de Customer ID
                            UserId = SessionManager.CurrentUser.UserId,
                            Quantity = item.Quantity,
                            Type = "Stock Out", // Tipul de ieșire
                            Date = DateTime.Now
                        };

                        // Folosim metoda RegisterTransaction pentru a păstra istoricul
                        // Notă: Metoda RegisterTransaction din clasa ta scade stocul din nou. 
                        // Deoarece ProcessSale a scăzut deja stocul, aici doar adăugăm tranzacția manual în DB
                        db.Transactions.Add(saleTransaction);
                    }
                    db.SaveChanges();
                }

                MessageBox.Show("Sale and Stock Transactions registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Resetare formular
                customer_id_tb.Clear();
                total_amount_tb.Text = "0.00";
                sales_dgv.DataSource = null;
                cart.Clear();
                ClearSaleForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during processing: {ex.Message}", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ClearSaleForm()
        {
            customer_id_tb.Clear();
            total_amount_tb.Clear();
            cart.Clear();
            // Refresh DataGridView here if applicable
        }

        private void add_to_cart_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(product_id_tb.Text, out int pid) || !int.TryParse(qty_tb.Text, out int qty))
            {
                MessageBox.Show("Please enter valid Product ID and Quantity.");
                return;
            }

            using (var db = new SmartStockContext())
            {
                var product = db.Products.AsNoTracking().FirstOrDefault(p => p.ProductId == pid);

                if (product == null)
                {
                    MessageBox.Show("Product not found!");
                    return;
                }

                if (product.CurrentStock < qty)
                {
                    MessageBox.Show($"Insufficient stock! Available: {product.CurrentStock}");
                    return;
                }

                // Creăm obiectul de detaliu
                SaleDetails detail = new SaleDetails
                {
                    ProductId = pid,
                    Quantity = qty,
                    UnitPrice = product.UnitPrice // Fixăm prețul de vânzare actual
                };

                cart.Add(detail);
                RefreshCartGrid();

                // Calculăm automat totalul în total_amount_tb
                total_amount_tb.Text = cart.Sum(item => item.Quantity * item.UnitPrice).ToString("F2");
            }
        }
        private void RefreshCartGrid()
        {
            sales_dgv.DataSource = null;

            if (cart != null && cart.Count > 0)
            {
                using (var db = new SmartStockContext())
                {
                    // Extragem toate ID-urile din coș pentru o singură interogare rapidă
                    var productIds = cart.Select(c => c.ProductId).ToList();

                    // Interogarea SQL (în spate) care aduce denumirile produselor
                    var productsInfo = db.Products
                        .AsNoTracking()
                        .Where(p => productIds.Contains(p.ProductId))
                        .ToDictionary(p => p.ProductId, p => p.ProductName);

                    // Proiecția finală pentru Grid
                    var displayData = cart.Select(item => new
                    {
                        ProductID = item.ProductId,
                        // Luăm denumirea din dicționarul extras din SQL
                        DenumireProdus = productsInfo.ContainsKey(item.ProductId)
                                         ? productsInfo[item.ProductId]
                                         : "Unknown Product",
                        Cantitate = item.Quantity,
                        UnitPrice = item.UnitPrice,
                        LineTotal = item.Quantity * item.UnitPrice
                    }).ToList();

                    sales_dgv.DataSource = displayData;

                    // Formatare coloane
                    FormatGridColumns();
                }
            }
        }

        private void FormatGridColumns()
        {
            sales_dgv.Columns["ProductID"].HeaderText = "ID";
            sales_dgv.Columns["DenumireProdus"].HeaderText = "Product Name";
            sales_dgv.Columns["Cantitate"].HeaderText = "Qty";
            sales_dgv.Columns["UnitPrice"].HeaderText = "Price";
            sales_dgv.Columns["LineTotal"].HeaderText = "Total";

            sales_dgv.Columns["UnitPrice"].DefaultCellStyle.Format = "N2";
            sales_dgv.Columns["LineTotal"].DefaultCellStyle.Format = "N2";
        }
    }
}
