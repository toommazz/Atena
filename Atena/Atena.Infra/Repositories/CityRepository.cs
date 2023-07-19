using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class CityRepository : SqlServerRepository<City>, ICityRepository
    {
        public CityRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
