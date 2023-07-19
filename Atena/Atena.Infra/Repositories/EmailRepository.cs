using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class EmailRepository : SqlServerRepository<Email>, IEmailRepository
    {
        public EmailRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
