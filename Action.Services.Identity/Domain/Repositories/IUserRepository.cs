﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Action.Services.Identity.Domain.Models;

namespace Action.Services.Identity.Domain.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetAsync(Guid id);
        Task<User> GetAsync(string email);
        Task AddAsync(User user);

    }
}
