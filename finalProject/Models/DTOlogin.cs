using System.ComponentModel.DataAnnotations;

namespace finalProject.Models
{
    public class DTOlogin
    {
        [EmailAddress]
        public string email { get; set; }
        public string password { get; set; }
    }
}
