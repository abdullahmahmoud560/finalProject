using finalProject.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class IT_Requirements : ControllerBase
    {
        private readonly DB _db;

        public IT_Requirements(DB db)
        {
            _db = db;
        }

        [Authorize]
        [HttpGet("it_core_courses")]
        public async Task<IActionResult> Get_it_Compulsory()
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);
                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(token);
                var claims = jwtToken.Claims;
                int userId = int.Parse(claims.FirstOrDefault(c => c.Type == "id")?.Value);

                var courses = await _db.iT_Compulsories
                   .GroupJoin(
                       _db.StudentSubjects.Where(ss => ss.StudentId == userId),
                       course => course.code,
                       studentSubject => studentSubject.SubjectCode,
                       (course, studentSubjects) => new
                       {
                           course.code,
                           course.course_Name,
                           course.hours,
                           course.prerequest,
                           Grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault().grade : null
                       }
                   )
                   .ToListAsync();
                if (courses != null)
                {
                    return Ok(new ApiResponse
                    {
                        Data = courses,
                        Message = "Retrive Data Succssfully"
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Message = ex.Message
                });
            }
            return NotFound(new ApiResponse
            {
                Message = "Not Found Any Data",
            });
        }

        [Authorize]
        [HttpGet("it_elective_courses")]
        public async Task<IActionResult> Get_it_Electives()
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);
                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(token);
                var claims = jwtToken.Claims;
                int userId = int.Parse(claims.FirstOrDefault(c => c.Type == "id")?.Value);

                var courses = await _db.iT_Electives
                   .GroupJoin(
                       _db.StudentSubjects.Where(ss => ss.StudentId == userId),
                       course => course.code,
                       studentSubject => studentSubject.SubjectCode,
                       (course, studentSubjects) => new
                       {
                           course.code,
                           course.course_Name,
                           course.hours,
                           course.prerequest,
                           Grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault().grade : null
                       }
                   )
                   .ToListAsync();
                if (courses != null)
                {
                    return Ok(new ApiResponse
                    {
                        Data = courses,
                        Message = "Retrive Data Succssfully"
                    });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Message = ex.Message
                });
            }
            return NotFound(new ApiResponse
            {
                Message = "Not Found Any Data",
            });
        }
    }
}
