using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using System.ComponentModel;

namespace SmartStock.Forms.User_Control
{
    public partial class ModifySale : UserControl
    {

        public ModifySale()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenModifyInstanceForm(this, selector_cb);
            DataLayer.PopulatePaymentMethodSelector(payment_method_cb);
            DataLayer.PopulatePaymentStatusSelector(payment_status_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }
        BindingList<SaleDetails> saleItemsList = new BindingList<SaleDetails>();

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(sale_id_tb.Text, out int sId)) {
                MessageBox.Show("Please enter a valid Sale ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new SmartStockContext())
            {
                var sale = db.Sales.AsNoTracking().FirstOrDefault(s => s.SaleId == sId);
                if (sale != null)
                {
                    customer_id_tb.Text = sale.CustomerId.ToString();
                    user_id_tb.Text = sale.UserId.ToString();
                    date_picker.Value = sale.SaleDate;

                    var details = new SaleDetails().GetItemsBySaleId(sId);
                    saleItemsList = new BindingList<SaleDetails>(details);

                    sales_dgv.DataSource = saleItemsList;
                    sales_dgv.AllowUserToAddRows = true;
                    sales_dgv.ReadOnly = false;

                    if (sales_dgv.Columns["Sale"] != null) sales_dgv.Columns["Sale"].Visible = false;
                    if (sales_dgv.Columns["Product"] != null) sales_dgv.Columns["Product"].Visible = false;

                    if (sales_dgv.Columns["DetailId"] != null) sales_dgv.Columns["DetailId"].ReadOnly = true;
                    if (sales_dgv.Columns["SaleId"] != null) sales_dgv.Columns["SaleId"].ReadOnly = true; // Blocat
                    if (sales_dgv.Columns["LineTotal"] != null) sales_dgv.Columns["LineTotal"].ReadOnly = true;

                    SetupProductNameColumn();

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
                else
                {
                    sale_id_tb.BackColor = Color.DarkRed;
                    MessageBox.Show("Sale not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(sale_id_tb.Text, out int saleId)) return;

            if (MessageBox.Show("Deactivate this sale? This will preserve historical data for AI analysis.",
                "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (var db = new SmartStockContext())
                    {
                        var sale = db.Sales.Find(saleId);
                        if (sale != null)
                        {
                            sale.IsActive = false;
                            db.SaveChanges();
                            MessageBox.Show("Sale has been deactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearSaleFields();
                        }
                        else
                        {
                            MessageBox.Show("Sale not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearSaleFields();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Error during deactivation: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(sale_id_tb.Text, out int saleId)) {
                MessageBox.Show("Please search for a sale first using a valid ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            sales_dgv.EndEdit();
            using (var db = new SmartStockContext())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (var item in saleItemsList)
                        {
                            if (item.ProductId <= 0 || item.Quantity <= 0)
                            {
                                MessageBox.Show("Invalid Product ID or Quantity in grid.", "Validation Error");
                                return;
                            }
                            var prod = db.Products.Find(item.ProductId);
                            if (prod == null)
                            {
                                MessageBox.Show($"Product {item.ProductId} does not exist!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        var oldDetails = db.SaleDetails.Where(d => d.SaleId == saleId).ToList();
                        foreach (var oldItem in oldDetails)
                        {
                            var product = db.Products.Find(oldItem.ProductId);
                            if (product != null) product.CurrentStock += oldItem.Quantity;
                        }
                        db.SaveChanges();
                        db.SaleDetails.RemoveRange(oldDetails);
                        db.SaveChanges();

                        foreach (var newItem in saleItemsList)
                        {
                            var product = db.Products.Find(newItem.ProductId);
                            if (product.CurrentStock < newItem.Quantity)
                            {
                                throw new Exception($"Insufficient stock for {product.ProductName}. " +
                                                    $"Available: {product.CurrentStock}, Requested: {newItem.Quantity}");
                            }
                            product.CurrentStock -= newItem.Quantity;
                            db.SaleDetails.Add(new SaleDetails
                            {
                                SaleId = saleId,
                                ProductId = newItem.ProductId,
                                Quantity = newItem.Quantity,
                                UnitPrice = newItem.UnitPrice
                            });
                        }
                        var header = db.Sales.Find(saleId);
                        if (header != null)
                        {
                            header.TotalAmount = saleItemsList.Sum(x => x.Quantity * x.UnitPrice);
                            header.SaleDate = date_picker.Value;
                        }

                        db.SaveChanges();
                        transaction.Commit();
                        MessageBox.Show("Sale updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Update Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearSaleFields()
        {
            customer_id_tb.Clear();
            user_id_tb.Clear();
            date_picker.Value = DateTime.Now;
            payment_method_cb.SelectedIndex = -1;
            payment_status_cb.SelectedIndex = -1;
            total_amount_tb.Clear();
            sales_dgv.DataSource = null;
        }

        private void sales_dgv_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columnName = sales_dgv.Columns[e.ColumnIndex].Name;

            if (columnName == "Quantity")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int newQty) || newQty <= 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("Quantity must be a positive whole number.", "Validation Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (columnName == "UnitPrice")
            {
                string val = e.FormattedValue.ToString().Replace('.', ',');
                if (!decimal.TryParse(val, out decimal newPrice) || newPrice < 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("Price must be a valid positive number.", "Validation Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (columnName == "ProductId")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int pid) || pid <= 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a valid Product ID.", "Validation Error");
                }
            }
        }

        private void sales_dgv_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            sales_dgv.Refresh();
            decimal total = 0;
            foreach (var item in saleItemsList) total += item.Quantity * item.UnitPrice;
            total_amount_tb.Text = total.ToString("N2");
        }

        private void SetupProductNameColumn()
        {
            if (!sales_dgv.Columns.Contains("ProductNameDisplay"))
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = "ProductNameDisplay";
                col.HeaderText = "Product Name";
                col.ReadOnly = true;
                sales_dgv.Columns.Insert(3, col);
            }
        }

        private void sales_dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (sales_dgv.Columns[e.ColumnIndex].Name == "ProductNameDisplay")
            {
                var row = sales_dgv.Rows[e.RowIndex];
                var detail = row.DataBoundItem as SaleDetails;

                if (detail != null && detail.Product != null)
                {
                    e.Value = detail.Product.ProductName;
                }
                else if (detail != null && detail.ProductId > 0)
                {
                    using (var db = new SmartStockContext())
                    {
                        var pName = db.Products.Where(p => p.ProductId == detail.ProductId)
                                               .Select(p => p.ProductName)
                                               .FirstOrDefault();
                        e.Value = pName ?? "Unknown Product";
                    }
                }
            }
        }
        private void sales_dgv_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            if (int.TryParse(sale_id_tb.Text, out int sId))
            {
                e.Row.Cells["SaleId"].Value = sId;
            }
        }
    }
}
