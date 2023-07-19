using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class StateRepository : SqlServerRepository<State>, IStateRepository
    {
        public StateRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
