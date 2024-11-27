using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace finalProject.Data
{
    [Table("Students")]
   public class Student
    {
        [Key]
        public int Id {  get; set; }
        [EmailAddress]
        public string Email {  get; set; }  
        public string FirstName { get; set; }        
        public string lastName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public string role { get; set; }
        public int? hours { get; set; }
        public float? gpa { get; set; }
        public string? department { get; set; }
        public string? level { get; set; }
        public byte[]? ProfilePic { get; set; }

        public ICollection<StudentSubject> StudentSubjects { get; set; }

    }
}
