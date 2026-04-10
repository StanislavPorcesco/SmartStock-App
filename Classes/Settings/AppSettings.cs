
namespace SmartStock.Classes.Settings
{
    public class AppSettings
    {
        public string Theme { get; set; } = "Light";
        public string Language { get; set; } = "en-US";
        public string DeepSeekApiKey { get; set; } = string.Empty;
        public string OpenAIApiKey { get; set; } = string.Empty;
    }
}
