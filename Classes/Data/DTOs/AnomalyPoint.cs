namespace SmartStock.Classes.Data.DTOs
{
    public class AnomalyPoint
    {
        public DateTime Date { get; set; }
        public decimal ActualValue { get; set; }
        public decimal ExpectedValue { get; set; }
        public decimal ZScore { get; set; }
        public string Description { get; set; } = string.Empty;
        public int DataIndex { get; set; }
    }
}
