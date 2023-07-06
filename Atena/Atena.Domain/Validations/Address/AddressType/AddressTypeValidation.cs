using Atena.Domain.Commands.Address.AddressType;
using FluentValidation;

namespace Atena.Domain.Validations.Address.AddressType
{
    public class AddressTypeValidation<T> : AbstractValidator<T>
        where T : AddressTypeCommand
    {
        protected void ValidateeId()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O campo ID é obrigatórrio!");
        }
        protected void Validate()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O campo nome é obrigatório!");
        }
    }
}
