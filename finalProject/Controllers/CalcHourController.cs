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
    public class CalcHourController : ControllerBase
    {
        private DB _db;
        private Functions _functions;
        public CalcHourController(DB db ,Functions functions)
        {
            _db = db;
            _functions = functions;
        }

        [Authorize]
        [HttpGet("Calculate-Total-Hours")]
        public async Task<IActionResult> calculatetotalHours()
        {
            var userId = int.Parse(User.FindFirstValue("id")!);
            var department = User.FindFirstValue("department");
            var allSubjects = await _db.StudentSubjects.Where(ss => ss.StudentId == userId).ToListAsync();

            if (allSubjects.Any())
            {
                var insertHours = await _db.students.Where(s => s.Id == userId).FirstOrDefaultAsync();

                if (department == "General")
                {
                    var General_Hours = await _functions.CalculateTotalHoursGeneral(allSubjects);
                    var Faculty_Houes = await _functions.CalculateTotalHoursFaculty(allSubjects);
                    insertHours!.hours = General_Hours+Faculty_Houes;
                    _db.students.Update(insertHours!);
                    await _db.SaveChangesAsync();
                    return Ok(new{GenralHours =  General_Hours,FacultyHours = Faculty_Houes});
                }
                else if(department == "CS")
                {
                    var General_Hours = await _functions.CalculateTotalHoursGeneral(allSubjects);
                    var Faculty_Houes = await _functions.CalculateTotalHoursFaculty(allSubjects);
                    var CS_Hours = await _functions.CalculateTotalHoursCS(allSubjects);
                    insertHours!.hours = General_Hours + Faculty_Houes + CS_Hours;
                    _db.students.Update(insertHours!);
                    await _db.SaveChangesAsync();
                    return Ok(new { GenralHours = General_Hours, FacultyHours = Faculty_Houes,CSHours = CS_Hours });
                }else if(department == "IS")
                {
                    var General_Hours = await _functions.CalculateTotalHoursGeneral(allSubjects);
                    var Faculty_Houes = await _functions.CalculateTotalHoursFaculty(allSubjects);
                    var IS_Hours = await _functions.CalculateTotalHoursIS(allSubjects);
                    insertHours!.hours = General_Hours + Faculty_Houes + IS_Hours;
                    _db.students.Update(insertHours!);
                    await _db.SaveChangesAsync();
                    return Ok(new { GenralHours = General_Hours, FacultyHours = Faculty_Houes,ISHours = IS_Hours });
                }else if(department == "IT")
                {
                    var General_Hours = await _functions.CalculateTotalHoursGeneral(allSubjects);
                    var Faculty_Houes = await _functions.CalculateTotalHoursFaculty(allSubjects);
                    var IT_Hours = await _functions.CalculateTotalHoursIT(allSubjects);
                    insertHours!.hours = General_Hours + Faculty_Houes + IT_Hours;
                    _db.students.Update(insertHours!);
                    await _db.SaveChangesAsync();
                    return Ok(new { GenralHours = General_Hours, FacultyHours = Faculty_Houes,CSHours = IT_Hours });
                }else if(department == "AI")
                {
                    var General_Hours = await _functions.CalculateTotalHoursGeneral(allSubjects);
                    var Faculty_Houes = await _functions.CalculateTotalHoursFaculty(allSubjects);
                    var AI_Hours = await _functions.CalculateTotalHoursAI(allSubjects);
                    insertHours!.hours = General_Hours + Faculty_Houes + AI_Hours;
                    _db.students.Update(insertHours!);
                    await _db.SaveChangesAsync();
                    return Ok(new { GenralHours = General_Hours, FacultyHours = Faculty_Houes,AIHours = AI_Hours });
                }
            }
            return Ok();
        }
    }
}
