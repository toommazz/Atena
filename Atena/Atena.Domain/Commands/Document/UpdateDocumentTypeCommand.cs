using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Document;

namespace Atena.Domain.Commands.Document
{
    public class UpdateDocumentTypeCommand : DocumentTypeCommand, IUpdateCommand
    {
        public UpdateDocumentTypeCommand(
            Guid? id,
            string name,
            string description) : base(id, name, description) 
        {
            Id= id;
            Name= name; 
            Description= description;
        }
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public override bool IsValid()
        {
            ValidationResult = new UpdateDocumentTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
