using Atena.Domain.Core.Events;
using Atena.Domain.Core.Extensions;
using FluentValidation.Results;

namespace Atena.Domain.Core
{
    public abstract class Query<TResponse> : QueryMessage<TResponse>
    {
        public DateTime Timestamp { get; private set; }

        public ValidationResult ValidationResult { get; set; } = new ValidationResult();

        protected Query()
        {
            Timestamp = DateTime.Now.ToBrasilianTimezone();
        }

        public abstract bool IsValid();
    }
}
