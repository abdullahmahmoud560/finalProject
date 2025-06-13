using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Subject
    {
        [Column("SubjectCode")]
        [Key]
        public string? code { get; set; }
        public string? course_Name_en { get; set; }
        public int hours { get; set; }
        public ICollection<StudentSubject>? StudentSubjects { get; set; }
        [NotMapped]
        public string? grade { get; set; }
    }
}
