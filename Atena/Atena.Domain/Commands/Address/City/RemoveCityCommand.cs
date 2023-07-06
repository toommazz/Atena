using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.Address.City;
using FluentValidation.Results;

namespace Atena.Domain.Commands.Address.City
{
    public class RemoveCityCommand : CityCommand, IRemoveCommand
    {
        public RemoveCityCommand(Guid? id) : base(id) 
        {
            Id = id;
            Status = "0"; //Excluido
        }
        public override bool IsValid()
        {
            ValidationResult = new RemoveCityValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
