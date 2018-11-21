using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RawRabbit;
using  Action.Common.Commands;


namespace Action.Api.Controllers
{
    [Route("[Controller]")]
    public class ActivityController : Controller
    {
        private readonly IBusClient _busClinet;
        public ActivityController(IBusClient busClient)
        {
            _busClinet = busClient;
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody] CreateActivity command)
        {
            command.Id = Guid.NewGuid();
           // command.UserId = Guid.Parse(User.Identity.Name);
            command.CreatedAt = DateTime.UtcNow;
            await _busClinet.PublishAsync(command);
            return Accepted($"Activities/{command.Id}");
        }
    }
}