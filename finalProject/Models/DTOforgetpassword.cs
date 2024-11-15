using System.ComponentModel.DataAnnotations;

namespace finalProject.Models
{
    public class DTOforgetpassword
    {
        [EmailAddress]
        public string email { get; set; }
        public string ClientUrl { get; set; }
    }
}
