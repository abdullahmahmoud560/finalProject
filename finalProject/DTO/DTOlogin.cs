using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finalProject.DTO
{
    public class DTOlogin
    {
        [EmailAddress]
        public string? email { get; set; }
        public string? password { get; set; }
    }
}
