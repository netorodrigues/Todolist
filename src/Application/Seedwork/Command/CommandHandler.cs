using MediatR;

namespace Application.Seedwork.Command
{
    public abstract class CommandHandler<TCommand> : IRequestHandler<TCommand, CommandResult> where TCommand : Command
    {
        public abstract Task<CommandResult> Handle(TCommand request, CancellationToken cancellationToken);
    }
}
