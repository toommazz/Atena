using Atena.Domain.Commands.People;
using FluentValidation;

namespace Atena.Domain.Validations.People
{
    public class PeopleValidation<T> : AbstractValidator<T>
        where T : PeopleCommand
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

            RuleFor(x => x.FirstName)
                .NotEmpty()
                .WithMessage("O primeiro nome é obrigatório!");

            RuleFor(x => x.LastNAme)
                .NotEmpty()
                .WithMessage("O último nome é obrigatório!");


        }

    }
}
