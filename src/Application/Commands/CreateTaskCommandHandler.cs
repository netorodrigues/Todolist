using Application.Seedwork.Command;

namespace Application.Commands
{
    public class CreateTaskCommandHandler : CommandHandler<CreateTaskCommand>
    {
        public override async Task<CommandResult> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            await Task.Factory.StartNew(() => { Console.WriteLine("Creating a task and saving in database..."); });
            return new CommandResult(201, "Task Created");
        }
    }
}
