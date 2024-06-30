using APITest.Model;
using APITest.Services;
using Microsoft.AspNetCore.Mvc;

namespace APITest.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if (username == "developer" && password == "123qwer")
            {
                var token = TokenService.GenerateToken(new Employee());
                return Ok(token);
            }
            return BadRequest("invalid credentials");
        }
    }
}
