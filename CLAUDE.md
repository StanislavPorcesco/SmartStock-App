# SmartStock — C# WinForms Stock Management

**Stack:** .NET 8.0, WinForms, SQLite + EF Core | **Architecture:** Facade, Repository, DI | **Principle:** All logic → Services/Facade, never UI

---

## 🎯 Critical Rules

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
- **Merged-cell pattern:** When two controls share a row cell, wrap in a container Panel (Tag="card") with Dock=Fill label + Dock=Right cta pill button (e.g., `report_row_pnl` in SettingsForm).

### Architecture
- **Forms:** Data display + event capture only. No business logic.
- **Services/Facade:** All processing, validation, AI, analytics, logging.
- **MenuForm layout:** TableLayoutPanel root (sidebar 320px + content fill) → brand header + nav buttons + user card footer.
- **BaseAddInstance shell:** TableLayoutPanel root (3 rows: 196px selector card / fill content card / 84px footer). Selector card: hero header (PenRuler icon) + 2-col combo grid (entity type + action). Content card: dynamic icon + title (updated via `UpdateContentHeader`). Footer: archive (outlined) + save (cta, mode-aware text/icon).
- **SettingsForm layout:** 2×3 card grid (Preferences, Reporting, Paths, Logging, AI, Factors) inside scrollable base_pnl (Dock=Fill, AutoScroll). Hero header (Gears icon + title). Sticky `apply_pnl` (Dock=Bottom, 88px) with full-width cta button.
- **Card shell pattern:** outer Panel (Tag="base") → body Panel (Tag="card", padding 22) → 56px header (IconPictureBox Tag="accent-icon" + title Label 11pt Semibold) → divider Panel (Tag="divider", 1px) → body TableLayoutPanel.
- **ModifyForm field grid pattern:** base_pnl (Tag="base", Dock=Fill, padding 28/24) → fields_table (160px label col + fill input col, 52px rows). Row 0: search_row Panel (Dock=Fill TextBox Tag="flat" + Dock=Right IconButton Tag="outlined" MagnifyingGlass). All labels Tag="muted", all TextBoxes Tag="flat". Button type: `FontAwesome.Sharp.IconButton`.
- **ModifySale 2-column layout:** root_table (48%/52%, Dock=Top) → left_pnl (sale_fields + cart_section with accent title + divider + cart_fields + cart_buttons: cta CartPlus + outlined TrashCan) → right_pnl (Tag="card", DataGridView Dock=Fill). base_pnl has AutoScroll=true for full-form scrolling.
- **Filter controls:** Attach tooltips to specific labels via `ToolTipHelp.AddToolTip(label, text)` — never form-level.

---

## 📂 Project Structure

```
Classes/Data/
  ├── DTOs/ (11 filter criteria + AnalyticsResult, AnomalyPoint)
  ├── Interfaces/ (8 interfaces for services, AI, data)
  ├── Repositories/ (GenericRepository<T>)
  └── Services/ (AnalyticsFacade, 8 CRUD + 2 Schedulers + AI providers)

Classes/Models/ (12 EF entities + AiForecast, EconometricModel, AiStockRecommendation)
Classes/Settings/ (AppSettings, SettingsManager, PathsManager)
Classes/Utils/ (SecurityService, SessionManager, SmartStockContext, ThemeManager, ActivityLogger, EmailService, etc.)

Forms/
  ├── User Control/
  │   ├── AddForms/ (8 + base)
  │   ├── ModifyForms/ (8 + base)
  │   ├── SearchForms/ (8 filters)
  │   └── AnalysisForms/ (DemandForecast, CorrelationAnalysis, StockOptimization, LanguageQuery)
  ├── LoginForms/ (Login, AddAccount, MailConfirmation, Settings)
  └── Main: LoginForm, MenuForm, AnalyzeForm, SearchForm, SettingsForm
```

---

## 🎨 ThemeManager — 12-Color Palette

**Dark (Midnight Cobalt):** Background #0E1420 | Surface #161D2E | SurfaceHover #1E2740 | Accent #F5B547 (amber) | TextPrimary #E6EBF5 | TextSecondary #94A0B8 | Border #252E47 | Success/Warning/Danger

**Light:** Background #FAFAF7 | Surface #F0EFE9 | Accent #0D7D6B (teal) | TextPrimary #1A1D1A | TextSecondary #5C615E | Border #D4D1C5

**Rule:** 60–30–10 (Background–Surface–Accent). Legacy aliases: `LightColor → Surface`, `DarkColor → Background`, `Text → TextPrimary`.

---

## ⚙️ Config & Bootstrap

| Config | Location | Purpose |
|---|---|---|
| **paths.cfg** | Resources/ | Database + appSettings.json paths (loaded first) |
| **appSettings.json** | (PathsManager.SettingsFilePath) | Theme, API keys, feature flags, log settings |
| **.env** | Project root | Fallback for API keys (DEEPSEEK_API_KEY, ALPHAVANTAGE_API_KEY, PREDICTHQ_API_KEY) |
| **activity.log** | LogFilePath or Resources/ | User actions, AI ops, system events (thread-safe, rotates at LogMaxSizeMb) |

**Load order:** PathsManager → SettingsManager → DB Migrate → ReportScheduler.Start → ExternalFactorsScheduler.Start (deferred 2 min).

---

## 🔐 Security & Auth

- **SessionManager:** Static, holds CurrentUser after login.
- **Login flow:** Username/password → SHA-256 hash + salt check → 3-fail lockout → email code validation → session set.
- **Multi-provider AI:** DeepSeek, OpenAI, Claude selectable in SettingsForm; key resolution deferred at call-time (not constructor).
- **Email accounts:** `smartstock.auth@gmail.com` (AuthPassword) for codes | `smartstock.reports@gmail.com` (ReportsPassword) for reports.

---

## 📊 Analytics & Scheduling

| Feature | Files | Firing conditions |
|---|---|---|
| **External Factors Fetch** | ExternalFactorsFetchService, ExternalFactorsScheduler | Enabled + 23h cooldown + ±5min of FetchTime |
| **Weekly Report** | WeeklyReportService, ReportScheduler | Enabled + non-empty recipient + 7d cooldown + ±5min of ReportTime |
| **Anomaly Detection** | AnalyticsFacade.ComputeAnomalyDetection | Z-score threshold (1.5/2.0/2.5/3.0), aggregation level (Daily/Weekly/Monthly) |
| **EOQ Model** | AnalyticsFacade.ComputeEoq | Q* = √(2DS/H), SS = z·σ_d·√L, ROP = d̄·L + SS |

---

## 📝 Logging

`ActivityLogger` (static, thread-safe, file-locked):

| Action | Used in |
|---|---|
| ADD/MODIFY/ARCHIVE/RESTORE/DELETE | All 8 CRUD services |
| DEMAND_FORECAST / CORRELATION / STOCK_OPTIMIZATION / ANOMALY_DETECTION / TEXT_TO_SQL | AnalyticsFacade, TextToSqlService |
| EXTERNAL_FETCH | ExternalFactorsFetchService |

Log levels: **Info** (all) | **Warning** (noise suppressed) | **Error** (always writes, bypasses level filter).

---

---

## ✅ Session Progress: ModifyForm UI Redesign

**Completed:** 2026-04-16
- **ModifySupplier.Designer.cs** — Converted to Tag-based field grid (6 rows: Supplier ID+search, Name, Contact Person, Email, Phone, Address)
- **ModifyTransaction.Designer.cs** — Converted to Tag-based field grid (7 rows: Transaction ID+search, Product ID, Entity ID, User ID, Quantity, Type ComboBox, Date DateTimePicker)
- **ModifyUser.Designer.cs** — Converted to Tag-based field grid (8 rows: User ID+search, Username, Full Name, Password, Email, Role ComboBox, Is Active CheckBox, Failed Count)

All three use the standardized pattern: base_pnl (Tag="base") → fields_table (160px label + fill input, 52px rows) → Row 0 search_row (TextBox Tag="flat" + IconButton Tag="outlined"). Button changed from `Button` to `FontAwesome.Sharp.IconButton` (MagnifyingGlass icon).

---

## 🔗 See Also

- [/docs/FEATURES.md](docs/FEATURES.md) — Full feature checklist
- [/docs/UI_ARCHITECTURE.md](docs/UI_ARCHITECTURE.md) — AnalyzeForm, ModifySale cart, SettingsForm scroll patterns
- [/docs/SYSTEMS.md](docs/SYSTEMS.md) — Detailed architecture of Forecasting, Weekly Reports, External Factors, Logging
- [/docs/PATTERNS.md](docs/PATTERNS.md) — Repository ClearChanges, BindingList DataSource, Filter tooltips, ThemeManager evolution
- `.claude/rules/solid.md` — SOLID principles
