using Atena.Domain.Core.Model;

namespace Atena.Domain.Model
{
    public class PhoneType : Entity 
    {
        public PhoneType(Guid? id) : base(id) { }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
