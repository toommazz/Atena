using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class PersonTypeRepository : SqlServerRepository<PersonType>, IPersonTypeRepository
    {
        public PersonTypeRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
