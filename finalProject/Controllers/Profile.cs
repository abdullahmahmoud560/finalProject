using finalProject.Data;
using finalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BCrypt.Net;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class Profile : ControllerBase
    {
        private readonly DB _db;
        private readonly IConfiguration _configuration;

        public Profile(DB db, IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }

        [Authorize]
        [HttpPut("student/update")]
        public async Task<IActionResult> UpdateProfileImage([FromForm] DTOprofile profile)
        {
            if (ModelState.IsValid)
            {
                if (profile != null)
                {
                    var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var jwtToken = tokenHandler.ReadJwtToken(token);
                    var claims = jwtToken.Claims;
                    int userId = int.Parse(claims.FirstOrDefault(c => c.Type == "id")?.Value);

                    var user = await _db.students.SingleOrDefaultAsync(u => u.Id == userId);

                    if (user != null)
                    {
                        if (profile.profilePic != null && profile.profilePic.Length > 0)
                        {
                            using (var memoryStream = new MemoryStream())
                            {
                                await profile.profilePic.CopyToAsync(memoryStream);
                                user.ProfilePic = memoryStream.ToArray();
                            }
                        }

                        if (!string.IsNullOrEmpty(profile.password))
                        {
                            user.Password = BCrypt.Net.BCrypt.HashPassword(profile.password);
                        }
                        else
                        {
                            return Ok(new ApiResponse
                            {
                                Message = "Not Matching"
                            });
                        }

                        await _db.SaveChangesAsync();

                        return Ok(new ApiResponse
                        {
                            Data = user.ProfilePic,
                            Message = "Profile updated successfully"
                        });
                    }

                    return NotFound(new ApiResponse
                    {
                        Message = "User not found"
                    });
                }
            }

            return BadRequest(new ApiResponse
            {
                Message = "Invalid input"
            });
        }
    }
}
