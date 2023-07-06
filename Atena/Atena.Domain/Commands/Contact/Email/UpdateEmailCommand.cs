using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Contact.Email;

namespace Atena.Domain.Commands.Contact.Email
{
    public class UpdateEmailCommand : EmailCommand, IUpdateCommand
    {
        public UpdateEmailCommand(
            Guid? id, 
            string name,
            string description
            ) : base (id, name, description ) 
        {
            Name= name;
            Description= description;
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new UpdateEmailValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
