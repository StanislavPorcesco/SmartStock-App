namespace SmartStock.Classes.Data.DTOs
{
    /// <summary>
    /// DTO complex pentru filtrarea avansată a vânzărilor.
    /// Permite interogări corelate (Sales -> SaleDetails -> Products).
    /// </summary>
    public class SaleFilterCriteria
    {
        // 1. Identificatori și Status
        public bool? IsActive { get; set; } = true;
        public int? CustomerId { get; set; }
        public int? UserId { get; set; }
        public string PaymentStatus { get; set; } // Paid, Pending, Cancelled
        public string PaymentMethod { get; set; } // Cash, Card, Transfer

        // 2. Căutare Text Globală (Căutare în Nume Client sau Username vânzător)
        public string SearchText { get; set; }

        // 3. Filtre de Dată (Intervale)
        public DateTime? SaleDateFrom { get; set; }
        public DateTime? SaleDateTo { get; set; }

        // 4. Filtre Valorice (Intervale de sumă)
        public decimal? TotalAmountMin { get; set; }
        public decimal? TotalAmountMax { get; set; }

        // 5. FILTRE COMPLEXE (Deep Filtering)

        // Găsește vânzările care conțin cel puțin o dată acest produs
        public int? ContainsProductId { get; set; }

        // Găsește vânzările care conțin produse dintr-o anumită categorie
        public int? ContainsCategoryId { get; set; }

        // Filtrare după volumul vânzării (ex: vânzări cu peste 10 produse pe bon)
        public int? MinItemsCount { get; set; }
        public int? MaxItemsCount { get; set; }

        // 6. Sortare și Paginare
        public string SortBy { get; set; } = "SaleDate"; // SaleDate, TotalAmount, CustomerName
        public string SortOrder { get; set; } = "desc";
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 0; // 0 = Fără paginare (Toate)
    }
}