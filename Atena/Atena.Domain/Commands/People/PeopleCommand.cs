using Atena.Domain.Core;

namespace Atena.Domain.Commands.People
{
    public class PeopleCommand : Command
    {
        public PeopleCommand(Guid? id) : base(id) { }

        public PeopleCommand(
            Guid? id,
            string name,
            string firstName,
            string lastName,
            Guid genderTypeId,
            string status = "1",
            DateTime included = default,
            DateTime updated = default
            ) : base(id, status, included, updated)
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
            throw new NotImplementedException();
        }
    }
}
