using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class UpdateDocumentTypeEvent : EventCore<DocumentType>
    {
        public UpdateDocumentTypeEvent(DocumentType _entity) : base(_entity)
        {
        }
    }
}
