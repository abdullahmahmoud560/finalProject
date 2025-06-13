using System.Security.Claims;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Shared.DataTransferObjects;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private IServiceManager _serviceManager;

        public ProfileController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [Authorize]
        [HttpPost("student/update")]
        public async Task<IActionResult> UpdateProfile(ResetDTO profile)
        {
            if (ModelState.IsValid)
            {
                if (profile.confirm != null && profile.password !=null)
                {
                    var userId = int.Parse(User.FindFirstValue("id")!);
                    var user = (await _serviceManager.StudentService.GetByConditionAsync(u => u.Id == userId)).FirstOrDefault();

                    if (user != null)
                    {
                        if (profile.password.Equals(profile.confirm))
                        {
                            user.Password = BCrypt.Net.BCrypt.HashPassword(profile.password);
                            await _serviceManager.StudentService.UpdateStudent(user);
                            UserInformation info = new UserInformation();
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
