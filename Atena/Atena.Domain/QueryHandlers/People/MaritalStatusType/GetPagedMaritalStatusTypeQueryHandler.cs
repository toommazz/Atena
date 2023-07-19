using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPagedMaritalStatusTypeQueryHandler : MediatorQueryHandler<GetPagedMaritalStatusTypeQuery, PagedList<MaritalStatusType>>
    {
        private readonly IMaritalStatusTypeRepository _repository;

        public GetPagedMaritalStatusTypeQueryHandler(
            IMaritalStatusTypeRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override  async Task<PagedList<MaritalStatusType>> AfterValidation(GetPagedMaritalStatusTypeQuery request)
        {
            return await _repository.GetAllPagedAsync(request.Order, request.Page, request.Filter);
        }
    }
}
