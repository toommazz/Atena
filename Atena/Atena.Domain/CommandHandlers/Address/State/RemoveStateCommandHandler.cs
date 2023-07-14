using Atena.Domain.Commands.Address.State;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers
{
    public class RemoveStateCommandHandler : CommandHandlerRemove<RemoveStateCommand, State, RemovedStateEvent>
    {
        public RemoveStateCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<State> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
