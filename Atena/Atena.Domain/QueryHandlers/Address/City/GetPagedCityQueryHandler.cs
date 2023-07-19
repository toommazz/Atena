using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPagedCityQueryHandler : MediatorQueryHandler<GetPagedCityQuery, PagedList<City>>
    {
        private readonly ICityRepository _repository;

        public GetPagedCityQueryHandler(
            ICityRepository repository,
            IMediatorHandler mediator) : base (mediator)
        {
            _repository = repository;
        }

        public override async Task<PagedList<City>> AfterValidation(GetPagedCityQuery request)
        {
            return await _repository.GetAllPagedAsync(request.Order, request.Page, request.Filter);
        }
    }
}
