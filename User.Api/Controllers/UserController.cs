using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MicroserviceUser.Domain.Entities.User;
namespace User.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {


        [HttpGet]
        public async Task<List<User>> getUsers() { 
        

        
        
        }








    }
}
