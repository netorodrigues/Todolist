using MediatR;

namespace Application.Seedwork.Query
{
    public abstract class Query: IRequest<QueryResult>
    {
    }
}
