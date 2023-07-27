using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People;

namespace Atena.Domain.Commands.People
{
    public class UpdatePeopleCommand : PeopleCommand, IUpdateCommand
    {
        public UpdatePeopleCommand(Guid? id,
            string name,
            string firstName,
            string lastName,
            Guid genderTypeId,
            Guid personTypeId,
            Guid maritalStatusId
            ) : base(id, name, lastName, genderTypeId, personTypeId, maritalStatusId)
        {
            Id= id;
            Name = name;
            FirstName = firstName;
            LastNAme = lastName;
            GenderTypeId = genderTypeId;
        }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastNAme { get; set; }
        public Guid? GenderTypeId { get; set; }

        public override bool IsValid()
        {
            ValidationResult = new UpdatePeopleValidation().Validate(this);
            return ValidationResult.IsValid;
        }

}
}
