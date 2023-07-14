using Atena.Domain.Commands.Contact.Phone;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers
{
    public class AddPhoneCommandHandler : CommandHandlerAdd<AddPhoneCommand, Phone, AddedPhoneEvent>
    {
        public AddPhoneCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<Phone> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
