
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Model;
using Atena.Domain.Core.Querys;
using Atena.Domain.Core.Repositories;

namespace Atena.Domain.Core.QueryHandlers
{
    public abstract class QueryHandlerGetAsync<TQuery, TResponse>
        : MediatorQueryHandler<TQuery, TResponse>
        where TQuery : GetQuery<TResponse>
        where TResponse : Entity
    {
        IRepository<TResponse> _repository;

        public QueryHandlerGetAsync(IMediatorHandler mediator, IRepository<TResponse> repository)
            : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<TResponse> AfterValidation(TQuery request)
        {
            var resultado = await _repository.GetOneAsync(x => x.Id == request.Id);

            return resultado;
        }
    }
}
