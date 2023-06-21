using Domain.Entities.CustomerAgg.ValueObjects;
using Domain.Entities.ProjectAgg.ValueObjects;
using Domain.Seedwork;
using DomainTask = Domain.Entities.TaskAgg.Task;


namespace Domain.Entities.ProjectAgg
{
    public sealed class Project
    {
        public ProjectId Id { get; private set; }
        public string Name { get; private set; }
        public HexColor Color { get; private set; }
        public IEnumerable<DomainTask> Tasks { get; private set; }
        public CustomerId CustomerId { get; private set; }

        public Project(string name, string color, string customerId)
        {
            Id = new ProjectId();
            Name = name;
            Color = new HexColor(nameof(Project), color);
            Tasks = Array.Empty<DomainTask>();
            CustomerId = new CustomerId(customerId);
        }

        public Project(string projectId, string name, string color, IEnumerable<DomainTask> tasks, string customerId)
        {
            Id = new ProjectId(projectId);
            Name = name;
            Color = new HexColor(nameof(Project), color);
            Tasks = tasks;
            CustomerId = new CustomerId(customerId);
        }
    }
}
