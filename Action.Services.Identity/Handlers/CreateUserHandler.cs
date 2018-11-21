using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Action.Common.Commands;
using Action.Common.Events;
using RawRabbit;

namespace Action.Services.Identity.Handlers
{
    public class CreateUserHandler :ICommandHandler<CreateUser>
    {
        private readonly IBusClient _busClient;

        public CreateUserHandler(IBusClient busClient)
        {
            _busClient = busClient;

        }
        public async Task HandleAsync(CreateUser command)
        {
            try
            {
                Console.Write($"Creating Activity :{command.Name}");
                await _busClient.PublishAsync(new UserCreated(command.Email,command.Name));
                return;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
