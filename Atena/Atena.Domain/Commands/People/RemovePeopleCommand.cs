using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People;

namespace Atena.Domain.Commands.People
{
    public class RemovePeopleCommand : PeopleCommand, IRemoveCommand
    {
        public RemovePeopleCommand(Guid? id) : base(id)
        {
            Id = id;
            Status = "0"; //Excluído
        }
        public override bool IsValid()
        {
            ValidationResult = new RemovePeopleValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
