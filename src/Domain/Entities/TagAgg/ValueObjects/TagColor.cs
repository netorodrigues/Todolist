using Domain.Seedwork;

namespace Domain.Entities.TagAgg.ValueObjects
{
    public sealed record TagColor : HexColor<Tag>
    {
        public TagColor(string color): base(color) 
        {
        }
    }
}
