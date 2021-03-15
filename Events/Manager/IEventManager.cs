namespace WorkerServiceEvents.Events.Manager
{
    public interface IEventManager
    {
        void SendEvent(IEventData eventData);
    }
}
