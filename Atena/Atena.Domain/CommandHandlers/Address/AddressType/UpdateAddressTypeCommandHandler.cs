using Atena.Domain.Commands.Address.AddressType;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers
{
    public class UpdateAddressTypeCommandHandler : CommandHandlerUpdate<UpdateAddressTypeCommand, AddressType, UpdateAddressTypeEvent>
    {
        public UpdateAddressTypeCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<AddressType> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
