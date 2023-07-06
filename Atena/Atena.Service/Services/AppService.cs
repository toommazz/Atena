using Atena.Domain.Core;
using Atena.Domain.Core.Data;
using Atena.Domain.Core.Interfaces;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Model;
using Atena.Domain.Core.Notifications;
using Atena.Domain.Core.Querys;
using Atena.Domain.Core.Tools;
using Atena.Domain.Interfaces.Commands;
using AutoMapper;


namespace Atena.Service
{
    public class AppService<TView, TEntity, TAddCommand, TUpdadeCommand, 
        TRemovedCommand, TGet, TGetPaged>
        where TView : class
        where TEntity : Entity
        where TAddCommand : Command, IAddCommand
        where TUpdadeCommand: Command, IUpdateCommand
        where TRemovedCommand: Command, IRemoveCommand
        where TGet: QueryCore<TEntity>, new()
        where TGetPaged: GetPagedQuery<TEntity>, new()
    {
        private readonly IMapper _mapper;
        private readonly IMediatorHandler _mediator;
        private readonly DomainNotificationHandler _notifications;
        private readonly IUnitOfWork _unitOfWork;

        public AppService(IMapper mapper, IMediatorHandler mediator, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _mediator = mediator;
            _notifications = (DomainNotificationHandler)mediator.GetNotificationHandler();
            _unitOfWork = unitOfWork;
        }

        public async Task Save(TView model)
        {
            var command = _mapper.Map<TAddCommand>(model);

            await _mediator.SendCommand(command);

            if (_notifications.HasNotifications())
                await _mediator.RaiseEvent(new DomainNotification("Commit", "Não foi possível salvar os dados!"));

            await _unitOfWork.CommitAsync();
        }
        public async Task Update(TView model)
        {
            var command = _mapper.Map<TUpdadeCommand>(model);
            await _mediator.SendCommand(command);

            if (_notifications.HasNotifications()) await _mediator.RaiseEvent(new DomainNotification("Commit", "Não foi possível atualizar os dados!"));

            await _unitOfWork.CommitAsync();
        }

        public async Task Remove(Guid? id)
        {
            var command = InstanceCreator.Create<Guid?, TRemovedCommand>(id) as TRemovedCommand;

            await _mediator.SendCommand(command);

            if(_notifications.HasNotifications()) await _mediator.RaiseEvent(new DomainNotification("Commit", "Não foi possível remover os dados!"));

            await _unitOfWork.CommitAsync();
        }

        public async Task<TView> Get(Guid? id)
        {
            var query = new TGet() { Id = id };
            var result = await _mediator.SendQuery(query);
            return _mapper.Map<TView>(result);
        }

        public async Task<PagedList<TView>> GetPaged(int page, int size,
            string orderProperty, bool orderCrescente)
        {
            var query = new TGetPaged()
            {
                Page = new Page(page, size),
                Order = new Order(orderProperty, orderCrescente)
            };

            var paged = await _mediator.SendQuery(query);

            return _mapper.Map<PagedList<TView>>(paged);
        }
    }
}
