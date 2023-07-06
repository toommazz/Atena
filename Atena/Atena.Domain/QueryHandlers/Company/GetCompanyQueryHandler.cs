using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.QueryHandlers;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Domain.Repositories;

namespace Atena.Domain.QueryHandlers
{
    public class GetCompanyQueryHandler : MediatorQueryHandler<GetCompanyQuery, Company>
    {
        private readonly ICompanyRepository _repository;

        public GetCompanyQueryHandler(ICompanyRepository repository,
            IMediatorHandler mediator) : base(mediator)        
        {
            _repository = repository;
        }
        public override async Task<Company> AfterValidation(GetCompanyQuery request)
        {
            return await _repository.GetOneAsync(x => x.Id == request.Id);
        }
    }
}
