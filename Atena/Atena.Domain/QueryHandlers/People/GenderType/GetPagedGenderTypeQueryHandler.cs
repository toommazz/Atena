using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPagedGenderTypeQueryHandler : MediatorQueryHandler<GetPagedGenderTypeQuery, PagedList<GenderType>>
    {
        private readonly IGenderTypeRepository _repository;

        public GetPagedGenderTypeQueryHandler(
            IGenderTypeRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<PagedList<GenderType>> AfterValidation(GetPagedGenderTypeQuery request)
        {
            return await _repository.GetAllPagedAsync(request.Order, request.Page, request.Filter);
        }
    }
}
