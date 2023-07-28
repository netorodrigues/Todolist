using Domain.Entities.ProjectAgg.ValueObjects;
using Domain.Entities.TaskAgg.ValueObjects;
using Domain.Exceptions;
using FluentAssertions;
using DomainTask = Domain.Entities.TaskAgg.Task;

namespace Domain.Tests.Entities.TaskAgg
{
    public class TaskTests
    {
        [Fact(DisplayName = @" CASE 01:
            GIVEN A task object build
            SHOULD create task object")]
        public void ShouldCreateTask()
        {
            //arrange
            var title = "task-title";
            var description = "task-description";
            var projectId = new ProjectId();


            //act
            var result = new DomainTask(title, description, projectId.Code.ToString());

            //assert
            result.Should().NotBeNull();
            result.Id.Should().NotBeNull();
            result.Title.Should().Be(title);
            result.Description.Should().Be(description);
            result.ProjectId.Should().Be(projectId);
            result.Done.Should().BeFalse();
            result.Priority.Should().BeNull();
            result.ScheduledDate.Should().BeNull();
            result.CreatedAt.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(1));
            result.UpdatedAt.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(1));

        }

        #region SetPriority
        [Fact(DisplayName = @" CASE 02:
            GIVEN A set priority in task object
            SHOULD throw exception
            WHEN receive a invalid priority")]
        public void ShouldThrowException_WhenPriorityIsInvalid()
        {
            //arrange
            var task = BuildTask();


            //act
            var result = () => task.SetPriority("invalid-priority");

            //assert
            result.Should().Throw<DomainException>();

        }

        [Fact(DisplayName = @" CASE 03:
            GIVEN A set priority in task object
            SHOULD not set priority
            WHEN receives a null value")]
        public void ShouldNotSetPriority_WhenPriorityReceivedIsNull()
        {
            //arrange
            var task = BuildTask();


            //act
            task.SetPriority(null);

            //assert
            task.Priority.Should().BeNull();

        }
        #endregion

        #region SetDueDate
        [Fact(DisplayName = @" CASE 04:
            GIVEN A set due date in task object
            SHOULD throw exception
            WHEN receives a date lower than now")]
        public void ShouldThrowException_WhenDueDateIsLowerThenNow()
        {
            //arrange
            var task = BuildTask();

            //act
            var result = () => task.SetDueDate(DateTime.UtcNow.AddMinutes(-5));

            //assert
            result.Should().Throw<DomainException>();

        }
        #endregion
        private static DomainTask BuildTask()
        {
            return new DomainTask("a task title", "a task description", new TaskId().Code.ToString());
        }
    }
}
