using finalProject.Data;
using finalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mysqlx.Session;
using System.IdentityModel.Tokens.Jwt;
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
                Student? student = await _db.students.SingleOrDefaultAsync(e => e.Email == forget.email);
                if (student != null)
                {
                    
                    var resetLink = $"https://edu-guide-ai.vercel.app/reset-password?token={Uri.EscapeDataString(student.Token)}";
                    await _emailService.SendEmailAsync(forget.email, "Reset Your Password",
                    $"Click here to reset your password: {resetLink}");
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
            var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);
            var tokenHandler = new JwtSecurityTokenHandler();
            var jwtToken = tokenHandler.ReadJwtToken(token);
            var claims = jwtToken.Claims;
            int userId = int.Parse(claims.FirstOrDefault(c => c.Type == "id")?.Value);

            var userInfo = await _db.students.Where(info => info.Id == userId).ToListAsync();
            userInfo[0].Password = BCrypt.Net.BCrypt.HashPassword(reset.password);
            await _db.SaveChangesAsync();
            return Ok(new ApiResponse
            {
                Message = "Password Changed successfully"
            });
        }

    }
}
