using AppBackendAPI.Bussiness;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace AppBackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService) 
        {
            _userService = userService;
        }

        /// <summary>
        /// Devuelve usuarios registrados 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            var users = await _userService.GetUsersAsync();
            return Ok(users);
        }
    }
}
