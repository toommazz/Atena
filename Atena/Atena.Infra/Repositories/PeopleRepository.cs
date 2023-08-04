using Atena.Domain.Core.Model;
using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;
using Microsoft.Identity.Client;
using System.Linq;
using System.Linq.Expressions;

namespace Atena.Infra.Repositories
{
    public class PeopleRepository : SqlServerRepository<People>, IPeopleRepository
    {
        public PeopleRepository(AtenaDataContext context) : base(context) { }
    }
}
