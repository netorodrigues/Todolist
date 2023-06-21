using Domain.Seedwork;

namespace Domain.Entities.ProjectAgg.ValueObjects
{
    public sealed record ProjectColor : HexColor<Project>
    {
        public ProjectColor(string color) : base(color)
        {
        }
    }
}
