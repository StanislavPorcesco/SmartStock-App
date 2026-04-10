namespace SmartStock.Classes.Data.DTOs
{
    /// <summary>
    /// Rezultatul complet al modelului EOQ (Economic Order Quantity).
    ///
    /// Formulele implementate:
    ///   Q* = √(2 × D × S / H)                    — cantitatea optimă de comandă
    ///   SS = z × σ_d × √L                         — stocul de siguranță (distribuție normală)
    ///   ROP = d̄ × L + SS                          — punctul de reaprovizionare
    ///   TC = (D/Q*) × S + (Q*/2 + SS) × H         — cost total anual la Q*
    /// </summary>
    public class EoqResult
    {
        // ── Parametri introduși de utilizator ───────────────────────────────────
        public decimal OrderingCostPerOrder { get; set; }    // S — cost per comandă
        public decimal HoldingCostPerUnit { get; set; }      // H = (h/100) × UnitPrice
        public int LeadTimeDays { get; set; }                // L — timp de livrare (zile)
        public decimal ServiceLevel { get; set; }            // 0.90 / 0.95 / 0.99
        public decimal ZScore { get; set; }                  // z — scorul z al nivelului de serviciu

        // ── Statistici cerere (derivate din date istorice) ─────────────────────
        public decimal DailyDemandMean { get; set; }         // d̄ — cerere medie zilnică
        public decimal DailyDemandStdDev { get; set; }       // σ_d — abaterea standard zilnică
        public decimal AnnualDemand { get; set; }            // D = d̄ × 365

        // ── Rezultate EOQ ───────────────────────────────────────────────────────
        public decimal EoqQuantity { get; set; }             // Q* — cantitate optimă
        public decimal SafetyStock { get; set; }             // SS — stoc de siguranță
        public decimal ReorderPoint { get; set; }            // ROP — punct de reaprovizionare
        public decimal OrdersPerYear { get; set; }           // N = D / Q*
        public decimal CycleTimeDays { get; set; }           // T = Q* / d̄ (zile)

        // ── Descompunere cost anual la Q* ───────────────────────────────────────
        public decimal OrderingCostPerYear { get; set; }     // (D / Q*) × S
        public decimal HoldingCostPerYear { get; set; }      // (Q*/2 + SS) × H
        public decimal TotalAnnualCost { get; set; }         // TC = ordering + holding

        // ── Date curba de cost pentru grafic (60 puncte, Q ∈ [0.15Q*, 3Q*]) ───
        // Afișează curba caracteristică în formă de U care demonstrează
        // că Q* minimizează costul total.
        public List<double> TotalCostCurve { get; set; } = new();
        public List<double> OrderingCostCurve { get; set; } = new();
        public List<double> HoldingCostCurve { get; set; } = new();
        public List<string> QuantityLabels { get; set; } = new();
    }
}
