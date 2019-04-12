using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MVP.Events.EventInterfaces
{
    public interface IEventAggregator
    {
        bool HandlerExistsFor(Type messageType);
        void Subscribe(object subscriber, Func<Func<Task>, Task> marshal);
        void Unsubscribe(object subscriber);
        Task PublishAsync(object message, Func<Func<Task>, Task> marshal, CancellationToken cancellationToken);
    }
}
