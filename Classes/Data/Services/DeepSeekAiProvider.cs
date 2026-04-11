using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using SmartStock.Classes.Data.Interfaces;
using SmartStock.Classes.Models;
using SmartStock.Classes.Settings;

namespace SmartStock.Classes.Data.Services
{
    public class DeepSeekAiProvider : IAIReasoningProvider
    {
        private const string DefaultModel = "deepseek-chat";
        private static readonly TimeSpan RequestTimeout = TimeSpan.FromSeconds(30);

        private readonly HttpClient _httpClient;

        // Key provided explicitly at construction time (e.g. from tests).
        // May be empty — ResolveApiKey() falls back to SettingsManager at call time.
        private readonly string _constructorApiKey;

        public DeepSeekAiProvider(HttpClient httpClient, string? apiKey = null)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            _httpClient.BaseAddress ??= new Uri("https://api.deepseek.com/");
            _constructorApiKey = apiKey ?? string.Empty;
            // No throw here — key resolution is deferred to GetRecommendationAsync
            // so the provider works even when the form is constructed before the key is saved.
        }

        /// <summary>
        /// Resolves the effective API key at call time:
        /// 1. Constructor-supplied key (if non-empty)
        /// 2. Current SettingsManager value (handles key saved after form was opened)
        /// 3. DEEPSEEK_API_KEY environment variable
        /// </summary>
        private string ResolveApiKey()
        {
            if (!string.IsNullOrWhiteSpace(_constructorApiKey))
                return _constructorApiKey;

            var settingsKey = SettingsManager.Current.DeepSeekApiKey;
            if (!string.IsNullOrWhiteSpace(settingsKey))
                return settingsKey;

            return Environment.GetEnvironmentVariable("DEEPSEEK_API_KEY") ?? string.Empty;
        }

        public async Task<AiStockRecommendation> GetRecommendationAsync(string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
                throw new ArgumentException("Prompt cannot be null or empty.", nameof(prompt));

            var apiKey = ResolveApiKey();
            if (string.IsNullOrWhiteSpace(apiKey))
                throw new InvalidOperationException(
                    "DeepSeek API key is not configured. Please add your API key in Settings and retry.");

            using var cts = new CancellationTokenSource(RequestTimeout);

            try
            {
                using var request = BuildRequest(prompt, apiKey);
                using var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cts.Token);

                var responseContent = await response.Content.ReadAsStringAsync(cts.Token);

                if (!response.IsSuccessStatusCode)
                {
                    throw new InvalidOperationException(
                        $"DeepSeek API request failed with status {(int)response.StatusCode}: {responseContent}");
                }

                var aiContent = ExtractAssistantMessage(responseContent);
                return ParseRecommendation(aiContent);
            }
            catch (TaskCanceledException ex) when (!cts.Token.IsCancellationRequested)
            {
                throw new TimeoutException("DeepSeek API request timed out.", ex);
            }
            catch (HttpRequestException ex)
            {
                throw new InvalidOperationException("Network error while calling DeepSeek API.", ex);
            }
            catch (JsonException ex)
            {
                throw new InvalidOperationException("Invalid JSON response from DeepSeek API.", ex);
            }
        }

        private static HttpRequestMessage BuildRequest(string prompt, string apiKey)
        {
            const string systemMessage =
                "You are an inventory optimization assistant. " +
                "Always respond with a valid JSON object using EXACTLY this schema — no extra fields, no wrapper keys, no markdown fences: " +
                "{\"suggestedQuantity\": <int>, \"priorityLevel\": \"<Low|Medium|High>\", \"reasoning\": \"<your full analysis as plain text>\"}. " +
                "For analysis tasks where a restock quantity is not applicable, set suggestedQuantity to 0.";

            var body = new
            {
                model = DefaultModel,
                messages = new[]
                {
                    new { role = "system", content = systemMessage },
                    new { role = "user", content = prompt }
                },
                temperature = 0.2
            };

            var request = new HttpRequestMessage(HttpMethod.Post, "chat/completions")
            {
                Content = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json")
            };

            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
            return request;
        }

        private static string ExtractAssistantMessage(string responseContent)
        {
            using var document = JsonDocument.Parse(responseContent);
            var root = document.RootElement;

            var content = root
                .GetProperty("choices")[0]
                .GetProperty("message")
                .GetProperty("content")
                .GetString();

            if (string.IsNullOrWhiteSpace(content))
                throw new InvalidOperationException("DeepSeek API returned an empty response content.");

            return content;
        }

        private static AiStockRecommendation ParseRecommendation(string aiContent)
        {
            var cleanJson = ExtractJsonObject(aiContent);

            if (!string.IsNullOrWhiteSpace(cleanJson))
            {
                using var recDoc = JsonDocument.Parse(cleanJson);
                var root = recDoc.RootElement;

                var quantity = root.TryGetProperty("suggestedQuantity", out var q) && q.ValueKind == JsonValueKind.Number
                    ? q.GetInt32()
                    : 0;

                var priority = root.TryGetProperty("priorityLevel", out var p) && p.ValueKind == JsonValueKind.String
                    ? p.GetString() ?? "Medium"
                    : "Medium";

                var reasoning = ExtractReasoning(root, aiContent);

                return new AiStockRecommendation
                {
                    ProductId = 0,
                    SuggestedQuantity = Math.Max(0, quantity),
                    PriorityLevel = NormalizePriority(priority),
                    Reasoning = TrimToLength(reasoning, 500),
                    CreatedAt = DateTime.Now
                };
            }

            return new AiStockRecommendation
            {
                ProductId = 0,
                SuggestedQuantity = 0,
                PriorityLevel = "Medium",
                Reasoning = TrimToLength(aiContent, 500),
                CreatedAt = DateTime.Now
            };
        }

        private static string ExtractReasoning(JsonElement root, string fallback)
        {
            if (root.TryGetProperty("reasoning", out var r) && r.ValueKind == JsonValueKind.String)
                return r.GetString() ?? fallback;

            // AI wrapped its response in an "analysis" object — flatten string fields into readable text
            if (root.TryGetProperty("analysis", out var analysis) && analysis.ValueKind == JsonValueKind.Object)
            {
                var parts = new List<string>();
                foreach (var prop in analysis.EnumerateObject())
                {
                    if (prop.Value.ValueKind == JsonValueKind.String)
                    {
                        var text = prop.Value.GetString();
                        if (!string.IsNullOrWhiteSpace(text))
                            parts.Add(text);
                    }
                }
                if (parts.Count > 0)
                    return string.Join("\n\n", parts);
            }

            return fallback;
        }

        private static string? ExtractJsonObject(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return null;

            var start = text.IndexOf('{');
            var end = text.LastIndexOf('}');

            if (start < 0 || end <= start)
                return null;

            return text[start..(end + 1)];
        }

        private static string NormalizePriority(string priority)
        {
            return priority.Trim().ToLowerInvariant() switch
            {
                "high" => "High",
                "low" => "Low",
                _ => "Medium"
            };
        }

        private static string TrimToLength(string value, int maxLength)
        {
            if (string.IsNullOrEmpty(value))
                return string.Empty;

            return value.Length <= maxLength ? value : value[..maxLength];
        }
    }
}
