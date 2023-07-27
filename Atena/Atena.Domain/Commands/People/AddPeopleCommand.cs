using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations;

namespace Atena.Domain.Commands.People
{
    public class AddPeopleCommand : PeopleCommand, IAddCommand
    {
        public AddPeopleCommand(
            Guid? id,
            string name,
            string lastName,
            Guid genderTypeId,
            Guid personTypeId,
            Guid maritalStatusTypeId
            ) : base(id, name, lastName, genderTypeId, personTypeId, maritalStatusTypeId) { }
        public override bool IsValid()
        {
            ValidationResult = new AddPeopleValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
