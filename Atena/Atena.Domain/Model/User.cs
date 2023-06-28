
using Atena.Domain.Core.Model;

namespace Atena.Domain.Model
{
    public class User : Entity
    {
        public User(Guid? id) : base ( id )
        {
            Id = id;
        }
        public Guid? Id { get; set; }
    }
}
