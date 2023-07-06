using Atena.Domain.Commands.Address.City;
using FluentValidation;

namespace Atena.Domain.Validations.Address.City
{
    public class CityValidation<T> : AbstractValidator<T>
        where T : CityCommand
    {
        protected void ValidateId()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O campo ID é obrigatório!");
        }
        protected   void Validate() 
        { 
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O nome da cidade é um campo obrigatório!");
        }
    }
}
