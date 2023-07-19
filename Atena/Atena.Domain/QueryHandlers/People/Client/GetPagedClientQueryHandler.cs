using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPagedClientQueryHandler : MediatorQueryHandler<GetPagedClientQuery, PagedList<Client>>
    {
        private readonly IClientRepository _repository;

        public GetPagedClientQueryHandler(
            IClientRepository repository,
            IMediatorHandler mediator) : base (mediator)
        {
            _repository = repository;
        }

        public override  async Task<PagedList<Client>> AfterValidation(GetPagedClientQuery request)
        {
            return await _repository.GetAllPagedAsync(request.Order, request.Page, request.Filter);
        }
    }
}
