using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Document;
using FluentValidation.Results;

namespace Atena.Domain.Commands.Document
{
    public class RemoveDocumentTypeCommand : DocumentTypeCommand, IRemoveCommand
    {
        public RemoveDocumentTypeCommand(Guid? id) : base(id)
        {
            Id= id;
            Status = "0";//Excluido
        }
        public override bool IsValid()
        {
            ValidationResult = new RemoveDocumentTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
