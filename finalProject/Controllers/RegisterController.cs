using finalProject.Data;
using finalProject.DTO;
using finalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly DB _db;
        private readonly EmailService _emailService;
        private readonly Token _token;
        public RegisterController(DB db, EmailService emailService,Token token)
        {
            _db = db;
            _emailService = emailService;
            _token = token;
        }


        [HttpPost("admin/register")]
        public async Task<IActionResult> RegisterNewUser(DTOregister user)
        {

            if (ModelState.IsValid && user != null)
            {
                var isFound = await _db.students.FirstOrDefaultAsync(l => l.Email == user.email);
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
                        Token = "null"
                    };
                    await _db.AddAsync(register);
                    await _db.SaveChangesAsync();
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
        public async Task<IActionResult> studentRegister(DTOregister user)
        {
            if (ModelState.IsValid && user != null)
            {
                // التحقق من وجود البريد الإلكتروني في قاعدة البيانات
                var isFound = await _db.students.FirstOrDefaultAsync(l => l.Email == user.email);
                if (isFound != null)
                {
                    return Ok(new ApiResponse { Message = "The Email Already Exists" });
                }

                // التحقق من صحة البريد الإلكتروني
                if (user.email != null /*&& user.email.EndsWith("@fci.helwan.edu.eg")*/)
                {
                    // إنشاء حساب طالب جديد
                    Student register = new()
                    {
                        FirstName = user.firstName,
                        lastName = user.lastName,
                        Email = user.email,
                        Password = BCrypt.Net.BCrypt.HashPassword(user.password),
                        role = "Student",
                        department = "General",
                    };

                    // توليد التوكن
                    var token = _token.GenerateToken(register);

                    // تعيين التوكن في الكائن
                    register.Token = token;

                    // إضافة الطالب الجديد إلى قاعدة البيانات
                    await _db.AddAsync(register);
                    await _db.SaveChangesAsync();

                    // إرسال البريد الإلكتروني مع التوكن
                    var sendEmail = await _emailService.SendEmailAsync(user.email, "Activate Your EduguideAI Account",token);

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
