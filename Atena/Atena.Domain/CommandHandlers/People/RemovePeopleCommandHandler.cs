using Atena.Domain.Commands.People.Client;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers.Login
{
    public class RemovePeopleCommandHandler : CommandHandlerRemove<RemoveClientCommand, Client, RemovedClientEvent>
    {
        public RemovePeopleCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<Client> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
