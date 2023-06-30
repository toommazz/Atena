using Atena.Domain.Core.Events;
using Atena.Domain.Core.Extensions;
using FluentValidation.Results;

namespace Atena.Domain.Core
{
    public abstract class Command : CommandMessage
    {
        public Command(Guid? id, string status = "1", DateTime included = default, DateTime updated = default)
        {
            Id = id;
            Included = included;
            Updated = updated;
            Status = status;
        }

        public Guid? Id { get; protected set; }

        public DateTime Included { get; protected set; }

        public DateTime Updated { get; protected set; }

        public string Status { get; protected set; }

        public ValidationResult ValidationResult { get; set; } = new ValidationResult();

        protected Command()
        {
             Included = DateTime.Now.ToBrasilianTimezone();
        }

        public abstract bool IsValid();
    }
}
