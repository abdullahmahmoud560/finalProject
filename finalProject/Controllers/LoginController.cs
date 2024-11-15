using finalProject.Data;
using finalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace finalProject.Controllers
{
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

        [HttpGet]
        [Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "John Doe", "Jane Doe" };
        }

        [HttpPost]
        public async Task<IActionResult> login([FromBody] DTOlogin login)
        {
            Register? user = await _db.registers.SingleOrDefaultAsync(l => l.Email == login.email);

            if (user != null && BCrypt.Net.BCrypt.Verify(login.password, user.Password))
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:secretKey"]));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: configuration["JWT:Issuer"],
                    audience: configuration["JWT:Audience"],
                    claims: new List<Claim>() {
                   new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                   new Claim(ClaimTypes.Email, login.email),
                   new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                   new Claim(JwtRegisteredClaimNames.Exp, DateTimeOffset.UtcNow.AddMinutes(10).ToUnixTimeSeconds().ToString())
                    },
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new AuthenticatedResponse { Token = tokenString });
            }
            return Unauthorized();

        }
    }
}

