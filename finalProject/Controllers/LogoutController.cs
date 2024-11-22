using finalProject.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace finalProject.Controllers
{
    [Route("api/auth/logout")]
    [ApiController]
    public class LogoutController : ControllerBase
    {
        private readonly DB _db;
        public LogoutController(DB db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> logout()
        {
            return Ok();
        }
    }
}
