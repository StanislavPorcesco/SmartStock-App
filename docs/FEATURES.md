# SmartStock Features Checklist

## 1. Authentication & Security
- [X] RBAC (Administrator/Operator)
- [X] Brute-force protection (3-fail lockout in `UserService`)
- [X] Session management (`SessionManager`)
- [X] Password hashing (SHA-256 + salt in `SecurityService`)

## 2. Settings & Configuration
- [X] Theme switching (Light/Dark via `ThemeManager`)
- [ ] Multilingual UI (Language property exists in `AppSettings`, infrastructure incomplete)
- [X] AI API key management (multi-provider, deferred resolution)
- [X] Settings persistence (`appSettings.json`)
- [X] Database path configuration (`PathsManager`)
- [X] Activity logging (thread-safe file append with rotation)

## 3. CRUD & Search
- [X] Full CRUD for 8 entity types (Category, Customer, Product, Sale, Supplier, Transaction, ExternalFactor, User)
- [X] Input validation (all Add/Modify forms)
- [X] Advanced filtering (8 `Filter*` controls with `IFilterControl`)

## 4. Analytics & AI
- [X] Demand forecasting (OLS + trend bands via `EconometricEngine`)
- [X] Correlation analysis (Pearson r, real t-test)
- [X] Stock optimization (EOQ: Q* = √(2DS/H), ROP = d̄·L + SS)
- [X] Anomaly detection (Z-score, tolerance band μ±Nσ)
- [X] Text-to-SQL (NLQ → SQL via `TextToSqlService`)
- [X] Dynamic visualization (LiveCharts: trends, bands, scatter)
- [X] Automated weekly reports (HTML email with Sales Snapshot, AI Alerts, Action Plan, PNG chart)
- [X] Result persistence (AI forecasts, econometric models, stock recommendations stored in DB)

## 5. Background Tasks
- [X] External factors fetch (4 sources: Alpha Vantage, World Bank, PredictHQ, Open-Meteo; daily cooldown, ±5min window)
- [X] Weekly report scheduler (7-day cooldown, ±5min window)
- [X] Proper startup/shutdown (deferred start, clean Application.ApplicationExit)
