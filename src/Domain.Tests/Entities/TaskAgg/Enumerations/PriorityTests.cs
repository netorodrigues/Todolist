using Ardalis.SmartEnum;
using Domain.Entities.TaskAgg.Enumerations;
using FluentAssertions;

namespace Domain.Tests.Entities.TaskAgg.Enumerations
{
    public class PriorityTests
    {
        [Fact(DisplayName = @" CASE 01:
            GIVEN A create priority object
            SHOULD throw exception
            WHEN string received is not a valid priority")]
        public void ShouldThrowException_WhenDueDateIsLowerThenNow()
        {
            //arrange
            //act
            var result = () => Priority.FromName("invalid-priority");

            //assert
            result.Should().Throw<SmartEnumNotFoundException>();
        }

        [Fact(DisplayName = @" CASE 02:
            GIVEN A create priority object
            SHOULD build object")]
        public void ShouldBuildPriorityObject()
        {
            //arrange
            //act
            var result = () => Priority.FromName(nameof(Priority.Priority1));

            //assert
            result.Should().NotThrow<SmartEnumNotFoundException>();
        }
    }
}
