using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finalProject.Data
{
    public class Subject
    {
        [Key]
        [Required]
        public string code { get; set; }
        [Required]
        public string course_Name { get; set; }
        [Required]
        public int hours { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }

        [NotMapped]
        public string? grade { get; set; }
    }
}
