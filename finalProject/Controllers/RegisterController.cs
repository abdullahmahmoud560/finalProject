using finalProject.Data;
using finalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        public RegisterController(DB db)
        {
            _db = db;
        }

        private readonly DB _db;


        [HttpPost("admin/register")]
        public async Task<IActionResult> RegisterNewUser(DTOregister user)
        {

            if (ModelState.IsValid && user != null)
            {
                Register register = new()
                {
                    FirstName = user.firstName,
                    LastName = user.lastName,
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
            return BadRequest(ModelState);
        }

        [HttpPost("student/register")]
        public async Task<IActionResult> studentRegister(DTOregister user)
        {
            if (ModelState.IsValid && user != null)
            {
                Register register = new()
                {
                    FirstName = user.firstName,
                    LastName = user.lastName,
                    Email = user.email,
                    Password = BCrypt.Net.BCrypt.HashPassword(user.password),
                    role = "Student",
                    Token = "null"
                };
                await _db.AddAsync(register);
                await _db.SaveChangesAsync();
                return Ok(new ApiResponse
                {
                    Message = "Succss",
                });
            }
            return BadRequest(ModelState);
        }
    }
}
