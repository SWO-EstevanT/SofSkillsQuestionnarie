using AutoMapper;
using MicroserviceUser.Domain.Commands;
using MicroserviceUser.Domain.Entities;
using MicroserviceUser.UsesCases.Gateway;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;




namespace Users.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController
    {
        private readonly IUserUseCase _userUseCase;
        private readonly IMapper _mapper;

        public UserController(IUserUseCase userUseCase, IMapper mapper)
        {
            _userUseCase = userUseCase;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<string> CreateUser(CreateUser user)
        {
            return await _userUseCase.CreateUser(user);
        }

        [HttpGet("")]
        public async Task<List<User>> GetUsers()
        {
            return await _userUseCase.GetUsers();
        }



    }
}
