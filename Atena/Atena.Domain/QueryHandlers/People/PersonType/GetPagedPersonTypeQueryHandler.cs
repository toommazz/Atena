using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;


namespace Atena.Domain.QueryHandler
{
    public class GetPagedPersonTypeQueryHandler : MediatorQueryHandler<GetPagedPersonTypeQuery, PagedList<PersonType>>
    {
        private readonly IPersonTypeRepository _repository;

        public GetPagedPersonTypeQueryHandler(
            IPersonTypeRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<PagedList<PersonType>> AfterValidation(GetPagedPersonTypeQuery request)
        {
            return await _repository.GetAllPagedAsync(request.Order, request.Page, null, request.Filter);
        }
    }
}
