using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class MaritalStatusTypeRepository : SqlServerRepository<MaritalStatusType>, IMaritalStatusTypeRepository
    {
        public MaritalStatusTypeRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
