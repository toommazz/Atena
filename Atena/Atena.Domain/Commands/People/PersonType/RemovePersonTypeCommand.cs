using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People.PersonType;
using FluentValidation.Results;

namespace Atena.Domain.Commands.People.PersonType
{
    public class RemovePersonTypeCommand : PersonTypeCommand, IRemoveCommand
    {
        public RemovePersonTypeCommand(Guid? id) : base(id)
        {

            Id=id;
            Status = "0"; //Excluido
            
        }
        public override bool IsValid()
        {
            ValidationResult = new RemovePersonTypeValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
