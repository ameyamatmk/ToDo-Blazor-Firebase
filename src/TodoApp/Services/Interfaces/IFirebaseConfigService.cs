using System.Threading.Tasks;

namespace TodoApp.Services.Interfaces
{
    /// <summary>
    /// Firebaseの設定情報を取得するサービスのインターフェース
    /// </summary>
    public interface IFirebaseConfigService
    {
        Task<string> GetFirebaseConfigAsync();
    }

    /// <summary>
    /// Firebaseの設定情報
    /// </summary>
    public class FirebaseConfig
    {
        /// <summary>
        /// FirebaseのAPIキー
        /// </summary>
        public string ApiKey { get; set; }
        /// <summary>
        /// FirebaseのプロジェクトID
        /// </summary>
        public string AuthDomain { get; set; }
        /// <summary>
        /// FirebaseのデータベースURL
        /// </summary>
        public string DatabaseURL { get; set; }
        /// <summary>
        /// FirebaseのプロジェクトID
        /// </summary>
        public string ProjectId { get; set; }
        /// <summary>
        /// Firebaseのストレージバケット
        /// </summary>
        public string StorageBucket { get; set; }
        /// <summary>
        /// Firebaseのメッセージング送信者ID
        /// </summary>
        public string MessagingSenderId { get; set; }
        /// <summary>
        /// FirebaseのアプリID
        /// </summary>
        public string AppId { get; set; }
    }
}