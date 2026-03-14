using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class ModifyExternalFactor : UserControl
    {
        public ModifyExternalFactor()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenModifyInstanceForm(this, selector_cb);
            ThemeManager.Apply(this);
            this.Refresh();
            value_type_cb.Items.AddRange(new string[] { "Absolute", "Percentage", "Multiplier" });
            value_type_cb.Text = "Select a value type";
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(factor_id_tb.Text, out int factorId))
            {
                MessageBox.Show("Please enter a valid Factor ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new SmartStockContext())
                {
                    var factor = db.ExternalFactors.AsNoTracking().FirstOrDefault(f => f.FactorId == factorId);

                    if (factor != null)
                    {
                        factor_type_tb.Text = factor.FactorType;
                        description_tb.Text = factor.Description;
                        region_tb.Text = factor.Region;
                        impact_value_tb.Text = factor.ImpactValue.ToString();
                        date_picker.Value = factor.Date;
                        value_type_cb.SelectedItem = factor.ValueType;

                        if (factor.IsActive)
                        {
                            factor_id_tb.BackColor = Color.DarkGreen;
                            factor_id_tb.ForeColor = Color.White;
                        }
                        else
                        {
                            factor_id_tb.BackColor = Color.DarkOrange;
                            factor_id_tb.ForeColor = Color.White;
                            MessageBox.Show("This factor is currently deactivated (Soft Deleted).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        factor_id_tb.BackColor = Color.DarkRed;
                        factor_id_tb.ForeColor = Color.White;
                        MessageBox.Show("Factor ID not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearFactorFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during search: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(factor_id_tb.Text, out int factorId)) return;

            DialogResult confirm = MessageBox.Show("Are you sure you want to deactivate this factor? It will no longer be used in new AI predictions, but historical data remains.",
                                                 "Confirm Deactivation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var db = new SmartStockContext())
                    {
                        var factor = db.ExternalFactors.FirstOrDefault(f => f.FactorId == factorId);

                        if (factor != null)
                        {
                            factor.IsActive = false;
                            db.SaveChanges();

                            MessageBox.Show("Factor has been deactivated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearFactorFields();
                        }
                        else
                        {
                            MessageBox.Show("External Factor not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearFactorFields();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error during deactivation: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(factor_id_tb.Text, out int factorId) || string.IsNullOrWhiteSpace(factor_type_tb.Text))
            {
                MessageBox.Show("Please search for a External Factor first using a valid ID.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(impact_value_tb.Text, out decimal impactValue))
            {
                MessageBox.Show("Invalid impact value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var db = new SmartStockContext())
                {
                    var factor = db.ExternalFactors.FirstOrDefault(f => f.FactorId == factorId);

                    if (factor != null)
                    {
                        factor.FactorType = factor_type_tb.Text.Trim();
                        factor.Description = description_tb.Text.Trim();
                        factor.Region = region_tb.Text.Trim();
                        factor.ImpactValue = impactValue;
                        factor.Date = date_picker.Value;
                        factor.ValueType = value_type_cb.SelectedItem?.ToString() ?? "Absolute";

                        db.SaveChanges();

                        MessageBox.Show("External factor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFactorFields();
                    }
                    else
                    {
                        MessageBox.Show("Factor not found.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearFactorFields();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: { ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearFactorFields();
            }
        }
        private void ClearFactorFields()
        {
            factor_id_tb.Clear();
            factor_type_tb.Clear();
            description_tb.Clear();
            region_tb.Clear();
            impact_value_tb.Clear();
            date_picker.Value = DateTime.Now;
            value_type_cb.SelectedIndex = -1;
            ThemeManager.Apply(this);
        }
    }
}
