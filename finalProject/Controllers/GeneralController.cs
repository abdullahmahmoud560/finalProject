using System.Security.Claims;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Shared.DataTransferObjects;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class GeneralController : ControllerBase
    {
        private IServiceManager _serviceManager;

        public GeneralController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [Authorize]
        [HttpGet("g_core_courses")]
        public async Task<IActionResult> Get_g_Compulsory()
        {
            try
            {
                var userId = int.Parse(User.FindFirstValue("id")!);
                var courses = await _serviceManager.CourseService.General_Compulsories(userId);

                List<CourseDTO> courseDTOs = new List<CourseDTO>();

                if (courses.Any())
                {
                    foreach (var course in courses)
                    {
                        if (course.prerequest_en != "-")
                        {
                           
                            var isFound = (await _serviceManager.StudentSubjectService.GetByConditionAsync
                               (ss => ss.StudentId == userId && ss.Subject!.course_Name_en == course.prerequest_en && ss.grade != "F")).FirstOrDefault();
                            if (isFound != null)
                            {
                                courseDTOs.Add(new CourseDTO
                                {
                                    Code = course.code!,
                                    course_Name_en = course.course_Name_en!,
                                    course_Name_ar = course.course_Name_ar!,
                                    Hours = course.hours!.Value,
                                    prerequest_en = course.prerequest_en,
                                    prerequest_ar = course.prerequest_ar,
                                    Grade = course.grade
                                });
                            }
                        }
                        else
                        {
                            courseDTOs.Add(new CourseDTO
                            {
                                Code = course.code!,
                                course_Name_en = course.course_Name_en!,
                                course_Name_ar = course.course_Name_ar!,
                                Hours = course.hours!.Value,
                                prerequest_en = course.prerequest_en,
                                prerequest_ar = course.prerequest_ar,
                                Grade = course.grade
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
        [HttpGet("g_elective_courses")]
        public async Task<IActionResult> Get_g_Electives()
        {
            try
            {
                var userId = int.Parse(User.FindFirstValue("id")!);

                var courses = await _serviceManager.CourseService.General_Electives(userId);
                List<CourseDTO> courseDTOs = new List<CourseDTO>();

                if (courses.Any())
                {
                    foreach (var course in courses)
                    {
                        if (course.prerequest_en != "-")
                        {

                            var isFound = (await _serviceManager.StudentSubjectService.GetByConditionAsync
                               (ss => ss.StudentId == userId && ss.Subject!.course_Name_en == course.prerequest_en && ss.grade != "F")).FirstOrDefault();
                            if (isFound != null )
                            {
                                courseDTOs.Add(new CourseDTO
                                {
                                    Code = course.code!,
                                    course_Name_en = course.course_Name_en!,
                                    course_Name_ar = course.course_Name_ar!,
                                    Hours = course.hours!.Value,
                                    prerequest_en = course.prerequest_en,
                                    prerequest_ar = course.prerequest_ar,
                                    Grade = course.grade
                                });
                            }
                        }
                        else
                        {
                            courseDTOs.Add(new CourseDTO
                            {
                                Code = course.code!,
                                course_Name_en = course.course_Name_en!,
                                course_Name_ar = course.course_Name_ar!,
                                Hours = course.hours!.Value,
                                prerequest_en = course.prerequest_en,
                                prerequest_ar = course.prerequest_ar,
                                Grade = course.grade
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