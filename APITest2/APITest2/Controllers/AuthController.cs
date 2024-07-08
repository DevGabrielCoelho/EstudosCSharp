using APITest2.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace APITest2.Controllers
{
    [ApiController]
    [Route("api/v1/auth")]
    public class AuthController : Controller
    {
        [HttpGet]
        public IActionResult Auth(string username, string password)
        {
            if (username == "developer" && password == "123qwer")
            {
                Object token = TokenService.GenerateToken(new Domain.Model.Employee());
                return Ok(token);
            }

            return BadRequest("username or password invalid");
        }
    }
}
