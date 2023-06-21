using Api.Requests;
using Application.Commands;

namespace Api.Mappers
{
    public static class TaskCreateRequestToCommand
    {
        public static CreateTaskCommand ToCommand(this TaskCreateRequest task) =>
            new(task.Title, task.Description, task.ScheduledDate);

    }
}


