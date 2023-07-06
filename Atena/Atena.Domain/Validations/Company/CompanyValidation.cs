using Atena.Domain.Commands.Company;
using FluentValidation;

namespace Atena.Domain.Validations.Company
{
    public class CompanyValidation<T> : AbstractValidator<T>
        where T : CompanyCommand
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
            RuleFor(x => x.Cnpj)
                .NotEmpty()
                .WithMessage("O CNPJ é obrigatório!");

        }
    }
}
