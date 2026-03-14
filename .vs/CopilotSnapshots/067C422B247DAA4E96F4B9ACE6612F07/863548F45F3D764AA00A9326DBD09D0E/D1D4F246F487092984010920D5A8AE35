using SmartStock.Classes.Models;
using SmartStock.Classes.Utils;

namespace SmartStock.Forms.User_Control
{
    public partial class AddExternalFactor : UserControl
    {
        public AddExternalFactor()
        {
            InitializeComponent();
            DataLayer.PopulateSelector(selector_cb);
            selector_cb.SelectedIndexChanged += DataLayer.OpenAddInstanceForm(this, selector_cb);
            value_type_cb.Items.AddRange(new string[] { "Absolute", "Percentage", "Multiplier" });
            value_type_cb.Text = "Select a value type";
            ThemeManager.Apply(this);
            this.Refresh();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            // 1. Preluare date și validări de bază pentru șiruri de caractere
            string factorType = factor_type_tb.Text.Trim();
            string description = description_tb.Text.Trim();
            string region = region_tb.Text.Trim();

            if (string.IsNullOrWhiteSpace(factorType) || string.IsNullOrWhiteSpace(region))
            {
                MessageBox.Show("Factor Type and Region are required fields.", "Input Validation",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validare pentru Impact Value (trebuie să fie numeric)
            if (!decimal.TryParse(impact_value_tb.Text, out decimal impactValue))
            {
                MessageBox.Show("Please enter a valid numeric value for Impact Value.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (value_type_cb.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Value Type.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Cursor = Cursors.WaitCursor;

                using (var db = new SmartStockContext())
                {
                    // 3. Crearea obiectului bazat pe modelul tău
                    // Notă: Folosim DateTime deoarece majoritatea DB-urilor (SQL Server) 
                    // lucrează mai bine cu DateTime decât cu DateOnly în EF Core.
                    var newFactor = new ExternalFactor
                    {
                        FactorType = factorType,
                        Description = description,
                        Region = region,
                        Date = date_picker.Value,
                        ImpactValue = impactValue,
                        ValueType = value_type_cb.SelectedItem.ToString(),
                        IsActive = true
                    };

                    // 4. Salvarea în baza de date
                    db.ExternalFactors.Add(newFactor);
                    db.SaveChanges();

                    MessageBox.Show("External factor has been successfully recorded!", "Success",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving to database: {ex.Message}", "Database Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ClearFields()
        {
            factor_type_tb.Clear();
            description_tb.Clear();
            region_tb.Clear();
            impact_value_tb.Clear();
            date_picker.Value = DateTime.Now;
        }
    }
}
