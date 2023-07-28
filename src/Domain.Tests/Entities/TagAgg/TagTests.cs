using Domain.Entities.CustomerAgg.ValueObjects;
using Domain.Entities.TagAgg;
using Domain.Entities.TagAgg.ValueObjects;
using Domain.Exceptions;
using Domain.Tests.Fixtures;
using FluentAssertions;
using DomainTasks = Domain.Entities.TaskAgg.Task;

namespace Domain.Tests.Entities.TagAgg
{
    public class TagTests
    {
        [Theory(DisplayName = @"GIVEN a invalid id
SHOULD throw an domain exception
WHEN creating a tag entity")]
        [InlineData("invalid-id", "4f76d7e7-773c-4608-97d7-12834293028f", "#000")]
        [InlineData("4f76d7e7-773c-4608-97d7-12834293028f", "invalid-id", "#000")]
        [InlineData("4f76d7e7-773c-4608-97d7-12834293028f", "4f76d7e7-773c-4608-97d7-12834293028f", "invalid-id")]
        public void Case01(string id, string customerId, string color)
        {
            //arrange
            var tasks = DomainFixture.GenerateTasks();
            var favorite = true;

            //act
            var result = () => new Tag(id, customerId, tasks, color, favorite);

            //assert
            result.Should().Throw<DomainException>();

        }

        [Fact(DisplayName = @"GIVEN a tag creation
SHOULD create a tag object")]
        public void Case02()
        {
            var id = Guid.NewGuid().ToString();
            var customerId = Guid.NewGuid().ToString();
            var color = "#000";
            var tasks = DomainFixture.GenerateTasks();
            var favorite = true;

            var tag = new Tag(id, customerId, tasks, color, favorite);

            tag.Should().NotBeNull();
            tag.Id.Should().Be(new TagId(id));
            tag.CustomerId.Should().Be(new CustomerId(customerId));
            tag.Color.Should().Be(new TagColor(color));
            tag.IsFavorite.Should().Be(favorite);

            tag.Tasks.Should().NotBeEmpty();
            tag.Tasks?
                .Select(tagTask => tagTask.Tags?.Contains(tag) == true)
                .All(x => true);
        }
    }
}
