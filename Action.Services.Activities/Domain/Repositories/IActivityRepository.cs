using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Action.Services.Activities.Domain.Models;

namespace Action.Services.Activities.Domain.Repositories
{
    interface IActivityRepository
    {
        Task<Activity> GetAsync(Guid id);
        Task AddAsync(Activity category);


    }
}
