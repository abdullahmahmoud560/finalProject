using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace finalProject.Models
{
    public class DTOregister
    {
        [EmailAddress]
        public string email { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
    }
}
