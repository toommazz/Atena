
using Atena.Domain.Commands.Document;
using FluentValidation;

namespace Atena.Domain.Validations.Document
{
    public class DocumentTypeValidation<T> : AbstractValidator<T>
        where T : DocumentTypeCommand
    {
        protected void ValidateId()
        {
            RuleFor(x => x.Id)
                .NotEmpty()
                .WithMessage("O campo Id é obrigatório!");
        }
        protected void Validate()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O campo nome é obrigatório!");
        }
    }
}
