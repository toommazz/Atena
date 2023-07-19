using Atena.Domain.Core;
using Atena.Domain.Core.Data;

namespace Atena.Domain.Queries
{
    public abstract class CompanyQuery<TResponse> : Query<TResponse>
    {
        public Guid? Id { get; set; }

        public Page Page { get; set; }

        public Order Order { get; set; }

        public Restriction Restriction { get; set; } 
    }
}
