using Microsoft.AspNetCore.Mvc;
using UnitTest_Demo.Data.Interface;
using UnitTest_Demo.Data.Service;

namespace UnitTest_Demo.Controllers
{
    public class UserController : Controller
    {
        public readonly IUser _userService;
        public UserController(IUser user)
        {
            _userService = user;
        }
        [HttpGet("Get")]
        public async Task<IActionResult> GetUserByName(string name)
        {
            try
            {
                var result = _userService.GetUserByName(name);
                return Ok(result);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
