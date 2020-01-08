using System;
using Microsoft.AspNetCore.Mvc;
using Users.Models;
using Users.Services;

namespace ForgotPassword.Controllers
{
    [Route("api/forgot-password")]
    [ApiController]
    public class ForgotPasswordController : ControllerBase
    {
        private readonly UserService _userService;
        public ForgotPasswordController(UserService userService)
        {
            _userService = userService;
        }


        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, User userIn)
        {
            Console.WriteLine("User input: " + userIn);
            var user = _userService.Get(id);

            if (user == null)
            {
                return NotFound();
            }

            _userService.Update(id, userIn);

            return NoContent();
        }
    }
}
