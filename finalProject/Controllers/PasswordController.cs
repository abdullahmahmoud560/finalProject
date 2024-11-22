using finalProject.Data;
using finalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Session;
namespace finalProject.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class ResetPasswordController : ControllerBase
    {
        private readonly DB _db;
        private readonly EmailService _emailService;
        private readonly IConfiguration configuration;
        public ResetPasswordController(DB db, EmailService emailService, IConfiguration configuration)
        {
            _db = db;
            _emailService = emailService;
            this.configuration = configuration;
        }

        [HttpPost("forget-password")]
        public async Task<IActionResult> forgetPassword([FromBody]DTOforgetpassword  forget)
        {
            try
            {
                Register? email = await _db.registers.SingleOrDefaultAsync(e => e.Email == forget.email);
                if (email != null)
                {
                    var userInfo = await _db.registers.Where(info => info.Email == forget.email).ToListAsync();
                    Token generateToken = new Token(configuration);
                    var token = generateToken.GenerateToken(userInfo[0].Id, forget.email);
                    var resetLink = $"https://edu-guide-ai.vercel.app/reset-password?email={Uri.EscapeDataString(forget.email)}";
                    await _emailService.SendEmailAsync(forget.email, "Reset Your Password",
                    $"Click here to reset your password: {resetLink}");
                    userInfo[0].Token = token;
                    await _db.SaveChangesAsync();
                    return Ok(new ApiResponse
                    {
                        Message = "Password reset email sent successfully",
                        Data = forget.email,
                    });
                }
            }
            catch(Exception ex)
            {
                return Ok(ex.Message);
            }
            return NotFound("Not Found This Email");
        }

        [Authorize]
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] resetPassword reset)
        {
            if(reset.password != reset.confirm)
            {
                return BadRequest("Not Match Password");
            }
            var userInfo = await _db.registers.Where(info => info.Email == reset.email).ToListAsync();
            userInfo[0].Password = BCrypt.Net.BCrypt.HashPassword(reset.password);
            await _db.SaveChangesAsync();
            return Ok(new ApiResponse
            {
                Message = "Password Changed successfully"
            });
        }

    }
}
