using Atena.Domain.Model;
using Atena.Domain.Repositories;
using Atena.Infra.Contexts.Base;
using Atena.Infra.Repositories.Base;

namespace Atena.Infra.Repositories
{
    public class DocumentTypeRepository : SqlServerRepository<DocumentType>, IDocumentTypeRepository
    {
        public DocumentTypeRepository(AtenaDataContext context) : base(context)
        {
        }
    }
}
