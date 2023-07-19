using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandler
{
    public class GetPagedPhoneQueryHandler : MediatorQueryHandler<GetPagedPhoneQuery, PagedList<Phone>>
    {
        private readonly IPhoneRepository _repository;

        public GetPagedPhoneQueryHandler(
            IPhoneRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<PagedList<Phone>> AfterValidation(GetPagedPhoneQuery request)
        {
            return await _repository.GetAllPagedAsync(request.Order, request.Page, request.Filter);
        }
    }
}
