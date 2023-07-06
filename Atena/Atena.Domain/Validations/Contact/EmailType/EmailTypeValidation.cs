using Atena.Domain.Commands.Contact.EmailType;
using FluentValidation;

namespace Atena.Domain.Validations.Contact.EmailType
{
    public class EmailTypeValidation<T> : AbstractValidator<T>
        where T : EmailTypeCommand
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
