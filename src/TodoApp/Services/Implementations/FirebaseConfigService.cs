using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using TodoApp.Services.Interfaces;

namespace TodoApp.Services.Implementations
{
    public class FirebaseConfigService : IFirebaseConfigService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<FirebaseConfigService> _logger;

        public FirebaseConfigService(HttpClient httpClient, ILogger<FirebaseConfigService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<string> GetFirebaseConfigAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<string>("firebase-config.json");
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex, "Firebase設定ファイルの読み込みに失敗しました。");
                throw;
            }
        }
    }
}