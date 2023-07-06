using Atena.Domain.Commands.Address.State;
using FluentValidation;

namespace Atena.Domain.Validations.Address.State
{
    public class StateValidation<T> : AbstractValidator<T>
        where T : StateCommand
    {
        protected void ValidateId()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O compo ID é obrigatório!");
        }
        protected void Validate()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O campo nome é obrigatório!");
        }

    }
}
