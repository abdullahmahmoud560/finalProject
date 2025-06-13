using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Student
    {
        [Column("StudentId")]
        public int Id { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        [RegularExpression(@"^[\u0621-\u064A a-zA-Z]+$")]
        public string? FirstName { get; set; }

        [RegularExpression(@"^[\u0621-\u064A a-zA-Z]+$")]
        public string? lastName { get; set; }

        public string? Password { get; set; }
        public string? Token { get; set; } = string.Empty;
        public string? role { get; set; }
        public int? hours { get; set; }
        public double? gpa { get; set; }
        [AllowedValues("CS", "IT", "IS", "AI")]
        public string? department_en { get; set; }
        public string? department_ar { get; set; }
        public bool? isActive { get; set; } = false;
        public ICollection<StudentSubject>? StudentSubjects { get; set; }
        public ICollection<ChatMessage>? chatMessages { get; set; }
        public ICollection<ChatMessagePDF>? chatPDFHistories { get; set; }
    }
}
