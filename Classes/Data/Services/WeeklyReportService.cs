using Microsoft.EntityFrameworkCore;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;
using SmartStock.Classes.Settings;
using SmartStock.Classes.Utils;
using System.Net.Http;
using System.Text;

namespace SmartStock.Classes.Data.Services
{
    /// <summary>
    /// Builds the HTML content for the automated weekly report email.
    /// Queries the database directly for: sales snapshot, anomaly alerts,
    /// critical stock forecasts, and top EOQ-based recommendations.
    ///
    /// The Action Plan is generated live by the AI agent when a key is configured and
    /// the provider responds; otherwise it falls back to recent saved recommendations.
    /// </summary>
    public class WeeklyReportService
    {
        // Fallback: only show saved recommendations newer than this when the agent is unavailable.
        private const int FallbackMaxAgeDays = 14;
        // How many at-risk products the live Action Plan covers (one AI call each).
        private const int ActionPlanTopN = 3;

        private readonly IAIReasoningProvider _aiProvider;
        private readonly ILLMPromptBuilder _promptBuilder;

        /// <summary>
        /// Defaults to the live DeepSeek provider + prompt builder (key resolved at call time),
        /// matching the wiring in AnalyzeForm. Both are injectable for testing.
        /// </summary>
        public WeeklyReportService(
            IAIReasoningProvider? aiProvider = null,
            ILLMPromptBuilder? promptBuilder = null)
        {
            _aiProvider    = aiProvider    ?? new DeepSeekAiProvider(new HttpClient());
            _promptBuilder = promptBuilder ?? new PromptBuilder();
        }

        // A render-ready row, decoupled from EF navigation so the live and DB paths share rendering.
        private sealed record ActionItem(
            string ProductName,
            string PriorityLevel,
            int SuggestedQuantity,
            string Reasoning,
            DateTime CreatedAt);

        // ── Public entry point ────────────────────────────────────────────────

        public async Task<string> BuildReportHtmlAsync()
        {
            using var context = new SmartStockContext();
            var now = DateTime.Now;

            var salesBlock     = await BuildSalesSnapshotBlockAsync(context, now);
            var alertsBlock    = await BuildInventoryAlertsBlockAsync(context, now);
            var actionBlock    = await BuildActionPlanBlockAsync(context, now);

            return AssembleHtml(salesBlock, alertsBlock, actionBlock, now);
        }

        // ── Sales Snapshot ────────────────────────────────────────────────────

        private static async Task<string> BuildSalesSnapshotBlockAsync(SmartStockContext ctx, DateTime now)
        {
            // Week boundaries: Monday 00:00 → Sunday 23:59
            int daysFromMon   = ((int)now.DayOfWeek - (int)DayOfWeek.Monday + 7) % 7;
            var thisWeekStart = now.Date.AddDays(-daysFromMon);
            var lastWeekStart = thisWeekStart.AddDays(-7);
            var lastWeekEnd   = thisWeekStart.AddTicks(-1);

            // Fetch raw rows first — SQLite EF provider can't apply Sum over decimal columns
            var thisWeekRows = await ctx.SaleDetails
                .Include(sd => sd.Sale)
                .Where(sd => sd.Sale.SaleDate >= thisWeekStart && sd.Sale.SaleDate <= now)
                .Select(sd => new { sd.Quantity, sd.UnitPrice })
                .ToListAsync();

            var lastWeekRows = await ctx.SaleDetails
                .Include(sd => sd.Sale)
                .Where(sd => sd.Sale.SaleDate >= lastWeekStart && sd.Sale.SaleDate <= lastWeekEnd)
                .Select(sd => new { sd.Quantity })
                .ToListAsync();

            // Aggregate on the client — no SQLite type restrictions here
            decimal thisWeekUnits   = thisWeekRows.Sum(r => r.Quantity);
            decimal lastWeekUnits   = lastWeekRows.Sum(r => r.Quantity);
            decimal thisWeekRevenue = thisWeekRows.Sum(r => r.Quantity * r.UnitPrice);

            decimal changePct = lastWeekUnits > 0
                ? Math.Round((thisWeekUnits - lastWeekUnits) / lastWeekUnits * 100m, 1)
                : 0m;

            string currency   = SmartStock.Classes.Settings.SettingsManager.Current.CurrencySymbol;
            bool isUp         = changePct >= 0;
            string arrowHtml  = isUp
                ? "<span style='color:#4CAF50'>&#x2191;</span>"
                : "<span style='color:#f44336'>&#x2193;</span>";
            string changeCss  = isUp ? "color:#4CAF50" : "color:#f44336";

            return $@"
<div class='section'>
  <h2>Sales Snapshot</h2>
  <table role='presentation' width='100%' cellspacing='0' cellpadding='0' class='stat-table'>
    <tr>
      <td width='23.5%' class='stat-box'>
        <div class='value'>{thisWeekUnits:N0}</div>
        <div class='label'>This Week (units sold)</div>
      </td>
      <td width='2%'></td>
      <td width='23.5%' class='stat-box'>
        <div class='value'>{lastWeekUnits:N0}</div>
        <div class='label'>Last Week (units sold)</div>
      </td>
      <td width='2%'></td>
      <td width='23.5%' class='stat-box'>
        <div class='value' style='{changeCss}'>{arrowHtml} {Math.Abs(changePct)}%</div>
        <div class='label'>Week-over-Week Change</div>
      </td>
      <td width='2%'></td>
      <td width='23.5%' class='stat-box'>
        <div class='value' style='color:#64B5F6; font-size:19px'>{currency}{thisWeekRevenue:N2}</div>
        <div class='label'>This Week Revenue</div>
      </td>
    </tr>
  </table>
</div>";
        }

        // ── Inventory Alerts ──────────────────────────────────────────────────
        // Purely statistical: Z-score sales anomalies + forecast-vs-safety-stock projections.
        // No LLM/AI involved despite living next to the AI-generated Action Plan.

        private static async Task<string> BuildInventoryAlertsBlockAsync(SmartStockContext ctx, DateTime now)
        {
            var anomalyItems   = await BuildAnomalyItemsAsync(ctx, now);
            var criticalItems  = await BuildCriticalStockItemsAsync(ctx, now);

            bool hasAlerts = anomalyItems.Length > 0 || criticalItems.Length > 0;
            string content = hasAlerts
                ? anomalyItems + criticalItems
                : "<p class='no-data'>No alerts detected for this period.</p>";

            return $@"
<div class='section'>
  <h2>Inventory Alerts</h2>
  {content}
</div>";
        }

        /// Detects Z-score anomalies (last 30 days aggregated daily, per product)
        /// and returns those that occurred within the last 24 hours.
        private static async Task<string> BuildAnomalyItemsAsync(SmartStockContext ctx, DateTime now)
        {
            var cutoff24h     = now.AddHours(-24);
            var historyCutoff = now.Date.AddDays(-30);

            // Fetch raw rows then group client-side — SQLite can't handle .Date in server-side GroupBy
            var rawRows = await ctx.SaleDetails
                .Include(sd => sd.Sale)
                .Where(sd => sd.Sale.SaleDate >= historyCutoff && sd.Sale.SaleDate <= now)
                .Select(sd => new { sd.ProductId, SaleDate = sd.Sale.SaleDate, sd.Quantity })
                .ToListAsync();

            // Daily aggregation per product (LINQ to Objects — no DB constraints)
            var dailySales = rawRows
                .GroupBy(r => new { r.ProductId, Date = r.SaleDate.Date })
                .Select(g => new
                {
                    g.Key.ProductId,
                    g.Key.Date,
                    Total = g.Sum(x => x.Quantity)
                })
                .ToList();

            // Group by product and compute Z-scores
            var sb = new StringBuilder();
            foreach (var productGroup in dailySales.GroupBy(x => x.ProductId))
            {
                var series = productGroup.OrderBy(x => x.Date).ToList();
                if (series.Count < 3) continue;

                var values  = series.Select(x => (double)x.Total).ToList();
                var mean    = values.Average();
                var variance = values.Sum(v => (v - mean) * (v - mean)) / Math.Max(1, values.Count - 1);
                var stdDev  = Math.Sqrt(variance);
                if (stdDev <= 0) continue;

                foreach (var point in series.Where(p => p.Date >= cutoff24h.Date))
                {
                    double z = ((double)point.Total - mean) / stdDev;
                    if (Math.Abs(z) < 2.0) continue;

                    var product = await ctx.Products
                        .AsNoTracking()
                        .FirstOrDefaultAsync(p => p.ProductId == productGroup.Key);

                    string name = product?.ProductName ?? $"Product #{productGroup.Key}";
                    string dir = z > 0
                        ? $"spike (+{(point.Total - mean) / mean * 100:F0}% vs. avg)"
                        : $"drop ({(point.Total - mean) / mean * 100:F0}% vs. avg)";

                    sb.Append($@"
<div class='alert-item anomaly'>
  <div class='alert-header'>
    <strong style='color:#FF9800'>{name}</strong>
    <span class='badge badge-anomaly'>Z={z:F2}</span>
  </div>
  <div class='alert-date'>{point.Date:dd MMM yyyy}</div>
  <div class='alert-desc'>Unusual sales {dir}. Sold: {point.Total} units (avg: {mean:F1}).</div>
</div>");
                }
            }

            return sb.ToString();
        }

        /// Products whose forecasted demand for the next 3 days will push stock below SafetyStock.
        private static async Task<string> BuildCriticalStockItemsAsync(SmartStockContext ctx, DateTime now)
        {
            var forecastEnd = now.Date.AddDays(3);

            var products = await ctx.Products
                .Where(p => p.IsActive)
                .AsNoTracking()
                .ToListAsync();

            var forecasts = await ctx.AiForecasts
                .Where(f => f.ForecastDate >= now.Date && f.ForecastDate <= forecastEnd)
                .AsNoTracking()
                .ToListAsync();

            var sb = new StringBuilder();
            foreach (var product in products)
            {
                decimal forecast3Days = forecasts
                    .Where(f => f.ProductId == product.ProductId)
                    .Sum(f => f.PredictedDemand);

                decimal projectedStock = product.CurrentStock - forecast3Days;
                if (projectedStock >= product.SafetyStock) continue;

                string urgency   = projectedStock <= 0 ? "STOCKOUT" : "CRITICAL";
                string badgeCss  = projectedStock <= 0 ? "badge-high" : "badge-medium";
                string borderCss = projectedStock <= 0 ? "border-left-color:#f44336" : "border-left-color:#FF9800";

                sb.Append($@"
<div class='alert-item' style='{borderCss}'>
  <div class='alert-header'>
    <strong style='color:#fff'>{product.ProductName}</strong>
    <span class='badge {badgeCss}'>{urgency}</span>
  </div>
  <div class='alert-date'>Projected in 3 days</div>
  <div class='alert-desc'>
    Current stock: <strong>{product.CurrentStock}</strong> |
    Forecasted demand: <strong>{forecast3Days:F0}</strong> |
    Projected: <strong>{projectedStock:F0}</strong> (Safety: {product.SafetyStock})
  </div>
</div>");
            }

            return sb.ToString();
        }

        // ── Action Plan ───────────────────────────────────────────────────────

        private async Task<string> BuildActionPlanBlockAsync(SmartStockContext ctx, DateTime now)
        {
            // Prefer a fresh plan from the AI agent; fall back to recent saved recommendations
            // whenever the agent isn't configured, fails (e.g. no credits), or has nothing to act on.
            List<ActionItem> items;
            bool live = false;

            if (IsAgentConfigured())
            {
                items = await TryGenerateLiveActionItemsAsync(ctx, now);
                if (items.Count > 0)
                    live = true;
                else
                    items = await GetRecentDbActionItemsAsync(ctx, now);
            }
            else
            {
                items = await GetRecentDbActionItemsAsync(ctx, now);
            }

            return RenderActionPlan(items, live);
        }

        // DeepSeek is the only concrete reasoning provider in the app, so a configured key
        // means the agent is *attemptable* — the actual call still fails fast (and falls back)
        // when there are no credits.
        private static bool IsAgentConfigured() =>
            !string.IsNullOrWhiteSpace(SettingsManager.Current.DeepSeekApiKey);

        /// <summary>
        /// Generates one fresh recommendation per top at-risk product via the agent.
        /// All-or-nothing: the first failed call aborts (fast) and returns empty so the caller
        /// falls back to cache. AI success is rendered regardless of whether the best-effort
        /// persistence to AiStockRecommendations succeeds.
        /// </summary>
        private async Task<List<ActionItem>> TryGenerateLiveActionItemsAsync(SmartStockContext ctx, DateTime now)
        {
            var atRisk = await GetAtRiskProductsAsync(ctx, now, ActionPlanTopN);
            if (atRisk.Count == 0) return new List<ActionItem>();

            var factors        = await GetRecentFactorsAsync(ctx);
            var forecastsByPid  = await GetPromptForecastsAsync(ctx, now, atRisk.Select(p => p.ProductId));

            var generated = new List<AiStockRecommendation>();
            var items     = new List<ActionItem>();

            try
            {
                foreach (var product in atRisk)
                {
                    var productForecasts = forecastsByPid.GetValueOrDefault(product.ProductId, new List<AiForecast>());
                    var prompt = _promptBuilder.BuildInventoryPrompt(product, factors, productForecasts);

                    // Sequential by design — shared DbContext is not thread-safe and a weekly
                    // batch gains nothing from parallelism.
                    var reco = await _aiProvider.GetRecommendationAsync(prompt);

                    var priority  = NormalizePriority(reco.PriorityLevel);
                    var quantity  = Math.Max(0, reco.SuggestedQuantity);
                    var reasoning = string.IsNullOrWhiteSpace(reco.Reasoning)
                        ? "No reasoning provided."
                        : reco.Reasoning.Trim();
                    if (reasoning.Length > 4000) reasoning = reasoning[..4000]; // column is StringLength(4000)

                    generated.Add(new AiStockRecommendation
                    {
                        ProductId         = product.ProductId,   // provider hardcodes 0 — set it here
                        SuggestedQuantity = quantity,
                        PriorityLevel     = priority,
                        Reasoning         = reasoning,
                        CreatedAt         = now
                    });

                    items.Add(new ActionItem(product.ProductName, priority, quantity, reasoning, now));
                }
            }
            catch (Exception ex)
            {
                ActivityLogger.LogSystemAction("WEEKLY_REPORT",
                    $"Live Action Plan unavailable, using saved recommendations: {ex.Message}");
                return new List<ActionItem>();
            }

            // Persistence is best-effort: display must not depend on the save succeeding.
            try
            {
                ctx.AiStockRecommendations.AddRange(generated);
                await ctx.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                ActivityLogger.LogSystemAction("WEEKLY_REPORT",
                    $"Failed to persist live recommendations: {ex.Message}", isError: true);
            }

            return items;
        }

        /// Active products whose projected stock in 3 days falls below SafetyStock,
        /// most-at-risk first, capped at <paramref name="max"/>.
        private static async Task<List<Product>> GetAtRiskProductsAsync(SmartStockContext ctx, DateTime now, int max)
        {
            var forecastEnd = now.Date.AddDays(3);

            var products = await ctx.Products
                .Where(p => p.IsActive)
                .AsNoTracking()
                .ToListAsync();

            var forecasts = await ctx.AiForecasts
                .Where(f => f.ForecastDate >= now.Date && f.ForecastDate <= forecastEnd)
                .AsNoTracking()
                .ToListAsync();

            return products
                .Select(p => new
                {
                    Product   = p,
                    Projected = p.CurrentStock - forecasts.Where(f => f.ProductId == p.ProductId).Sum(f => f.PredictedDemand)
                })
                .Where(x => x.Projected < x.Product.SafetyStock)
                .OrderBy(x => x.Projected)
                .Take(max)
                .Select(x => x.Product)
                .ToList();
        }

        /// Next-7-days forecasts for the given products, grouped by product id (for prompt context).
        private static async Task<Dictionary<int, List<AiForecast>>> GetPromptForecastsAsync(
            SmartStockContext ctx, DateTime now, IEnumerable<int> productIds)
        {
            var ids     = productIds.ToHashSet();
            var horizon = now.Date.AddDays(7);

            var rows = await ctx.AiForecasts
                .Where(f => ids.Contains(f.ProductId) && f.ForecastDate >= now.Date && f.ForecastDate <= horizon)
                .AsNoTracking()
                .ToListAsync();

            return rows.GroupBy(f => f.ProductId).ToDictionary(g => g.Key, g => g.ToList());
        }

        /// Most recent external factors, for prompt context (PromptBuilder re-limits to 6).
        private static async Task<List<ExternalFactor>> GetRecentFactorsAsync(SmartStockContext ctx) =>
            await ctx.ExternalFactors
                .OrderByDescending(f => f.Date)
                .Take(6)
                .AsNoTracking()
                .ToListAsync();

        /// <summary>
        /// Fallback: latest *valid* saved recommendation per product within the age window,
        /// sorted High > Medium > Low then by date. Excludes FallbackAiReasoningProvider rows.
        /// </summary>
        private static async Task<List<ActionItem>> GetRecentDbActionItemsAsync(SmartStockContext ctx, DateTime now)
        {
            var cutoff = now.AddDays(-FallbackMaxAgeDays);

            var recentRecs = await ctx.AiStockRecommendations
                .Include(r => r.Product)
                .Where(r => r.CreatedAt >= cutoff)
                .AsNoTracking()
                .OrderByDescending(r => r.CreatedAt)
                .ToListAsync();

            return recentRecs
                .Where(r => !string.IsNullOrWhiteSpace(r.Reasoning)
                         && !r.Reasoning.StartsWith("AI provider is not configured",
                                                     StringComparison.OrdinalIgnoreCase))
                .GroupBy(r => r.ProductId)
                .Select(g => g.First())
                .OrderBy(r => r.PriorityLevel switch
                {
                    "High"   => 0,
                    "Medium" => 1,
                    _        => 2
                })
                .ThenByDescending(r => r.CreatedAt)
                .Take(ActionPlanTopN)
                .Select(r => new ActionItem(
                    r.Product?.ProductName ?? $"Product #{r.ProductId}",
                    r.PriorityLevel,
                    r.SuggestedQuantity,
                    r.Reasoning ?? string.Empty,
                    r.CreatedAt))
                .ToList();
        }

        private static string NormalizePriority(string? priority) =>
            (priority ?? string.Empty).Trim().ToLowerInvariant() switch
            {
                "high" => "High",
                "low"  => "Low",
                _      => "Medium"
            };

        private static string RenderActionPlan(List<ActionItem> items, bool live)
        {
            if (items.Count == 0)
                return @"
<div class='section'>
  <h2>Action Plan — Top Recommendations</h2>
  <p class='no-data'>No stock recommendations available yet. Run a Stock Optimization analysis to generate recommendations.</p>
</div>";

            string note = live
                ? "<p class='plan-note'>Generated live by the AI agent for this report.</p>"
                : $"<p class='plan-note'>Showing saved recommendations from the last {FallbackMaxAgeDays} days.</p>";

            var sb = new StringBuilder();
            sb.Append($@"
<div class='section'>
  <h2>Action Plan — Top Recommendations</h2>
  {note}");

            foreach (var item in items)
            {
                string priorityCss = item.PriorityLevel switch
                {
                    "High"   => "priority-high",
                    "Medium" => "priority-medium",
                    _        => "priority-low"
                };
                string badgeCss = item.PriorityLevel switch
                {
                    "High"   => "badge-high",
                    "Medium" => "badge-medium",
                    _        => "badge-low"
                };

                // Encode for HTML, then restore line-breaks as <br> for readability
                string reasoning = System.Web.HttpUtility.HtmlEncode(item.Reasoning ?? string.Empty)
                                       .Replace("\r\n", "<br>")
                                       .Replace("\n", "<br>");

                sb.Append($@"
<div class='rec-item {priorityCss}'>
  <div class='rec-header'>
    <span class='rec-product'>{item.ProductName}</span>
    <span class='badge {badgeCss}'>{item.PriorityLevel}</span>
  </div>
  <div class='rec-qty'>Order quantity: <strong>{item.SuggestedQuantity}</strong> units</div>
  <div class='rec-reasoning'>{reasoning}</div>
  <div class='rec-date'>{item.CreatedAt:dd MMM yyyy HH:mm}</div>
</div>");
            }

            sb.Append("</div>");
            return sb.ToString();
        }

        // ── HTML Assembly ─────────────────────────────────────────────────────

        private static string AssembleHtml(
            string salesBlock,
            string alertsBlock,
            string actionBlock,
            DateTime reportDate)
        {
            string periodLabel = $"Week of {GetMondayOfWeek(reportDate):dd MMM} – {GetSundayOfWeek(reportDate):dd MMM yyyy}";

            return $@"<!DOCTYPE html>
<html lang='en'>
<head>
<meta charset='UTF-8'>
<meta name='viewport' content='width=device-width, initial-scale=1.0'>
<title>SmartStock Weekly Report</title>
<style>
  * {{ box-sizing: border-box; margin: 0; padding: 0; }}
  body {{ background-color: #121212; font-family: 'Segoe UI', Tahoma, sans-serif; color: #ccc; padding: 20px; }}
  .container {{ max-width: 860px; margin: 0 auto; background: #1e1e1e; border: 1px solid #2d2d2d; border-radius: 10px; overflow: hidden; }}
  .header {{ background: linear-gradient(135deg, #1a1a2e 0%, #16213e 100%); padding: 28px 32px; text-align: center; border-bottom: 2px solid #4CAF50; }}
  .header h1 {{ color: #fff; font-size: 28px; letter-spacing: 4px; font-weight: 800; }}
  .header .subtitle {{ color: #4CAF50; font-size: 13px; margin-top: 8px; letter-spacing: 1px; text-transform: uppercase; }}
  .header .period {{ color: #888; font-size: 12px; margin-top: 4px; }}
  .section {{ padding: 24px 28px; border-bottom: 1px solid #2a2a2a; }}
  .section h2 {{ color: #e0e0e0; font-size: 14px; text-transform: uppercase; letter-spacing: 1.5px; margin-bottom: 16px; padding-bottom: 8px; border-bottom: 1px solid #333; }}
  .stat-table {{ width: 100%; table-layout: fixed; border-collapse: collapse; }}
  .stat-box {{ background: #252525; border: 1px solid #333; border-radius: 8px; padding: 16px 10px; text-align: center; vertical-align: top; }}
  .stat-box .value {{ font-size: 22px; font-weight: 700; color: #fff; line-height: 1.1; white-space: nowrap; }}
  .stat-box .label {{ font-size: 11px; color: #666; margin-top: 6px; text-transform: uppercase; letter-spacing: 0.5px; }}
  .alert-item {{ background: #252525; border-left: 3px solid #FF9800; padding: 12px 16px; margin-bottom: 10px; border-radius: 0 6px 6px 0; }}
  .alert-header {{ display: flex; align-items: center; gap: 8px; margin-bottom: 4px; }}
  .alert-date {{ color: #666; font-size: 11px; margin-bottom: 4px; }}
  .alert-desc {{ color: #aaa; font-size: 13px; line-height: 1.5; }}
  .rec-item {{ background: #252525; border-left: 3px solid #4CAF50; padding: 14px 16px; margin-bottom: 10px; border-radius: 0 6px 6px 0; }}
  .rec-header {{ display: flex; align-items: center; gap: 8px; margin-bottom: 6px; }}
  .rec-product {{ color: #fff; font-weight: 600; font-size: 14px; }}
  .rec-qty {{ color: #ccc; font-size: 13px; margin-bottom: 6px; }}
  .rec-reasoning {{ color: #888; font-size: 12px; line-height: 1.6; }}
  .rec-date {{ color: #555; font-size: 11px; margin-top: 6px; }}
  .plan-note {{ color: #777; font-size: 11px; font-style: italic; margin-bottom: 12px; }}
  .priority-high {{ border-left-color: #f44336 !important; }}
  .priority-medium {{ border-left-color: #FF9800 !important; }}
  .priority-low {{ border-left-color: #4CAF50 !important; }}
  .badge {{ display: inline-block; padding: 2px 9px; border-radius: 12px; font-size: 10px; font-weight: 700; text-transform: uppercase; letter-spacing: 0.5px; }}
  .badge-high {{ background: #f44336; color: #fff; }}
  .badge-medium {{ background: #FF9800; color: #fff; }}
  .badge-low {{ background: #4CAF50; color: #fff; }}
  .badge-anomaly {{ background: #9C27B0; color: #fff; }}
  .no-data {{ color: #555; font-style: italic; text-align: center; padding: 12px 0; font-size: 13px; }}
  .chart-section {{ padding: 24px 28px; border-bottom: 1px solid #2a2a2a; text-align: center; }}
  .chart-section h2 {{ color: #e0e0e0; font-size: 14px; text-transform: uppercase; letter-spacing: 1.5px; margin-bottom: 16px; padding-bottom: 8px; border-bottom: 1px solid #333; }}
  .chart-note {{ color: #555; font-size: 12px; }}
  .footer {{ padding: 18px 28px; text-align: center; color: #444; font-size: 11px; background: #161616; }}
  .footer a {{ color: #4CAF50; text-decoration: none; }}
</style>
</head>
<body>
<div class='container'>
  <div class='header'>
    <h1>SMART STOCK</h1>
    <div class='subtitle'>Automated Weekly Report</div>
    <div class='period'>{periodLabel}</div>
  </div>

  {salesBlock}
  {alertsBlock}
  {actionBlock}

  <div class='chart-section'>
    <h2>Analysis Chart</h2>
    <p class='chart-note'>See attached PNG for the latest analysis chart from SmartStock.</p>
  </div>

  <div class='footer'>
    &copy; {reportDate.Year} SmartStock &mdash; Automated reporting system<br>
    Generated on {reportDate:dddd, dd MMMM yyyy HH:mm}
  </div>
</div>
</body>
</html>";
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static DateTime GetMondayOfWeek(DateTime date)
        {
            int days = ((int)date.DayOfWeek - (int)DayOfWeek.Monday + 7) % 7;
            return date.Date.AddDays(-days);
        }

        private static DateTime GetSundayOfWeek(DateTime date) =>
            GetMondayOfWeek(date).AddDays(6);
    }
}
