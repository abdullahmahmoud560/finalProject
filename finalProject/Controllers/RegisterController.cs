using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using static Shared.DataTransferObjects;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private IServiceManager _serviceManager;
        public RegisterController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }


        [HttpPost("admin/register")]
        public async Task<IActionResult> RegisterNewUser(registerDTO user)
        {

            if (ModelState.IsValid && user != null)
            {
                var isFound = await _serviceManager.StudentService.GetByConditionAsync(l => l.Email == user.email);
                if (isFound != null)
                {
                    return Ok(new ApiResponse { Message = "The Email Already Exists" });
                }

                if (user.email != null && user.email.EndsWith("@fci.helwan.edu.eg"))
                {
                    Student register = new()
                    {
                        FirstName = user.firstName,
                        lastName = user.lastName,
                        Email = user.email,
                        Password = BCrypt.Net.BCrypt.HashPassword(user.password),
                        role = "Admin",
                    };
                    await _serviceManager.StudentService.AddStudent(register);
                   
                    return Ok(new ApiResponse
                    {
                        Message = "Succss",
                    });
                }
                return Ok(new ApiResponse { Message = "The Email is not valid" });
            }
            return BadRequest(ModelState);
        }

        [HttpPost("student/register")]
        public async Task<IActionResult> studentRegister(registerDTO user)
        {
            if (ModelState.IsValid && user != null)
            {
                var isFound = (await _serviceManager.StudentService.GetByConditionAsync(l => l.Email == user.email)).FirstOrDefault();
                if (isFound != null)
                {
                    return Ok(new ApiResponse { Message = "The Email Already Exists" });
                }

                // التحقق من صحة البريد الإلكتروني
                if (user.email != null && user.email.EndsWith("@fci.helwan.edu.eg"))
                {

                    // إنشاء حساب طالب جديد
                    Student register = new()
                    {
                        FirstName = user.firstName,
                        lastName = user.lastName,
                        Email = user.email,
                        Password = BCrypt.Net.BCrypt.HashPassword(user.password),
                        role = "Student",
                        department_en = "General",
                        department_ar = "عام",
                    };

                    await _serviceManager.StudentService.AddStudent(register);

                    // توليد التوكن
                    var token = _serviceManager.TokenService.GenerateToken(register);

                    // تعيين التوكن في الكائن
                    register.Token = token;

                   await _serviceManager.StudentService.UpdateStudent(register);

                    // إرسال البريد الإلكتروني مع التوكن
                    var sendEmail = await _serviceManager.EmailService.SendEmailAsync(user.email, "Activate Your EduguideAI Account", token);

                    // إرجاع استجابة ناجحة
                    return Ok(new ApiResponse
                    {
                        Message = "Your account has been created successfully",
                    });
                }

                return BadRequest(new ApiResponse { Message = "The Email is not valid" });
            }

            return BadRequest(ModelState);
        }
    }
}
