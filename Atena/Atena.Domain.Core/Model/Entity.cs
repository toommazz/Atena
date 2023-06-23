
namespace Atena.Domain.Core.Model
{
    public abstract class Entity
    {
        public Entity(Guid? id)
        {
            Id = id;
        }

        public Guid? Id { get; set; }
    }
}