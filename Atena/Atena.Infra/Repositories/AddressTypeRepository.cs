using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class AddressTypeRepository : SqlServerRepository<AddressType>, IAddressTypeRepository
    {
        public AddressTypeRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
