using Atena.Domain.Core.Events;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Model;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Core.Tools;
using AutoMapper;

namespace Atena.Domain.Core.CommandHandles
{
    public abstract class CommandHandlerRemove<TCommand, TEntity, Event> : MediatorCommandHandler <TCommand>
        where TCommand : Command
        where TEntity : Entity
        where Event : EventCore<TEntity>
    {
        protected IMapper _mapper;

        IRepository<TEntity> _repository;

        public CommandHandlerRemove(IMediatorHandler mediator, IMapper mapper, IRepository<TEntity> repository)
            : base(mediator)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public override async Task AfterValidation(TCommand request)
        {
            var registered = await _repository.GetByIdAsync(request.Id);

            if(registered == null)
            {
                NotifyError($"O destino com código {request.Id} não existe");
                return;
            }

            await _repository.RemoveAsync(request.Id);

            if (!HasNotification())
                await _mediator.RaiseEvent(InstanceCreator.Create<TEntity, Event>(registered) as Event);
            else
                NotifyError("Commit", "Não foi possível gravar seus dados!");
        }
    }
}
