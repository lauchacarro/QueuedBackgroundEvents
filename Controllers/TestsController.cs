using WorkerServiceEvents.Events.Manager;
using WorkerServiceEvents.Events.Mediator.Test;

using Microsoft.AspNetCore.Mvc;

namespace WorkerServiceEvents.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestsController : ControllerBase
    {
        private readonly IEventManager _eventManager;

        public TestsController(IEventManager eventManager)
        {
            _eventManager = eventManager;
        }

        [HttpGet]
        public IActionResult TheTest()
        {
            _eventManager.SendEvent(new TestEventData("The Special Message"));

            return Ok();
        }
    }
}
