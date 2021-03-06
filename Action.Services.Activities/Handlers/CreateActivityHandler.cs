using System;
using System.Threading.Tasks;
using Action.Common.Commands;
using Action.Common.Events;
using Microsoft.Extensions.Logging;
using RawRabbit;

namespace Action.Services.Activities.Handlers
{
    public class CreateActivityHandler : ICommandHandler<CreateActivity>
    {
        private readonly IBusClient _busClient;

        public CreateActivityHandler(IBusClient busClient)
        {
            _busClient = busClient;

        }

        public async Task HandleAsync(CreateActivity command)
        {
            try
            {
                Console.Write($"Creating Activity :{command.Name}");
                await _busClient.PublishAsync(new ActivityCreated(command.Id,
                    command.UserId, command.Category, command.Name, command.Description, command.CreatedAt));

                return;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}