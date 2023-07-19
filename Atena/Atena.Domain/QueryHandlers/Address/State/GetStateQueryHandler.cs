using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetStateQueryHandler : MediatorQueryHandler<GetStateQuery, State>
    {
        private readonly IStateRepository _repository;

        public GetStateQueryHandler(
            IStateRepository repository,
            IMediatorHandler mediator) : base(mediator) 
        {
            _repository = repository;
        }

        public override async Task<State> AfterValidation(GetStateQuery request)
        {
            return await _repository.GetOneAsync(x => x.Id == request.Id);
        }
    }

}
