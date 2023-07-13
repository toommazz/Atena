using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class RemovedDocumentTypeEvent : EventCore<DocumentType>
    {
        public RemovedDocumentTypeEvent(DocumentType _entity) : base(_entity)
        {
        }
    }
}
