using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace finalProject.Data
{
   public class Register
    {
        [Key]
        public int Id {  get; set; }
        
        [EmailAddress]
        public string Email {  get; set; }  

       public string FirstName { get; set; }        
       public string LastName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string role { get; set; }
   }
}
