namespace SmartStock.Classes.Data.DTOs
{
    /// <summary>
    /// DTO pentru transportul criteriilor de filtrare Customer
    /// </summary>
    public class CustomerFilterCriteria
    {
        public bool? IsActive { get; set; }
        public string SearchText { get; set; }
        public string City { get; set; }
        public DateTime? RegistrationDateFrom { get; set; }
        public DateTime? RegistrationDateTo { get; set; }
        public string SortBy { get; set; } = "FullName";
        public string SortOrder { get; set; } = "asc";
        public int PageSize { get; set; } = 50;
        public int PageNumber { get; set; } = 1;
    }
}
