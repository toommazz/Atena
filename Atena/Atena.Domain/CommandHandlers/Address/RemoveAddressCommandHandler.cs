using Atena.Domain.Commands.Address;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers
{
    public class RemoveAddressCommandHandler : CommandHandlerRemove<RemoveAddressCommand, Address, RemovedAddressEvent>
    {
        public RemoveAddressCommandHandler(IMediatorHandler mediator, IMapper mapper, Core.Repositories.IRepository<Address> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
