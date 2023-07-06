using Atena.Domain.Commands.Address;
using FluentValidation;

namespace Atena.Domain.Validations.Address
{
    public class AddressValidation<T> : AbstractValidator<T>
          where T : AddressCommand
    {
        protected void ValidateId()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .NotEmpty()
                .WithMessage("O código é obrigatório!");
        }

        protected void Validate()
        {
            RuleFor(x => x.ZipCode)
                .NotEmpty()
                .WithMessage("O CEP é obrigatório!");

            RuleFor(x => x.AddressName)
                .NotEmpty()
                .WithMessage("O nome da rua é um campo obrigatório!");

            RuleFor(x => x.Number)
                .NotEmpty()
                .WithMessage("O número é um campo obrigatório!");

            RuleFor(x => x.CityId)
                .NotEmpty()
                .WithMessage("O campo cidade é obrigatório!");

            RuleFor(x => x.StateId)
                .NotEmpty()
                .WithMessage("O campo estado é obrigatório!");

            RuleFor(x => x.District)
                .NotEmpty()
                .WithMessage("O campo bairro é obrigatório!");
        }
    }
}