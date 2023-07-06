using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Contact.EmailType;

namespace Atena.Domain.Commands.Contact.EmailType
{
    public class UpdateEmailTypeCommand : EmailTypeCommand, IUpdateCommand
    {    
           public UpdateEmailTypeCommand(
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
            ValidationResult = new UpdateEmailTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }


}
