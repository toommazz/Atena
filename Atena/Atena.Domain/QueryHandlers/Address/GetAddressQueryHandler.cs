using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetAddressQueryHandler : MediatorQueryHandler<GetAddressQuery, Address>
    {
        private readonly IAddressRepository _repository;

        public GetAddressQueryHandler(
            IAddressRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }
        public override async Task<Address> AfterValidation(GetAddressQuery request)
        {
            return await _repository.GetOneAsync(x => x.Id == request.Id);
        }
    }
}
