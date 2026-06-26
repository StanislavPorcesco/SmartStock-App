using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Models;
using SmartStock.Utils;

namespace SmartStock.Forms.User_Control.AnalysisForms
{
    public partial class DemandForecast : UserControl, IAnalysisParameterControl
    {
        private readonly ExternalFactorService _externalFactorService;

        public DemandForecast() : this(CreateDefaultExternalFactorService())
        {
        }

        public DemandForecast(ExternalFactorService externalFactorService)
        {
            InitializeComponent();
            _externalFactorService = externalFactorService ?? throw new ArgumentNullException(nameof(externalFactorService));
            InitializeDefaults();
            AddTooltips();
            _ = LoadFactorsAsync();
        }

        private void AddTooltips()
        {
            ToolTipHelp.AddToolTip(range_lbl, "Number of future days to project demand for (1–365).");
            ToolTipHelp.AddToolTip(label1, "Optional external factors to condition the forecast on. Selecting factors switches to a multivariate model (sales ~ factors).");
            ToolTipHelp.AddToolTip(label2, "Confidence level for the forecast band — higher values widen the prediction interval.");
        }

        public AnalysisContext GetParameters()
        {
            var selectedFactors = factors_clb.CheckedItems
                .Cast<object>()
                .Select(item => item.ToString() ?? string.Empty)
                .Where(v => !string.IsNullOrWhiteSpace(v))
                .ToList();

            return new AnalysisContext
            {
                Parameters = new Dictionary<string, object>
                {
                    ["ForecastHorizonDays"] = (int)horizon_nud.Value,
                    ["SelectedFactors"] = selectedFactors,
                    ["ConfidencePercent"] = confidence_tb.Value
                }
            };
        }

        public void Reset()
        {
            horizon_nud.Value = 30;
            confidence_tb.Value = 80;
            for (var i = 0; i < factors_clb.Items.Count; i++)
            {
                factors_clb.SetItemChecked(i, false);
            }
        }

        private void InitializeDefaults()
        {
            SetFallbackFactorItemsIfEmpty();

            horizon_nud.Minimum = 1;
            horizon_nud.Maximum = 365;
            horizon_nud.Value = 30;

            confidence_tb.Minimum = 0;
            confidence_tb.Maximum = 100;
            confidence_tb.Value = 80;
            confidence_tb.TickFrequency = 10;
        }

        private async Task LoadFactorsAsync()
        {
            try
            {
                var factors = await _externalFactorService.GetAllActiveAsync();
                var factorItems = factors
                    .Select(f => string.IsNullOrWhiteSpace(f.Description) ? f.FactorType : f.Description)
                    .Where(v => !string.IsNullOrWhiteSpace(v))
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .OrderBy(v => v)
                    .ToArray();

                factors_clb.Items.Clear();
                if (factorItems.Length > 0)
                {
                    factors_clb.Items.AddRange(factorItems);
                    return;
                }
            }
            catch
            {
                // fallback below
            }

            SetFallbackFactorItemsIfEmpty();
        }

        private void SetFallbackFactorItemsIfEmpty()
        {
            if (factors_clb.Items.Count == 0)
            {
                factors_clb.Items.AddRange(new object[] { "Economic", "Weather", "Social", "Market" });
            }
        }

        private static ExternalFactorService CreateDefaultExternalFactorService()
        {
            return new ExternalFactorService(
                new GenericRepository<ExternalFactor>(new SmartStockContext()));
        }
    }
}
