using Atena.Domain.Commands.People.PersonType;
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
    public class PersonTypeService : AppService<PersonTypeViewModel, PersonType,
        AddPersonTypeCommand, UpdatePersonTypeCommand, RemovePersonTypeCommand,
        GetPersonTypeQuery, GetPagedPersonTypeQuery>, IPersonTypeService
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediator;
        private readonly DomainNotificationHandler _notifications;
        private readonly IUnitOfWork _unitOfWork;
        public PersonTypeService(IMapper mapper, IMediatorHandler mediator, IUnitOfWork unitOfWork) : base(mapper, mediator, unitOfWork)
        {
            _mapper = mapper;
            _mediator = mediator;
            _notifications = (DomainNotificationHandler)mediator.GetNotificationHandler();
            _unitOfWork = unitOfWork;
        }
    }
}
