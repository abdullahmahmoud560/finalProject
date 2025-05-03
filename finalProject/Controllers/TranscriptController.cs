using System.Security.Claims;
using finalProject.Data;
using finalProject.DTO;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class TranscriptController : ControllerBase
    {
        private readonly DB _db;

        public TranscriptController(DB db)
        {
            _db = db;
        }

        [Authorize]
        [HttpGet("Transcript")]
        public async Task<IActionResult> transcript()
        {
            try { 
                var userId = User.FindFirstValue("id");
                var student = _db.StudentSubjects.Where(l=>l.StudentId == int.Parse(userId!)).ToList();
                List<GPA_DTO> transcript = new List<GPA_DTO>();
                double GPA = 0;
                string totalGpa = string.Empty;
                int? totalHours = 0;
                if (student.Any())
                {
                    foreach (var point in student)
                    {
                        var subject = await _db.Subjects.Where(l => l.code == point.SubjectCode).FirstOrDefaultAsync();
                        switch (point.grade)
                        {
                            case "A+": transcript.Add(new GPA_DTO { points = 4.0,Hours = subject!.hours }); break;
                            case "A": transcript.Add(new GPA_DTO { points = 3.75 , Hours = subject!.hours }); break;
                            case "B+": transcript.Add(new GPA_DTO { points = 3.4, Hours = subject!.hours }); break;
                            case "B": transcript.Add(new GPA_DTO { points = 3.1, Hours = subject!.hours }); break;
                            case "C+": transcript.Add(new GPA_DTO { points = 2.8 , Hours = subject!.hours }); break;
                            case "C": transcript.Add(new GPA_DTO { points = 2.5, Hours = subject!.hours }); break;
                            case "D+": transcript.Add(new GPA_DTO { points = 2.25, Hours = subject!.hours }); break;
                            case "D": transcript.Add(new GPA_DTO { points = 2 , Hours = subject!.hours }); break;
                            case "F": transcript.Add(new GPA_DTO { points = 1 , Hours = subject!.hours }); break;
                        }
                    }
                    var totalPoints = transcript.Sum(l => l.points * l.Hours!.Value);
                    totalHours = transcript.Sum(l => l.Hours)!.Value;
                    GPA = (totalHours == 0) ? 0 : (totalPoints / totalHours)!.Value;
                    if (GPA >= 3.75)
                        totalGpa = "Excellent";
                    else if (GPA >= 3.0)
                        totalGpa = "Very Good";
                    else if (GPA >= 2.5)
                        totalGpa = "Good";
                    else if (GPA >= 2.0)
                        totalGpa = "Pass";
                    else
                        totalGpa = "Fail";
                    transcript.Add(new GPA_DTO { Hours = totalHours });
                }
                var addGpa = await _db.students.Where(l => l.Id == int.Parse(userId!)).FirstOrDefaultAsync();
                addGpa!.gpa = GPA;
                _db.students.Update(addGpa);
                await _db.SaveChangesAsync();
                return Ok(new { GPA = Math.Round(GPA, 2), totalHours = totalHours, Department = addGpa.department, totalGpa });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
