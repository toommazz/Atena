using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPagedEmailQueryHandler : MediatorQueryHandler<GetPagedEmailQuery, PagedList<Email>>
    {
        private readonly IEmailRepository _repository;

        public GetPagedEmailQueryHandler(
            IEmailRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<PagedList<Email>> AfterValidation(GetPagedEmailQuery request)
        {
            return await _repository.GetAllPagedAsync(request.Order, request.Page, null, request.Filter);
        }
    }
}
