using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Forms.AddForms;
using SmartStock.Forms.User_Control;

namespace SmartStock
{
    public partial class BaseAddInstance : Form
    {
        UserControl controlToOpen = null;
        private string _currentEntityType = null;

        public BaseAddInstance()
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            DataLayer.PopulateSelector(selector_cb);
            action_cb.Items.AddRange(new object[] { "Add Instance", "Modify Instance" });
            action_cb.SelectedIndex = 0;
        }

        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void selector_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = selector_cb.SelectedItem as string;
            _currentEntityType = selectedOption;
            usercontrol_pnl.SuspendLayout();
            usercontrol_pnl.Controls.Clear();

            try
            {
                switch (selectedOption)
                {
                    case "Product":
                        controlToOpen = new ModifyProduct();
                        break;
                    case "Category":
                        controlToOpen = new ModifyCategory();
                        break;
                    case "Supplier":
                        controlToOpen = new ModifySupplier();
                        break;
                    case "Transaction":
                        controlToOpen = new ModifyTransaction();
                        break;
                    case "Customer":
                        controlToOpen = new ModifyCustomer();
                        break;
                    case "Sale":
                        var modifySale = new ModifySale();
                        modifySale.CartGrid = browser_dgv;
                        controlToOpen = modifySale;
                        break;
                    case "ExternalFactor":
                        controlToOpen = new ModifyExternalFactor();
                        break;
                    case "User":
                        controlToOpen = new ModifyUser();
                        break;
                }
                if (controlToOpen != null)
                {
                    controlToOpen.Dock = DockStyle.Fill;
                    usercontrol_pnl.Controls.Add(controlToOpen);
                    ThemeManager.Apply(controlToOpen);
                    UpdateContentHeader(selectedOption);
                    SyncActionState();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                usercontrol_pnl.ResumeLayout(true);
            }

            _ = LoadBrowserDataAsync(selectedOption);
        }

        // ── Records Browser ───────────────────────────────────────────────────

        private async Task LoadBrowserDataAsync(string entityType)
        {
            if (string.IsNullOrEmpty(entityType)) return;

            // For Sale, browser_dgv is used as the cart — no DB load needed
            if (entityType == "Sale")
            {
                browser_dgv.DataSource = null;
                UpdateBrowserHeader(entityType);
                ThemeManager.Apply(browser_card);
                return;
            }

            try
            {
                browser_dgv.DataSource = null;
                using var db = new SmartStockContext();

                object data = entityType switch
                {
                    "Product"        => (object)await db.Products.AsNoTracking().ToListAsync(),
                    "Category"       => await db.Categories.AsNoTracking().ToListAsync(),
                    "Supplier"       => await db.Suppliers.AsNoTracking().ToListAsync(),
                    "Transaction"    => await db.Transactions.AsNoTracking().ToListAsync(),
                    "Customer"       => await db.Customers.AsNoTracking().ToListAsync(),
                    "ExternalFactor" => await db.ExternalFactors.AsNoTracking().ToListAsync(),
                    "User"           => await db.Users.AsNoTracking().ToListAsync(),
                    _                => null
                };

                if (data == null) return;

                browser_dgv.DataSource = data;
                SetupBrowserColumns();
                UpdateBrowserHeader(entityType);
                ThemeManager.Apply(browser_card);
            }
            catch { }
        }

        private void SetupBrowserColumns()
        {
            browser_dgv.AllowUserToAddRows = false;
            browser_dgv.ReadOnly = true;
            browser_dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            foreach (DataGridViewColumn col in browser_dgv.Columns)
            {
                var t = col.ValueType;
                if (t != null && t != typeof(string) && !t.IsValueType)
                    col.Visible = false;
            }
        }

        private void browser_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || _currentEntityType == null) return;
            if (_currentEntityType == "Sale") return; // browser_dgv shows cart, not sale records

            int id = GetIdFromRow(browser_dgv.Rows[e.RowIndex], _currentEntityType);
            if (id <= 0) return;

            // Auto-switch to Modify mode so the form loads the record
            if (action_cb.SelectedItem?.ToString() != "Modify Instance")
                action_cb.SelectedItem = "Modify Instance";

            if (controlToOpen is ISaveableControl saveable)
                saveable.LoadById(id);
        }

        private int GetIdFromRow(DataGridViewRow row, string entityType)
        {
            string idColumn = entityType switch
            {
                "Product"        => "ProductId",
                "Category"       => "CategoryId",
                "Supplier"       => "SupplierId",
                "Transaction"    => "TransactionId",
                "Customer"       => "CustomerId",
                "Sale"           => "SaleId",
                "ExternalFactor" => "FactorId",
                "User"           => "UserId",
                _                => null
            };
            if (idColumn == null) return -1;
            var cell = row.Cells[idColumn];
            return cell != null && int.TryParse(cell.Value?.ToString(), out int id) ? id : -1;
        }

        private void UpdateBrowserHeader(string entityType)
        {
            browser_title_lbl.Text = entityType == "Sale"
                ? "Product Cart"
                : $"Records Browser — {entityType}";
            browser_icon.IconChar = entityType switch
            {
                "Product"        => IconChar.Box,
                "Category"       => IconChar.Tags,
                "Supplier"       => IconChar.Truck,
                "Transaction"    => IconChar.ArrowRightArrowLeft,
                "Customer"       => IconChar.UserTie,
                "Sale"           => IconChar.CashRegister,
                "ExternalFactor" => IconChar.CloudBolt,
                "User"           => IconChar.UserGear,
                _                => IconChar.TableList
            };
        }

        // ── Footer actions ────────────────────────────────────────────────────

        private async void archive_btn_Click(object sender, EventArgs e)
        {
            bool isAddMode = action_cb.SelectedItem?.ToString() == "Add Instance";
            if (isAddMode) return;

            if (controlToOpen is ISaveableControl saveable)
            {
                int idToArchive = saveable.GetCurrentId();

                if (idToArchive <= 0)
                {
                    MessageBox.Show("Please select a valid record first (use Search).", "Warning",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirmResult = MessageBox.Show("Are you sure you want to archive this record?",
                                             "Confirm Archive",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (confirmResult == DialogResult.Yes)
                {
                    archive_btn.Enabled = false;
                    bool success = await saveable.PerformArchive(idToArchive);
                    archive_btn.Enabled = true;

                    if (success)
                        _ = LoadBrowserDataAsync(_currentEntityType);
                }
            }
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            if (controlToOpen is ISaveableControl saveable)
            {
                bool isAddMode = action_cb.SelectedItem?.ToString() == "Add Instance";
                save_btn.Enabled = false;

                bool success = await saveable.PerformSave(isAddMode);

                if (success)
                {
                    MessageBox.Show("Instance saved successfully!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saveable.ClearControls();
                    _ = LoadBrowserDataAsync(_currentEntityType);
                }
                else
                {
                    MessageBox.Show("Failed to save instance.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                save_btn.Enabled = true;
            }
        }

        private void action_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            SyncActionState();
        }

        private void SyncActionState()
        {
            if (controlToOpen is ISaveableControl control)
            {
                bool isAddMode = action_cb.SelectedItem?.ToString() == "Add Instance";
                control.UpdateUIState(isAddMode);
                archive_btn.Enabled = !isAddMode;
                save_btn.Text = isAddMode ? "  Add to Inventory" : "  Save Changes";
                save_btn.IconChar = isAddMode ? IconChar.Plus : IconChar.FloppyDisk;
                ThemeManager.Apply(controlToOpen);
            }
        }

        private void UpdateContentHeader(string selectedOption)
        {
            content_title_lbl.Text = $"Current Instance — {selectedOption}";
            content_icon.IconChar = selectedOption switch
            {
                "Product"        => IconChar.Box,
                "Category"       => IconChar.Tags,
                "Supplier"       => IconChar.Truck,
                "Transaction"    => IconChar.ArrowRightArrowLeft,
                "Customer"       => IconChar.UserTie,
                "Sale"           => IconChar.CashRegister,
                "ExternalFactor" => IconChar.CloudBolt,
                "User"           => IconChar.UserGear,
                _                => IconChar.TableList
            };
        }
    }
}
