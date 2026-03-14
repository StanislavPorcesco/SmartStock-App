namespace SmartStock.Classes.Data.DTOs
{
    /// <summary>
    /// DTO pentru transportul criteriilor de filtrare Transaction
    /// </summary>
    public class TransactionFilterCriteria
    {
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public int? EntityId { get; set; }
        public string Type { get; set; } // "Stock In", "Stock Out", "Adjustment"
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public int? QuantityMin { get; set; }
        public int? QuantityMax { get; set; }
        public string SortBy { get; set; } = "Date";
        public string SortOrder { get; set; } = "desc";
        public int PageSize { get; set; } = 50;
        public int PageNumber { get; set; } = 1;
    }
}
