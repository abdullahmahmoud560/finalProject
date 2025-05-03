using System.ComponentModel.DataAnnotations;

namespace finalProject.DTO
{
    public class DTOforgetpassword
    {
        [EmailAddress]
        public string? email { get; set; }
    }
}
