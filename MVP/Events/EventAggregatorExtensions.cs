using MVP.Events.EventInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MVP.Events
{
    public class SyncContext
    {
        public static SynchronizationContext UI { get; private set; }

        public static void SetUIContext(SynchronizationContext context)
        {
            UI = context;
        }
    }

    public static class EventAggregatorExtensions
    {
        public static void SubscribeOnPublishedThread(this IEventAggregator eventAggregator, object subscriber)
        {
            eventAggregator.Subscribe(subscriber, f => f());
        }

        [Obsolete("Use SubscribeOnPublishedThread")]
        public static void Subscribe(this IEventAggregator eventAggregator, object subscriber)
        {
            eventAggregator.SubscribeOnPublishedThread(subscriber);
        }

        public static void SubscribeOnBackgroundThread(this IEventAggregator eventAggregator, object subscriber)
        {
            eventAggregator.Subscribe(subscriber, f => Task.Factory.StartNew(f, default, TaskCreationOptions.None, TaskScheduler.Default));
        }

        public static void PublishToUI(this IEventAggregator eventAggregator, object message)
        {
            var context = SyncContext.UI;
            eventAggregator.PublishAsync(message, func => Task.Factory.StartNew(() => context.Post(_ => func.Invoke(), null)), default(CancellationToken));
        }

        public static Task PublishOnCurrentThreadAsync(this IEventAggregator eventAggregator, object message, CancellationToken cancellationToken)
        {
            return eventAggregator.PublishAsync(message, f => f(), cancellationToken);
        }

        public static Task PublishOnCurrentThreadAsync(this IEventAggregator eventAggregator, object message)
        {
            return eventAggregator.PublishOnCurrentThreadAsync(message, default);
        }
        public static Task PublishOnBackgroundThreadAsync(this IEventAggregator eventAggregator, object message, CancellationToken cancellationToken)
        {
            return eventAggregator.PublishAsync(message, f => Task.Factory.StartNew(f, default, TaskCreationOptions.None, TaskScheduler.Default), cancellationToken);
        }

        public static Task PublishOnBackgroundThreadAsync(this IEventAggregator eventAggregator, object message)
        {
            return eventAggregator.PublishOnBackgroundThreadAsync(message, default);
        }

    }
}
