using Atena.Domain.Core.Model;

using Atena.Domain.Core.Model;

namespace Atena.Domain.Model
{
    public class PersonType : Entity
    {
        public PersonType(Guid? id) : base(id) { }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
