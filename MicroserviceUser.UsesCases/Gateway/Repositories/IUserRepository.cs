﻿using MicroserviceUser.Domain.Commands;
using MicroserviceUser.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceUser.UsesCases.Gateway.Repositories
{
    public interface IUserRepository
    {
        Task<string> CreateUser(CreateUser user);
        Task<List<User>> GetUsers();
        Task<User> GetUserById(string id);

    }
}
