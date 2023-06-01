using Domain.Entities.ProjectAgg.ValueObjects;
using Domain.Seedwork;
using DomainTask = Domain.Entities.TaskAgg.Task;


namespace Domain.Entities.ProjectAgg
{
    public sealed class Project
    {
        public EntityCode Id { get; private set; }
        public string Name { get; private set; }
        public HexColor Color { get; private set; }
        public IEnumerable<DomainTask> Tasks { get; private set; }

        public Project(string name, string color)
        {
            Id = new EntityCode();
            Name = name;
            Color = new HexColor(nameof(Project), color);
            Tasks = Array.Empty<DomainTask>();
        }

        public Project(string projectId, string name, string color, IEnumerable<DomainTask> tasks)
        {
            Id = new EntityCode(nameof(Project), projectId);
            Name = name;
            Color = new HexColor(nameof(Project), color);
            Tasks = tasks;
        }
    }
}
