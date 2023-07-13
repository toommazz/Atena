using Atena.Domain.Core.Events;
using Atena.Domain.Model;

namespace Atena.Domain.Events
{
    public class AddedDocumentTypeEvent : EventCore<DocumentType>
    {
        public AddedDocumentTypeEvent(DocumentType _entity) : base(_entity)
        {
        }
    }
}
