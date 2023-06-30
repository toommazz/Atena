
using Atena.Domain.Core.Model;

namespace Atena.Domain.Model
{
    public class GenderType : Entity 
    {
        public GenderType(Guid? id) : base(id) { }

        public string Name { get; set; }
        public string Description { get; set; }

    }
}
