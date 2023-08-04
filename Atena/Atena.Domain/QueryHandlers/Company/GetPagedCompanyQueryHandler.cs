using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPagedCompanyQueryHandler : MediatorQueryHandler<GetPagedCompanyQuery, PagedList<Company>>
    {
        private readonly ICompanyRepository _repository;

        public GetPagedCompanyQueryHandler(
            ICompanyRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<PagedList<Company>> AfterValidation(GetPagedCompanyQuery request)
        {
            return await _repository.GetAllPagedAsync(request.Order, request.Page, null, request.Filter);
        }
    }
}
