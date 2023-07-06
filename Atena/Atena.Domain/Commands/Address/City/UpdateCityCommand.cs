using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Address.City;

namespace Atena.Domain.Commands.Address.City
{
    public class UpdateCityCommand : CityCommand, IUpdateCommand
    {
        public UpdateCityCommand(
            Guid? id,
            string  name,
            string description) : base(id, name, description) 
        {
            Id= id;
            Name= name; 
            Description= description;
        }
        public Guid? id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public override bool IsValid()
        {
            ValidationResult = new UpdateCityValidation().Validate(this);
            return ValidationResult.IsValid;
        }

    }
}
