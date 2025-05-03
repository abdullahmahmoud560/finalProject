using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finalProject.Models
{
    public class Subject
    {
        [Key]
        public string? code { get; set; }
        public string? course_Name { get; set; }
        public int hours { get; set; }
        public ICollection<StudentSubject>? StudentSubjects { get; set; }
        [NotMapped]
        public string? grade { get; set; }
    }
}
