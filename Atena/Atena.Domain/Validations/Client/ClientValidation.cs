using Atena.Domain.Commands.Client;
using FluentValidation;

namespace Atena.Domain.Validations.Client
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
