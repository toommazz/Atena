using Atena.Domain.Commands.People.PersonType;
using FluentValidation;

namespace Atena.Domain.Validations.People.PersonType
{
    public class PersonTypeValidation<T> : AbstractValidator<T>
        where T : PersonTypeCommand
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
