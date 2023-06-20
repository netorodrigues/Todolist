using Domain.Seedwork;

namespace Domain.Entities.ProjectAgg.ValueObjects
{
    public record ProjectId : EntityCode<Project>
    {
        public ProjectId(string projectId) : base(projectId)
        {
        }
        public ProjectId() : base()
        {
        }
    }
}
