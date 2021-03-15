namespace WorkerServiceEvents.Events.Mediator.Test
{
    public class TestEventData : IEventData
    {
        public TestEventData(string message)
        {
            Message = message;
        }

        public string Message { get; }
    }
}
