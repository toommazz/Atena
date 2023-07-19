using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetDocumentTypeQueryHandler : MediatorQueryHandler<GetDocumentTypeQuery, DocumentType>
    {
        private readonly IDocumentTypeRepository _repository;

        public GetDocumentTypeQueryHandler(IDocumentTypeRepository repository,
            IMediatorHandler mediator) : base(mediator)        
        {
            _repository = repository;
        }
    public override async Task<DocumentType> AfterValidation(GetDocumentTypeQuery request)
    {
        return await _repository.GetOneAsync(x => x.Id == request.Id);
    }

}
}
