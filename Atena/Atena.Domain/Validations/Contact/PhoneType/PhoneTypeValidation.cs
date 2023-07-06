using Atena.Domain.Commands.Contact.PhoneType;
using FluentValidation;

namespace Atena.Domain.Validations.Contact.PhoneType
{
    public class PhoneTypeValidation<T> : AbstractValidator<T>
        where T : PhoneTypeCommand
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
