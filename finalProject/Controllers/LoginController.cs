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
        public async Task<IActionResult> login([FromBody] DTOlogin login)
        {
            try
            {
                Register? user = await _db.registers.SingleOrDefaultAsync(l => l.Email == login.email);

                if (user != null && BCrypt.Net.BCrypt.Verify(login.password, user.Password))
                {
                    var userInfo = await _db.registers.Where(info => info.Email == login.email).ToListAsync();
                    Token token = new Token(configuration);
                    userInfo info = new userInfo();
                    info.Id = userInfo[0].Id;
                    info.firstName = userInfo[0].FirstName;
                    info.lasttName = userInfo[0].LastName;
                    info.email = userInfo[0].Email;
                    user.Token = token.GenerateToken(user.Id, login.email);
                    info.token = userInfo[0].Token;
                    info.role = userInfo[0].role;
                    await _db.SaveChangesAsync();
                    return Ok(new ApiResponse
                    {
                        Data = info,
                    });
                }
                return Unauthorized();
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}

