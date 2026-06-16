
using LiveChartsCore;
using LiveChartsCore.Defaults;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using SmartStock.Classes.Data.DTOs;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Data.Repositories;
using SmartStock.Classes.Data.Services;
using SmartStock.Classes.Models;
using SmartStock.Classes.Settings;
using SmartStock.Classes.Utils;
using SmartStock.Forms.User_Control.AnalysisForms;

namespace SmartStock.Forms
{
    public partial class AnalyzeForm : Form
    {
        private readonly AnalyticsFacade _analyticsFacade;
        private readonly ProductService _productService;
        private readonly ExternalFactorService _externalFactorService;
        private readonly IExternalDataProvider _externalDataProvider;
        private IAnalysisParameterControl? _currentParameterControl;
        private UserControl? _currentParameterView;
        private CancellationTokenSource? _analysisCancellationTokenSource;
        private readonly CartesianChart _analysisChart;
        private Dictionary<int, AnomalyPoint> _anomalyLookup = new();
        private readonly SmartStockContext? _ownedAnalyticsContext;
        private readonly SmartStockContext? _ownedProductContext;
        private readonly SmartStockContext? _ownedFactorContext;
        private readonly ITextToSqlProvider? _textToSqlService;

        public AnalyzeForm()
        {
            InitializeComponent();

            _ownedAnalyticsContext = new SmartStockContext();
            _ownedProductContext = new SmartStockContext();
            _ownedFactorContext = new SmartStockContext();

            _analyticsFacade = CreateDefaultFacade(_ownedAnalyticsContext);
            _productService = CreateDefaultProductService(_ownedProductContext);
            _externalFactorService = CreateDefaultExternalFactorService(_ownedFactorContext);
            _externalDataProvider = CreateDefaultExternalDataProvider(_ownedFactorContext);
            _textToSqlService = CreateDefaultTextToSqlService();

            _analysisChart = CreateAnalysisChart();
            chart_pnl.Controls.Add(_analysisChart);

            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            Load += AnalyzeForm_Load;

            InitializeUi();
            ThemeManager.Apply(this);
            ApplyChartTheme();
        }

        public AnalyzeForm(AnalyticsFacade analyticsFacade, ProductService productService)
        {
            InitializeComponent();

            _ownedFactorContext = new SmartStockContext();

            _analyticsFacade = analyticsFacade ?? throw new ArgumentNullException(nameof(analyticsFacade));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _externalFactorService = CreateDefaultExternalFactorService(_ownedFactorContext);
            _externalDataProvider = CreateDefaultExternalDataProvider(_ownedFactorContext);
            _textToSqlService = CreateDefaultTextToSqlService();

            _analysisChart = CreateAnalysisChart();
            chart_pnl.Controls.Add(_analysisChart);

            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            Load += AnalyzeForm_Load;

            InitializeUi();
            ThemeManager.Apply(this);
            ApplyChartTheme();
        }

        public AnalyzeForm(AnalyticsFacade analyticsFacade, ProductService productService, ExternalFactorService externalFactorService)
        {
            InitializeComponent();

            _ownedFactorContext = new SmartStockContext();

            _analyticsFacade = analyticsFacade ?? throw new ArgumentNullException(nameof(analyticsFacade));
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _externalFactorService = externalFactorService ?? throw new ArgumentNullException(nameof(externalFactorService));
            _externalDataProvider = CreateDefaultExternalDataProvider(_ownedFactorContext);
            _textToSqlService = CreateDefaultTextToSqlService();

            _analysisChart = CreateAnalysisChart();
            chart_pnl.Controls.Add(_analysisChart);

            ThemeManager.OnThemeChanged += HandleThemeUpdate;
            Load += AnalyzeForm_Load;

            InitializeUi();
            ThemeManager.Apply(this);
            ApplyChartTheme();
        }

        private void InitializeUi()
        {
            analysis_type_cb.Items.Clear();
            analysis_type_cb.Items.AddRange(new object[]
            {
                "Demand Forecast",
                "Correlation Analysis",
                "Stock Optimization",
                "Natural Language Query",
                "Anomaly Detection"
            });

            analysis_type_cb.SelectedIndexChanged += analysis_type_cb_SelectedIndexChanged;

            var now = DateTime.Now.Date;
            start_date_dtp.Value = now.AddMonths(-6);
            end_date_dtp.Value = now;

            status_lbl.Text = "Ready";
            progressBar1.Visible = false;

            _ = LoadProductsAsync();

            if (analysis_type_cb.Items.Count > 0)
            {
                analysis_type_cb.SelectedIndex = 0;
            }
        }

        private async Task LoadProductsAsync()
        {
            var products = await _productService.GetAllActiveProductsAsync();
            target_subject_cb.DisplayMember = nameof(Product.ProductName);
            target_subject_cb.ValueMember = nameof(Product.ProductId);
            target_subject_cb.DataSource = products;
            target_subject_cb.SelectedIndex = products.Count > 0 ? 0 : -1;
        }

        private void analysis_type_cb_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadDynamicParameterControl(analysis_type_cb.SelectedIndex);
        }

        private void LoadDynamicParameterControl(int selectedIndex)
        {
            _currentParameterView?.Dispose();
            dynamic_params_pnl.Controls.Clear();

            var isNlq = selectedIndex == 3;
            groupBox1.Visible = !isNlq;
            query_results_gb.Visible = isNlq;

            label1.Visible = !isNlq;
            target_subject_cb.Visible = !isNlq;
            label2.Visible = !isNlq;
            end_date_lbl.Visible = !isNlq;
            start_date_dtp.Visible = !isNlq;
            end_date_dtp.Visible = !isNlq;

            _currentParameterView = selectedIndex switch
            {
                0 => new DemandForecast(_externalFactorService),
                1 => new CorrelationAnalysis(),
                2 => new StockOptimization(),
                3 => new LanguageQuery(),
                4 => new AnomalyDetection(),
                _ => null
            };

            if (_currentParameterView == null)
            {
                _currentParameterControl = null;
                return;
            }

            _currentParameterView.Dock = DockStyle.Fill;
            dynamic_params_pnl.Controls.Add(_currentParameterView);
            _currentParameterControl = _currentParameterView as IAnalysisParameterControl;
            ThemeManager.Apply(_currentParameterView);

            if (_currentParameterView is CorrelationAnalysis correlationControl)
            {
                _ = PopulatePrimaryFactorComboAsync(correlationControl);
            }
        }

        private async void AnalyzeForm_Load(object? sender, EventArgs e)
        {
            if (_currentParameterView is CorrelationAnalysis correlationControl)
            {
                await PopulatePrimaryFactorComboAsync(correlationControl);
            }
        }

        private async Task PopulatePrimaryFactorComboAsync(CorrelationAnalysis control)
        {
            try
            {
                var factorOptions = await _externalDataProvider.GetDistinctFactorOptionsAsync();
                control.SetPrimaryFactors(factorOptions);
            }
            catch
            {
                control.SetPrimaryFactors(Array.Empty<string>());
            }
        }

        private void HandleThemeUpdate()
        {
            ThemeManager.Apply(this);
            if (_currentParameterView != null)
            {
                ThemeManager.Apply(_currentParameterView);
                _currentParameterView.Refresh();
            }
            ApplyChartTheme();
            Refresh();
        }

        private async void run_btn_Click(object sender, EventArgs e)
        {
            if (_analysisCancellationTokenSource != null)
            {
                _analysisCancellationTokenSource.Cancel();
                return;
            }

            if (analysis_type_cb.SelectedIndex == 3)
            {
                await RunNaturalLanguageQueryAsync();
                return;
            }

            if (target_subject_cb.SelectedValue is not int productId)
            {
                MessageBox.Show("Please select a valid product.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var baseContext = _currentParameterControl?.GetParameters() ?? new AnalysisContext();
            baseContext.ProductId = productId;
            baseContext.AnalysisType = analysis_type_cb.SelectedItem?.ToString() ?? string.Empty;
            baseContext.StartDate = start_date_dtp.Value.Date;
            baseContext.EndDate = end_date_dtp.Value.Date;

            _analysisCancellationTokenSource = new CancellationTokenSource();
            SetBusyState(true, "Collecting data...");

            try
            {
                var result = await _analyticsFacade.RunAnalysisAsync(baseContext, _analysisCancellationTokenSource.Token);
                var isDemandForecast = baseContext.AnalysisType.Equals("Demand Forecast", StringComparison.OrdinalIgnoreCase);

                if (result.Eoq != null)
                {
                    SetEoqChartSeries(result.Eoq);
                    UpdateEoqBadges(result.Eoq);
                }
                else if (baseContext.AnalysisType.Equals("Anomaly Detection", StringComparison.OrdinalIgnoreCase))
                {
                    SetAnomalyChartSeries(result);
                    UpdateAnomalyBadges(result);
                }
                else if (baseContext.AnalysisType.Equals("Correlation Analysis", StringComparison.OrdinalIgnoreCase))
                {
                    UpdateChart(result.HistoricalSales, result.TrendValues, result.UpperBond, result.LowerBond, result.ChartLabels, isDemandForecast);
                    UpdateCorrelationBadges(result);
                }
                else
                {
                    UpdateChart(result.HistoricalSales, result.TrendValues, result.UpperBond, result.LowerBond, result.ChartLabels, isDemandForecast);
                    UpdateBadges(result);
                }

                ApplyMarkdownLikeFormatting(result.AiInsights);
                status_lbl.Text = isDemandForecast
                    ? $"Analysis complete · {result.ModelType}"
                    : "Analysis complete.";

                // Best-effort chart snapshot for the weekly report email attachment.
                _ = Task.Delay(1000).ContinueWith(_ => BeginInvoke(SaveChartSnapshot));
            }
            catch (OperationCanceledException)
            {
                status_lbl.Text = "Analysis cancelled.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Analysis failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status_lbl.Text = "Analysis failed.";
            }
            finally
            {
                SetBusyState(false, status_lbl.Text);
                _analysisCancellationTokenSource.Dispose();
                _analysisCancellationTokenSource = null;
            }
        }

        /// <summary>
        /// Saves a PNG snapshot of the current chart to Resources/last_chart.png.
        /// Called ~1 second after analysis completes so LiveCharts has time to render.
        /// Failures are silently swallowed — the snapshot is best-effort.
        /// </summary>
        private void SaveChartSnapshot()
        {
            try
            {
                if (_analysisChart.Width <= 0 || _analysisChart.Height <= 0) return;

                var bmp = new Bitmap(_analysisChart.Width, _analysisChart.Height);
                _analysisChart.DrawToBitmap(bmp, new Rectangle(0, 0, _analysisChart.Width, _analysisChart.Height));

                var snapshotPath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "Resources", "last_chart.png");
                bmp.Save(snapshotPath, System.Drawing.Imaging.ImageFormat.Png);
                bmp.Dispose();

                SmartStock.Classes.Utils.ReportScheduler.LastChartSnapshotPath = snapshotPath;
            }
            catch { /* best-effort — never crash the UI */ }
        }

        private void SetBusyState(bool isBusy, string status)
        {
            status_lbl.Text = status;
            progressBar1.Visible = isBusy;
            progressBar1.Style = isBusy ? ProgressBarStyle.Marquee : ProgressBarStyle.Continuous;

            run_btn.Text = isBusy ? "Cancel" : "Run Analysis";
            analysis_type_cb.Enabled = !isBusy;
            target_subject_cb.Enabled = !isBusy;
            start_date_dtp.Enabled = !isBusy;
            end_date_dtp.Enabled = !isBusy;
            reset_btn.Enabled = !isBusy;
        }

        private void UpdateChart(
            List<decimal> historicalSales,
            List<decimal> trendValues,
            List<decimal> upperBound,
            List<decimal> lowerBound,
            List<string>? labels,
            bool isDemandForecast)
        {
            SetChartSeries(
                historicalSales.Select(x => (double)x).ToArray(),
                trendValues.Select(x => (double)x).ToArray(),
                upperBound.Select(x => (double)x).ToArray(),
                lowerBound.Select(x => (double)x).ToArray(),
                labels ?? new List<string>(),
                isDemandForecast);
        }

        private void UpdateBadges(AnalyticsResult result)
        {
            label5.Text = "Reliability (R²)";
            label4.Text = "Sales Trend (%)";
            label6.Text = "AI Confidence";

            // result.Reliability reflectă modelul EFECTIV folosit (multivariat sau univariat),
            // fără a depinde de RSquared-ul persistat din EconometricModel.
            var rSquared = result.Reliability;
            reliability_lbl.Text = $"{rSquared:F3}";
            trend_lbl.Text = result.TrendLabel;
            confidence_lbl.Text = $"{result.AiConfidence:P0}";

            ApplyBadgeColors(rSquared, result.TrendLabel, result.AiConfidence);
        }

        /// <summary>
        /// Badge-uri pentru Correlation Analysis: corelația Pearson (aliniată pe dată),
        /// semnificația statistică (p-value) și mărimea eșantionului.
        /// </summary>
        private void UpdateCorrelationBadges(AnalyticsResult result)
        {
            label5.Text = "Correlation (r)";
            label4.Text = "Significance (p)";
            label6.Text = "Sample Size (n)";

            var r = result.Correlation;
            var p = result.CorrelationPValue;

            reliability_lbl.Text = $"{r:F3}";
            confidence_lbl.Text = result.CorrelationSampleSize.ToString();

            // Forța corelației (|r|): codare culoare după convenția uzuală.
            var absR = Math.Abs(r);
            reliability_lbl.ForeColor = absR < 0.2m ? Color.Red
                : absR < 0.4m ? Color.Orange
                : absR < 0.6m ? Color.Gold
                : Color.LimeGreen;

            // Semnificația: verde dacă p < 0.05 (corelație reală), altfel roșu.
            if (result.CorrelationSampleSize < 3)
            {
                trend_lbl.Text = "n/a";
                trend_lbl.ForeColor = Color.Orange;
            }
            else
            {
                // p≈0 e corect (corelație foarte semnificativă), dar "0.000" induce în eroare;
                // afișăm "<0.001" ca să se citească drept „înalt semnificativ", nu „zero".
                trend_lbl.Text = p < 0.001m ? "<0.001" : $"{p:F3}";
                trend_lbl.ForeColor = p < 0.05m ? Color.LimeGreen
                    : p < 0.10m ? Color.Gold
                    : Color.Red;
            }

            confidence_lbl.ForeColor = result.CorrelationSampleSize >= 4 ? Color.LimeGreen : Color.Orange;
        }

        private void ApplyMarkdownLikeFormatting(string markdown)
        {
            ai_insights_rtb.Clear();

            var normalized = (markdown ?? string.Empty)
                .Replace("###", string.Empty)
                .Replace("##", string.Empty)
                .Replace("**", string.Empty)
                .Replace("- ", "• ");

            ai_insights_rtb.Text = normalized;
        }

        private void reset_btn_Click(object sender, EventArgs e)
        {
            if (analysis_type_cb.SelectedIndex == 3)
            {
                _currentParameterControl?.Reset();
                query_dgv.DataSource = null;
                status_lbl.Text = "Ready";
                return;
            }

            // Reset only the PARAMETERS — keep the user on the analysis module they chose.
            // (Previously this forced SelectedIndex=0, snapping back to Demand Forecast.)
            target_subject_cb.SelectedIndex = target_subject_cb.Items.Count > 0 ? 0 : -1;

            var now = DateTime.Now.Date;
            start_date_dtp.Value = now.AddMonths(-6);
            end_date_dtp.Value = now;

            _currentParameterControl?.Reset();

            SetChartSeries(Array.Empty<double>(), Array.Empty<double>(), Array.Empty<double>(), Array.Empty<double>(), new List<string>(), true);
            ai_insights_rtb.Clear();

            // Restore badge labels to their default (time-series) meaning
            label5.Text = "Reliability (R²)";
            label4.Text = "Sales Trend (%)";
            label6.Text = "AI Confidence";

            status_lbl.Text = "Ready";
            trend_lbl.Text = "0";
            reliability_lbl.Text = "0.000";
            confidence_lbl.Text = "0";
            reliability_lbl.ForeColor = Color.White;
            trend_lbl.ForeColor = Color.White;
            confidence_lbl.ForeColor = Color.White;
        }

        private static AnalyticsFacade CreateDefaultFacade(SmartStockContext context)
        {
            var econometricEngine = new EconometricEngine(
                new GenericRepository<SaleDetails>(context),
                new GenericRepository<ExternalFactor>(context));

            var externalDataProvider = new ExternalDataProvider(
                new GenericRepository<ExternalFactor>(context));

            // Key is resolved at call time inside DeepSeekAiProvider.ResolveApiKey(),
            // so this works even when the form is opened before the key is saved in Settings.
            IAIReasoningProvider aiReasoningProvider = new DeepSeekAiProvider(new HttpClient());

            var promptBuilder = new PromptBuilder();

            return new AnalyticsFacade(
                econometricEngine,
                externalDataProvider,
                aiReasoningProvider,
                promptBuilder,
                new GenericRepository<SaleDetails>(context),
                new GenericRepository<AiForecast>(context),
                new GenericRepository<Product>(context),
                new GenericRepository<EconometricModel>(context),
                new GenericRepository<AiStockRecommendation>(context));
        }

        private static ProductService CreateDefaultProductService(SmartStockContext context)
        {
            return new ProductService(new GenericRepository<Product>(context));
        }

        private static ExternalFactorService CreateDefaultExternalFactorService(SmartStockContext context)
        {
            return new ExternalFactorService(
                new GenericRepository<ExternalFactor>(context));
        }

        private static IExternalDataProvider CreateDefaultExternalDataProvider(SmartStockContext context)
        {
            return new ExternalDataProvider(new GenericRepository<ExternalFactor>(context));
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            ThemeManager.OnThemeChanged -= HandleThemeUpdate;
            _analysisCancellationTokenSource?.Dispose();
            _ownedAnalyticsContext?.Dispose();
            _ownedProductContext?.Dispose();
            _ownedFactorContext?.Dispose();
            base.OnFormClosed(e);
        }

        private async Task RunNaturalLanguageQueryAsync()
        {
            if (_textToSqlService == null)
            {
                MessageBox.Show(
                    "Natural Language Query requires a valid DeepSeek API key.\nPlease configure it in Settings.",
                    "API Key Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nlQuery = string.Empty;
            var parameters = _currentParameterControl?.GetParameters().Parameters;
            if (parameters != null && parameters.TryGetValue("NaturalLanguageQuery", out var q))
                nlQuery = q?.ToString() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(nlQuery))
            {
                MessageBox.Show("Please enter a natural language query.", "Input Required",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _analysisCancellationTokenSource = new CancellationTokenSource();
            SetBusyState(true, "Generating SQL...");

            try
            {
                var sql = await _textToSqlService.GenerateSqlAsync(nlQuery, _analysisCancellationTokenSource.Token);
                status_lbl.Text = "Executing query...";
                var dataTable = await _textToSqlService.ExecuteQueryAsync(sql, _analysisCancellationTokenSource.Token);
                query_dgv.DataSource = dataTable;
                status_lbl.Text = $"Query returned {dataTable.Rows.Count} row(s).";
            }
            catch (OperationCanceledException)
            {
                status_lbl.Text = "Query cancelled.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Query failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status_lbl.Text = "Query failed.";
            }
            finally
            {
                SetBusyState(false, status_lbl.Text);
                _analysisCancellationTokenSource?.Dispose();
                _analysisCancellationTokenSource = null;
            }
        }

        private static ITextToSqlProvider? CreateDefaultTextToSqlService()
        {
            try
            {
                var apiKey = SettingsManager.Current.DeepSeekApiKey;
                if (string.IsNullOrWhiteSpace(apiKey))
                    return null;
                return new TextToSqlService(new HttpClient(), apiKey);
            }
            catch
            {
                return null;
            }
        }

        private static CartesianChart CreateAnalysisChart()
        {
            var chart = new CartesianChart
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(54, 54, 54)
            };

            SetEnumPropertyByName(chart, "LegendPosition", "Right");
            SetEnumPropertyByName(chart, "TooltipPosition", "Top");

            return chart;
        }

        private void ApplyChartTheme()
        {
            var palette = ThemeManager.GetCurrentPalette();
            var textColor = new SKColor(palette.TextPrimary.R, palette.TextPrimary.G, palette.TextPrimary.B);
            var bgColor   = new SKColor(palette.Surface.R, palette.Surface.G, palette.Surface.B);

            var chartType = _analysisChart.GetType();
            chartType.GetProperty("LegendTextPaint")?.SetValue(_analysisChart, new SolidColorPaint(textColor));
            chartType.GetProperty("LegendBackgroundPaint")?.SetValue(_analysisChart, new SolidColorPaint(bgColor));
            _analysisChart.Invalidate();
        }

        private void SetChartSeries(double[] historicalValues, double[] trendValues, double[] upperValues, double[] lowerValues, List<string> labels, bool isDemandForecast)
        {
            var seriesProperty = _analysisChart.GetType().GetProperty("Series");
            if (seriesProperty == null)
                return;

            var lineSeriesType = typeof(LineSeries<double>);
            var seriesArray = Array.CreateInstance(lineSeriesType, isDemandForecast ? 4 : 2);
            seriesArray.SetValue(new LineSeries<double>
            {
                Name = "Daily Sales Total",
                Fill = null,
                GeometrySize = 6,
                Stroke = new SolidColorPaint(SKColors.SkyBlue) { StrokeThickness = 3 },
                Values = historicalValues
            }, 0);

            if (!isDemandForecast)
            {
                seriesArray.SetValue(new LineSeries<double>
                {
                    Name = "Trend",
                    GeometrySize = 0,
                    Fill = null,
                    Stroke = new SolidColorPaint(SKColors.MediumPurple) { StrokeThickness = 3 },
                    Values = trendValues
                }, 1);
            }

            if (isDemandForecast)
            {
                seriesArray.SetValue(new LineSeries<double>
                {
                    Name = "Forecasted Trend",
                    GeometrySize = 0,
                    Fill = new SolidColorPaint(new SKColor(255, 165, 0, 60)),
                    Stroke = new SolidColorPaint(SKColors.Orange) { StrokeThickness = 3 },
                    Values = trendValues
                }, 1);
                seriesArray.SetValue(new LineSeries<double>
                {
                    Name = "Upper CI",
                    GeometrySize = 0,
                    Fill = null,
                    Stroke = new SolidColorPaint(new SKColor(255, 99, 71, 180)) { StrokeThickness = 1.5f },
                    Values = upperValues
                }, 2);
                seriesArray.SetValue(new LineSeries<double>
                {
                    Name = "Lower CI",
                    GeometrySize = 0,
                    Fill = null,
                    Stroke = new SolidColorPaint(new SKColor(255, 99, 71, 180)) { StrokeThickness = 1.5f },
                    Values = lowerValues
                }, 3);
            }

            seriesProperty.SetValue(_analysisChart, seriesArray);

            ConfigureAxes(labels);
        }

        private void ApplyBadgeColors(decimal rSquared, string trendLabel, decimal aiConfidence)
        {
            reliability_lbl.ForeColor = GetLevelColorByReliability(rSquared);
            trend_lbl.ForeColor = GetLevelColorByTrend(trendLabel);
            confidence_lbl.ForeColor = GetLevelColorByConfidence(aiConfidence);
        }

        private static Color GetLevelColorByReliability(decimal rSquared)
        {
            if (rSquared < 0.25m) return Color.Red;
            if (rSquared < 0.5m) return Color.Orange;
            if (rSquared < 0.75m) return Color.Gold;
            return Color.LimeGreen;
        }

        private static Color GetLevelColorByTrend(string trendLabel)
        {
            if (string.IsNullOrWhiteSpace(trendLabel))
                return Color.Gold;

            var numeric = trendLabel.Replace("%", string.Empty).Replace("+", string.Empty).Trim();
            if (!decimal.TryParse(numeric, out var trendPercent))
                return Color.Gold;

            if (trendPercent < -10m) return Color.Red;
            if (trendPercent < 0m) return Color.Orange;
            if (trendPercent < 5m) return Color.Gold;
            return Color.LimeGreen;
        }

        private static Color GetLevelColorByConfidence(decimal aiConfidence)
        {
            if (aiConfidence < 0.4m) return Color.Red;
            if (aiConfidence < 0.6m) return Color.Orange;
            if (aiConfidence < 0.8m) return Color.Gold;
            return Color.LimeGreen;
        }

        private void ConfigureAxes(List<string> labels)
        {
            var xAxesProperty = _analysisChart.GetType().GetProperty("XAxes");
            var yAxesProperty = _analysisChart.GetType().GetProperty("YAxes");

            if (xAxesProperty != null)
            {
                var xAxis = new Axis
                {
                    Name = "Date",
                    Labels = labels,
                    LabelsRotation = 15
                };

                var xAxisArray = Array.CreateInstance(typeof(Axis), 1);
                xAxisArray.SetValue(xAxis, 0);
                xAxesProperty.SetValue(_analysisChart, xAxisArray);
            }

            if (yAxesProperty != null)
            {
                var yAxis = new Axis
                {
                    Name = "Sales Quantity"
                };

                var yAxisArray = Array.CreateInstance(typeof(Axis), 1);
                yAxisArray.SetValue(yAxis, 0);
                yAxesProperty.SetValue(_analysisChart, yAxisArray);
            }
        }

        private static void SetEnumPropertyByName(object target, string propertyName, string enumValueName)
        {
            var property = target.GetType().GetProperty(propertyName);
            if (property?.PropertyType.IsEnum != true)
                return;

            if (Enum.TryParse(property.PropertyType, enumValueName, true, out var parsed))
            {
                property.SetValue(target, parsed);
            }
        }

        // ── Anomaly Detection chart & badges ─────────────────────────────────────

        private void SetAnomalyChartSeries(AnalyticsResult result)
        {
            var seriesProperty = _analysisChart.GetType().GetProperty("Series");
            if (seriesProperty == null) return;

            _anomalyLookup = result.Anomalies.ToDictionary(a => a.DataIndex);

            var salesValues = result.HistoricalSales.Select(x => (double)x).ToArray();
            var meanValues = result.TrendValues.Select(x => (double)x).ToArray();
            var upperValues = result.UpperBond.Select(x => (double)x).ToArray();
            var lowerValues = result.LowerBond.Select(x => (double)x).ToArray();

            var anomalyPoints = result.Anomalies
                .Select(a => new ObservablePoint(a.DataIndex, (double)a.ActualValue))
                .ToArray();

            var lookup = _anomalyLookup;
            var series = new ISeries[]
            {
                new LineSeries<double>
                {
                    Name        = "Daily Sales",
                    Fill        = null,
                    GeometrySize = 4,
                    Stroke      = new SolidColorPaint(SKColors.SteelBlue) { StrokeThickness = 2 },
                    Values      = salesValues
                },
                new LineSeries<double>
                {
                    Name        = $"Mean ({meanValues.FirstOrDefault():F1})",
                    Fill        = null,
                    GeometrySize = 0,
                    Stroke      = new SolidColorPaint(new SKColor(200, 200, 200, 200)) { StrokeThickness = 1.5f },
                    Values      = meanValues
                },
                new LineSeries<double>
                {
                    Name        = "Upper Tolerance",
                    Fill        = new SolidColorPaint(new SKColor(255, 165, 0, 35)),
                    GeometrySize = 0,
                    Stroke      = new SolidColorPaint(new SKColor(255, 165, 0, 200)) { StrokeThickness = 1.5f },
                    Values      = upperValues
                },
                new LineSeries<double>
                {
                    Name        = "Lower Tolerance",
                    Fill        = null,
                    GeometrySize = 0,
                    Stroke      = new SolidColorPaint(new SKColor(255, 165, 0, 200)) { StrokeThickness = 1.5f },
                    Values      = lowerValues
                },
                new ScatterSeries<ObservablePoint>
                {
                    Name        = "Anomaly",
                    Fill        = new SolidColorPaint(SKColors.Red),
                    Stroke      = new SolidColorPaint(SKColors.DarkRed) { StrokeThickness = 2 },
                    GeometrySize = 16,
                    Values      = anomalyPoints,
                    YToolTipLabelFormatter = point =>
                    {
                        var idx = (int)Math.Round(point.Model?.X ?? 0);
                        if (!lookup.TryGetValue(idx, out var a))
                            return $"Value: {point.Model?.Y:F0} units";

                        var direction = a.ZScore > 0 ? "Spike" : "Drop";
                        return $"[{direction}] {a.Date:dd/MM/yyyy} | " +
                               $"Actual: {a.ActualValue:F0}  Expected: {a.ExpectedValue:F0}  " +
                               $"Z={a.ZScore:+0.00;-0.00}";
                    }
                }
            };

            seriesProperty.SetValue(_analysisChart, series);
            ConfigureAxes(result.ChartLabels);
        }

        private void UpdateAnomalyBadges(AnalyticsResult result)
        {
            label5.Text = "Anomalies";
            label4.Text = "Max Z-Score";
            label6.Text = "Anomaly Rate";

            var totalPoints = result.HistoricalSales.Count;
            var anomalyRate = totalPoints > 0
                ? (decimal)result.Anomalies.Count / totalPoints * 100m
                : 0m;
            var maxZ = result.MaxSeverityZScore;

            reliability_lbl.Text = result.Anomalies.Count.ToString();
            trend_lbl.Text = maxZ > 0 ? $"{maxZ:F1}" : "0.0";
            confidence_lbl.Text = $"{anomalyRate:F1}%";

            reliability_lbl.ForeColor = result.Anomalies.Count == 0 ? Color.LimeGreen
                : result.Anomalies.Count <= 2 ? Color.Orange : Color.Red;

            trend_lbl.ForeColor = maxZ < 2.5m ? Color.Orange
                : maxZ < 3.0m ? Color.OrangeRed : Color.Red;

            confidence_lbl.ForeColor = anomalyRate < 5m ? Color.LimeGreen
                : anomalyRate < 15m ? Color.Orange : Color.Red;
        }

        // ── EOQ chart & badges ────────────────────────────────────────────────────

        /// <summary>
        /// Renderizează curba de cost EOQ: Total Cost (U-shaped), Ordering Cost
        /// (descrescătoare) și Holding Cost (crescătoare). Minimul costului total
        /// corespunde vizual cu intersecția celor două componente — adică Q*.
        /// </summary>
        private void SetEoqChartSeries(EoqResult eoq)
        {
            var seriesProperty = _analysisChart.GetType().GetProperty("Series");
            if (seriesProperty == null) return;

            var seriesArray = Array.CreateInstance(typeof(LineSeries<double>), 3);

            seriesArray.SetValue(new LineSeries<double>
            {
                Name = $"Total Annual Cost (min @ Q*={eoq.EoqQuantity:F0})",
                Fill = null,
                GeometrySize = 0,
                Stroke = new SolidColorPaint(SKColors.SkyBlue) { StrokeThickness = 3 },
                Values = eoq.TotalCostCurve.ToArray()
            }, 0);

            seriesArray.SetValue(new LineSeries<double>
            {
                Name = "Ordering Cost  (D/Q) × S",
                Fill = null,
                GeometrySize = 0,
                Stroke = new SolidColorPaint(SKColors.Orange) { StrokeThickness = 2 },
                Values = eoq.OrderingCostCurve.ToArray()
            }, 1);

            seriesArray.SetValue(new LineSeries<double>
            {
                Name = "Holding Cost  (Q/2 + SS) × H",
                Fill = null,
                GeometrySize = 0,
                Stroke = new SolidColorPaint(SKColors.MediumPurple) { StrokeThickness = 2 },
                Values = eoq.HoldingCostCurve.ToArray()
            }, 2);

            seriesProperty.SetValue(_analysisChart, seriesArray);

            var xAxesProperty = _analysisChart.GetType().GetProperty("XAxes");
            var yAxesProperty = _analysisChart.GetType().GetProperty("YAxes");

            if (xAxesProperty != null)
            {
                var xAxis = new Axis
                {
                    Name = "Order Quantity (units)",
                    Labels = eoq.QuantityLabels,
                    LabelsRotation = 45
                };
                var arr = Array.CreateInstance(typeof(Axis), 1);
                arr.SetValue(xAxis, 0);
                xAxesProperty.SetValue(_analysisChart, arr);
            }

            if (yAxesProperty != null)
            {
                var yAxis = new Axis { Name = "Annual Cost" };
                var arr = Array.CreateInstance(typeof(Axis), 1);
                arr.SetValue(yAxis, 0);
                yAxesProperty.SetValue(_analysisChart, arr);
            }
        }

        /// <summary>
        /// Repurposes the three stat badges for EOQ mode:
        ///   Reliability → Service Level
        ///   Trend       → EOQ Quantity (Q*)
        ///   Confidence  → Reorder Point (ROP)
        /// </summary>
        private void UpdateEoqBadges(EoqResult eoq)
        {
            label5.Text = "Service Level";
            label4.Text = "EOQ Qty (Q*)";
            label6.Text = "Reorder Point";

            reliability_lbl.Text = $"{eoq.ServiceLevel:P0}";
            trend_lbl.Text = $"{eoq.EoqQuantity:F0}";
            confidence_lbl.Text = $"{eoq.ReorderPoint:F0}";

            reliability_lbl.ForeColor = Color.LimeGreen;
            trend_lbl.ForeColor = Color.LimeGreen;
            confidence_lbl.ForeColor = Color.LimeGreen;
        }
    }
}
