using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Model;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;
using System.Collections.ObjectModel;

namespace Atena.Domain.QueryHandler
{
    public class GetPagedPeopleQueryHandler : MediatorQueryHandler<GetPagedPeopleQuery, PagedList<People>>
    {
        private readonly IPeopleRepository _repository;

        public GetPagedPeopleQueryHandler(
            IPeopleRepository repository,
            IMediatorHandler mediator) : base(mediator)
        {
            _repository = repository;
        }

        public override async Task<PagedList<People>> AfterValidation(GetPagedPeopleQuery request)
        {           
            ICollection<string> include = new Collection<string>();
            include.Add(typeof(GenderType).Name);

            return await _repository.GetAllPagedAsync(request.Order, request.Page, include, request.Filter);
        }
    }
}
