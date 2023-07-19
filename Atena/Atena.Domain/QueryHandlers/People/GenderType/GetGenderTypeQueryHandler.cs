using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetGenderTypeQueryHandler : MediatorQueryHandler<GetGenderTypeQuery, GenderType>
    {
        private readonly IGenderTypeRepository _repository;

        public GetGenderTypeQueryHandler(
            IGenderTypeRepository repository,
            IMediatorHandler mediator) : base (mediator)
        {
            _repository = repository;
        }

        public override  async Task<GenderType> AfterValidation(GetGenderTypeQuery request)
        {
            return await _repository.GetOneAsync(x => x.Id == request.Id);
        }
    }
}
