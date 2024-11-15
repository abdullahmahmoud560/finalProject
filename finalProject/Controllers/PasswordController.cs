using finalProject.Data;
using finalProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace finalProject.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class ResetPasswordController : ControllerBase
    {
        private readonly DB _db;
        public ResetPasswordController(DB db)
        {
            _db = db;
        }

        [HttpPost("forget-password")]
        public async Task<IActionResult> forgetPassword(DTOforgetpassword  forget)
        {
            Register? email = await _db.registers.SingleOrDefaultAsync(e => e.Email == forget.email);
            if(email != null)
            {
                return Ok();
            }
            return NotFound("Not Found This Email");
        }


        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword()
        {
            return Ok();
        }
    }
}
