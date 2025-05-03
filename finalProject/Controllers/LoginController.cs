using finalProject.Data;
using finalProject.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Text.Json;

namespace finalProject.Controllers
{

    [Route("api/auth/login")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly DB _db;
        private readonly IConfiguration configuration;
        private readonly HttpClient _httpClient;
        private readonly Token _token;

        public LoginController(DB db, IConfiguration configuration, HttpClient httpClient, Token token)
        {
            _db = db;
            this.configuration = configuration;
            _httpClient = httpClient;
            _token = token;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] DTOlogin login)
        {
            try
            {
                var user = await _db.students.SingleOrDefaultAsync(l => l.Email == login.email);

                if (user != null && BCrypt.Net.BCrypt.Verify(login.password, user.Password) && user.isActive == true)
                {
                    userInfo info = new userInfo();
                    info.role = user.role!;
                    info.firstName = user.FirstName!;
                    info.lastName = user.lastName!;
                    info.email = user.Email!;
                    var token = _token.GenerateToken(user);
                    user.Token = token;
                    _db.students.Update(user); 
                    await _db.SaveChangesAsync();
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

        [HttpPost("Chat-Bot")]
        public async Task<IActionResult> task(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return BadRequest();
            }
            else
            {
                var requestBody = new
                {
                    inputs = message,
                    parameters = new { max_length = 200 }
                };

                string jsonBody = JsonSerializer.Serialize(requestBody);
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                // إضافة مفتاح API
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer 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");

                // إرسال الطلب
                HttpResponseMessage response = await _httpClient.PostAsync("https://api-inference.huggingface.co/models/gpt2", content);

                // قراءة الرد
                string responseContent = await response.Content.ReadAsStringAsync();
                return Ok(responseContent);

            }
        }

    }
}

