using Atena.Domain.Commands.People.Client;
using FluentValidation;

namespace Atena.Domain.Validations.People.Client
{
    public class ClientValidation<T> : AbstractValidator<T>
        where T : ClientCommand
    {
        protected void ValidateId()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("O código é obrigatório");
        }

        protected void Validate()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O nome é obrigatório!");

        }
    }
}
