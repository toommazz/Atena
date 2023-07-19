using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPagedDocumentTypeQueryHandler : MediatorQueryHandler<GetPagedDocumentTypeQuery, PagedList<DocumentType>>
    {
        private readonly IDocumentTypeRepository _repository;

        public GetPagedDocumentTypeQueryHandler(
            IDocumentTypeRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }
        public override async Task<PagedList<DocumentType>> AfterValidation(GetPagedDocumentTypeQuery request)
        {
            return await _repository.GetAllPagedAsync(request.Order, request.Page, request.Filter);
        }

    }
}
