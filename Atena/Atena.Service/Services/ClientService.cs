using Atena.Domain.Commands.People.Client;
using Atena.Domain.Core.Interfaces;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Notifications;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Service.Interfaces;
using Atena.Service.ViewModels;
using AutoMapper;

namespace Atena.Service
{
    public class ClientService : AppService<ClientViewModel,Client,
        AddClientCommand,UpdateClientCommand,RemoveClientCommand,
        GetClientQuery,GetPagedClientQuery>, IClientService
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediator;
        private readonly DomainNotificationHandler _notifications;
        private readonly IUnitOfWork _unitOfWork;

        public ClientService(IMapper mapper, IMediatorHandler mediator, IUnitOfWork unitOfWork) : base(mapper, mediator, unitOfWork)
        {
            _mapper = mapper;
            _mediator = mediator;
            _notifications = (DomainNotificationHandler)mediator.GetNotificationHandler();
            _unitOfWork = unitOfWork;
        }
    }
}
