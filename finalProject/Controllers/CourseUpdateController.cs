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
    public class CourseUpdateController : ControllerBase
    {
        private IServiceManager _serviceManager;

        public CourseUpdateController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [Authorize]
        [HttpPost("courses/update")]
        public async Task<IActionResult> UpdateAndFetchSubjects(UpdateSubjectDTO dTOupdate)
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

                var existingSubject = (await _serviceManager.StudentSubjectService.GetByConditionAsync
                    (ss => ss.StudentId == userId && ss.SubjectCode == dTOupdate.code)).FirstOrDefault();

                if (existingSubject != null)
                {
                    if (dTOupdate.grade != null)
                    {
                        existingSubject.grade = dTOupdate.grade;
                        await _serviceManager.StudentSubjectService.UpdateStudentSubject(existingSubject);
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
                        await _serviceManager.StudentSubjectService.AddStudentSubject(studentSubject);
                    }
                }
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
        public async Task<IActionResult> updateDepartment(UpdateDepartment dto)
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
                var student = (await _serviceManager.StudentService.GetByConditionAsync(l=>l.Id == userId)).FirstOrDefault();
                if (student == null)
                {
                    return NotFound(new ApiResponse
                    {
                        Message = "Student not found"
                    });
                }
                student.department_en = dto.DepartmentName;
                switch (student.department_en)
                {
                    case "CS":
                        student.department_ar = "علوم الحاسب";
                        break;
                    case "IT":
                        student.department_ar = "تكنولوجيا المعلومات";
                        break;
                    case "IS":
                        student.department_ar = "نظم المعلومات";
                        break;
                    case "AI":
                        student.department_ar = "الذكاء الإصطناعي";
                        break;

                }
                await _serviceManager.StudentService.UpdateStudent(student);
                return Ok(new ApiResponse
                {
                    Message = "Department updated successfully.",
                    Data = student.department_en
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
