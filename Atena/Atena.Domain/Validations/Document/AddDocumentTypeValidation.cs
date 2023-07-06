using Atena.Domain.Commands.Document;

namespace Atena.Domain.Validations.Document
{
    public class AddDocumentTypeValidation : DocumentTypeValidation<AddDocumentTypeCommand>
    {
        public AddDocumentTypeValidation() 
        {
            Validate();
        }
    }
}
