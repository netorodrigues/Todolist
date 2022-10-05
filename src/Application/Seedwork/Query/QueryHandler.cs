using MediatR;

namespace Application.Seedwork.Query
{
    public abstract class QueryHandler : IRequestHandler<Query, QueryResult>
    {
        public abstract Task<QueryResult> Handle(Query request, CancellationToken cancellationToken);
    }
}
