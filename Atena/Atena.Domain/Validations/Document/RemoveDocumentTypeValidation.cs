using Atena.Domain.Commands.Document;

namespace Atena.Domain.Validations.Document
{
    public class RemoveDocumentTypeValidation : DocumentTypeValidation<RemoveDocumentTypeCommand>
    {
        public RemoveDocumentTypeValidation()
        {
            ValidateId();
        }
    }
}
