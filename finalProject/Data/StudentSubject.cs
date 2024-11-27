using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace finalProject.Data
{
    public class StudentSubject
    {
        [Key]
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [ForeignKey("Subject")]
        public string SubjectCode { get; set; }
        public Subject Subject { get; set; }
        public string? grade { get; set; }
    }
}
