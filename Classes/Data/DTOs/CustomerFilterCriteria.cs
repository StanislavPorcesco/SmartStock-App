namespace SmartStock.Classes.Data.DTOs
{
    /// <summary>
    /// DTO pentru transportul criteriilor de filtrare Customer
    /// </summary>
    public class CustomerFilterCriteria
    {
        // 1. Căutare Text (Nume, Email, Telefon)
        public string SearchText { get; set; }

        // 2. Locație
        public string City { get; set; }

        // 3. Status (null = Toți, true = Activ, false = Inactiv)
        public bool? IsActive { get; set; }

        // 4. Perioadă Înregistrare (Range)
        public DateTime? RegisteredFrom { get; set; }
        public DateTime? RegisteredTo { get; set; }

        // 5. Criterii de Performanță (Filtrare după volumul de vânzări)
        public int? MinSalesCount { get; set; }
        public int? MaxSalesCount { get; set; }

        // 6. Valoare totală cheltuită (Total Spent)
        public decimal? MinTotalSpent { get; set; }
        public decimal? MaxTotalSpent { get; set; }

        // 7. Sortare și Paginare
        public string SortBy { get; set; } = "FullName"; // Implicit după nume
        public string SortOrder { get; set; } = "asc";    // Implicit ascendent
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 0; // 0 înseamnă fără paginare
    }
}
