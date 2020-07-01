using MicroRabbit.Domain.Core.Commands;
using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventBus
    {
        Task SendCommands<TEntity>(TEntity command) where TEntity : Command;

        void Publish<TEvent>(TEvent @event) where TEvent : Event;

        void Subscrib<TEvent, TEventHandler>()
            where TEvent : Event
            where TEventHandler : IEventHandler<TEvent>;

    }
}
