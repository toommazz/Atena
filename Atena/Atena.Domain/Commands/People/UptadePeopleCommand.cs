using Atena.Domain.Interfaces.Commands;
using Atena.Domain.Validations.People;

namespace Atena.Domain.Commands.People
{
    public class UptadePeopleCommand : PeopleCommand, IUpdateCommand
    {
        public UptadePeopleCommand(Guid? id,
            string name,
            string firstName,
            string lastName,
            Guid genderTypeId
            ) : base(id, name, firstName, lastName, genderTypeId)
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
