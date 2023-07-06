using Atena.Domain.Commands.People.GenderType;
using FluentValidation;

namespace Atena.Domain.Validations.People.GenderType
{
    public class GenderTypeValidation<T> : AbstractValidator<T>
        where T : GenderTypeCommand
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
