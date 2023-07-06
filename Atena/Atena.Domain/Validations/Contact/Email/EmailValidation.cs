using Atena.Domain.Commands.Contact.Email;
using FluentValidation;

namespace Atena.Domain.Validations.Contact.Email
{
    public class EmailValidation<T> : AbstractValidator<T>
        where T : EmailCommand
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
