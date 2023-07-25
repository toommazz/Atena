

using Atena.Domain.Core.Model;

namespace Atena.Domain.Model.People
{
    public class People : Entity
    {
        public People(Guid? id) : base(id) {}
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid? GenderTypeId { get; set; }

    }
}
