using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Contact.PhoneType;

namespace Atena.Domain.Commands.Contact.PhoneType
{
    public class UpdatePhoneTypeCommand : PhoneTypeCommand, IUpdateCommand
    {
        public UpdatePhoneTypeCommand(
            Guid? id, 
            string name, 
            string description) : base (id, name, description) 
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
            ValidationResult = new UpdatePhoneTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
