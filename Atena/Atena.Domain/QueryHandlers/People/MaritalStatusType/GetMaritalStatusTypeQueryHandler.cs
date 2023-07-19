using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetMaritalStatusTypeQueryHandler : MediatorQueryHandler<GetMaritalStatusTypeQuery, MaritalStatusType>
    {
        private readonly IMaritalStatusTypeRepository _repository;

        public GetMaritalStatusTypeQueryHandler(
            IMaritalStatusTypeRepository repository,
            IMediatorHandler mediator) : base (mediator)
        {
            _repository = repository;
        }

        public override async Task<MaritalStatusType> AfterValidation(GetMaritalStatusTypeQuery request)
        {
            return await _repository.GetOneAsync(x => x.Id == request.Id);
        }
    }
}
