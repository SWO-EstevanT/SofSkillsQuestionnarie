using MicroserviceUser.Domain.Commands;
using MicroserviceUser.Domain.Entities;
using MicroserviceUser.UsesCases.Gateway;
using MicroserviceUser.UsesCases.Gateway.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroserviceUser.UsesCases.UseCases
{
    public class UserUseCase : IUserUseCase
    {
        private readonly IUserRepository _userRepository;
        public UserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<string> CreateUser(CreateUser user)
        {
            return await _userRepository.CreateUser(user);
        }

        public async Task<List<User>> GetUsers()
        {
            return await _userRepository.GetUsers();
        }

    }
}
