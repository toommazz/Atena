using Atena.Domain.Core.Data;
using Atena.Domain.Core;

namespace Atena.Domain.Queries
{
    public abstract class PhoneTypeQuery<TResponse> : Query<TResponse>
    {
        public Guid? Id { get; set; }

        public Page Page { get; set; }

        public Order Order { get; set; }

        public Restriction Restriction { get; set; }
    }
}
