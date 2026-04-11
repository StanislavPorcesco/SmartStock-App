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
│   │       └── 📄 UserService.cs
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
│   │   └── 📄 SettingsManager.cs
│   │
│   └── 📂 Utils/
│       ├── 📄 ComboBoxHelper.cs
│       ├── 📄 DataLayer.cs
│       ├── 📄 DataSeeder.cs
│       ├── 📄 EmailService.cs
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
- [ ] Configurarea dinamică a căii bazei de date SQLite — calea este hardcodată în `SmartStockContext.OnConfiguring`
- [ ] Sistem de monitorizare (Logging) — nicio infrastructură de jurnalizare nu există

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
