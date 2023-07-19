using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPhoneTypeQueryHandler : MediatorQueryHandler<GetPhoneTypeQuery, PhoneType>
    {
        private readonly IPhoneTypeRepository _repository;

        public GetPhoneTypeQueryHandler(
            IPhoneTypeRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<PhoneType> AfterValidation(GetPhoneTypeQuery request)
        {
            return await _repository.GetOneAsync(x => x.Id == request.Id);
        }
    }
}
