using Atena.Domain.Commands.People;
using Atena.Domain.Commands.People.Client;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers.Login
{
    public class AddPeopleCommandHandler : CommandHandlerAdd<AddPeopleCommand, People, AddedPeopleEvent>
    {
        public AddPeopleCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<People> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
