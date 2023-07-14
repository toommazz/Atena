using Atena.Domain.Commands.Document;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers.Login
{
    public class AddDocumentTypeCommandHandler : CommandHandlerAdd<AddDocumentTypeCommand, DocumentType, AddedDocumentTypeEvent>
    {
        public AddDocumentTypeCommandHandler(IMediatorHandler mediator, IMapper mapper, Core.Repositories.IRepository<DocumentType> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
