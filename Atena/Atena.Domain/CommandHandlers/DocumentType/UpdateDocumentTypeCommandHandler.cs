using Atena.Domain.Commands.Document;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers.Login
{
    public class UpdateDocumentTypeCommandHandler : CommandHandlerUpdate<UpdateDocumentTypeCommand, DocumentType, UpdateDocumentTypeEvent>
    {
        public UpdateDocumentTypeCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<DocumentType> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
