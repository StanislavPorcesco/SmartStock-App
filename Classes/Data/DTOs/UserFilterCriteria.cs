namespace SmartStock.Classes.Data.DTOs
{
    /// <summary>
    /// DTO pentru transportul criteriilor de filtrare User
    /// </summary>
    public class UserFilterCriteria
    {
        public bool? IsActive { get; set; }
        public string Role { get; set; } // Admin, Manager, Operator
        public bool? IsLoggedIn { get; set; }
        public string SearchText { get; set; } // Username, FullName, Email
        public DateTime? LastLoginFrom { get; set; }
        public DateTime? LastLoginTo { get; set; }
        public string SortBy { get; set; } = "Username";
        public string SortOrder { get; set; } = "asc";
        public int PageSize { get; set; } = 50;
        public int PageNumber { get; set; } = 1;
    }
}
