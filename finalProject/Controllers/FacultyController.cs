using System.Security.Claims;
using finalProject.Data;
using finalProject.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class FacultyController : ControllerBase
    {
        private readonly DB _db;

        public FacultyController(DB db)
        {
            _db = db;
        }

        [Authorize]
        [HttpGet("f_core_courses")]
        public async Task<IActionResult> Get_f_Compulsory()
        {
            try
            {
                var userId = int.Parse(User.FindFirstValue("id")!);

                var courses = await _db.faculty_Compulsories
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
                           Grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
                       }
                   )
                   .ToListAsync();
                List<CourseDTO> courseDTOs = new List<CourseDTO>();

                if (courses.Any())
                {
                    foreach (var course in courses)
                    {
                        if (course.prerequest != "-")
                        {
                            var isFound = await _db.StudentSubjects
                               .AnyAsync(ss => ss.StudentId == userId && ss.Subject!.course_Name == course.prerequest);
                            if (isFound)
                            {
                                courseDTOs.Add(new CourseDTO
                                {
                                    Code = course.code!,
                                    course_Name = course.course_Name!,
                                    Hours = course.hours!.Value,
                                    Prerequest = course.prerequest,
                                    Grade = course.Grade
                                });
                            }
                        }
                        else
                        {
                            courseDTOs.Add(new CourseDTO
                            {
                                Code = course.code!,
                                course_Name = course.course_Name!,
                                Hours = course.hours!.Value,
                                Prerequest = course.prerequest,
                                Grade = course.Grade
                            });
                        }
                    }
                }
                return Ok(new ApiResponse
                {
                    Data = courseDTOs,
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
        [HttpGet("f_elective_courses")]
        public async Task<IActionResult> Get_f_Electives()
        {
            try
            {
                var userId = int.Parse(User.FindFirstValue("id")!);
                var courses = await _db.faculty_Electives
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
                           Grade = studentSubjects.Any() ? studentSubjects.FirstOrDefault()!.grade : null
                       }
                   )
                   .ToListAsync();

                List<CourseDTO> courseDTOs = new List<CourseDTO>();

                if (courses.Any())
                {
                    foreach (var course in courses)
                    {
                        if (course.prerequest != "-")
                        {
                            
                            var isFound = await _db.StudentSubjects
                               .AnyAsync(ss => ss.StudentId == userId && ss.Subject!.course_Name == course.prerequest);
                            if (isFound)
                            {
                                courseDTOs.Add(new CourseDTO
                                {
                                    Code = course.code!,
                                    course_Name = course.course_Name!,
                                    Hours = course.hours!.Value,
                                    Prerequest = course.prerequest,
                                    Grade = course.Grade
                                });
                            }
                        }
                        else
                        {
                            courseDTOs.Add(new CourseDTO
                            {
                                Code = course.code!,
                                course_Name = course.course_Name!,
                                Hours = course.hours!.Value,
                                Prerequest = course.prerequest,
                                Grade = course.Grade
                            });
                        }
                    }

                }
                return Ok(new ApiResponse
                {
                    Data = courseDTOs,
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
