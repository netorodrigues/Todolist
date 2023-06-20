using Domain.Seedwork;

namespace Domain.Entities.TaskAgg.ValueObjects
{
    public record TaskId : EntityCode<Task>
    {
        public TaskId(string taskId) : base(taskId)
        {
        }
        public TaskId() : base()
        {
        }
    }
}
