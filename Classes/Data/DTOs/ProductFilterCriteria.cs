namespace SmartStock.Classes.Data.DTOs
{
    /// <summary>
    /// DTO (Data Transfer Object) pentru transportul criteriilor de filtrare
    /// de la UI (Presentation Layer) către Service (Business Logic Layer).
    /// </summary>
    public class ProductFilterCriteria
    {
        /// <summary>
        /// Filtru după ID-ul categoriei.
        /// </summary>
        public int? CategoryId { get; set; }

        /// <summary>
        /// Filtru după ID-ul furnizorului.
        /// </summary>
        public int? SupplierId { get; set; }

        /// <summary>
        /// Filtru după starea produsului (activ/inactiv).
        /// </summary>
        public bool? IsActive { get; set; }

        /// <summary>
        /// Filtru pentru produse cu stoc sub limita de siguranță.
        /// </summary>
        public bool? OnlyUnderSafetyLimit { get; set; }

        /// <summary>
        /// Preț minim pentru filtrare după interval de preț.
        /// </summary>
        public decimal? MinPrice { get; set; }

        /// <summary>
        /// Preț maxim pentru filtrare după interval de preț.
        /// </summary>
        public decimal? MaxPrice { get; set; }

        /// <summary>
        /// Stoc minim pentru filtrare după interval de stoc.
        /// </summary>
        public int? MinStock { get; set; }

        /// <summary>
        /// Stoc maxim pentru filtrare după interval de stoc.
        /// </summary>
        public int? MaxStock { get; set; }

        /// <summary>
        /// Text de căutare pentru nume produs (partial match).
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Sortare după proprietate (ex: "ProductName", "UnitPrice").
        /// </summary>
        public string SortBy { get; set; } = "ProductId";

        /// <summary>
        /// Ordinea sortării: "asc" pentru crescător, "desc" pentru descrescător.
        /// </summary>
        public string SortOrder { get; set; } = "asc";

        /// <summary>
        /// Numărul de înregistrări pe pagină (pentru paginare).
        /// </summary>
        public int PageSize { get; set; } = 50;

        /// <summary>
        /// Pagina curentă (pentru paginare).
        /// </summary>
        public int PageNumber { get; set; } = 1;
    }
}
