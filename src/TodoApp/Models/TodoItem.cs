using System;

namespace TodoApp.Models
{
    /// <summary>
    /// Todoアイテム
    /// </summary>
    public class TodoItem
    {
        /// <summary>
        /// ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// ユーザーID
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 詳細
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 完了フラグ
        /// </summary>
        public bool IsCompleted { get; set; }
        /// <summary>
        /// 作成日時
        /// </summary>
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// 期限日
        /// </summary>
        public DateTime? DueDate { get; set; }
        /// <summary>
        /// 優先度
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TodoItem()
        {
            // GUIDを生成してIDに設定
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            IsCompleted = false;
            Priority = 3;
        }
    }
}