using MediatR;

namespace Application.Seedwork.Query
{
    public abstract class QueryHandler<TQuery> : IRequestHandler<TQuery, QueryResult> where TQuery : Query
    {
        public abstract Task<QueryResult> Handle(TQuery request, CancellationToken cancellationToken);
    }
}
