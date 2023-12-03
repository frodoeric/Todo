
using System;

namespace Todo.Domain.Entities
{    
    public class TodoItem(string title, bool done, DateTime createdAt, string user) : Entity
    {
        public string Title { get; } = title;
        public bool Done { get; } = done;
        public DateTime CreatedAt { get; } = createdAt;
        public string User { get; } = user;

        public void MarkAsDone() => done = true;
        public void MarkAsUndone() => done = false;
        public static void UpdateTitle(string title) => _ = title;
    }
    
}
