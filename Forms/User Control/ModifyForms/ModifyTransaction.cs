using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class ModifyTransaction : UserControl
    {
        public ModifyTransaction()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            DataLayer.PopulateTransactionTypeSelector(type_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenModifyInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(transaction_id_tb.Text, out int transId))
            {
                MessageBox.Show("Please enter a valid Transaction ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new SmartStockContext())
                {
                    var transaction = db.Transactions.AsNoTracking().FirstOrDefault(t => t.TransactionId == transId);

                    if (transaction != null)
                    {
                        product_id_tb.Text = transaction.ProductId.ToString();
                        entity_id_tb.Text = transaction.EntityId?.ToString() ?? "";
                        user_id_tb.Text = transaction.UserId.ToString();
                        quantity_tb.Text = transaction.Quantity.ToString();
                        date_picker.Value = transaction.Date;
                        type_cb.SelectedItem = transaction.Type;

                        // Actualizăm eticheta în funcție de tipul tranzacției
                        if (transaction.Type == "Stock In")
                            entity_lbl.Text = "Supplier ID";
                        else if (transaction.Type == "Stock Out" || transaction.Type == "Adjustment")
                            entity_lbl.Text = "Customer ID";

                        transaction_id_tb.BackColor = Color.DarkGreen;
                        transaction_id_tb.ForeColor = Color.White;
                    }
                    else
                    {
                        transaction_id_tb.BackColor = Color.DarkRed;
                        transaction_id_tb.ForeColor = Color.White;
                        MessageBox.Show("Transaction not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        ClearTransactionFields();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(transaction_id_tb.Text, out int transId)) return;

            DialogResult confirm = MessageBox.Show("Deleting a transaction will NOT automatically revert the stock levels. " +
                "It is recommended to create a reverse transaction instead. Proceed with deletion?",
                "Confirm Physical Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var db = new SmartStockContext())
                    {
                        var transaction = db.Transactions.Find(transId);
                        if (transaction != null)
                        {
                            db.Transactions.Remove(transaction);
                            db.SaveChanges();
                            MessageBox.Show("Transaction deleted from history.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTransactionFields();
                        }
                        else
                        {
                            MessageBox.Show("Transaction not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearTransactionFields();
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show($"Error during deactivation: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(transaction_id_tb.Text, out int transId))
            {
                MessageBox.Show("Please select a valid Transaction ID first.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new SmartStockContext())
                {
                    var transaction = db.Transactions.FirstOrDefault(t => t.TransactionId == transId);

                    if (transaction == null)
                    {
                        MessageBox.Show("Transaction not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (int.TryParse(product_id_tb.Text, out int newPid))
                    {
                        if (!db.Products.Any(p => p.ProductId == newPid))
                        {
                            MessageBox.Show($"Product ID {newPid} does not exist!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        transaction.ProductId = newPid;

                        if (int.TryParse(user_id_tb.Text, out int newUid))
                        {
                            if (!db.Users.Any(u => u.UserId == newUid))
                            {
                                MessageBox.Show($"User ID {newUid} does not exist!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            transaction.UserId = newUid;
                        }

                        if (int.TryParse(entity_id_tb.Text, out int newEntId))
                        {
                            bool entityExists = false;
                            string type = type_cb.SelectedItem?.ToString() ?? "";

                            if (type == "Stock In")
                            {
                                entityExists = db.Suppliers.Any(s => s.SupplierId == newEntId);
                                if (!entityExists) { MessageBox.Show($"Supplier ID {newEntId} does not exist!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            }
                            else if (type == "Stock Out")
                            {
                                entityExists = db.Customers.Any(c => c.CustomerId == newEntId);
                                if (!entityExists) { MessageBox.Show($"Customer ID {newEntId} does not exist!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                            }

                            transaction.EntityId = newEntId;
                        }
                        if (int.TryParse(quantity_tb.Text, out int qty)) transaction.Quantity = qty;
                        transaction.Date = date_picker.Value;
                        transaction.Type = type_cb.SelectedItem?.ToString() ?? transaction.Type;

                        db.SaveChanges();
                        MessageBox.Show("Transaction updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearTransactionFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearTransactionFields()
        {
            transaction_id_tb.Clear();
            product_id_tb.Clear();
            entity_id_tb.Clear();
            user_id_tb.Clear();
            quantity_tb.Clear();
            type_cb.SelectedIndex = -1;
            entity_lbl.Text = "Entity ID";
            ThemeManager.Apply(this);
        }
    }
}
