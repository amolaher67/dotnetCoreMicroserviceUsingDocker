using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Action.Services.Activities.Domain.Models;

namespace Action.Services.Activities.Domain.Repositories
{
    interface ICategoryRepository
    {
        Task<Category> GetAsync(string name);
        Task<IEnumerable<Category>> BrowseAsync();
        Task AddAsync(Category category);


    }
}
