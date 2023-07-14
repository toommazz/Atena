using Atena.Domain.Commands.Address.City;
using Atena.Domain.Core.CommandHandles;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Events;
using Atena.Domain.Model;
using AutoMapper;

namespace Atena.Domain.CommandHandlers
{
    public class AddCityCommandHandler : CommandHandlerAdd<AddCityCommand, City, AddedCityEvent>
    {
        public AddCityCommandHandler(IMediatorHandler mediator, IMapper mapper, IRepository<City> repository) : base(mediator, mapper, repository)
        {
        }
    }
}
