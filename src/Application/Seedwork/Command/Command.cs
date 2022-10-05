using MediatR;

namespace Application.Seedwork.Command
{
    public abstract class Command : IRequest<CommandResult>
    {
    }
}
