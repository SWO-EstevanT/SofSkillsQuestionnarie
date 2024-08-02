using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;




namespace Users.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //private readonly iuserusecase _userusecase;
        //private readonly imapper _mapper;


        [HttpGet]
        public async Task<List<User>> GetUsersAsync()
        {
            //var users = await _userusecase.getusersasync();
            //return _mapper.map<List<User>>(users);
            return null;
        }




    }
}
