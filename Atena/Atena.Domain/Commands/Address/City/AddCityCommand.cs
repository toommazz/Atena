
using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Address.City;

namespace Atena.Domain.Commands.Address.City
{
    public class AddCityCommand : CityCommand, IAddCommand
    {
        public AddCityCommand(
            Guid? id,
            string name,
            string description) : base(id, name, description) { }
        public override bool IsValid()
        {
            ValidationResult = new AddCityValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
