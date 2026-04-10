# SOLID Implementation Rules

## Single Responsibility (SRP)
- Forms are ONLY for data display and event capturing.
- Business logic belongs to `AnalyticsFacade` or specific Services.

## Dependency Inversion (DIP)
- Always depend on Abstractions (Interfaces), not concretions.
- Example: Use `IEconometricEngine` in Facade, not the concrete class.

## Interface Segregation (ISP)
- Don't bloat interfaces. Split `IExternalDataProvider` if it handles too many sources.