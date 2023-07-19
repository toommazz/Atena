using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetEmailQueryHandler : MediatorQueryHandler<GetEmailQuery, Email>
    {
        private readonly IEmailRepository _repository;

        public GetEmailQueryHandler(
            IEmailRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<Email> AfterValidation(GetEmailQuery request)
        {
            return await _repository.GetOneAsync(x => x.Id == request.Id);
        }
    }
}
