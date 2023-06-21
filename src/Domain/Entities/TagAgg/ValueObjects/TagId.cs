using Domain.Seedwork;

namespace Domain.Entities.TagAgg.ValueObjects
{
    public sealed record TagId: EntityCode<Tag>
    {
        public TagId(string tagId) : base(tagId)
        {
        }

        public TagId() : base()
        {
        }
    }
}
