using Atena.Domain.Commands.People.MaritalType;
using Atena.Domain.Core.Interfaces;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Notifications;
using Atena.Domain.Model;
using Atena.Domain.Queries;
using Atena.Service.Interfaces;
using Atena.Service.ViewModels;
using AutoMapper;

namespace Atena.Service.Services
{
    public class MaritalStatusTypeService : AppService<MaritalStatusTypeViewModel, MaritalStatusType,
        AddMaritalStatusTypeCommand, UpdateMaritalStatusTypeCommand, RemoveMaritalStatusTypeCommand,
        GetMaritalStatusTypeQuery, GetPagedMaritalStatusTypeQuery>, IMaritalStatusTypeService
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediator;
        private readonly DomainNotificationHandler _notifications;
        private readonly IUnitOfWork _unitOfWork;

        public MaritalStatusTypeService(IMapper mapper, IMediatorHandler mediator, IUnitOfWork unitOfWork) : base(mapper, mediator, unitOfWork)
        {
            _mapper = mapper;
            _mediator = mediator;
            _notifications = (DomainNotificationHandler)mediator.GetNotificationHandler();
            _unitOfWork = unitOfWork;
        }
    }
}
