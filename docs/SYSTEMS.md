# System Architecture Details

## External Factors Fetch

**Files:** `ExternalFactorsFetchService`, `ExternalFactorsScheduler`

### Scheduling
Fires every 5 min poll if: enabled + 23h since last fetch + within ±5 min of `ExternalFactorsFetchTime`.

### Sources (4)
| Source | Auth | Type | Formula |
|---|---|---|---|
| Alpha Vantage | API key | CommodityPrice | `(latest−prev)/prev×100` (7 commodities, 12s between calls for free tier) |
| World Bank | None | EconomicIndex | GDP, inflation, etc. |
| PredictHQ | Bearer token | Event | `phq_rank / 100` |
| Open-Meteo | None | Weather | temp °C, precipitation mm |

### Deduplication
Key: `"yyyy-MM-dd|FactorType|Description"`. HashSet on client-side; existing records for `Date >= minDate` pre-loaded.

### Validation
`ExternalFactorService.ValidateFactor` allows negative values (price drops, recessions, sub-zero temps).

### AppSettings
```csharp
public string   AlphaVantageApiKey { get; set; }
public string   PredictHQApiKey { get; set; }
public string   WorldBankCountryCode { get; set; } = "RO";
public double   WeatherLatitude { get; set; } = 45.9432;
public double   WeatherLongitude { get; set; } = 24.9668;
public bool     ExternalFactorsFetchEnabled { get; set; }
public string   ExternalFactorsFetchTime { get; set; } = "08:00";
public DateTime? LastExternalFactorsFetched { get; set; }
```

---

## Weekly Report Scheduler

**Files:** `WeeklyReportService`, `ReportScheduler`

### Scheduling
Fires every 5 min poll if: enabled + non-empty recipient + 7d since last send + within ±5 min of `ReportScheduleTime`.

### Report Sections
| Section | Source | Notes |
|---|---|---|
| **Sales Snapshot** | SaleDetails + Sale | This-week vs last-week units/revenue; WoW % with ↑↓ |
| **AI Alerts — Anomalies** | SaleDetails (30d), Z-score client-side | Last 24h only, threshold \|Z\| ≥ 2.0 |
| **AI Alerts — Critical Stock** | AiForecasts (3d) + Products | `CurrentStock − ForecastDemand < SafetyStock` |
| **Action Plan** | AiStockRecommendations | Latest per product, fallback rows excluded, High→Medium→Low, top 3 |
| **Chart** | Resources/last_chart.png | PNG from `AnalyzeForm.SaveChartSnapshot()` ~1s post-analysis |

### SQLite Gotcha
**Cannot translate** `SumAsync(decimal)` or `GroupBy(.Date)` server-side. Always:
```csharp
var rows = await query.Select(r => new { r.Col1, r.Col2 }).ToListAsync();
decimal total = rows.Sum(r => r.Col1 * r.Col2);
```

### Fallback Guard
Skip any `AiStockRecommendation` where `Reasoning.StartsWith("AI provider is not configured")`.

### AppSettings
```csharp
public bool     WeeklyReportsEnabled { get; set; }
public string   ReportRecipientEmail { get; set; }
public string   ReportScheduleTime { get; set; } = "08:00";
public DateTime? LastWeeklyReportSent { get; set; }
```

### Email Accounts
- `smartstock.auth@gmail.com` (AuthPassword) — verification codes
- `smartstock.reports@gmail.com` (ReportsPassword) — weekly/test reports

### Chart Snapshot
After any successful analysis, deferred 1s call:
```csharp
_ = Task.Delay(1000).ContinueWith(_ => BeginInvoke(SaveChartSnapshot));
```
Uses `DrawToBitmap` on LiveCharts `CartesianChart` → `Resources/last_chart.png`. Failure silently swallowed.

---

## Anomaly Detection

**Method:** `AnalyticsFacade.ComputeAnomalyDetection()` (static, pure, no DB/AI).

### Algorithm
1. Aggregate sales series → compute μ (mean), σ (Bessel-corrected std dev).
2. Z-score each point: `Z = (x − μ) / σ`. Flag if `|Z| ≥ threshold`.
3. Tolerance band: `μ + N·σ` (upper) and `max(0, μ − N·σ)` (lower).
4. Return `AnalyticsResult` with `Anomalies` list + `MaxSeverityZScore` + text report.

### Parameters
- **Sensitivity:** 1.5 / 2.0 / 2.5 / 3.0 (Z-score threshold)
- **Aggregation:** Daily / Weekly / Monthly

### Chart Series (5 total)
1. Line — sales (SteelBlue)
2. Line — mean (light gray)
3. Line — upper tolerance (orange, semi-transparent)
4. Line — lower tolerance (orange)
5. Scatter — anomalies (Red, 16px, tooltip shows date/actual/expected/Z)

### Badges
| Badge | Metric | Color rule |
|---|---|---|
| reliability_lbl | Anomaly count | Green=0, Orange≤2, Red>2 |
| trend_lbl | Max Z-Score | Orange<2.5, OrangeRed<3.0, Red≥3.0 |
| confidence_lbl | Anomaly % | Green<5%, Orange<15%, Red≥15% |

---

## Secret Management

### .env File
Project root, git-ignored:
```
DEEPSEEK_API_KEY=<key>
ALPHAVANTAGE_API_KEY=<key>
PREDICTHQ_API_KEY=<key>
```

### Load Priority in `SettingsManager.Load()`
1. Deserialize `Resources/appSettings.json` (persisted UI → always wins).
2. If empty, call `ReadKeyFromDotEnv()` (walks up 4 parent directories for `.env`).
3. Load into `Current.DeepSeekApiKey` in memory only — **not written to appSettings.json**. UI save persists explicitly.

### DeepSeekAiProvider — Deferred Resolution
Constructor no longer throws. Key resolved at call-time:
```csharp
private string ResolveApiKey()
{
    if (!string.IsNullOrWhiteSpace(_constructorApiKey)) return _constructorApiKey;
    var settingsKey = SettingsManager.Current.DeepSeekApiKey;
    if (!string.IsNullOrWhiteSpace(settingsKey)) return settingsKey;
    return Environment.GetEnvironmentVariable("DEEPSEEK_API_KEY") ?? string.Empty;
}
```

**Rule:** Never bake infrastructure credentials into constructors that run at form-load time. Resolve at call-time so late-bound config (e.g., saved after form opened) is always picked up.

---

## AI Settings Panel (SettingsForm)

### Multi-Provider Support
Dictionary `_providerKeys` holds all three keys. Switching providers stashes current key into prev provider's slot, restores new key. On Apply, all keys + `SelectedAiProvider` flushed to settings and saved.

| Provider | Key field | .env variable |
|---|---|---|
| DeepSeek | DeepSeekApiKey | DEEPSEEK_API_KEY |
| OpenAI | OpenAIApiKey | OPENAI_API_KEY |
| Claude | ClaudeApiKey | ANTHROPIC_API_KEY or CLAUDE_API_KEY |

### Security
- `api_tb.UseSystemPasswordChar = true` — always masked by default.
- `view_api_btn` (Tag="clean_icon") — **disabled for non-Admin users**. Check: `SessionManager.CurrentUser?.Role == "Admin"`.
- Click toggles mask + swaps icon EyeSlash ↔ Eye.

### API Status Check
Fires on open + on provider switch. Hits each provider's models endpoint (GET, no tokens):
- DeepSeek: `GET https://api.deepseek.com/models` (Bearer)
- OpenAI: `GET https://api.openai.com/v1/models` (Bearer)
- Claude: `GET https://api.anthropic.com/v1/models` (x-api-key + anthropic-version header)

Updates `status_color_lbl` (dot: LimeGreen/Red/Gray) + `api_status_lbl` (text: Active/Inactive/No Key/Error/Checking).

### Temperature
`AppSettings.AiTemperature` (double, default 0.2). Range 0.0–2.0, step 0.1. Use `Tag="range_lock"` to prevent ThemeManager override. `DeepSeekAiProvider.BuildRequest` clamps: `Math.Clamp(SettingsManager.Current.AiTemperature, 0.0, 2.0)`.

---

## Activity Logging

**File:** `ActivityLogger` (static, thread-safe, file-locked).

### Entry Points
| Method | Guard | Used in |
|---|---|---|
| `LogUserAction` | LoggingEnabled | All 8 CRUD services |
| `LogAiAction` | LoggingEnabled + AiLoggingEnabled | AnalyticsFacade, TextToSqlService |
| `LogSystemAction` | LoggingEnabled | ExternalFactorsFetchService, background events |

### Actions
ADD, MODIFY, ARCHIVE, RESTORE, DELETE (user) | DEMAND_FORECAST, CORRELATION, STOCK_OPTIMIZATION, ANOMALY_DETECTION, TEXT_TO_SQL (AI) | EXTERNAL_FETCH (system)

### Log Levels
- **Info:** Everything.
- **Warning:** ARCHIVE, RESTORE, DELETE + AI + SYSTEM + ERROR (ADD/MODIFY suppressed).
- **Error:** ERROR only — always written, bypasses level filter.

### Format
```
[yyyy-MM-dd HH:mm:ss] [USER:username] [ACTION] EntityType: "EntityName" (ID:id)
[yyyy-MM-dd HH:mm:ss] [AI] [OPERATION] details
[yyyy-MM-dd HH:mm:ss] [SYSTEM] [OPERATION] details (or [ERROR] tag)
```

### File Rotation
When `FileInfo.Length >= LogMaxSizeMb`, rename current to `activity_backup_yyyyMMdd_HHmmss.log`, start fresh.

### AppSettings
```csharp
public bool   LoggingEnabled { get; set; }
public bool   AiLoggingEnabled { get; set; }
public string LogFilePath { get; set; } = string.Empty; // defaults to Resources/activity.log
public string LogLevel { get; set; } = "Info"; // Info | Warning | Error
public int    LogMaxSizeMb { get; set; } = 10;
```
