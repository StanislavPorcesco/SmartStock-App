using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;
using SmartStock.Classes.Data.Interfaces;

namespace SmartStock.Forms.User_Control
{
    /// <summary>
    /// Passive View: Doar colectează date din controale și afișează mesaje.
    /// Logica de business este delegată ExternalFactorService.
    /// </summary>
    public partial class ModifyExternalFactor : UserControl, ISaveableControl
    {
        private ExternalFactorService _factorService;
        private int _currentFactorId;
        private ExternalFactor _loadedFactor;

        public ModifyExternalFactor()
        {
            InitializeComponent();
            InitializeService();
            value_type_cb.Items.AddRange(new string[] { "Absolute", "Percentage", "Multiplier" });
        }

        private void InitializeService()
        {
            var repository = new GenericRepository<ExternalFactor>(new SmartStockContext());
            _factorService = new ExternalFactorService(repository);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!FormValidator.RequireId(factor_id_tb.Text, "Factor ID", out int factorId)) return;

            SearchAndLoadFactor(factorId);
        }

        private async void SearchAndLoadFactor(int factorId)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                var factor = await _factorService.GetByIdAsync(factorId);

                if (factor != null)
                {
                    _currentFactorId = factor.FactorId;
                    _loadedFactor    = factor;
                    DisplayFactorData(factor);
                }
                else
                {
                    factor_id_tb.BackColor = Color.DarkRed;
                    factor_id_tb.ForeColor = Color.White;
                    MessageBox.Show("External Factor not found.", "Search Error",
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

        private void DisplayFactorData(ExternalFactor factor)
        {
            factor_type_tb.Text        = factor.FactorType;
            description_tb.Text        = factor.Description;
            region_tb.Text             = factor.Region;
            impact_value_tb.Text       = factor.ImpactValue.ToString();
            value_type_cb.SelectedItem = factor.ValueType;
            date_picker.Value          = factor.Date;

            factor_id_tb.BackColor = factor.IsActive ? Color.DarkGreen : Color.DarkOrange;
            factor_id_tb.ForeColor = Color.White;

            if (!factor.IsActive)
                MessageBox.Show("This factor is currently deactivated.", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool TryCollectFactorData(out ExternalFactor factor)
        {
            factor = null;

            if (!FormValidator.RequireText(factor_type_tb.Text, "Factor Type")) return false;
            if (!FormValidator.RequireText(region_tb.Text, "Region")) return false;
            if (!FormValidator.RequireDecimal(impact_value_tb.Text, "Impact Value", out decimal impactValue)) return false;
            if (!FormValidator.RequireSelection(value_type_cb.SelectedIndex, "Value Type")) return false;

            factor = new ExternalFactor
            {
                FactorType  = factor_type_tb.Text.Trim(),
                Description = description_tb.Text.Trim(),
                Region      = region_tb.Text.Trim(),
                ImpactValue = impactValue,
                ValueType   = value_type_cb.SelectedItem.ToString(),
                Date        = date_picker.Value,
                IsActive    = true
            };

            return true;
        }

        // ── ISaveableControl ──────────────────────────────────────────────────

        public async Task<SaveOutcome> PerformSave(bool isAddMode)
        {
            if (!TryCollectFactorData(out var factor)) return SaveOutcome.Handled;

            try
            {
                bool ok;
                if (isAddMode)
                {
                    ok = await _factorService.AddFactorAsync(factor);
                }
                else
                {
                    // Mutate the tracked entity — avoids EF duplicate-key tracking conflict
                    _loadedFactor.FactorType  = factor.FactorType;
                    _loadedFactor.Description = factor.Description;
                    _loadedFactor.Region      = factor.Region;
                    _loadedFactor.ImpactValue = factor.ImpactValue;
                    _loadedFactor.ValueType   = factor.ValueType;
                    _loadedFactor.Date        = factor.Date;
                    ok = await _factorService.UpdateFactorAsync(_loadedFactor);
                }

                return ok ? SaveOutcome.Success : SaveOutcome.Failed;
            }
            catch (Exception ex)
            {
                FormValidator.ShowDbError(ex);
                return SaveOutcome.Handled;
            }
        }

        public async Task<bool> PerformArchive(int factorId)
        {
            bool success = false;
            try
            {
                Cursor = Cursors.WaitCursor;

                success = await _factorService.DeactivateFactorAsync(factorId);

                if (success)
                {
                    MessageBox.Show("Factor has been deactivated successfully.", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearControls();
                }
                else
                {
                    MessageBox.Show("External Factor not found.", "Error",
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
            var idTextBox    = this.Controls.Find("factor_id_tb", true).FirstOrDefault();
            if (searchButton != null) searchButton.Enabled = !isAddMode;
            if (idTextBox    != null) idTextBox.Enabled    = !isAddMode;
            ClearControls();
        }

        public int GetCurrentId()
        {
            return int.TryParse(factor_id_tb.Text, out int id) ? id : -1;
        }

        public void LoadById(int id)
        {
            factor_id_tb.Text = id.ToString();
            SearchAndLoadFactor(id);
        }

        public void ClearControls()
        {
            factor_id_tb.Clear();
            factor_type_tb.Clear();
            description_tb.Clear();
            region_tb.Clear();
            impact_value_tb.Clear();
            value_type_cb.SelectedIndex = -1;
            date_picker.Value = DateTime.Now;
            ThemeManager.Apply(this);
        }
    }
}
