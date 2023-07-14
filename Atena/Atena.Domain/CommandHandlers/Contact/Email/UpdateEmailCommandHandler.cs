using Atena.Domain.Commands.Contact.Email;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers
{
    public class UpdateEmailCommandHandler : CommandHandlerUpdate<UpdateEmailCommand, Email, UpdateEmailEvent>
    {
        public UpdateEmailCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<Email> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
