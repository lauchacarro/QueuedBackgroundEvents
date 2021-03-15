using MediatR;

using Microsoft.Extensions.Logging;

using System.Threading;
using System.Threading.Tasks;

namespace WorkerServiceEvents.Events.Mediator.Test
{
    public class TestEventHandler : AsyncRequestHandler<TestEventData>
    {
        private readonly ILogger<TestEventHandler> _logger;

        public TestEventHandler(ILogger<TestEventHandler> logger)
        {
            _logger = logger;
        }

        protected override async Task Handle(TestEventData request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Mensaje: " + request.Message);
        }
    }
}
