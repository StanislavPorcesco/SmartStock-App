using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class ModifyProduct : UserControl
    {
        public ModifyProduct()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            DataLayer.PopulateCategorySelector(product_category_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenModifyInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(product_id_tb.Text, out int pid))
            {
                MessageBox.Show("Please enter a valid Product ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new SmartStockContext())
                {
                    var product = db.Products.FirstOrDefault(p => p.ProductId == pid);

                    if (product != null)
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
                            MessageBox.Show("This product is currently inactive (Soft Deleted).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        product_id_tb.BackColor = Color.DarkRed;
                        product_id_tb.ForeColor = Color.White;
                        MessageBox.Show("Product not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearControls();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(product_id_tb.Text, out int pid)) return;
            DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate this product? Historical sales data will be preserved.",
                                                 "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var db = new SmartStockContext())
                    {
                        var product = db.Products.Find(pid);
                        if (product != null)
                        {
                            product.IsActive = false;
                            db.SaveChanges();
                            MessageBox.Show("Product has been deactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearControls();
                        }
                        else
                        {
                            MessageBox.Show("Product not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearControls();
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Error during deactivation: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(product_id_tb.Text, out int pid))
            {
                MessageBox.Show("Please search for a product first using a valid ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new SmartStockContext())
                {
                    var product = db.Products.Find(pid);

                    if (product != null)
                    {
                        product.ProductName = product_name_tb.Text;
                        product.UnitOfMeasure = unit_measure_tb.Text;

                        if (decimal.TryParse(unit_price_tb.Text, out decimal price)) product.UnitPrice = price;
                        if (int.TryParse(current_stock_tb.Text, out int stock)) product.CurrentStock = stock;
                        if (int.TryParse(safety_stock_tb.Text, out int sStock)) product.SafetyStock = sStock;
                        if (int.TryParse(supplier_id_tb.Text, out int sid)) product.SupplierId = sid;

                        if (product_category_cb.SelectedValue != null)
                            product.CategoryId = (int)product_category_cb.SelectedValue;

                        db.SaveChanges();
                        MessageBox.Show("Product updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearControls();   
                    }
                    else
                    {
                        MessageBox.Show("Product not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                ClearControls();
                MessageBox.Show("Error updating product: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearControls()
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
    }
}
