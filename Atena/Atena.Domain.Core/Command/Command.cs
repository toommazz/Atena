using Atena.Domain.Core.Events;
using Atena.Domain.Core.Extensions;
using FluentValidation.Results;

namespace Atena.Domain.Core
{
    public abstract class Command : CommandMessage
    {
        public Command(Guid? id, string situacao = "1", DateTime dataInclusao = default, DateTime dataAlteracao = default)
        {
            Id = id;
            DataInclusao = dataInclusao;
            DataAlteracao = dataAlteracao;
            Situacao = situacao;
        }

        public Guid? Id { get; protected set; }

        public DateTime DataInclusao { get; protected set; }

        public DateTime DataAlteracao { get; protected set; }

        public string Situacao { get; protected set; }

        public ValidationResult ValidationResult { get; set; } = new ValidationResult();

        protected Command()
        {
            DataInclusao = DateTime.Now.ToBrasilianTimezone();
        }

        public abstract bool IsValid();
    }
}
