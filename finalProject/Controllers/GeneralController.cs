using finalProject.Data;
using finalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mysqlx;
using Org.BouncyCastle.Bcpg;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Cryptography.X509Certificates;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        private readonly DB _db;

        public GeneralController(DB db)
        {
            _db = db;
        }

        [Authorize]
        [HttpGet("g_core_courses")]
        public async Task<IActionResult> Get_g_Compulsory()
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);
                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(token);
                var claims = jwtToken.Claims;
                int userId = int.Parse(claims.FirstOrDefault(c => c.Type == "id")?.Value);

                var courses = await _db.general_Compulsories
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

                if (courses != null && courses.Any())
                {
                    return Ok(new ApiResponse
                    {
                        Data = courses,
                        Message = "Retrieve Data Successfully"
                    });
                }

                return NotFound(new ApiResponse
                {
                    Message = "No data found."
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Message = ex.Message
                });
            }
        }


        [Authorize]
        [HttpGet("g_elective_courses")]
        public async Task<IActionResult> Get_g_Electives()
        {
            try
            {
                var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);
                var tokenHandler = new JwtSecurityTokenHandler();
                var jwtToken = tokenHandler.ReadJwtToken(token);
                var claims = jwtToken.Claims;
                int userId = int.Parse(claims.FirstOrDefault(c => c.Type == "id")?.Value);

                var courses = await _db.general_Electives
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

                if (courses != null && courses.Any())
                {
                    return Ok(new ApiResponse
                    {
                        Data = courses,
                        Message = "Retrieve Data Successfully"
                    });
                }

                return NotFound(new ApiResponse
                {
                    Message = "No data found."
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Message = ex.Message
                });
            }
        }


        [Authorize]
        [HttpPut("courses/update")]
        public async Task<IActionResult> UpdateAndFetchSubjects(DTOupdateSubject dTOupdate)
        {
            try
            {
                if (dTOupdate != null)
                {
                    var token = Request.Headers["Authorization"].ToString().Replace("Bearer ", string.Empty);
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var jwtToken = tokenHandler.ReadJwtToken(token);
                    var claims = jwtToken.Claims;
                    int userId = int.Parse(claims.FirstOrDefault(c => c.Type == "id")?.Value);
                    foreach (var subjectCode in dTOupdate.code)
                    {
                       
                        var existingSubject = await _db.StudentSubjects
                            .SingleOrDefaultAsync(ss => ss.StudentId == userId && ss.SubjectCode == dTOupdate.code);

                        if (existingSubject != null)
                        {
                            if (dTOupdate.grade != "None")
                            {
                                existingSubject.grade = dTOupdate.grade;
                                _db.StudentSubjects.Update(existingSubject);
                            }
                        }
                        else
                        {
                            StudentSubject studentSubject = new()
                            {
                                StudentId = userId,
                                SubjectCode = dTOupdate.code,
                                grade = dTOupdate.grade
                            };
                            await _db.AddAsync(studentSubject);
                            await _db.SaveChangesAsync();
                        }
                    }

                    await _db.SaveChangesAsync();

                    var updatedSubjects = await _db.StudentSubjects
                        .Where(ss => ss.StudentId == userId)
                        .Select(ss => new Subject
                        {
                            code = ss.SubjectCode,
                            grade = ss.grade
                        })
                        .ToListAsync();

                    return Ok(new ApiResponse
                    {
                        Message = "Subjects updated."
                    });
                }

                return BadRequest(new ApiResponse
                {
                    Message = "Invalid input data"
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse
                {
                    Message = ex.Message
                });
            }
        }

    }
}