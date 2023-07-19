using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPhoneQueryHandler : MediatorQueryHandler<GetPhoneQuery, Phone>
    {
        private readonly IPhoneRepository _repository;

        public GetPhoneQueryHandler(
            IPhoneRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<Phone> AfterValidation(GetPhoneQuery request)
        {
            return await _repository.GetOneAsync(x => x.Id == request.Id);
        }
    }
}
