using System.Security.Claims;
using Application.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace finalProject.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CalcHourController : ControllerBase
    {
        private IServiceManager _serviceManager;

        public CalcHourController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [Authorize]
        [HttpGet("Calculate-Total-Hours")]
        public async Task<IActionResult> calculatetotalHours()
        {
            var userId = int.Parse(User.FindFirstValue("id")!);
            var department = (await _serviceManager.StudentService.GetByConditionAsync(l=>l.Id == userId)).Select(g=>new { g.department_en , g.department_ar }).FirstOrDefault();
            var allSubjects = (await _serviceManager.StudentSubjectService.GetByConditionAsync(ss => ss.StudentId == userId)).ToList();

            if (allSubjects.Any())
            {
                var insertHours = (await _serviceManager.StudentService.GetByConditionAsync(s => s.Id == userId)).FirstOrDefault();

                if (department!.department_en == "General")
                {
                    var General_Hours = await _serviceManager.FunctionService.CalculateTotalHoursGeneral(allSubjects);
                    var Faculty_Houes = await _serviceManager.FunctionService.CalculateTotalHoursFaculty(allSubjects);
                    insertHours!.hours = General_Hours+Faculty_Houes;
                    await _serviceManager.StudentService.UpdateStudent(insertHours!);
                    return Ok(new{GenralHours =  General_Hours,FacultyHours = Faculty_Houes});
                }
                else if(department!.department_en == "CS")
                {
                    var General_Hours = await _serviceManager.FunctionService.CalculateTotalHoursGeneral(allSubjects);
                    var Faculty_Houes = await _serviceManager.FunctionService.CalculateTotalHoursFaculty(allSubjects);
                    var CS_Hours = await _serviceManager.FunctionService.CalculateTotalHoursCS(allSubjects);
                    insertHours!.hours = General_Hours + Faculty_Houes + CS_Hours;
                    await _serviceManager.StudentService.UpdateStudent(insertHours!);
                    return Ok(new { GenralHours = General_Hours, FacultyHours = Faculty_Houes,CSHours = CS_Hours });
                }else if(department!.department_en == "IS")
                {
                    var General_Hours = await _serviceManager.FunctionService.CalculateTotalHoursGeneral(allSubjects);
                    var Faculty_Houes = await _serviceManager.FunctionService.CalculateTotalHoursFaculty(allSubjects);
                    var IS_Hours = await _serviceManager.FunctionService.CalculateTotalHoursIS(allSubjects);
                    insertHours!.hours = General_Hours + Faculty_Houes + IS_Hours;
                    await _serviceManager.StudentService.UpdateStudent(insertHours!);
                    return Ok(new { GenralHours = General_Hours, FacultyHours = Faculty_Houes,ISHours = IS_Hours });
                }else if(department!.department_en == "IT")
                {
                    var General_Hours = await _serviceManager.FunctionService.CalculateTotalHoursGeneral(allSubjects);
                    var Faculty_Houes = await _serviceManager.FunctionService.CalculateTotalHoursFaculty(allSubjects);
                    var IT_Hours = await _serviceManager.FunctionService.CalculateTotalHoursIT(allSubjects);
                    insertHours!.hours = General_Hours + Faculty_Houes + IT_Hours;
                    await _serviceManager.StudentService.UpdateStudent(insertHours!);
                    return Ok(new { GenralHours = General_Hours, FacultyHours = Faculty_Houes,ITHours = IT_Hours });
                }else if(department!.department_en == "AI")
                {
                    var General_Hours = await _serviceManager.FunctionService.CalculateTotalHoursGeneral(allSubjects);
                    var Faculty_Houes = await _serviceManager.FunctionService.CalculateTotalHoursFaculty(allSubjects);
                    var AI_Hours = await _serviceManager.FunctionService.CalculateTotalHoursAI(allSubjects);
                    insertHours!.hours = General_Hours + Faculty_Houes + AI_Hours;
                    await _serviceManager.StudentService.UpdateStudent(insertHours!);
                    return Ok(new { GenralHours = General_Hours, FacultyHours = Faculty_Houes,AIHours = AI_Hours });
                }
            }
            return Ok(new { GenralHours = 0, FacultyHours = 0 });
        }
    }
}
