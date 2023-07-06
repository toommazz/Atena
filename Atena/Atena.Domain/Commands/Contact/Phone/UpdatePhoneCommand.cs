using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Contact.Phone;


namespace Atena.Domain.Commands.Contact.Phone
{
    public  class UpdatePhoneCommand : PhoneCommand, IUpdateCommand
    {
        public UpdatePhoneCommand(
            Guid? id, 
            string name, 
            string description) : base(id, name, description)
        {
            Id=id;
            Name=name;
            Description=description;
        }
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new UpdatePhoneValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
