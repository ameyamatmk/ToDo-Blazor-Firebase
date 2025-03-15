using System;

namespace TodoApp.Models
{
    public class TodoItem
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? DueDate { get; set; }
        public int Priority { get; set; }

        public TodoItem()
        {
            Id = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
            IsCompleted = false;
            Priority = 3;
        }
    }
}