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
- [ ] Motor de căutare bazat pe expresii regulate (regex) — filtrele curente folosesc comparație text simplă, nu regex

### 4. Modulul de Analiză Predictivă și Inteligență Artificială
- [X] Prognoza vânzărilor (serii de timp) — `DemandForecast`, `AnalyticsFacade`, `EconometricEngine` (OLS + trend bands)
- [X] Corelație și regresie liniară cu factori externi — `CorrelationAnalysis` + `EconometricEngine.CalculateCorrelation` (Pearson r, t-test real)
- [X] UI pentru optimizarea stocurilor — `StockOptimization` control cu parametri (HoldingCost, OrderingCost, LeadTime, RiskTolerance)
- [X] Modelul EOQ complet (Economic Order Quantity) — `Q* = √(2DS/H)`, `SS = z·σ_d·√L`, `ROP = d̄·L + SS`, curba de cost U-shaped în `AnalyticsFacade.ComputeEoq`
- [X] Determinarea punctului de reaprovizionare (Reorder Point) — calculat statistic în modelul EOQ
- [ ] Generare SQL asistată de AI (Text-to-SQL) — nicio infrastructură
- [ ] Detectarea anomaliilor în date istorice — nicio infrastructură
- [X] Vizualizare grafică dinamică — `AnalyzeForm` cu LiveCharts (linii trend, benzi CI/PI, prognoză)
- [ ] Trimitere automată de rapoarte prin e-mail — `EmailService` există pentru confirmarea contului, nu pentru rapoarte econometrice
