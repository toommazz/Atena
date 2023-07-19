using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;


namespace Atena.Domain.QueryHandler
{
    public class GetAddressTypeQueryHandler : MediatorQueryHandler<GetAddressTypeQuery, AddressType>
    {
        private readonly IAddressTypeRepository _repository;

        public GetAddressTypeQueryHandler(
            IAddressTypeRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }
        public override async Task<AddressType> AfterValidation(GetAddressTypeQuery request)
        {
            return await _repository.GetOneAsync(x => x.Id == request.Id);
        }
    }
}