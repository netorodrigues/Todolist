using Domain.Exceptions;
using Domain.Seedwork;

namespace Domain.Entities.TaskAgg
{
    public sealed class Task
    {
        public EntityCode Id { get; private set; }
        public EntityCode ProjectId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool Done { get; private set; }
        public DateTime? ScheduledDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public Task(string title, string description, string projectId, DateTime? scheduledDate = null)
        {
            Id = new EntityCode();
            ProjectId = new EntityCode(nameof(Task), projectId);
            Title = title;
            Description = description;
            Done = false;
            SetDueDate(scheduledDate);
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Task(string taskId, string projectId, string title, string description,
            bool done, DateTime createdAt, DateTime updatedAt, DateTime? scheduledDate = null)
        {
            Id = new EntityCode(nameof(Task), taskId);
            ProjectId = new EntityCode(nameof(Task), projectId);
            Title = title;
            Description = description;
            Done = done;
            SetDueDate(scheduledDate);
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public void SetDueDate(DateTime? scheduledDate)
        {
            if (scheduledDate < DateTime.UtcNow)
                throw new DomainException($"Can't define a schedule date lower than now for task {Id}");

            ScheduledDate = scheduledDate;
        }


    }
}