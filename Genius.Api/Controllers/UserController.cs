using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Genius.Api.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet("login")]
        public async Task<string> LoginAsync()
        {
            return "text";
        }
    }
}
