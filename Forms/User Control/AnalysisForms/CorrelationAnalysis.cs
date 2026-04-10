using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;

namespace SmartStock.Forms.User_Control.AnalysisForms
{
    public partial class CorrelationAnalysis : UserControl, IAnalysisParameterControl
    {
        public CorrelationAnalysis()
        {
            InitializeComponent();
            InitializeDefaults();
        }

        public AnalysisContext GetParameters()
        {
            return new AnalysisContext
            {
                Parameters = new Dictionary<string, object>
                {
                    ["PrimaryFactor"] = factor_type_cb.SelectedItem?.ToString() ?? string.Empty,
                    ["LagDays"] = (int)lag_nud.Value,
                    ["AggregationLevel"] = interval_cb.SelectedItem?.ToString() ?? string.Empty
                }
            };
        }

        public void Reset()
        {
            factor_type_cb.SelectedIndex = 0;
            interval_cb.SelectedIndex = 0;
            lag_nud.Value = 0;
        }

        private void InitializeDefaults()
        {
            if (factor_type_cb.Items.Count == 0)
            {
                factor_type_cb.Items.Add("No Factors Available");
            }

            if (interval_cb.Items.Count == 0)
            {
                interval_cb.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly" });
            }

            lag_nud.Minimum = 0;
            lag_nud.Maximum = 90;
            lag_nud.Value = 0;

            if (factor_type_cb.Items.Count > 0)
                factor_type_cb.SelectedIndex = 0;
            if (interval_cb.Items.Count > 0)
                interval_cb.SelectedIndex = 0;
        }

        public void SetPrimaryFactors(IEnumerable<string> factorTypes)
        {
            factor_type_cb.Items.Clear();

            var items = (factorTypes ?? Enumerable.Empty<string>())
                .Where(v => !string.IsNullOrWhiteSpace(v))
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(v => v)
                .ToList();

            if (items.Count == 0)
            {
                factor_type_cb.Items.Add("No Factors Available");
            }
            else
            {
                factor_type_cb.Items.AddRange(items.Cast<object>().ToArray());
            }

            factor_type_cb.SelectedIndex = factor_type_cb.Items.Count > 0 ? 0 : -1;
        }
    }
}
