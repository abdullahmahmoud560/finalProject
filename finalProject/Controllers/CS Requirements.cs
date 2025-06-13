using System.Security.Claims;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Shared.DataTransferObjects;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CS_Requirements : ControllerBase
    {
      
         private readonly IServiceManager _serviceManager;

        public CS_Requirements(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

            [Authorize]
            [HttpGet("cs_core_courses")]
            public async Task<IActionResult> Get_cs_Compulsory()
            {
            try
            {
                var userId = int.Parse(User.FindFirstValue("id")!);
                var courses = await _serviceManager.CourseService.CS_Compulsories(userId);
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
            [HttpGet("cs_elective_courses")]
            public async Task<IActionResult> Get_cs_Electives()
            {
            try
            {
                var userId = int.Parse(User.FindFirstValue("id")!);
                var courses = await _serviceManager.CourseService.CS_Electives(userId);
                List<CourseDTO> courseDTOs = new List<CourseDTO>();

                if (courses.Any())
                {
                    foreach (var course in courses)
                    {
                        if (course.prerequest_en != "-")
                        {

                            var isFound = (await _serviceManager.StudentSubjectService.GetByConditionAsync
                               (ss => ss.StudentId == userId && ss.Subject!.course_Name_en == course.prerequest_en && ss.grade != "F")).FirstOrDefault();
                            if (isFound !=null)
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
