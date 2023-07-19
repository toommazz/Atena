using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class CompanyRepository : SqlServerRepository<Company>, ICompanyRepository
    {
        public CompanyRepository(AtenaDataContext context) : base(context) { }
    }
}
