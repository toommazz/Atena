using Atena.Domain.Commands.Address;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers
{
    public class UpdateAddressCommandHandler : CommandHandlerUpdate<UpdateAddressCommand, Address, UpdateAddressEvent>
    {
        public UpdateAddressCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<Address> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
