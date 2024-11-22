using System.ComponentModel.DataAnnotations;

namespace finalProject.Models
{
    public class DTOforgetpassword
    {
        [EmailAddress]
        public string email { get; set; }
    }
}
