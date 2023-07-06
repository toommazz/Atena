using Atena.Domain.Commands.People.MaritalType;
using FluentValidation;

namespace Atena.Domain.Validations.People.MaritalType
{
    public class MaritalTypeValidation<T> : AbstractValidator<T>
        where T : MaritalTypeCommand
    {
        protected void ValidateId()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O campo id é obrigatório!");
        }
        protected void Validate()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O campo nome é obrigatório!");
        }
    }
}
