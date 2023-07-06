using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People.GenderType;

namespace Atena.Domain.Commands.People.GenderType
{
    public class UpdateGenderTypeCommand : GenderTypeCommand, IUpdateCommand
    {
        public UpdateGenderTypeCommand(Guid? id,
            string name,
            string description) : base(id, name, description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public override bool IsValid()
        {
            ValidationResult = new UpdateGenderTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
