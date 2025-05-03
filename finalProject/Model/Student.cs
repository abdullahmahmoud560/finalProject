namespace finalProject.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? lastName { get; set; }
        public string? Password { get; set; }
        public string? Token { get; set; }
        public string? role { get; set; }
        public int? hours { get; set; }
        public double? gpa { get; set; }
        public string? department { get; set; }
        public bool? isActive { get; set; } = false;
        public ICollection<StudentSubject>? StudentSubjects { get; set; }
        public StudentSubject? StudentSubject { get; set; }
        public string? SubjectCode { get; set; }

    }
}
