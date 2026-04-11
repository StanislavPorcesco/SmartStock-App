
namespace SmartStock.Classes.Settings
{
    public class AppSettings
    {
        public string Theme { get; set; } = "Light";
        public string Language { get; set; } = "en-US";
        public string DeepSeekApiKey { get; set; } = string.Empty;
        public string OpenAIApiKey { get; set; } = string.Empty;

        // Weekly report settings
        public bool WeeklyReportsEnabled { get; set; } = false;
        public string ReportRecipientEmail { get; set; } = string.Empty;
        public string ReportScheduleTime { get; set; } = "08:00"; // HH:mm
        public DateTime? LastWeeklyReportSent { get; set; } = null;
    }
}
