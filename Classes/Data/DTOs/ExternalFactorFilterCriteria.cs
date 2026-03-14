namespace SmartStock.Classes.Data.DTOs
{
    /// <summary>
    /// DTO pentru transportul criteriilor de filtrare ExternalFactor
    /// </summary>
    public class ExternalFactorFilterCriteria
    {
        public string FactorType { get; set; }
        public string Region { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public decimal? ImpactValueMin { get; set; }
        public decimal? ImpactValueMax { get; set; }
        public string ValueType { get; set; } // Absolute, Percentage, Multiplier
        public bool? IsActive { get; set; }
        public string SortBy { get; set; } = "Date";
        public string SortOrder { get; set; } = "desc";
        public int PageSize { get; set; } = 50;
        public int PageNumber { get; set; } = 1;
    }
}
