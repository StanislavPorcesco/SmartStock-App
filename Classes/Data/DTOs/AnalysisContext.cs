namespace SmartStock.Classes.Data.DTOs
{
    public class AnalysisContext
    {
        public int ProductId { get; set; }
        public string AnalysisType { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Dictionary<string, object> Parameters { get; set; } = new();
    }
}
