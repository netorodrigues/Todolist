using Domain.Entities.CustomerAgg.ValueObjects;
using Domain.Entities.TagAgg.ValueObjects;
using DomainTask = Domain.Entities.TaskAgg.Task;

namespace Domain.Entities.TagAgg
{
    public class Tag
    {
        public TagId Id { get; private set; }
        public CustomerId CustomerId { get; private set; }

        public TagColor Color { get; private set; }
        public bool IsFavorite { get; private set; }
        private List<DomainTask>? _tasks;
        public IReadOnlyList<DomainTask>? Tasks => _tasks?.AsReadOnly();

        public Tag(string id, string customerId, IEnumerable<DomainTask>? tasks, string hexColor, bool isFavorite)
        {
            Id = new TagId(id);
            CustomerId = new CustomerId(customerId);
            DefineTasks(tasks);
            Color = new TagColor(hexColor);
            IsFavorite = isFavorite;
        }

        public Tag(string customerId, IEnumerable<DomainTask>? tasks, string hexColor, bool isFavorite)
        {
            Id = new TagId();
            CustomerId = new CustomerId(customerId);
            DefineTasks(tasks);
            Color = new TagColor(hexColor);
            IsFavorite = isFavorite;
        }

        private void DefineTasks(IEnumerable<DomainTask>? tasks)
        {
            if (tasks is null) return;

            _tasks = tasks.ToList();
            _tasks.ForEach(task => task.AddTag(this));
        }

        public void AddTask(DomainTask? task)
        {
            if (task is null) return;

            _tasks ??= new List<DomainTask>();

            _tasks.Add(task);
            task.AddTag(this);
        }
    }
}
