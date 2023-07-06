using Atena.Domain.Commands.Document;

namespace Atena.Domain.Validations.Document
{
    public class UpdateDocumentTypeValidation : DocumentTypeValidation<UpdateDocumentTypeCommand>
    {
        public UpdateDocumentTypeValidation() 
        {
            ValidateId();
            Validate();
        
        }
    }
}
