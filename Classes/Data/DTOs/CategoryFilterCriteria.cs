namespace SmartStock.Classes.Data.DTOs
{
    /// <summary>
    /// DTO pentru transportul criteriilor de filtrare Category
    /// </summary>
    public class CategoryFilterCriteria
    {
        public bool? IsActive { get; set; }
        public string SearchText { get; set; }
        public string SortBy { get; set; } = "CategoryName";
        public string SortOrder { get; set; } = "asc";
        public int PageSize { get; set; } = 50;
        public int PageNumber { get; set; } = 1;
    }
}
