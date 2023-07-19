using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPersonTypeQueryHandler : MediatorQueryHandler<GetPersonTypeQuery, PersonType>
    {
        private readonly IPersonTypeRepository _repository;

        public GetPersonTypeQueryHandler(
            IPersonTypeRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<PersonType> AfterValidation(GetPersonTypeQuery request)
        {
            return await _repository.GetOneAsync(x => x.Id == request.Id);
        }
    }
}
