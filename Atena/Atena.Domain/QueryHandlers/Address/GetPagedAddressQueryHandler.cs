using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPagedAddressQueryHandler : MediatorQueryHandler<GetPagedAddressQuery, PagedList<Address>>
    {
        private readonly IAddressRepository _repository;

        public GetPagedAddressQueryHandler(
            IAddressRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<PagedList<Address>> AfterValidation(GetPagedAddressQuery request)
        {
            return await _repository.GetAllPagedAsync(request.Order, request.Page, request.Filter);
        }
    }
}
