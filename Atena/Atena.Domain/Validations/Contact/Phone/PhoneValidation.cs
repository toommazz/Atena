using Atena.Domain.Commands.Contact.Phone;
using FluentValidation;

namespace Atena.Domain.Validations.Contact.Phone
{
    public class PhoneValidation<T> : AbstractValidator<T>
        where T : PhoneCommand
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
