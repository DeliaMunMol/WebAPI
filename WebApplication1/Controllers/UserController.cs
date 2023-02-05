using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;
using WebApplication1.IServices;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IUserService _userService; 
        public UserController(ILogger<ProductController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }
        [HttpPost(Name = "InsertUser")]
        public int Post([FromBody] User user)
        {
            return _userService.InsertUser(user);
        }
        [HttpDelete(Name = "DeleteUser")]
        public void Delete([FromQuery] int Id)
        {
             _userService.DeleteUser(Id);
        }
        [HttpPatch(Name = "ModifyUser")]
        public void Patch([FromBody] User user)
        {
            {
                _userService.UpdateUser(user);
            }

        }
        [HttpGet(Name = "GetAllUser")]
        public List<User> GetAll()
        {
            return _userService.GetAll();
        }

    }
}
