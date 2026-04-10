using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;

namespace SmartStock.Forms.User_Control.AnalysisForms
{
    public partial class AnomalyDetection : UserControl, IAnalysisParameterControl
    {
        public AnomalyDetection()
        {
            InitializeComponent();
            InitializeDefaults();
        }

        public AnalysisContext GetParameters()
        {
            var selected = sensitivity_cb.SelectedItem?.ToString() ?? string.Empty;
            var threshold = selected switch
            {
                var s when s.StartsWith("Strict")       => 1.5,
                var s when s.StartsWith("Relaxed")      => 2.5,
                var s when s.StartsWith("Conservative") => 3.0,
                _                                        => 2.0
            };

            return new AnalysisContext
            {
                Parameters = new Dictionary<string, object>
                {
                    ["SensitivityThreshold"] = (decimal)threshold,
                    ["AggregationLevel"]     = aggregation_cb.SelectedItem?.ToString() ?? "Daily"
                }
            };
        }

        public void Reset()
        {
            sensitivity_cb.SelectedIndex  = 1;
            aggregation_cb.SelectedIndex  = 0;
        }

        private void InitializeDefaults()
        {
            sensitivity_cb.Items.AddRange(new object[]
            {
                "Strict (1.5σ)  — more anomalies",
                "Standard (2.0σ)  — balanced",
                "Relaxed (2.5σ)  — fewer anomalies",
                "Conservative (3.0σ)  — only extremes"
            });
            sensitivity_cb.SelectedIndex = 1;

            aggregation_cb.Items.AddRange(new object[] { "Daily", "Weekly", "Monthly" });
            aggregation_cb.SelectedIndex = 0;
        }
    }
}
