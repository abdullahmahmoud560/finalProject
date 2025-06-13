using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Shared.DataTransferObjects;
namespace finalProject.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class ResetPasswordController : ControllerBase
    {
       private IServiceManager _serviceManager;

        public ResetPasswordController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost("forget-password")]
        public async Task<IActionResult> forgetPassword([FromBody] ForgetDTO forget)
        {
            try
            {
                var student = (await _serviceManager.StudentService.GetByConditionAsync(e => e.Email == forget.email)).FirstOrDefault();
                if (student != null)
                {
                    var token = _serviceManager.TokenService.GenerateToken(student);
                    student.Token = token;
                    await _serviceManager.StudentService.UpdateStudent(student);

                    await _serviceManager.EmailService.ResetPassword(forget.email!, "Reset Password", student.Token!);

                    var passowrd = student.Password;
                    return Ok(new ApiResponse
                    {
                        Message = "Password reset email sent successfully",
                        Data = token,
                    });
                }

                else {
                    return Ok(new ApiResponse { Message = "Not Found this Email"});
                }
            }
            catch(Exception ex)
            {
                return Ok(ex.Message);
            }
        }

        [Authorize]
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetDTO reset)
        {
            if (reset.password != reset.confirm)
            {
                return BadRequest("Don't Match Password");
            }
            var UserID = int.Parse(User.FindFirstValue("id")!);
            var userInfo = (await _serviceManager.StudentService.GetByConditionAsync(info => info.Id == UserID)).FirstOrDefault();
            userInfo!.Password = BCrypt.Net.BCrypt.HashPassword(reset.password);
            await _serviceManager.StudentService.UpdateStudent(userInfo);
            return Ok(new ApiResponse
            {
                Message = "Password Changed successfully"
            });
        }
    }
}
