
namespace SmartStock.Classes.Settings
{
    public class AppSettings
    {
        public string Theme { get; set; } = "Light";
        public string Language { get; set; } = "en-US";
        public string DeepSeekApiKey { get; set; } = string.Empty;
        public string OpenAIApiKey { get; set; } = string.Empty;
        public string ClaudeApiKey { get; set; } = string.Empty;
        public string SelectedAiProvider { get; set; } = "DeepSeek";
        public double AiTemperature { get; set; } = 0.2;
        public string AlphaVantageApiKey { get; set; } = string.Empty;
        public string PredictHQApiKey { get; set; } = string.Empty;
        public string WorldBankCountryCode { get; set; } = "RO";
        public double WeatherLatitude { get; set; } = 45.9432;
        public double WeatherLongitude { get; set; } = 24.9668;
        public string WeatherRegion { get; set; } = "Romania";
        public bool ExternalFactorsFetchEnabled { get; set; } = false;
        public string ExternalFactorsFetchTime { get; set; } = "08:00";
        public DateTime? LastExternalFactorsFetched { get; set; } = null;

        // Weekly report settings
        public bool WeeklyReportsEnabled { get; set; } = false;
        public string ReportRecipientEmail { get; set; } = string.Empty;
        public string ReportScheduleTime { get; set; } = "08:00"; // HH:mm
        public DateTime? LastWeeklyReportSent { get; set; } = null;

        // Logging settings
        public bool LoggingEnabled { get; set; } = false;
        public bool AiLoggingEnabled { get; set; } = false;
        public string LogFilePath { get; set; } = string.Empty;
        public string LogLevel { get; set; } = "Info";   // Info | Warning | Error
        public int LogMaxSizeMb { get; set; } = 10;
    }
}
