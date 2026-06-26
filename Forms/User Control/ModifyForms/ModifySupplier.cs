using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Classes.Data.Interfaces;

namespace SmartStock.Forms.User_Control
{
    /// <summary>
    /// Passive View: Doar colectează date din controale și afișează mesaje.
    /// Logica de business este delegată SupplierService.
    /// </summary>
    public partial class ModifySupplier : UserControl, ISaveableControl
    {
        private SupplierService _supplierService;
        private int _currentSupplierId;
        private Supplier _loadedSupplier;

        public ModifySupplier()
        {
            InitializeComponent();
            InitializeService();
        }

        private void InitializeService()
        {
            var repository = new GenericRepository<Supplier>(new SmartStockContext());
            _supplierService = new SupplierService(repository);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!FormValidator.RequireId(supplier_id_tb.Text, "Supplier ID", out int suppId)) return;

            SearchAndLoadSupplier(suppId);
        }

        private async void SearchAndLoadSupplier(int supplierId)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var supplier = await _supplierService.GetByIdAsync(supplierId);

                if (supplier != null)
                {
                    _currentSupplierId = supplier.SupplierId;
                    _loadedSupplier    = supplier;
                    DisplaySupplierData(supplier);
                }
                else
                {
                    supplier_id_tb.BackColor = Color.DarkRed;
                    supplier_id_tb.ForeColor = Color.White;
                    MessageBox.Show("Supplier not found.", "Search Error",
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

        private void DisplaySupplierData(Supplier supplier)
        {
            supplier_name_tb.Text   = supplier.SupplierName;
            contact_person_tb.Text  = supplier.ContactPerson;
            email_tb.Text           = supplier.Email;
            phone_tb.Text           = supplier.Phone;
            address_tb.Text         = supplier.Address;

            if (supplier.IsActive)
            {
                supplier_id_tb.BackColor = Color.DarkGreen;
                supplier_id_tb.ForeColor = Color.White;
            }
            else
            {
                supplier_id_tb.BackColor = Color.DarkOrange;
                supplier_id_tb.ForeColor = Color.White;
                MessageBox.Show("This supplier is currently inactive (Soft Deleted).", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool TryCollectSupplierData(out Supplier supplier)
        {
            supplier = null;

            if (!FormValidator.RequireText(supplier_name_tb.Text, "Supplier Name")) return false;
            if (!FormValidator.ValidateOptionalEmail(email_tb.Text)) return false;

            supplier = new Supplier
            {
                SupplierName   = supplier_name_tb.Text.Trim(),
                ContactPerson  = contact_person_tb.Text.Trim(),
                Email          = email_tb.Text.Trim(),
                Phone          = phone_tb.Text.Trim(),
                Address        = address_tb.Text.Trim(),
                IsActive       = true
            };

            return true;
        }

        // ── ISaveableControl ──────────────────────────────────────────────────

        public async Task<SaveOutcome> PerformSave(bool isAddMode)
        {
            if (!TryCollectSupplierData(out var supplier)) return SaveOutcome.Handled;

            try
            {
                bool ok;
                if (isAddMode)
                {
                    ok = await _supplierService.AddSupplierAsync(supplier);
                }
                else
                {
                    // Mutate the tracked entity — avoids EF duplicate-key tracking conflict
                    _loadedSupplier.SupplierName  = supplier.SupplierName;
                    _loadedSupplier.ContactPerson = supplier.ContactPerson;
                    _loadedSupplier.Email         = supplier.Email;
                    _loadedSupplier.Phone         = supplier.Phone;
                    _loadedSupplier.Address       = supplier.Address;
                    ok = await _supplierService.UpdateSupplierAsync(_loadedSupplier);
                }

                return ok ? SaveOutcome.Success : SaveOutcome.Failed;
            }
            catch (Exception ex)
            {
                FormValidator.ShowDbError(ex);
                return SaveOutcome.Handled;
            }
        }

        public async Task<bool> PerformArchive(int supplierId)
        {
            bool success = false;
            try
            {
                Cursor = Cursors.WaitCursor;

                success = await _supplierService.DeactivateSupplierAsync(supplierId);

                if (success)
                {
                    MessageBox.Show("Supplier deactivated successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("Supplier not found.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControls();
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

        public void UpdateUIState(bool isAddMode)
        {
            var searchButton = this.Controls.Find("search_btn", true).FirstOrDefault();
            var idTextBox    = this.Controls.Find("supplier_id_tb", true).FirstOrDefault();
            if (searchButton != null) searchButton.Enabled = !isAddMode;
            if (idTextBox    != null) idTextBox.Enabled    = !isAddMode;
            ClearControls();
        }

        public int GetCurrentId()
        {
            return int.TryParse(supplier_id_tb.Text, out int id) ? id : -1;
        }

        public void LoadById(int id)
        {
            supplier_id_tb.Text = id.ToString();
            SearchAndLoadSupplier(id);
        }

        public void ClearControls()
        {
            supplier_id_tb.Clear();
            supplier_name_tb.Clear();
            contact_person_tb.Clear();
            email_tb.Clear();
            phone_tb.Clear();
            address_tb.Clear();
            ThemeManager.Apply(this);
        }
    }
}
