namespace SmartStock.Classes.Data.DTOs
{
    /// <summary>
    /// DTO pentru transportul criteriilor de filtrare Category
    /// </summary>
    public class CategoryFilterCriteria
    {
        public string SearchText { get; set; }
        public bool? IsActive { get; set; }
        public int? MinProducts { get; set; }
        public int? MaxProducts { get; set; }
        public decimal? MinValue { get; set; }
        public decimal? MaxValue { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 0;
        public string SortBy { get; set; }
        public string SortOrder { get; set; }
    }
}
