using Microsoft.AspNetCore.Mvc;
using Users.Models;
using Users.Services;

namespace Register.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly UserService _userService;
        public RegisterController(UserService userService)
        {
            _userService = userService;
        }


        [HttpPost]
        public ActionResult<User> Create(User user)
        {
            _userService.Create(user);

            return user;
        }
    }
}
