using System.Security.Claims;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Shared.DataTransferObjects;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class TranscriptController : ControllerBase
    {

        private IServiceManager _serviceManager;

        public TranscriptController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [Authorize]
        [HttpGet("Transcript")]
        public async Task<IActionResult> transcript()
        {
            try { 
                var userId = User.FindFirstValue("id");
                var student = await _serviceManager.StudentSubjectService.GetByConditionAsync(l => l.StudentId == int.Parse(userId!));
                List<GPADTO> transcript = new List<GPADTO>();
                double GPA = 0;
                string totalGpa_en = string.Empty;
                string totalGpa_ar = string.Empty;
                int? totalHours = 0;
                if (student.Any())
                {
                    foreach (var point in student)
                    {
                        var subject = (await _serviceManager.SubjectService.GetByConditionAsync(l => l.code == point.SubjectCode)).FirstOrDefault();
                        switch (point.grade)
                        {
                            case "A+": transcript.Add(new GPADTO { points = 4.0,Hours = subject!.hours }); break;
                            case "A": transcript.Add(new GPADTO { points = 3.75 , Hours = subject!.hours }); break;
                            case "B+": transcript.Add(new GPADTO { points = 3.4, Hours = subject!.hours }); break;
                            case "B": transcript.Add(new GPADTO { points = 3.1, Hours = subject!.hours }); break;
                            case "C+": transcript.Add(new GPADTO { points = 2.8 , Hours = subject!.hours }); break;
                            case "C": transcript.Add(new GPADTO { points = 2.5, Hours = subject!.hours }); break;
                            case "D+": transcript.Add(new GPADTO { points = 2.25, Hours = subject!.hours }); break;
                            case "D": transcript.Add(new GPADTO { points = 2 , Hours = subject!.hours }); break;
                            case "F": transcript.Add(new GPADTO { points = 1 , Hours = subject!.hours }); break;
                        }
                    }
                    var totalPoints = transcript.Sum(l => l.points * l.Hours);
                    totalHours = transcript.Sum(l => l.Hours);
                    GPA = (totalHours == 0) ? 0 : (totalPoints / totalHours)!.Value;
                    if (GPA >= 3.75)
                    {
                        totalGpa_en = "Excellent";
                        totalGpa_ar = "ممتاز";
                    }
                    else if (GPA >= 3.0)
                    {
                        totalGpa_en = "Very Good";
                        totalGpa_ar = "جيد جداً";
                    }
                    else if (GPA >= 2.5)
                    {
                        totalGpa_en = "Good";
                        totalGpa_ar = "جيد";
                    }
                    else if (GPA >= 2.0)
                    {
                        totalGpa_en = "Pass";
                        totalGpa_ar = "مقبول";
                    }
                    else
                    {
                        totalGpa_en = "Fail";
                        totalGpa_ar = "راسب";
                    }
                    transcript.Add(new GPADTO { Hours = totalHours.Value });
                }
                var addGpa = (await _serviceManager.StudentService.GetByConditionAsync(l => l.Id == int.Parse(userId!))).FirstOrDefault();
                addGpa!.gpa = GPA;
                await _serviceManager.StudentService.UpdateStudent(addGpa);
                return Ok(new { GPA = Math.Round(GPA, 2), totalHours = totalHours, addGpa.department_en, addGpa.department_ar , totalGpa_en , totalGpa_ar });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
