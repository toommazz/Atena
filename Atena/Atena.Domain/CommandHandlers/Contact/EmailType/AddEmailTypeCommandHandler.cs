using Atena.Domain.Commands.Contact.EmailType;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers
{
    public class AddEmailTypeCommandHandler : CommandHandlerAdd<AddEmailTypeCommand, EmailType, AddedEmailTypeEvent>
    {
        public AddEmailTypeCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<EmailType> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
