using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People.MaritalType;

namespace Atena.Domain.Commands.People.MaritalType
{
    public class UpdateMaritalTypeCommand : MaritalTypeCommand, IUpdateCommand
    {
        public UpdateMaritalTypeCommand(
            Guid? id,
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
            ValidationResult = new UpdateMaritalTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }

}
