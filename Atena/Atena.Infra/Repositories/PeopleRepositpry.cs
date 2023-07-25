using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class PeopleRepository : SqlServerRepository<People>, IPeopleRepository
    {
        public PeopleRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
