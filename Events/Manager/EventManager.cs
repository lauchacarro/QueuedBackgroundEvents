using WorkerServiceEvents.BackgroundTasks;

using MediatR;

namespace WorkerServiceEvents.Events.Manager
{
    public class EventManager : IEventManager
    {
        private readonly IBackgroundTaskQueue _backgroundTaskQueue;
        private readonly IMediator _mediator;

        public EventManager(IBackgroundTaskQueue backgroundTaskQueue, IMediator mediator)
        {
            _backgroundTaskQueue = backgroundTaskQueue;
            _mediator = mediator;
        }

        public void SendEvent(IEventData eventData)
        {
            _backgroundTaskQueue.QueueBackgroundWorkItem(async token =>
            {
                await _mediator.Send(eventData);
            });
        }
    }
}
