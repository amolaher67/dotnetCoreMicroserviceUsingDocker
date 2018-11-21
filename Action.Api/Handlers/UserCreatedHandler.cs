
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Action.Common.Events;

namespace Action.Api.Handlers
{
    public class UserCreatedHandler : IEventHandler<UserCreated>
    {
        public UserCreatedHandler()
        {

        }
        public async Task HandleAsync(UserCreated @event)
        {
            await Task.CompletedTask;
            Console.Write($"User Created : {@event.Name}");
        }
    }

}
