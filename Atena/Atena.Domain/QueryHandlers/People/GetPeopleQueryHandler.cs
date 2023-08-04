using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;
using System.Linq;

namespace Atena.Domain.QueryHandler
{
    public class GetPeopleQueryHandler : MediatorQueryHandler<GetPeopleQuery, People>
    {
        private readonly IPeopleRepository _repository;

        public GetPeopleQueryHandler(
            IPeopleRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<People> AfterValidation(GetPeopleQuery request)
        {
            return await _repository.GetOneAsync(x => x.Id == request.Id);
        }
    }
}
