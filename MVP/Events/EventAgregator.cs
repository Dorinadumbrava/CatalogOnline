using MVP.Events.EventInterfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace MVP.Events
{
    public class EventAgregator : IEventAgregator
    {
        private static readonly IEventAgregator instance = new EventAgregator();
        public static IEventAgregator Instance { get { return instance; } }

        private readonly ConcurrentDictionary<Type, List<object>> subscriptions 
            = new ConcurrentDictionary<Type, List<object>>();

        public void Publish<T>(T message) where T : IApplicationEvent
        {
            List<object> subscribers;
            if (subscriptions.TryGetValue(typeof(T), out subscribers))
            {
                foreach (var subscriber in subscribers.ToArray())
                {
                    ((Action<T>)subscriber)(message);
                }
            }
        }

        public void Subscribe<T>(Action<T> action) where T : IApplicationEvent
        {
            var subscribers = subscriptions.GetOrAdd(typeof(T), t => new List<object>());
            lock (subscribers)
            {
                subscribers.Add(action);
            }
        }

        public void Unsubscribe<T>(Action<T> action) where T : IApplicationEvent
        {
            List<object> subscribers;

            if (subscriptions.TryGetValue(typeof(T), out subscribers))
            {
                lock (subscribers)
                {
                    subscribers.Remove(action);
                }
            }
        }

        public void Dispose()
        {
            subscriptions.Clear();
        }
    }
    }

