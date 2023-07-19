using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class EmailTypeRepository : SqlServerRepository<EmailType>, IEmailTypeRepository
    {
        public EmailTypeRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
