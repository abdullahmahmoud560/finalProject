using System.Security.Claims;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Shared.DataTransferObjects;

namespace finalProject.Controllers
{

    [Route("api/")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IServiceManager _serviceManager;

        public LoginController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost("auth/login")]
        public async Task<IActionResult> Login([FromBody] loginDTO login)
        {
            try
            {
                var user = (await _serviceManager.StudentService.GetByConditionAsync(x => x.Email == login.email)).FirstOrDefault();

                if (user != null && BCrypt.Net.BCrypt.Verify(login.password, user.Password) && user.isActive == true)
                {
                    UserInformation info = new UserInformation();
                    info.role = user.role!;
                    info.firstName = user.FirstName!;
                    info.lastName = user.lastName!;
                    info.email = user.Email!;
                    info.department = user.department_en;
                    var token = _serviceManager.TokenService.GenerateToken(user);

                    user.Token = token;
                    await _serviceManager.StudentService.UpdateStudent(user);
                    info.token = token;

                    return Ok(new ApiResponse
                    {
                        Data = info,
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

