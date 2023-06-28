using Atena.Domain.Core.Events;
using Atena.Domain.Core.Extensions;
using Atena.Domain.Core.Interfaces.MediatorR;
using Atena.Domain.Core.Model;
using Atena.Domain.Core.Repositories;
using Atena.Domain.Core.Tools;
using AutoMapper;

namespace Atena.Domain.Core.CommandHandles
{
    public abstract class CommandHandlerUpdate<TCommand, TEntity, Event> : MediatorCommandHandler<TCommand>
        where TCommand : Command
        where TEntity : Entity
        where Event : EventCore<TEntity>
    {
        protected IMapper _mapper;
        private readonly IRepository<TEntity> _repository;

        public CommandHandlerUpdate(IMediatorHandler mediator, IMapper mapper, IRepository<TEntity> repository)
            : base(mediator)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public override async Task AfterValidation(TCommand request)
        {
            var entity = _mapper.Map<TEntity>(request);

            var registered = await _repository.GetByIdAsync(entity.Id);

            if(registered == null)
            {
                NotifyError($"O objeto {entity.GetType().Name} com o código {entity.Id} não existe");
                return;
            }

            var query = RepositoryExtension.LambdaUpdateGeneration(entity);

            registered = await _repository.GetLastOneAsync(query);

            if(registered != null)
            {
                var type = entity.GetType();
                var properties = type.GetProperties();
                var listProperties = properties.Where(c => c.GetCustomAttributes(false).
                    Any(a => a.GetType() == typeof(PropertyValidationAttribute))).ToList();

                string message = $"O objeto {entity.GetType().Name} com o(s) valores: ";

                for (int i = 0; i < listProperties.Count(); i++)
                {
                    if (listProperties[i].GetValue(entity, null).ToString() == listProperties[i]
                        .GetValue(registered, null).ToString())
                    {
                        message += $"{listProperties[i].Name}: {listProperties[i].GetValue(entity, null)}; ";
                    }
                }

                NotifyError(message);
                return;
            }

            await _repository.UpdateAsync(entity.Id);

            if(!HasNotification())
            {
                await _mediator.RaiseEvent(InstanceCreator.Create<TEntity, Event>(entity) as Event);
            }
            else
            {
                NotifyError("Commit", "Não foi possível gravar seus dados!");
            }
        }
    }
}
