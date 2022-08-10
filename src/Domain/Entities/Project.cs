using Domain.ValueObjects;

namespace Domain.Entities
{
    public sealed class Project
    {
        public EntityCode Id { get; private set; }
        public string Name { get; private set; }
        public HexColor Color { get; private set; }
        public Task[] Tasks { get; private set; }

        public Project(string name, string color)
        {
            Id = new EntityCode();
            Name = name;
            Color = new HexColor(nameof(Project), color);
            Tasks = new Task[] {};
        }
    }
}
