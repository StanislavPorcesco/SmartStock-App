# SmartStock Project context
A Stock Management System using C#, WinForms, and EF Core.

## Tech Stack
- Framework: .NET 8.0 (WinForms)
- Database: SQLite with EF Core
- Architecture: Facade, Repository Pattern, Dependency Injection

## Core Mission
Maintain a clean, testable, and robust system focused on SOLID principles.
All logic must reside in Services/Facade, never in UI (Forms).

## Guidelines
- Follow the modular rules in `.claude/rules/`
- Use custom commands from `.claude/commands/`
- Always refer to the folder structure in Classes/Data/Services for business logic and Forms/User Control for modular UI elements.

---

# 📂 SmartStock Project Structure

root/
│
├── 📂 Classes/            
│   ├── 📂 Data/
│   │   ├── 📂 DTOs/
│   │   │   ├── 📄 AnalysisContext.cs
│   │   │   ├── 📄 AnalyticsResult.cs
│   │   │   ├── 📄 CategoryFilterCriteria.cs
│   │   │   ├── 📄 CustomerFilterCriteria.cs
│   │   │   ├── 📄 EoqResult.cs
│   │   │   ├── 📄 ExternalFactorFilterCriteria.cs
│   │   │   ├── 📄 ProductFilterCriteria.cs
│   │   │   ├── 📄 SaleFilterCriteria.cs
│   │   │   ├── 📄 SupplierFilterCriteria.cs
│   │   │   ├── 📄 TransactionFilterCriteria.cs
│   │   │   └── 📄 UserFilterCriteria.cs
│   │   │
│   │   ├── 📂 Interfaces/
│   │   │   ├── 📄 IAIReasoningProvider.cs
│   │   │   ├── 📄 IAnalysisParameterControl.cs
│   │   │   ├── 📄 IEconometricEngine.cs
│   │   │   ├── 📄 IExternalDataProvider.cs
│   │   │   ├── 📄 IFilterControl.cs
│   │   │   ├── 📄 ILLMPromptBuilder.cs
│   │   │   ├── 📄 IRepository.cs
│   │   │   └── 📄 ITextToSqlProvider.cs
│   │   │
│   │   ├── 📂 Repositories/
│   │   │   └── 📄 GenericRepository.cs
│   │   │
│   │   └── 📂 Services/
│   │       ├── 📄 AnalyticsFacade.cs
│   │       ├── 📄 CategoryService.cs
│   │       ├── 📄 CustomerService.cs
│   │       ├── 📄 DeepSeekAiProvider.cs
│   │       ├── 📄 EconometricEngine.cs
│   │       ├── 📄 EconometricService.cs
│   │       ├── 📄 ExternalDataProvider.cs
│   │       ├── 📄 ExternalFactorService.cs
│   │       ├── 📄 FallbackAiReasoningProvider.cs
│   │       ├── 📄 ForecastService.cs
│   │       ├── 📄 ProductService.cs
│   │       ├── 📄 PromptBuilder.cs
│   │       ├── 📄 RecommendationService.cs
│   │       ├── 📄 SaleService.cs
│   │       ├── 📄 SupplierService.cs
│   │       ├── 📄 TextToSqlService.cs
│   │       ├── 📄 TransactionService.cs
│   │       ├── 📄 UserService.cs
│   │       └── 📄 WeeklyReportService.cs
│   │
│   ├── 📂 Models/
│   │   ├── 📄 AiForecast.cs
│   │   ├── 📄 AiStockRecommendation.cs
│   │   ├── 📄 Category.cs
│   │   ├── 📄 Customer.cs
│   │   ├── 📄 EconometricModel.cs
│   │   ├── 📄 ExternalFactor.cs
│   │   ├── 📄 Product.cs
│   │   ├── 📄 Sale.cs
│   │   ├── 📄 SaleDetails.cs
│   │   ├── 📄 Supplier.cs
│   │   ├── 📄 Transactions.cs
│   │   └── 📄 User.cs
│   │
│   ├── 📂 Settings/
│   │   ├── 📄 AppSettings.cs
│   │   ├── 📄 PathsManager.cs
│   │   └── 📄 SettingsManager.cs
│   │
│   └── 📂 Utils/
│       ├── 📄 ComboBoxHelper.cs
│       ├── 📄 DataLayer.cs
│       ├── 📄 DataSeeder.cs
│       ├── 📄 EmailService.cs
│       ├── 📄 ReportScheduler.cs
│       ├── 📄 SecurityService.cs
│       ├── 📄 SessionManager.cs
│       ├── 📄 SmartStockContext.cs
│       ├── 📄 ThemeManager.cs
│       ├── 📄 ToolTipHelp.cs
│       └── 📄 UISpaceHelper.cs
│
├── 📂 Forms/
│   ├── 📂 User Control/
│   │   ├── 📂 AddForms/
│   │   │   ├── 📄 AddCategory.cs
│   │   │   ├── 📄 AddCustomer.cs
│   │   │   ├── 📄 AddExternalFactor.cs
│   │   │   ├── 📄 AddProduct.cs
│   │   │   ├── 📄 AddSale.cs
│   │   │   ├── 📄 AddSupplier.cs
│   │   │   ├── 📄 AddTransaction.cs
│   │   │   ├── 📄 AddUser.cs
│   │   │   └── 📄 BaseAddInstance.cs
│   │   │
│   │   ├── 📂 AnalysisForms/
│   │   │   ├── 📄 CorrelationAnalysis.cs
│   │   │   ├── 📄 DemandForecast.cs
│   │   │   ├── 📄 LanguageQuery.cs
│   │   │   └── 📄 StockOptimization.cs
│   │   │
│   │   ├── 📂 LoginForms/
│   │   │   ├── 📄 AddAccount.cs
│   │   │   ├── 📄 Login.cs
│   │   │   ├── 📄 MailConfirmation.cs
│   │   │   └── 📄 Settings.cs
│   │   │
│   │   ├── 📂 ModifyForms/
│   │   │   ├── 📄 ModifyCategory.cs
│   │   │   ├── 📄 ModifyCustomer.cs
│   │   │   ├── 📄 ModifyExternalFactor.cs
│   │   │   ├── 📄 ModifyProduct.cs
│   │   │   ├── 📄 ModifySale.cs
│   │   │   ├── 📄 ModifySupplier.cs
│   │   │   ├── 📄 ModifyTransaction.cs
│   │   │   ├── 📄 ModifyUser.cs
│   │   │   └── 📄 BaseModifyInstance.cs
│   │   │
│   │   └── 📂 SearchForms/
│   │       ├── 📄 FilterCategories.cs
│   │       ├── 📄 FilterCustomers.cs
│   │       ├── 📄 FilterExternalFactors.cs
│   │       ├── 📄 FilterProducts.cs
│   │       ├── 📄 FilterSales.cs
│   │       ├── 📄 FilterSuppliers.cs
│   │       ├── 📄 FilterTransactions.cs
│   │       └── 📄 FilterUsers.cs
│   │
│   ├── 📄 AnalyzeForm.cs
│   ├── 📄 DetailsPopupForm.cs
│   ├── 📄 LoginForm.cs
│   ├── 📄 MenuForm.cs
│   ├── 📄 SearchForm.cs
│   └── 📄 SettingsForm.cs
│
├── 📂 .claude/
│   ├── 📄 CLAUDE.md
│   ├── 📂 agents/
│   ├── 📂 commands/
│   ├── 📂 rules/
│   └── 📄 settings.json
│
├── 📄 .claudeignore
├── 📄 SmartStock.slnx
└── 📄 Program.cs

---

## Funcționalități (Listă cerințe)

### 1. Modulul de Autentificare și Securitate
- [X] Sistem de logare securizat cu control acces bazat pe roluri (RBAC — Administrator/Operator)
- [X] Protecție Brute Force — blocare cont după 3 tentative eșuate (`AntiBruteForce` în `UserService`)
- [X] Gestiunea sesiunilor — `SessionManager` static cu stare de autentificare locală
- [X] Securizarea parolelor — hashing SHA-256 cu salt unic per utilizator (`SecurityService`)

### 2. Modulul de Configurare (Setări)
- [X] Schimbarea temei vizuale (Light / Dark Mode) — `ThemeManager` + `SettingsForm`
- [ ] Suport multilingvistic (Română / Engleză) — proprietatea `Language` există în `AppSettings`, dar lipsește infrastructura de localizare și opțiunea UI
- [X] Configurarea cheii API pentru agentul AI (DeepSeek) — expusă în `SettingsForm`
- [X] Persistența setărilor în `appSettings.json` — `SettingsManager.Load/Save`
- [X] Configurarea dinamică a căii bazei de date SQLite — `PathsManager` citește `Resources/paths.cfg`; `SmartStockContext.OnConfiguring` folosește `PathsManager.DatabasePath`; SettingsForm expune Browse buttons pentru ambele căi
- [X] Sistem de monitorizare (Logging) — `ActivityLogger` static thread-safe; acțiuni utilizator (ADD/MODIFY/ARCHIVE/RESTORE/DELETE) în toate cele 8 servicii; activitate AI în `AnalyticsFacade` + `TextToSqlService`; evenimente sistem (EXTERNAL_FETCH — erori per-sursă + sumar) via `LogSystemAction`; UI în `SettingsForm` (enable, AI toggle, path + browse button)

### 3. Modulul de Gestiune a Stocurilor (CRUD și Căutare)
- [X] Operații CRUD pentru toate entitățile (8 controale Add + 8 controale Modify)
- [X] Validarea datelor la input — implementată în toate formularele Add/Modify
- [X] Filtrare avansată după criterii — 8 controale `Filter*` cu `IFilterControl` (categorie, stoc, preț, dată etc.)

### 4. Modulul de Analiză Predictivă și Inteligență Artificială
- [X] Prognoza vânzărilor (serii de timp) — `DemandForecast`, `AnalyticsFacade`, `EconometricEngine` (OLS + trend bands)
- [X] Corelație și regresie liniară cu factori externi — `CorrelationAnalysis` + `EconometricEngine.CalculateCorrelation` (Pearson r, t-test real)
- [X] UI pentru optimizarea stocurilor — `StockOptimization` control cu parametri (HoldingCost, OrderingCost, LeadTime, RiskTolerance)
- [X] Modelul EOQ complet (Economic Order Quantity) — `Q* = √(2DS/H)`, `SS = z·σ_d·√L`, `ROP = d̄·L + SS`, curba de cost U-shaped în `AnalyticsFacade.ComputeEoq`
- [X] Determinarea punctului de reaprovizionare (Reorder Point) — calculat statistic în modelul EOQ
- [X] Generare SQL asistată de AI (Text-to-SQL) — `TextToSqlService` + `LanguageQuery` UC + `ITextToSqlProvider`
- [X] Detectarea anomaliilor în date istorice — `AnomalyDetection` UC + `AnalyticsFacade.ComputeAnomalyDetection` (Z-score, tolerance band μ±Nσ, scatter overlay în LiveCharts, raport text generat programatic)
- [X] Vizualizare grafică dinamică — `AnalyzeForm` cu LiveCharts (linii trend, benzi CI/PI, prognoză)
- [X] Trimitere automată de rapoarte prin e-mail — `WeeklyReportService` + `ReportScheduler` (7-day cooldown, ±5-min window); HTML report cu Sales Snapshot, AI Alerts (anomalii Z-score + stoc critic 3 zile), Action Plan (top 3 EOQ recs); chart PNG atașat din `AnalyzeForm.SaveChartSnapshot()`; UI în `SettingsForm.section_b_pnl` (enable, recipient, time, test button)
- [X] Persistența automată a rezultatelor analitice — `AiForecasts`, `EconometricModels`, `AiStockRecommendations` populate după fiecare analiză via `AnalyticsFacade` (trei helpers: `PersistForecastsAsync`, `PersistEconometricModelAsync`, `PersistStockRecommendationAsync`)

---

## UI Architecture Notes — `AnalyzeForm`

### Contextual Parameter Panel (NLQ Mode)
When **Natural Language Query** is selected (`analysis_type_cb` index 3), `LoadDynamicParameterControl` hides:
- `label1` + `target_subject_cb` (Target Subject)
- `label2` + `start_date_dtp` + `end_date_dtp` (Historical Range)

These fields are irrelevant for free-text SQL queries and are restored when any other analysis type is selected.

### Shared Status/Progress Bar (`panel3`) — Runtime Reparenting
`panel3` (contains `status_lbl` + `progressBar1`, `Dock = Bottom`, height = 35 px) is a **single shared control** that is reparented at runtime between `groupBox1` (analysis results) and `query_results_gb` (NLQ results) inside `LoadDynamicParameterControl`:

```csharp
var targetBox = isNlq ? (Control)query_results_gb : groupBox1;
if (panel3.Parent != targetBox)
{
    panel3.Parent?.Controls.Remove(panel3);
    targetBox.Controls.Add(panel3);
}
```

**Why reparenting instead of duplicating:** Duplicating would require two separate `status_lbl`/`progressBar1` references and double updates in `SetBusyState`. A single shared control keeps state management in one place (SRP).

**Padding alignment:** `query_results_gb.Padding = new Padding(10, 10, 10, 3)` — the bottom is 3 px (not 10) to match `groupBox1`'s effective bottom inset (Windows GroupBox default), ensuring `panel3` docks at the same visual position in both modes.

---

## Repository Pattern — `IRepository<T>` / `GenericRepository<T>`

### `ClearChanges()` — Cascade Failure Guard

`IRepository<T>` exposes `void ClearChanges()`, implemented in `GenericRepository<T>` as:

```csharp
public virtual void ClearChanges() => _context.ChangeTracker.Clear();
```

**Why it exists:** All five repositories injected into `AnalyticsFacade` share the **same `SmartStockContext` instance**. If a `SaveAsync` call fails (e.g., a constraint violation in `PersistEconometricModelAsync`), the failed entity remains in `Added` state in the change tracker. The next `SaveAsync` on any other repository (e.g., `PersistForecastsAsync`) would inherit the poisoned context, retry the stuck INSERT, and roll back the entire transaction — silently, because each helper has a `catch` block.

**How to apply:** Call `repository.ClearChanges()` inside every persistence `catch` block before the method returns. This detaches all tracked entities and ensures subsequent persist helpers start from a clean slate:

```csharp
catch
{
    _econometricModelRepository.ClearChanges(); // detaches stuck entities from shared context
}
```

**Rule:** Any time multiple sequential `SaveAsync` calls are made on repositories sharing a single `DbContext`, always `ClearChanges()` on failure — never rely on bare `catch { }` swallowing.

---

## Anomaly Detection — `AnalyzeForm` (index 4 in `analysis_type_cb`)

### Algorithm
`AnalyticsFacade.ComputeAnomalyDetection()` — pure static method, no DB or AI calls:
1. Computes `μ` (mean) and `σ` (sample std dev, Bessel-corrected) over the aggregated sales series.
2. Z-scores each point: `Z = (x − μ) / σ`. Points where `|Z| ≥ threshold` are flagged as `AnomalyPoint`.
3. Tolerance band: two constant lines at `μ + N·σ` (upper) and `max(0, μ − N·σ)` (lower) — stored in `UpperBond`/`LowerBond`.
4. Returns `AnalyticsResult` with `Anomalies`, `MaxSeverityZScore`, and a pre-built text report in `AiInsights`.

### DTOs
- `AnomalyPoint` — `Date`, `ActualValue`, `ExpectedValue`, `ZScore`, `Description`, `DataIndex`
- `AnalyticsResult` extended with `List<AnomalyPoint> Anomalies` and `decimal MaxSeverityZScore`

### UC Parameters (`AnomalyDetection.cs`)
| Parameter | Key | Values |
|---|---|---|
| Sensitivity | `SensitivityThreshold` | 1.5 / 2.0 / 2.5 / 3.0 (decimal) |
| Aggregation | `AggregationLevel` | Daily / Weekly / Monthly |

### Chart (`SetAnomalyChartSeries`)
5 `ISeries[]` entries set via reflection on `CartesianChart.Series`:
1. `LineSeries<double>` — sales (SteelBlue)
2. `LineSeries<double>` — mean line (light gray)
3. `LineSeries<double>` — upper tolerance (orange, semi-transparent fill)
4. `LineSeries<double>` — lower tolerance (orange)
5. `ScatterSeries<ObservablePoint>` — anomaly dots (Red, 16px) with `YToolTipLabelFormatter` showing date/actual/expected/Z-score

### Badges (`UpdateAnomalyBadges`)
| Badge | Label | Color rule |
|---|---|---|
| `reliability_lbl` | Anomalies (count) | Green=0, Orange≤2, Red>2 |
| `trend_lbl` | Max Z-Score | Orange<2.5, OrangeRed<3.0, Red≥3.0 |
| `confidence_lbl` | Anomaly Rate % | Green<5%, Orange<15%, Red≥15% |

---

## Secret Management — `.env` + `SettingsManager`

### `.env` file (project root, git-ignored)
```
DEEPSEEK_API_KEY=<key>
```

### Load priority in `SettingsManager.Load()`
1. Deserialize `Resources/appSettings.json` (persisted via Settings UI — always wins).
2. If `DeepSeekApiKey` is still empty, call `ReadKeyFromDotEnv("DEEPSEEK_API_KEY")`.
3. `ReadKeyFromDotEnv` walks up from `AppDomain.BaseDirectory` up to 4 parent directories looking for `.env` — finds both the runtime-output copy and the project-root file during development.
4. Key is loaded into `Current.DeepSeekApiKey` in memory only — **not written back to `appSettings.json`**. Saving via the UI persists it explicitly.

**`SettingsForm`** pre-fills `api_tb.Text = SettingsManager.Current.DeepSeekApiKey` in the constructor so the loaded key is visible for verification.

---

## `DeepSeekAiProvider` — Deferred Key Resolution

### Problem (fixed)
`DeepSeekAiProvider` originally threw in its constructor if the API key was empty, causing `AnalyzeForm.CreateDefaultFacade` to catch the exception and permanently install `FallbackAiReasoningProvider` for the lifetime of that form instance. Any user who opened `AnalyzeForm` before saving the key (or whose key came from `.env` but not from `appSettings.json` at that exact moment) would always see:

> *"AI provider is not configured. Please add API key in settings and retry."*

### Fix
The constructor no longer throws. Key resolution is deferred to call time via `ResolveApiKey()`:

```csharp
private string ResolveApiKey()
{
    if (!string.IsNullOrWhiteSpace(_constructorApiKey)) return _constructorApiKey;
    var settingsKey = SettingsManager.Current.DeepSeekApiKey;
    if (!string.IsNullOrWhiteSpace(settingsKey)) return settingsKey;
    return Environment.GetEnvironmentVariable("DEEPSEEK_API_KEY") ?? string.Empty;
}
```

`BuildRequest` now receives `apiKey` as a parameter instead of reading `_apiKey` directly. `CreateDefaultFacade` in `AnalyzeForm` always creates `new DeepSeekAiProvider(new HttpClient())` — no try/catch, no fallback provider.

**Rule:** Never bake infrastructure credentials into a constructor that runs at form-load time. Resolve them at the point of use so that late-bound configuration (e.g., saved after the form opened) is always picked up.

---

## External Factors Fetch — Architecture

### New files
| File | Role |
|---|---|
| `Classes/Data/Services/ExternalFactorsFetchService.cs` | Fetches from 4 APIs, deduplicates, batch-inserts `ExternalFactor` records |
| `Classes/Utils/ExternalFactorsScheduler.cs` | Background `System.Threading.Timer`, 5-min poll, daily cooldown |

### `AppSettings` additions
```csharp
public string   AlphaVantageApiKey          { get; set; } = string.Empty;
public string   PredictHQApiKey             { get; set; } = string.Empty;
public string   WorldBankCountryCode        { get; set; } = "RO";
public double   WeatherLatitude             { get; set; } = 45.9432;
public double   WeatherLongitude            { get; set; } = 24.9668;
public string   WeatherRegion               { get; set; } = "Romania";
public bool     ExternalFactorsFetchEnabled  { get; set; } = false;
public string   ExternalFactorsFetchTime    { get; set; } = "08:00";
public DateTime? LastExternalFactorsFetched { get; set; } = null;
```

### `.env` keys (loaded as fallback in `SettingsManager.Load`)
- `ALPHAVANTAGE_API_KEY` → `AlphaVantageApiKey`
- `PREDICTHQ_API_KEY`   → `PredictHQApiKey`

### Scheduler firing conditions (all must be true)
1. `ExternalFactorsFetchEnabled == true`
2. At least 23 hours since `LastExternalFactorsFetched` (or never fetched)
3. Current clock is within ±5 minutes of `ExternalFactorsFetchTime`

### Data sources
| Source | Auth | FactorType | ImpactValue | ValueType |
|---|---|---|---|---|
| Alpha Vantage | API key | `CommodityPrice` | `(latest−prev)/prev×100` | `Percentage` |
| World Bank | None (free) | `EconomicIndex` | indicator value | `Percentage` |
| PredictHQ | Bearer token | `Event` | `phq_rank / 100` | `Multiplier` |
| Open-Meteo | None (free) | `Weather` | temp °C / precip mm | `Absolute` |

### Deduplication
Key = `"yyyy-MM-dd|FactorType|Description"`. Existing records for `Date >= minDate` loaded client-side into a `HashSet<string>`. `HashSet.Add()` returns false for duplicates → in-batch dedup too.

### Alpha Vantage rate limit
Free tier: 5 req/min → `Task.Delay(12_000)` between each of the 7 commodity calls.

### `ExternalFactorService.ValidateFactor` — negative values allowed
Removed the `if (factor.ImpactValue < 0) throw` guard. Negative values are legitimate:
price drops (commodity %), recessions (GDP), below-zero temperatures (weather).

### `SettingsForm` — External Factors fetch panel
- `enable_daily_fetching` — toggles `ExternalFactorsFetchEnabled`
- `fetching_time` — `Format = Custom`, `CustomFormat = "HH:mm"`, `ShowUpDown = true`
- `next_fetch_lbl` — updated on load, on Apply, and after manual fetch
- `manual_fetch_btn` — calls `ExternalFactorsScheduler.RunFetchAsync()` immediately; shows count + any per-source warnings

---

## Automated Weekly Report — Architecture

### New files
| File | Role |
|---|---|
| `Classes/Data/Services/WeeklyReportService.cs` | Queries DB and builds the full HTML email |
| `Classes/Utils/ReportScheduler.cs` | Background `System.Threading.Timer`, 5-min poll |

### `AppSettings` additions
```csharp
public bool     WeeklyReportsEnabled   { get; set; } = false;
public string   ReportRecipientEmail   { get; set; } = string.Empty;
public string   ReportScheduleTime     { get; set; } = "08:00"; // HH:mm
public DateTime? LastWeeklyReportSent  { get; set; } = null;
```

### Scheduler firing conditions (all must be true)
1. `WeeklyReportsEnabled == true`
2. `ReportRecipientEmail` is non-empty
3. At least 7 days since `LastWeeklyReportSent` (or never sent)
4. Current clock is within ±5 minutes of `ReportScheduleTime`

### Report HTML sections
| Section | Data source | Notes |
|---|---|---|
| Sales Snapshot | `SaleDetails` + `Sale` | This-week vs last-week units & revenue; WoW % with ↑↓ arrows |
| AI Alerts — Anomalies | `SaleDetails` last 30 days, Z-score client-side | Only points from last 24 h with `\|Z\| ≥ 2.0` |
| AI Alerts — Critical Stock | `AiForecasts` next 3 days + `Products` | `CurrentStock − ForecastDemand < SafetyStock` |
| Action Plan | `AiStockRecommendations` | Latest per product, fallback rows excluded, sorted High→Medium→Low, top 3 |
| Chart | `Resources/last_chart.png` | PNG saved by `AnalyzeForm.SaveChartSnapshot()` ~1 s after analysis |

### SQLite aggregate rule
SQLite EF provider **cannot** translate `SumAsync` on `decimal`-typed columns. Always project to an anonymous type with `ToListAsync()` first, then aggregate via LINQ to Objects:
```csharp
// ✗ throws at runtime
.SumAsync(sd => (decimal?)sd.UnitPrice)

// ✓ correct
var rows = await query.Select(sd => new { sd.Quantity, sd.UnitPrice }).ToListAsync();
decimal total = rows.Sum(r => r.Quantity * r.UnitPrice);
```
Same applies to server-side `GroupBy` using `.Date` — always do it client-side after `ToListAsync`.

### Fallback recommendation guard
`BuildActionPlanBlockAsync` skips any `AiStockRecommendation` whose `Reasoning` starts with `"AI provider is not configured"`. This prevents stale fallback records (created before the key was set) from polluting the report.

### Email accounts
| Purpose | Address | Credential field |
|---|---|---|
| Account verification codes | `smartstock.auth@gmail.com` | `AuthPassword` |
| Weekly/test reports | `smartstock.reports@gmail.com` | `ReportsPassword` |

### `SettingsForm` — Automated Reporting panel (`section_b_pnl → groupBox1`)
- `enable_reports_chk` — toggles `WeeklyReportsEnabled`
- `time_picker` — `Format = Custom`, `CustomFormat = "HH:mm"`, `ShowUpDown = true` (time-only spinner)
- `email_recipient_tb` — pre-filled with `ReportRecipientEmail`; falls back to `SessionManager.CurrentUser?.Email` when empty
- `next_report_date_time_lbl` (formerly `label8`) — updated on load and on every Apply; shows `"Disabled"` or the computed next fire date
- `sent_test_btn` — calls `ReportScheduler.SendReportAsync(recipient, isTest: true)` immediately, no cooldown

### `AnalyzeForm` — chart snapshot
After every successful analysis, a deferred call fires ~1 s later:
```csharp
_ = Task.Delay(1000).ContinueWith(_ => BeginInvoke(SaveChartSnapshot));
```
`SaveChartSnapshot` uses `DrawToBitmap` on `_analysisChart` (LiveCharts `CartesianChart`) and saves to `Resources/last_chart.png`. Sets `ReportScheduler.LastChartSnapshotPath`. Failure is silently swallowed — the snapshot is best-effort and the report sends regardless.

---

## Bootstrap Config — `PathsManager`

### `Resources/paths.cfg` (fixed location, loaded before everything else)
```
SettingsFilePath=<absolute path to appSettings.json>
DatabasePath=<absolute path to SmartStock.db>
```

### Load order in `Program.cs`
1. `PathsManager.Load()` — reads `paths.cfg`, fills `PathsManager.SettingsFilePath` and `PathsManager.DatabasePath`, falls back to `<exe>/Resources/` defaults if file absent.
2. `SettingsManager.Load()` — uses `PathsManager.SettingsFilePath` (computed property, not a readonly string).
3. `db.Database.Migrate()` — `SmartStockContext.OnConfiguring` calls `PathsManager.DatabasePath`.
4. `ReportScheduler.Start()`.

**Why a separate file:** `appSettings.json` cannot store its own path. `paths.cfg` is the bootstrap anchor at a fixed known location, solving the circular dependency.

### `SettingsForm` path browsing
- `browse_settings_btn` and `browse_db_btn` open `OpenFileDialog` starting in the file's current directory.
- On Apply, `PathsManager.Save(settingsPath, databasePath)` writes `paths.cfg`.
- Default values on first start: `<exe>/Resources/appSettings.json` and `<exe>/Resources/SmartStock.db`.

---

## DeepSeek Prompt Engineering — `PromptBuilder` + System Message

### Prompt format (plain text, not JSON)
`PromptBuilder.BuildInventoryPrompt` sends a concise structured plain-text prompt instead of a verbose JSON blob. Internal DB IDs (`ForecastId`, `ProductId`, `FactorId`, `ModelVersion`) are excluded entirely.

```
Product: {name}
Current stock: {stock} {unit} | Safety stock: {safetyStock} | Gap: {±gap}
Demand — avg: {avg}, peak: {peak}, trend: {trendDescription}
Upcoming forecast ({N} days): {date: demand, ...}
Active external factors: {label (±impact), ...}

Recommend restock quantity and priority. State the specific risk or opportunity driving your decision,
then give a precise action. Do not repeat the numbers above — explain what they mean.
```

Key decisions:
- **Gap is pre-computed** (`current − safety`) so DeepSeek reasons about shortfall magnitude, not raw numbers.
- **Only 6 most recent factors** (down from 12) with impact values inline.
- **Closing instruction** explicitly forbids restating input numbers; demands interpretation.
- External factors capped at 6 (most recent by date) — older ones are typically superseded.

### System message rules (enforced in `DeepSeekAiProvider.BuildRequest`)
- 3–5 sentence cap on `reasoning`.
- Lead with the key risk or opportunity.
- Give a specific, actionable recommendation.
- Never repeat input numbers verbatim — interpret them instead.
- No preamble, no acknowledgements, no filler phrases like `"Based on the data provided"`.

**Why:** The old system message + JSON blob produced verbose outputs that restated all input data before concluding. The new format forces a conclusion-first structure with a hard sentence cap.

---

## Console Window Suppression — `Program.cs`

Two mechanisms applied together to prevent a console window from appearing when launched from Visual Studio:

1. **`FreeConsole()` P/Invoke** — called as the very first statement in `Main`, before any framework initialization. Detaches the process from whatever console handle VS attached at launch time.
2. **`Console.SetOut/SetError(TextWriter.Null)`** — redirects any residual `Console.Write*` calls to a null stream, preventing the runtime from lazily re-allocating a console handle later.
3. **`Properties/launchSettings.json`** — sets `"console": "internalConsole"` so VS routes debug output to its Output pane rather than a separate window.

`WinExe` in the `.csproj` sets the PE subsystem flag correctly for standalone `.exe` execution. The above three layers cover the VS debugger attachment scenario on top of that.

---

## Activity Logging — `ActivityLogger`

### `Classes/Utils/ActivityLogger.cs`
Static, thread-safe append logger. Uses a `private static readonly object _fileLock` and `lock` around every `File.AppendAllText` call. Failures silently swallowed — logging must never propagate to callers.

### Log entry format
```
[yyyy-MM-dd HH:mm:ss] [USER:{username}] [ACTION] EntityType: "EntityName" (ID:{id})
[yyyy-MM-dd HH:mm:ss] [AI] [OPERATION] details
[yyyy-MM-dd HH:mm:ss] [SYSTEM] [OPERATION] details
[yyyy-MM-dd HH:mm:ss] [ERROR] [OPERATION] details
```

### Three entry points
| Method | Guard | Used in |
|---|---|---|
| `LogUserAction(action, entityType, entityName, id?)` | `LoggingEnabled` | All 8 CRUD services |
| `LogAiAction(operation, details)` | `LoggingEnabled` AND `AiLoggingEnabled` | `AnalyticsFacade`, `TextToSqlService` |
| `LogSystemAction(operation, details, isError?)` | `LoggingEnabled` | `ExternalFactorsFetchService` (scheduler/background events) |

`LogSystemAction` writes `[SYSTEM]` tag normally, or `[ERROR]` tag when `isError: true`. `[ERROR]` entries **always pass the level filter** — they are never silenced regardless of configured log level.

### Action vocabulary
| Action | Trigger |
|---|---|
| `ADD` | Successful insert in any service |
| `MODIFY` | Successful update |
| `ARCHIVE` | `IsActive = false` (soft delete) |
| `RESTORE` | `IsActive = true` (re-activation) |
| `DELETE` | Hard delete (TransactionService reversal) |
| `DEMAND_FORECAST` | AI — forecast analysis complete |
| `CORRELATION` | AI — correlation analysis complete |
| `STOCK_OPTIMIZATION` | AI — EOQ + recommendation persisted |
| `ANOMALY_DETECTION` | AI — anomaly scan complete |
| `TEXT_TO_SQL` | AI — NLQ → SQL generated |
| `EXTERNAL_FETCH` | Scheduler/manual fetch — per-source errors + completion summary |

### Default path
`<exe>/Resources/activity.log` — used when `AppSettings.LogFilePath` is empty.

### `AppSettings` additions
```csharp
public bool   LoggingEnabled   { get; set; } = false;
public bool   AiLoggingEnabled { get; set; } = false;
public string LogFilePath      { get; set; } = string.Empty;
public string LogLevel         { get; set; } = "Info";   // Info | Warning | Error
public int    LogMaxSizeMb     { get; set; } = 10;
```

### Log level semantics
| Level | What is written |
|---|---|
| `Info` | Everything (ADD, MODIFY, ARCHIVE, RESTORE, DELETE, all AI, SYSTEM, ERROR) |
| `Warning` | ARCHIVE, RESTORE, DELETE + AI + SYSTEM + ERROR (ADD/MODIFY noise suppressed) |
| `Error` | ERROR only — `[ERROR]` tag always passes regardless of configured level |

**Rule:** `[ERROR]`-tagged entries (e.g. per-source fetch failures) bypass the level filter entirely — they are written even when `LogLevel = "Error"`. This ensures critical failures are always captured.

Implemented via `PassesLevelFilter(action)` in `ActivityLogger` — called before every `Write`.

### File rotation
`RotateIfNeeded(path)` runs inside `_fileLock` before each append. When `FileInfo.Length >= LogMaxSizeMb × 1 MB`, the current file is renamed to `activity_backup_yyyyMMdd_HHmmss.log` in the same directory and the next write starts a fresh file. No log lines are lost.

### `SettingsForm` — Logging panel (`section_b_pnl → groupBox2`)
- `enable_logging_chk` — toggles `LoggingEnabled`
- `ai_logs_ck` — toggles `AiLoggingEnabled`
- `logs_tb` — pre-filled with default path when `LogFilePath` is empty
- `browse_logs_btn` — `OpenFileDialog` for `.log` / `.txt` files; col 2, row 2 of `tableLayoutPanel2`
- `log_level_cb` — ComboBox with `Info / Warning / Error`; Designer originally declared as `comboBox1` (renamed to `log_level_cb`)
- `max_size_numeric` — `NumericUpDown` 1–999 MB; Designer originally declared as `min_numeric` (renamed)
- `open_log_btn` — opens log file via `Process.Start(UseShellExecute = true)`; Designer originally declared as `button1` (renamed)

### Designer naming fix
The Designer's `InitializeComponent` used VS default names (`button1`, `min_numeric`, `comboBox1`) while field declarations at the bottom used the proper names (`open_log_btn`, `max_size_numeric`, `log_level_cb`). Fixed by aligning all `InitializeComponent` references to the declared field names via PowerShell replace.

---

## AI Settings Panel — `SettingsForm` (`ai_settings_gb`)

### Multi-Provider Support

`SettingsForm` holds a `Dictionary<string, string> _providerKeys` populated from `SettingsManager.Current` on open. Provider selection is stored in `SettingsManager.Current.SelectedAiProvider`.

| Provider | Key field | `.env` variable |
|---|---|---|
| DeepSeek | `DeepSeekApiKey` | `DEEPSEEK_API_KEY` |
| OpenAI | `OpenAIApiKey` | `OPENAI_API_KEY` |
| Claude | `ClaudeApiKey` | `ANTHROPIC_API_KEY` or `CLAUDE_API_KEY` |

Switching providers stashes the current key into `_providerKeys[prev]` and restores `_providerKeys[new]`. Key persists in memory until Apply or close — the textbox clears visually but the key is not lost.

On Apply: all three keys and `SelectedAiProvider` are flushed to `SettingsManager.Current` and saved.

### API Key Security

- `api_tb.UseSystemPasswordChar = true` on every load and on every provider switch — key is always masked by default.
- `view_api_btn` (`IconButton`, `Tag = "clean_icon"`) is **disabled + grayed** for non-Admin users. Check: `SessionManager.CurrentUser?.Role == "Admin"`.
- Click toggles `UseSystemPasswordChar` and swaps icon `EyeSlash` ↔ `Eye`.

### API Status Check (`CheckApiStatusAsync`)

Fires on form open and on provider switch. Hits each provider's models endpoint (GET, no tokens consumed):
- DeepSeek: `GET https://api.deepseek.com/models` — `Authorization: Bearer`
- OpenAI: `GET https://api.openai.com/v1/models` — `Authorization: Bearer`
- Claude: `GET https://api.anthropic.com/v1/models` — `x-api-key` + `anthropic-version: 2023-06-01`

Updates `status_color_lbl` (colored dot: LimeGreen / Red / Gray) and `api_status_lbl` (text: Active / Inactive / No Key / Error / Checking...).

### Temperature — `temperature_numeric`

`AppSettings.AiTemperature` (double, default `0.2`). Range 0.0–2.0, step 0.1, 2 decimal places.

`temperature_numeric.Tag = "range_lock"` — prevents `ThemeManager` from overwriting `Maximum` with `9999999999`.

`DeepSeekAiProvider.BuildRequest` reads `Math.Clamp(SettingsManager.Current.AiTemperature, 0.0, 2.0)` — no longer hardcoded.

---

## ThemeManager — Control Tag Overrides

Tag values checked in `ApplyStyleToControl` before applying defaults:

| Tag | Control type | Effect |
|---|---|---|
| `"clean_icon"` | `Button` / `IconButton` | Transparent background, `BorderSize = 0`, `MouseOver/DownBackColor = Transparent`, `IconColor = theme.Text` |
| `"range_lock"` | `NumericUpDown` | Skips `num.Maximum = 9999999999` — preserves designer-set range |
| `"menu"` / `"title"` | `Button` | Transparent background with hover color |

**Rule:** Any `IconButton` used as an icon-only control must have `Tag = "clean_icon"` in the Designer. Any `NumericUpDown` with a meaningful bounded range must have `Tag = "range_lock"` and configure `Minimum`/`Maximum`/`DecimalPlaces` in the form constructor.

---

## SettingsForm — Scrollable Layout

### Structure

```
Form (Padding=30)
├── apply_pnl   (Dock=Bottom) ← always visible, never scrolls
└── base_pnl    (Dock=Fill, AutoScroll=true, Padding=10)
    └── settings_table  (Dock=Top, fixed height) ← scrollable content
```

### Why `Dock=Top` on `settings_table`

- `Dock=Fill` resizes the table to fit the parent — it never overflows, AutoScroll never activates.
- `Anchor=Top|Left` with a hardcoded width leaves a gap when the window is wider than the hardcoded value.
- `Dock=Top` stretches to fill the full width and keeps the natural/fixed height — the vertical overflow activates the scrollbar.

### Why `apply_pnl` is at Form level

`apply_pnl` inside `base_pnl` with `Dock=Bottom` scrolls away with the content. Moving it to a direct Form child (`Dock=Bottom`) pins it to the bottom of the window regardless of scroll position.
