using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class AddressRepository : SqlServerRepository<Address>, IAddressRepository
    {
        public AddressRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
