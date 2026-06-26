using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Settings;
using SmartStock.Utils;

namespace SmartStock.Forms.User_Control.AnalysisForms
{
    public partial class StockOptimization : UserControl, IAnalysisParameterControl
    {
        public StockOptimization()
        {
            InitializeComponent();
            InitializeDefaults();
            AddTooltips();
        }

        private void AddTooltips()
        {
            ToolTipHelp.AddToolTip(range_lbl, "Annual cost to hold one unit in stock, as a percentage of its unit price (H).");
            ToolTipHelp.AddToolTip(label_ordering, "Fixed cost incurred each time a purchase order is placed (S).");
            ToolTipHelp.AddToolTip(label1, "Days between placing an order and receiving it.");
            ToolTipHelp.AddToolTip(label2, "Service-level target. Lower risk tolerance raises safety stock and the reorder point.");
            label_ordering_unit.Text = SettingsManager.Current.CurrencySymbol;
        }

        public AnalysisContext GetParameters()
        {
            return new AnalysisContext
            {
                Parameters = new Dictionary<string, object>
                {
                    ["HoldingCostPercent"] = (decimal)buffer_nud.Value,
                    ["OrderingCost"]       = (decimal)ordering_cost_nud.Value,
                    ["LeadTimeDays"]       = (int)delivery_days_nud.Value,
                    ["RiskTolerance"]      = risk_cb.SelectedItem?.ToString() ?? "Medium"
                }
            };
        }

        public void Reset()
        {
            buffer_nud.Value        = 20;
            ordering_cost_nud.Value = 50;
            delivery_days_nud.Value = 7;
            risk_cb.SelectedIndex   = 1;
        }

        private void InitializeDefaults()
        {
            if (risk_cb.Items.Count == 0)
                risk_cb.Items.AddRange(new object[] { "Low", "Medium", "High" });

            // Holding cost % — typical range 15-30 % of unit price per year
            buffer_nud.Minimum = 1;
            buffer_nud.Maximum = 100;
            buffer_nud.Value   = 20;

            // Ordering cost S — fixed cost per purchase order placed
            ordering_cost_nud.Minimum   = 1;
            ordering_cost_nud.Maximum   = 100000;
            ordering_cost_nud.Value     = 50;
            ordering_cost_nud.DecimalPlaces = 2;

            delivery_days_nud.Minimum = 1;
            delivery_days_nud.Maximum = 365;
            delivery_days_nud.Value   = 7;

            if (risk_cb.Items.Count > 1)
                risk_cb.SelectedIndex = 1;
        }
    }
}
