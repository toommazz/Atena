using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Document;

namespace Atena.Domain.Commands.Document
{
    public class AddDocumentTypeCommand : DocumentTypeCommand, IAddCommand
        {  
        public AddDocumentTypeCommand(
            Guid? id,
            string name,
            string description): base(id, name, description) { }
    public override bool IsValid()
        {
            ValidationResult = new AddDocumentTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
