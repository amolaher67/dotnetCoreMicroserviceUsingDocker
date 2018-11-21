using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Action.Common.Events;

namespace Action.Api.Handlers
{
    public class ActivityCreatedHandler : IEventHandler<ActivityCreated>
    {
        public ActivityCreatedHandler()
        {
            
        }
        public async Task HandleAsync(ActivityCreated @event)
        {
            await Task.CompletedTask;
            Console.Write($"Activity Created :{@event.Name}");
        }
    }
}
