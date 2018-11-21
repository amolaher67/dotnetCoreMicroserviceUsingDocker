using System.Threading.Tasks;
using Action.Common.Commands;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;

namespace Action.Api.Controllers
{
    [Route("[Controller]")]
    public class UsersController : Controller
    {
        private readonly IBusClient _busClinet;
        public UsersController(IBusClient busClient)
        {
            _busClinet = busClient;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Post([FromBody] CreateUser command)
        {
            await _busClinet.PublishAsync(command);
            return Accepted();
        }
    }
}
