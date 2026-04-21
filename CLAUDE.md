# SmartStock — C# WinForms Stock Management

**Stack:** .NET 8.0, WinForms, SQLite + EF Core | **Architecture:** Facade, Repository, DI | **Principle:** All logic → Services/Facade, never UI

---

## Critical Rules

### Code Style
- **UI Tags** (all semantic, via `ThemeManager`):
  - Buttons: `"cta"` (primary) | `"ghost"` (secondary) | `"outlined"` (tertiary) | `"clean_icon"` (icon-only)
  - Panels: `"base"` (default bg) | `"hero"` (surface bg) | `"card"` (elevated) | `"divider"` (border)
  - Labels: `"muted"` (secondary text) | `"accent"` (highlight) | no tag → TextPrimary (default)
  - TextBox: `"flat"` (no border) | `"otp"` (OTP digits: SurfaceHover BG + Accent text + border)
  - Icons: `"accent-icon"` (amber) | `"muted-icon"` (secondary)
  - **Never hardcode BackColor/ForeColor in Designer** — use Tags only.
- **Repository pattern:** Shared `DbContext` across multiple repos → always call `ClearChanges()` on persist failure.
- **BindingList mutation:** After *any* cart/list edit, call `BindCartGrid()` or rebind (DataSource=null forces refresh).
- **NumericUpDown range:** Use `Tag = "range_lock"` to prevent ThemeManager from overwriting `Maximum`.

### Designer Safety
- **All properties INLINE in InitializeComponent** — VS Designer regeneration wipes helper methods. Never use post-init styling helpers.
- **Merged-cell pattern:** Two controls sharing a row cell → wrap in container Panel (Tag="card"), Dock=Fill label + Dock=Right cta button.

### Architecture
- **Forms:** Data display + event capture only. No business logic.
- **Services/Facade:** All processing, validation, AI, analytics, logging.
- **New form shell:** outer Panel (Tag="base") → body Panel (Tag="card", padding 22) → 56px header (IconPictureBox Tag="accent-icon" + title Label 11pt Semibold) → divider Panel (Tag="divider", 1px) → body TableLayoutPanel.
- **ModifyForm field grid:** base_pnl (Tag="base", Dock=Fill) → fields_table (160px label col + fill input col, 52px rows). Row 0: search_row (TextBox Tag="flat" + `FontAwesome.Sharp.IconButton` Tag="outlined" MagnifyingGlass). All labels Tag="muted", all inputs Tag="flat".
- **Filter tooltips:** `ToolTipHelp.AddToolTip(label, text)` — never form-level.

---

## ThemeManager — 12-Color Palette

**Dark (Midnight Cobalt):** Background `#0E1420` | Surface `#161D2E` | SurfaceHover `#1E2740` | Accent `#F5B547` (amber) | TextPrimary `#E6EBF5` | TextSecondary `#94A0B8` | Border `#252E47`

**Light:** Background `#FAFAF7` | Surface `#F0EFE9` | Accent `#0D7D6B` (teal) | TextPrimary `#1A1D1A` | TextSecondary `#5C615E` | Border `#D4D1C5`

**Rule:** 60–30–10 (Background–Surface–Accent). Legacy aliases: `LightColor → Surface`, `DarkColor → Background`, `Text → TextPrimary`.

---

## Config & Bootstrap

| Config | Location | Purpose |
|---|---|---|
| **paths.cfg** | Resources/ | Database + appSettings.json paths (loaded first) |
| **appSettings.json** | PathsManager.SettingsFilePath | Theme, API keys, feature flags, log settings |
| **.env** | Project root | Fallback API keys (DEEPSEEK_API_KEY, ALPHAVANTAGE_API_KEY, PREDICTHQ_API_KEY) |
| **activity.log** | LogFilePath or Resources/ | User actions, AI ops, system events (rotates at LogMaxSizeMb) |

**Load order:** PathsManager → SettingsManager → DB Migrate → ReportScheduler.Start → ExternalFactorsScheduler.Start (deferred 2 min).

---

## Security & Auth

- **SessionManager:** Static, holds CurrentUser after login.
- **Login flow:** Username/password → SHA-256 hash + salt → 3-fail lockout → email code validation → session set.
- **Multi-provider AI:** DeepSeek, OpenAI, Claude selectable in SettingsForm; key resolved at call-time, not constructor.
- **Email accounts:** `smartstock.auth@gmail.com` (AuthPassword) for codes | `smartstock.reports@gmail.com` (ReportsPassword) for reports.

---

## Analytics & Scheduling

| Feature | Files | Firing conditions |
|---|---|---|
| **External Factors Fetch** | ExternalFactorsFetchService, ExternalFactorsScheduler | Enabled + 23h cooldown + ±5min of FetchTime |
| **Weekly Report** | WeeklyReportService, ReportScheduler | Enabled + non-empty recipient + 7d cooldown + ±5min of ReportTime |
| **Anomaly Detection** | AnalyticsFacade.ComputeAnomalyDetection | Z-score threshold (1.5/2.0/2.5/3.0), aggregation (Daily/Weekly/Monthly) |
| **EOQ Model** | AnalyticsFacade.ComputeEoq | Q* = √(2DS/H), SS = z·σ_d·√L, ROP = d̄·L + SS |

---

## Logging

`ActivityLogger` (static, thread-safe, file-locked):

| Action | Used in |
|---|---|
| ADD / MODIFY / ARCHIVE / RESTORE / DELETE | All 8 CRUD services |
| DEMAND_FORECAST / CORRELATION / STOCK_OPTIMIZATION / ANOMALY_DETECTION / TEXT_TO_SQL | AnalyticsFacade, TextToSqlService |
| EXTERNAL_FETCH | ExternalFactorsFetchService |

Log levels: **Info** (all) | **Warning** (noise suppressed) | **Error** (always writes).

---

## Forms Structure

```
Forms/
  ├── User Control/
  │   ├── AddForms/     (8 entity forms + BaseAddInstance)
  │   ├── ModifyForms/  (8 entity forms + BaseModifyInstance)
  │   ├── SearchForms/  (8 filter panels)
  │   └── AnalysisForms/ (DemandForecast, CorrelationAnalysis, StockOptimization, LanguageQuery)
  ├── LoginForms/       (Login, AddAccount, MailConfirmation, Settings)
  └── Main:             LoginForm, MenuForm, AnalyzeForm, SearchForm, SettingsForm
```

---

## graphify — RAG Index

`graphify-out/` is a pre-built knowledge graph of `Classes/` (70 files, 538 nodes, 902 edges). Use it before reading raw source files.

**When to use (mandatory):** architecture questions, tracing data flow, adding a new service/interface/DTO.

**How:**
1. Read `graphify-out/GRAPH_REPORT.md` — god nodes, community map, suggested questions.
2. Search `graphify-out/graph.json` by label → use `source_file` + `source_location` to jump to the exact file/line.
3. BFS/DFS the graph to trace cross-class paths before opening files.

**Community map:**

| ID | Name | Key classes |
|----|------|-------------|
| 0 | Core CRUD Services | CustomerService, ProductService, SaleService, TransactionService, ExternalFactorService |
| 1 | Category & Activity Logging | CategoryService, ActivityLogger (user actions) |
| 2 | Analytics Facade & AI | AnalyticsFacade (24 edges) — forecast, anomaly, EOQ, correlation |
| 3 | UI Utilities & Session | ThemeManager, SessionManager, ComboBoxHelper, DataLayer |
| 4 | Forecast & Recommendation | ForecastService, RecommendationService, GenericRepository (bridge) |
| 5 | Activity Logging | ActivityLogger (system/AI actions) |
| 6 | User Auth & Security | UserService, SecurityService |
| 7 | Weekly Reports & Scheduling | WeeklyReportService, ReportScheduler |
| 8 | AI Providers | DeepSeekAiProvider, FallbackAiReasoningProvider |
| 9 | DB Context & Seeding | SmartStockContext, DataSeeder |
| 10 | Supplier Management | SupplierService |
| 11–21 | Interfaces | IRepository, ISaveableControl, IFilterControl, IEconometricEngine, IExternalDataProvider, ITextToSqlProvider, IAIReasoningProvider, ILLMPromptBuilder, IAnalysisParameterControl |
| 22 | Paths Configuration | PathsManager |
| 27–38 | Filter DTOs | One per entity (Category, Customer, Product, Sale, Supplier, Transaction, User, ExternalFactor, EOQ, Analysis, Anomaly) |
| 39–50 | EF Models | One per entity model |
| 51 | App Settings | AppSettings |

**God nodes** (high blast radius — touch carefully):
1. `AnalyticsFacade` — 24 edges
2. `UserService` — 21 edges
3. `CustomerService` / `ExternalFactorService` — 19 edges each
4. `SaleService` — 17 edges
5. `ThemeManager` — 14 edges

**After modifying `Classes/` files:** run `/graphify ./Classes --update` to refresh (AST-only, ~5s, no API cost).

---

## See Also

- [docs/FEATURES.md](docs/FEATURES.md) — Full feature checklist
- [docs/UI_ARCHITECTURE.md](docs/UI_ARCHITECTURE.md) — AnalyzeForm, ModifySale cart, SettingsForm scroll patterns
- [docs/SYSTEMS.md](docs/SYSTEMS.md) — Forecasting, Weekly Reports, External Factors, Logging architecture
- [docs/PATTERNS.md](docs/PATTERNS.md) — Repository ClearChanges, BindingList DataSource, Filter tooltips, ThemeManager evolution
- [.claude/rules/solid.md](.claude/rules/solid.md) — SOLID principles
