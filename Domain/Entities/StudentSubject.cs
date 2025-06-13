using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class StudentSubject
    {
        public int Id { get; set; }
        public Student? Student { get; set; }
        public Subject? Subject { get; set; }

        [ForeignKey(nameof(Subject))]
        public string? SubjectCode { get; set; }
        public string? grade { get; set; }
        [ForeignKey(nameof(Student))]
        public int? StudentId { get; set; }
    }
}
