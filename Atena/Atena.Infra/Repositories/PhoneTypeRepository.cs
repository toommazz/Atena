using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class PhoneTypeRepository : SqlServerRepository<PhoneType>, IPhoneTypeRepository
    {
        public PhoneTypeRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
