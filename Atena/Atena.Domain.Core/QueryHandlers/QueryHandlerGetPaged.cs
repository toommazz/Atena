
using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Model;
using Atena.Domain.Core.Querys;
using Atena.Domain.Core.Repositories;

namespace Atena.Domain.Core.QueryHandlers
{
    public abstract class QueryHandlerGetPaged<TQuery, TResponse>
        : MediatorQueryHandler<TQuery, PagedList<TResponse>>
        where TResponse : Entity
        where TQuery: GetPagedQuery<TResponse>
    {
        IRepository<TResponse> _repository;

        public QueryHandlerGetPaged(IMediatorHandler mediator, 
            IRepository<TResponse> repository) : base(mediator) 
        { 
            _repository = repository;
        }

        public override async Task<PagedList<TResponse>> AfterValidation(TQuery request)
        {
            var resultado = await _repository.GetAllPagedAsync(
                request.Order, request.Page, request.Filter);

            return resultado;
        }
    }
}
