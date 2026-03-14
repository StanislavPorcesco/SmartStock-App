namespace SmartStock.Classes.Data.DTOs
{
    /// <summary>
    /// DTO pentru transportul criteriilor de filtrare Sale
    /// </summary>
    public class SaleFilterCriteria
    {
        public bool? IsActive { get; set; }
        public int? CustomerId { get; set; }
        public int? UserId { get; set; }
        public string PaymentStatus { get; set; } // Paid, Pending, Cancelled
        public string PaymentMethod { get; set; } // Cash, Card, Transfer
        public DateTime? SaleDateFrom { get; set; }
        public DateTime? SaleDateTo { get; set; }
        public decimal? TotalAmountMin { get; set; }
        public decimal? TotalAmountMax { get; set; }
        public string SortBy { get; set; } = "SaleDate";
        public string SortOrder { get; set; } = "desc";
        public int PageSize { get; set; } = 50;
        public int PageNumber { get; set; } = 1;
    }
}
