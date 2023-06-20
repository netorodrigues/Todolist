using Domain.Entities.ProjectAgg.ValueObjects;
using Domain.Entities.TaskAgg.Enumerations;
using Domain.Entities.TaskAgg.ValueObjects;
using Domain.Exceptions;

namespace Domain.Entities.TaskAgg
{
    public sealed class Task
    {
        public TaskId Id { get; private set; }
        public ProjectId ProjectId { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool Done { get; private set; }
        public DateTime? ScheduledDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public Priority? Priority { get; private set; }

        public Task(string title, string description, string projectId, string? priority = null, DateTime? scheduledDate = null)
        {
            Id = new TaskId();
            ProjectId = new ProjectId(projectId);
            Title = title;
            Description = description;
            Done = false;
            SetDueDate(scheduledDate);
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
            SetPriority(priority);
        }

        public Task(string taskId, string projectId, string title, string description,
            bool done, DateTime createdAt, DateTime updatedAt, string? priority = null, DateTime? scheduledDate = null)
        {
            Id = new TaskId(taskId);
            ProjectId = new ProjectId(projectId);
            Title = title;
            Description = description;
            Done = done;
            SetDueDate(scheduledDate);
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            SetPriority(priority);
        }

        public void SetPriority(string? priority)
        {
            if (priority is null) return;

            if (Priority.TryFromName(priority, true, out var priorityObject) == false)
                throw new DomainException($"Trying to define invalid priority to task {Id}. Priority value: {priority}");

            Priority = priorityObject;

        }

        public void SetDueDate(DateTime? scheduledDate)
        {
            if (scheduledDate < DateTime.UtcNow)
                throw new DomainException($"Can't define a schedule date lower than now for task {Id}");

            ScheduledDate = scheduledDate;
        }


    }
}