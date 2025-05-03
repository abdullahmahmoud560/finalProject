using System.Security.Claims;
using finalProject.Data;
using finalProject.DTO;
using finalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CourseUpdateController : ControllerBase
    {
        private readonly DB _db;

        public CourseUpdateController(DB db)
        {
            _db = db;
        }

        [Authorize]
        [HttpPost("courses/update")]
        public async Task<IActionResult> UpdateAndFetchSubjects(DTOupdateSubject dTOupdate)
        {
            try
            {
                if (dTOupdate.code == null || dTOupdate.grade == null || dTOupdate.hours == 0)
                {
                    return BadRequest(new ApiResponse
                    {
                        Message = "Invalid input data"
                    });
                }

                int userId = int.Parse(User.FindFirstValue("id")!);

                var existingSubject = await _db.StudentSubjects.FirstOrDefaultAsync
                    (ss => ss.StudentId == userId && ss.SubjectCode == dTOupdate.code);

                if (existingSubject != null)
                {
                    if (dTOupdate.grade != null)
                    {
                        existingSubject.grade = dTOupdate.grade;
                        _db.StudentSubjects.Update(existingSubject);
                    }
                }
                else
                {
                    if (dTOupdate.grade != null)
                    {
                        var studentSubject = new StudentSubject
                        {
                            StudentId = userId,
                            SubjectCode = dTOupdate.code,
                            grade = dTOupdate.grade
                        };
                        await _db.StudentSubjects.AddAsync(studentSubject);
                    }
                }
                await _db.SaveChangesAsync();

                return Ok(new ApiResponse
                {
                    Message = "Updated Successfully.",
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
        [HttpPost("Update-Department")]
        public async Task<IActionResult> updateDepartment(UpdateDepartmentDTO dto)
        {
            try
            {
                if (dto == null)
                {
                    return BadRequest(new ApiResponse
                    {
                        Message = "Invalid input data"
                    });
                }
                int userId = int.Parse(User.FindFirstValue("id")!);
                var student = await _db.students.FindAsync(userId);
                if (student == null)
                {
                    return NotFound(new ApiResponse
                    {
                        Message = "Student not found"
                    });
                }

                student.department = dto.DepartmentName;
                _db.students.Update(student);
                await _db.SaveChangesAsync();
                return Ok(new ApiResponse
                {
                    Message = "Department updated successfully."
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
