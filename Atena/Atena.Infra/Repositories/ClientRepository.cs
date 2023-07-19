using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class ClientRepository : SqlServerRepository<Client>, IClientRepository
    {
        public ClientRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
