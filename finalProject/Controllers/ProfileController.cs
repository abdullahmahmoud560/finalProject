using System.Security.Claims;
using finalProject.Data;
using finalProject.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly DB _db;
        private readonly IConfiguration _configuration;

        public ProfileController(DB db, IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
        }

        [Authorize]
        [HttpPost("student/update")]
        public async Task<IActionResult> UpdateProfile(resetPassword profile)
        {
            if (ModelState.IsValid)
            {
                if (profile.confirm != null && profile.password !=null)
                {
                    var userId = int.Parse(User.FindFirstValue("id")!);
                    var user = await _db.students.FirstOrDefaultAsync(u => u.Id == userId);

                    if (user != null)
                    {
                        if (profile.password.Equals(profile.confirm))
                        {
                            user.Password = BCrypt.Net.BCrypt.HashPassword(profile.password);
                            _db.Update(user);
                            await _db.SaveChangesAsync();
                            userInfo info = new userInfo();
                            info.role = user.role!;
                            info.firstName = user.FirstName!;
                            info.lastName = user.lastName!;
                            info.email = user.Email!;
                            info.token = user.Token;
                            return Ok(new ApiResponse
                            {
                                Message = "Profile updated successfully",
                                Data = info
                            });
                        }
                        else
                        {
                            return Ok(new ApiResponse
                            {
                                Message = "Not Matching"
                            });
                        }
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
