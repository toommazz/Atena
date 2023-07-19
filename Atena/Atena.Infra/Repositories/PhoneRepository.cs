using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class PhoneRepository : SqlServerRepository<Phone>, IPhoneRepository
    {
        public PhoneRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
