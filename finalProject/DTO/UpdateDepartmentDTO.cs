using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Primitives;

namespace finalProject.DTO
{
    public class UpdateDepartmentDTO
    {
        [AllowedValues("CS", "IT", "IS", "AI")]
        public string? DepartmentName { get; set; }
    }
}
