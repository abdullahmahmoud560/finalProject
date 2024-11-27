using finalProject.Data;
using finalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

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

        //[Authorize]
        //[HttpPost]
        //public async Task<IActionResult> logout()
        //{
        //    var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);

        //    var tokenHandler = new JwtSecurityTokenHandler();
        //    var jwtToken = tokenHandler.ReadJwtToken(token);

        //    var claims = jwtToken.Claims;

        //    var userId = claims.FirstOrDefault(c => c.Type == "id")?.Value;
        //    var email = claims.FirstOrDefault(c => c.Type == "email")?.Value;

        //    return Ok(new { userId, email });
        //}
    }
}
