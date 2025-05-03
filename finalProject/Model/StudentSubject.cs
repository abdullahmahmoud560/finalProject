using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace finalProject.Models
{
    public class StudentSubject
    {
        [Key]
       public int StudentId { get; set; }
        public Student? Student { get; set; }
        public Subject? Subject { get; set; }
        public string? SubjectCode { get; set; }
        public string? grade { get; set; }
        public Collection<Student>? students { get; set; }
    }
}
