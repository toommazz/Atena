using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPagedEmailTypeQueryHandler : MediatorQueryHandler<GetPagedEmailTypeQuery, PagedList<EmailType>>
    {
        private readonly IEmailTypeRepository _repository;

        public GetPagedEmailTypeQueryHandler(
            IEmailTypeRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<PagedList<EmailType>> AfterValidation(GetPagedEmailTypeQuery request)
        {
            return await _repository.GetAllPagedAsync(request.Order, request.Page, request.Filter);
        }
    }
}