using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations;

namespace Atena.Domain.Commands.People
{
    public class AddPeopleCommand : PeopleCommand, IAddCommand
    {
        public AddPeopleCommand(
            Guid? id,
            string name,
            string firstName,
            string lastName,
            Guid genderTypeId
            ) : base(id, name, firstName, lastName, genderTypeId) { }
        public override bool IsValid()
        {
            ValidationResult = new AddPeopleValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
