namespace Atena.Domain.Core.Model
{
    public abstract class Entity
    {
        public Entity(Guid? id)
        {
            Id = id;
        }

        public Guid? Id { get; protected set; }
        public DateTime Included { get; protected set; }
        public DateTime Created { get; protected set; }
        public string Status { get; protected set; } = "1";
        public virtual bool IsValid()
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object? obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;
            return Id.Equals(compareTo.Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907 + Id.GetHashCode());
        }
    }
}