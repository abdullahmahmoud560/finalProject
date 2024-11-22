using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finalProject.Models
{
    public class DTOlogin
    {
        [EmailAddress]
        public string email { get; set; }
        public string password { get; set; }
    }
}
