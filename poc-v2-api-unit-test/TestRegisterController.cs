using Microsoft.VisualStudio.TestTools.UnitTesting;
using Register.Controllers;
using Users.Models;
using Users.Services;

namespace TestRegisterController.Controllers
{
    [TestClass]
    public class TestRegisterController
    {
        private readonly UserService _userService;
        [TestMethod]
        public void RegisterUser_ShouldReturnRegisteredUser()
        {
            var newUser = new User { Id = "1ab", Name = "John", Username = "john", Password = "password", Company = "test", PhoneNo = "200-200", Position = "Web Dev" };
            var controller = new RegisterController(_userService);
            var result = controller.Create(newUser);
            Assert.AreEqual(newUser, result);
        }
    }
}
