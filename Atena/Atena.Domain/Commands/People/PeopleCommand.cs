using Atena.Domain.Core;

namespace Atena.Domain.Commands.People
{
    public class PeopleCommand : Command
    {
        public PeopleCommand(Guid? id) : base(id) { }

        public PeopleCommand(
            Guid? id,
            string name,
            string lastName,
            Guid genderTypeId,
            Guid personTypeId,
            Guid maritalStatusTypeId,
            string status = "1",
            DateTime included = default,
            DateTime updated = default
            ) : base(id, status, included, updated)
        {
            Id= id;
            Name = name;
            LastName = lastName;
            GenderTypeId = genderTypeId;
            PersonTypeId = personTypeId;
            MaritalStatusTypeId = maritalStatusTypeId;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public Guid GenderTypeId { get; set; }
        public Guid PersonTypeId { get; set; }
        public Guid MaritalStatusTypeId { get; set; }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
