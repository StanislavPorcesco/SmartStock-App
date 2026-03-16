namespace SmartStock.Classes.Data.DTOs
{
    /// <summary>
    /// DTO pentru transportul criteriilor de filtrare ExternalFactor
    /// </summary>
    /// <summary>
    /// DTO avansat pentru filtrarea factorilor externi.
    /// Conceput pentru analize economice detaliate și corelații AI.
    /// </summary>
    public class ExternalFactorFilterCriteria
    {
        // 1. Căutare Text și Identificare
        public string SearchText { get; set; } // Căutare în Description și Region

        // Permitem filtrarea simultană după mai multe tipuri (ex: Economic + Weather)
        public List<string> FactorTypes { get; set; } = new List<string>();

        // 2. Filtre Geografice și Status
        public string Region { get; set; }
        public bool? IsActive { get; set; }

        // 3. Filtre de Timp Granulare (Crucial pentru sezonalitate)
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

        // Filtrare după luni specifice (ex: vrei să vezi doar factorii care apar în Decembrie de-a lungul anilor)
        public List<int> SpecificMonths { get; set; } // 1-12

        // Filtrare după zilele săptămânii (ex: weekend vs zile lucrătoare)
        public List<DayOfWeek> SpecificDays { get; set; }

        // 4. Analiză de Impact (Severitate)
        public decimal? ImpactValueMin { get; set; }
        public decimal? ImpactValueMax { get; set; }

        // Permite filtrarea după tipul de calcul (Procentual vs Absolut)
        public List<string> ValueTypes { get; set; } // Absolute, Percentage, Multiplier

        /// <summary>
        /// Filtrează doar impactul "Semnificativ" (ex: valori peste un anumit prag definit în logică)
        /// Util pentru a curăța "zgomotul" de date mici.
        /// </summary>
        public bool? OnlyHighImpact { get; set; }

        /// <summary>
        /// Filtrează după direcția impactului: Pozitiv (creștere) sau Negativ (scădere).
        /// </summary>
        public ImpactDirection? Direction { get; set; }

        // 5. Sortare și Paginare avansată
        public string SortBy { get; set; } = "Date"; // Date, ImpactValue, FactorType, Region
        public string SortOrder { get; set; } = "desc";
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 50;
    }

    public enum ImpactDirection
    {
        Any = 0,
        Positive, // ImpactValue > 0 sau Multiplier > 1
        Negative  // ImpactValue < 0 sau Multiplier < 1
    }
}
