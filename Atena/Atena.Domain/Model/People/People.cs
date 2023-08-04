using Atena.Domain.Core.Model;

namespace Atena.Domain.Model
{
    public class People : Entity
    {
        public People(Guid? id) : base(id) {}
        public string Name { get; set; }
        public string LastName { get; set; }
        public Guid? GenderTypeId { get; set; }
        public virtual GenderType? GenderType { get; set; }
        public Guid? PersonTypeId { get; set; }
        public PersonType PersonType { get; set; }
        public Guid? MaritalStatusTypeId { get; set; }
        public MaritalStatusType MaritalStatusType { get; set; }
    }
}
