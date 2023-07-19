using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class GenderTypeRepository : SqlServerRepository<GenderType>, IGenderTypeRepository
    {
        public GenderTypeRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
