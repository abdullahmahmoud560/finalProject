using finalProject.Data;
using finalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace finalProject.Controllers
{
    public class ApiResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; } = null;
    }



    [Route("api/auth/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DB _db;
        private readonly IConfiguration configuration;

        public LoginController(DB db, IConfiguration configuration)
        {
            _db = db;
            this.configuration = configuration;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] DTOlogin login)
        {
            try
            {
                var user = await _db.students.SingleOrDefaultAsync(l => l.Email == login.email);

                if (user != null && BCrypt.Net.BCrypt.Verify(login.password, user.Password))
                {
                    Token token = new Token(configuration);
                    var generatedToken = token.GenerateToken(user);
                    userInfo info = new userInfo();

                    user.Token = generatedToken;
                    await _db.SaveChangesAsync();

                    info.token = user.Token;
                    info.role = user.role;
                    info.firstName = user.FirstName;
                    info.lastName = user.lastName;
                    info.email = user.Email;
                    return Ok(new ApiResponse
                    {
                        Data = info,
                        Message = "Token generated and stored successfully"
                    });
                }
                else
                {
                    return Unauthorized(new ApiResponse
                    {
                        Message = "Invalid email or password"
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Message = "An error occurred",
                    Data = ex.Message
                });
            }
        }
    }
}

