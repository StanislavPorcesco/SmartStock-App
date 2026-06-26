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

        // Records-browser sort state (same click-to-sort behavior as SearchForms).
        private int _sortColumnIndex = -1;
        private SortOrder _sortOrder = SortOrder.None;

        public BaseAddInstance()
        {
            InitializeComponent();
            ThemeManager.Apply(this);
            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            DataLayer.PopulateSelector(selector_cb);
            action_cb.Items.AddRange(new object[] { "Add Instance", "Modify Instance" });
            action_cb.SelectedIndex = 0;
            selector_cb.SelectedIndex = 0;

            // Enter anywhere in the open ModifyForm triggers Save. KeyPreview lets the form
            // see the key before the focused (possibly deeply nested) control does.
            this.KeyPreview = true;
            this.KeyDown += BaseAddInstance_KeyDown;

            // Click a column header to sort the records browser (parity with SearchForms).
            browser_dgv.ColumnHeaderMouseClick += browser_dgv_ColumnHeaderMouseClick;
            browser_dgv.DataBindingComplete += browser_dgv_DataBindingComplete;
        }

        /// <summary>
        /// Pressing Enter acts as a click on <c>save_btn</c>, except while a combo dropdown
        /// is open — there Enter should select the highlighted item instead.
        /// </summary>
        private void BaseAddInstance_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            if (HasOpenDropDown(this)) return;

            e.SuppressKeyPress = true; // suppress the Windows "ding"
            save_btn.PerformClick();
        }

        /// <summary>Recursively checks whether any ComboBox under <paramref name="parent"/> is dropped down.</summary>
        private static bool HasOpenDropDown(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                if (child is ComboBox combo && combo.DroppedDown) return true;
                if (child.HasChildren && HasOpenDropDown(child)) return true;
            }
            return false;
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

            // A new entity has different columns, so any previous sort no longer applies.
            _sortColumnIndex = -1;
            _sortOrder = SortOrder.None;

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

                // Keep an active sort across reloads of the same entity (e.g. after a save).
                if (_sortColumnIndex >= 0 && _sortOrder != SortOrder.None)
                    ApplyCurrentSort();
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

        // ── Records Browser sorting (mirrors SearchForm) ──────────────────────

        private void browser_dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_currentEntityType == "Sale") return; // browser shows the cart, not sortable records

            try
            {
                var column = browser_dgv.Columns[e.ColumnIndex];
                var propName = column.DataPropertyName;
                if (string.IsNullOrEmpty(propName)) return;

                var source = browser_dgv.DataSource as System.Collections.IList;
                if (source == null || source.Count == 0) return;

                var prop = source[0].GetType().GetProperty(propName);
                if (prop == null) return;

                bool isCollection = typeof(System.Collections.IEnumerable).IsAssignableFrom(prop.PropertyType)
                                    && prop.PropertyType != typeof(string);
                if (isCollection) return;

                if (_sortColumnIndex == e.ColumnIndex)
                    _sortOrder = _sortOrder == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
                else
                {
                    _sortColumnIndex = e.ColumnIndex;
                    _sortOrder = SortOrder.Ascending;
                }

                ApplyCurrentSort();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sorting: {ex.Message}", "Sort Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyCurrentSort()
        {
            if (_sortColumnIndex < 0 || _sortOrder == SortOrder.None) return;
            if (_sortColumnIndex >= browser_dgv.Columns.Count) return;

            var propName = browser_dgv.Columns[_sortColumnIndex].DataPropertyName;
            if (string.IsNullOrEmpty(propName)) return;

            var source = browser_dgv.DataSource as System.Collections.IList;
            if (source == null || source.Count == 0) return;

            var items = source.Cast<object>().ToList();
            bool ascending = _sortOrder == SortOrder.Ascending;

            var sorted = (ascending
                ? items.OrderBy(x => GetSortKey(x, propName), NullSafeComparer.Instance)
                : items.OrderByDescending(x => GetSortKey(x, propName), NullSafeComparer.Instance))
                .ToList();

            var itemType = items[0].GetType();
            var typedList = (System.Collections.IList)Activator.CreateInstance(
                typeof(List<>).MakeGenericType(itemType));
            foreach (var item in sorted) typedList.Add(item);

            browser_dgv.DataSource = typedList;
            SetupBrowserColumns(); // re-hide navigation columns after the rebind
        }

        private void browser_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (browser_dgv.Rows.Count == 0) return;
            var firstItem = browser_dgv.Rows[0].DataBoundItem;
            if (firstItem == null) return;

            foreach (DataGridViewColumn col in browser_dgv.Columns)
            {
                if (string.IsNullOrEmpty(col.DataPropertyName))
                {
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    continue;
                }

                var prop = firstItem.GetType().GetProperty(col.DataPropertyName);
                if (prop == null) { col.SortMode = DataGridViewColumnSortMode.NotSortable; continue; }

                bool isCollection = typeof(System.Collections.IEnumerable).IsAssignableFrom(prop.PropertyType)
                                    && prop.PropertyType != typeof(string);

                col.SortMode = isCollection
                    ? DataGridViewColumnSortMode.NotSortable
                    : DataGridViewColumnSortMode.Programmatic;

                col.HeaderCell.SortGlyphDirection = (col.Index == _sortColumnIndex)
                    ? _sortOrder
                    : SortOrder.None;
            }
        }

        private static object GetSortKey(object item, string propName)
        {
            var prop = item.GetType().GetProperty(propName);
            if (prop == null) return null;

            var propType = prop.PropertyType;
            if (typeof(System.Collections.IEnumerable).IsAssignableFrom(propType) && propType != typeof(string))
                return null;

            var value = prop.GetValue(item);

            // M:1 relation — sort by the same resolved Name a display column would show.
            if (propType.IsClass && propType != typeof(string) && value != null)
            {
                var nameProp = value.GetType().GetProperties()
                    .FirstOrDefault(p => p.Name.Contains("Name") || p.Name.Contains("Username"));
                return nameProp?.GetValue(value);
            }

            return value;
        }

        private class NullSafeComparer : IComparer<object>
        {
            public static readonly NullSafeComparer Instance = new();

            public int Compare(object x, object y)
            {
                if (x == null && y == null) return 0;
                if (x == null) return -1;
                if (y == null) return 1;
                if (x is IComparable cx) return cx.CompareTo(y);
                return string.Compare(x.ToString(), y.ToString(), StringComparison.OrdinalIgnoreCase);
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

                SaveOutcome outcome = await saveable.PerformSave(isAddMode);

                switch (outcome)
                {
                    case SaveOutcome.Success:
                        MessageBox.Show("Instance saved successfully!", "Success",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        saveable.ClearControls();
                        _ = LoadBrowserDataAsync(_currentEntityType);
                        break;

                    case SaveOutcome.Failed:
                        MessageBox.Show("Could not save the record. Please check the values and try again.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case SaveOutcome.Handled:
                        // The control already showed a specific message — don't double up.
                        break;
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
