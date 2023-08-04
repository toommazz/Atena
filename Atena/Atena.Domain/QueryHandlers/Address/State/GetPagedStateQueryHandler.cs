using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPagedStateQueryHandler : MediatorQueryHandler<GetPagedStateQuery, PagedList<State>>
    {
        private readonly IStateRepository _repository;

        public GetPagedStateQueryHandler(
            IStateRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }
        public override async Task<PagedList<State>> AfterValidation(GetPagedStateQuery request)
        {
            return await _repository.GetAllPagedAsync(request.Order, request.Page, null, request.Filter);
        }
    }
}
