using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using TodoApp.Services.Interfaces;

namespace TodoApp.Services.Implementations
{
    /// <summary>
    /// Firebaseの設定情報を取得するサービス
    /// </summary>
    public class FirebaseConfigService : IFirebaseConfigService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<FirebaseConfigService> _logger;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="httpClient">HTTPクライアント</param>
        /// <param name="logger">ロガー</param>
        public FirebaseConfigService(HttpClient httpClient, ILogger<FirebaseConfigService> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        /// <summary>
        /// Firebaseの設定情報を取得する
        /// </summary>
        /// <returns></returns>
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