using Domain.ValueObjects;

namespace Domain.Entities
{
    public sealed class Task
    {
        public EntityCode Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool Done { get; private set; }
        public DateTime? ScheduledDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public Task(string title, string description, DateTime? scheduledDate = null)
        {
            Id = new EntityCode();
            Title = title;
            Description = description;
            Done = false;
            ScheduledDate = scheduledDate;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }


    }
}