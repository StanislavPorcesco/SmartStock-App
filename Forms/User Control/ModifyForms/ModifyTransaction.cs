using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Classes.Data.Interfaces;

namespace SmartStock.Forms.User_Control
{
    /// <summary>
    /// Passive View: Doar colectează date din controale și afișează mesaje.
    /// Logica de business și revert stoc este delegată TransactionService.
    /// Note: Transactions cannot be edited — only added or hard-deleted (stock reverted).
    /// </summary>
    public partial class ModifyTransaction : UserControl, ISaveableControl
    {
        private TransactionService _transactionService;
        private int _currentTransactionId;

        public ModifyTransaction()
        {
            InitializeComponent();
            InitializeService();
            type_cb.Items.AddRange(new object[] { "Stock In", "Stock Out", "Adjustment" });
        }

        private void InitializeService()
        {
            var repository   = new GenericRepository<Transaction>(new SmartStockContext());
            var productRepo  = new GenericRepository<Product>(new SmartStockContext());
            _transactionService = new TransactionService(repository, productRepo);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(transaction_id_tb.Text, out int transId))
            {
                MessageBox.Show("Please enter a valid Transaction ID.", "Search Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SearchAndLoadTransaction(transId);
        }

        private async void SearchAndLoadTransaction(int transactionId)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var transaction = await _transactionService.GetWithDetailsAsync(transactionId);

                if (transaction != null)
                {
                    _currentTransactionId = transaction.TransactionId;
                    DisplayTransactionData(transaction);
                }
                else
                {
                    transaction_id_tb.BackColor = Color.DarkRed;
                    transaction_id_tb.ForeColor = Color.White;
                    MessageBox.Show("Transaction not found.", "Search Error",
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

        private void DisplayTransactionData(Transaction transaction)
        {
            product_id_tb.Text   = transaction.ProductId.ToString();
            entity_id_tb.Text    = transaction.EntityId?.ToString() ?? "";
            user_id_tb.Text      = transaction.UserId.ToString();
            quantity_tb.Text     = transaction.Quantity.ToString();
            date_picker.Value    = transaction.Date;
            type_cb.SelectedItem = transaction.Type;

            entity_lbl.Text = transaction.Type == "Stock In" ? "Supplier ID" : "Customer/Entity ID";

            transaction_id_tb.BackColor = Color.DarkGreen;
            transaction_id_tb.ForeColor = Color.White;
        }

        private bool TryCollectTransactionData(out Transaction transaction)
        {
            transaction = null;

            if (!int.TryParse(product_id_tb.Text, out int productId) || productId <= 0)
            {
                MessageBox.Show("Please enter a valid Product ID.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(quantity_tb.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid Quantity (positive integer).", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (type_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Transaction Type.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int? entityId = int.TryParse(entity_id_tb.Text, out int eid) ? eid : (int?)null;
            int  userId   = SessionManager.CurrentUser?.UserId ?? 0;

            transaction = new Transaction
            {
                ProductId = productId,
                EntityId  = entityId,
                UserId    = userId,
                Quantity  = quantity,
                Date      = date_picker.Value,
                Type      = type_cb.SelectedItem.ToString()
            };

            return true;
        }

        // ── ISaveableControl ──────────────────────────────────────────────────

        public async Task<bool> PerformSave(bool isAddMode)
        {
            if (!isAddMode)
            {
                MessageBox.Show("Transactions cannot be edited. To correct a transaction, " +
                                "archive (delete) it and create a new one.",
                                "Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!TryCollectTransactionData(out var transaction)) return false;

            try
            {
                return await _transactionService.AddTransactionAsync(transaction);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public async Task<bool> PerformArchive(int transactionId)
        {
            bool success = false;
            try
            {
                Cursor = Cursors.WaitCursor;

                success = await _transactionService.DeleteTransactionAsync(transactionId);

                if (success)
                {
                    MessageBox.Show("Transaction deleted and stock reverted successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Transaction not found.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during deletion: {ex.Message}", "Database Error",
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
            var idTextBox    = this.Controls.Find("transaction_id_tb", true).FirstOrDefault();
            if (searchButton != null) searchButton.Enabled = !isAddMode;
            if (idTextBox    != null) idTextBox.Enabled    = !isAddMode;
            ClearControls();
        }

        public int GetCurrentId()
        {
            return int.TryParse(transaction_id_tb.Text, out int id) ? id : -1;
        }

        public void ClearControls()
        {
            transaction_id_tb.Clear();
            product_id_tb.Clear();
            entity_id_tb.Clear();
            user_id_tb.Clear();
            quantity_tb.Clear();
            type_cb.SelectedIndex = -1;
            ThemeManager.Apply(this);
        }
    }
}
