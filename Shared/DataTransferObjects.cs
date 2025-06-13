using System.ComponentModel.DataAnnotations.Schema;

namespace Shared
{
    public class DataTransferObjects
    {
        public class CourseDTO 
        { 
            public string? Code { get; set; }
            public string? course_Name_en { get; set; }
            public string? course_Name_ar { get; set; }
            public int Hours { get; set; }
            public string? prerequest_en { get; set; }
            public string? prerequest_ar { get; set; }
            public string? Grade { get; set; }
        };
        public record ForgetDTO (string email);
        public record profileDTO(string firstName,string lastName,string email,string password);
        public record loginDTO(string? email, string password);
        public record registerDTO(string? email, string firstName, string lastName, string? password);
        public record UpdateSubjectDTO (string? code , string? grade, int hours );
        public class GPADTO
        { 
            public int Hours { get; set; }
            public double points { get; set; }
        }
        public record ResetDTO(string password, string confirm);
        public record UpdateDepartment(string DepartmentName);
        public class UserInformation
        {
            public int Id { get; set; }
            public string? firstName { get; set; }
            public string? lastName { get; set; }
            public string? email { get; set; }
            public string? token { get; set; }
            public string? role { get; set; }
            public string? hours { get; set; }
            public float gpa { get; set; }
            public string? department { get; set; }
            public string? level { get; set; }
        }
        public class ApiResponse 
        {
            public string Message { get; set; } = string.Empty;
            public string State { get; set; } = string.Empty;
            public object? Data { get; set; } = null;
        };
        public record ChatBotDTO(string question,int ChatId);
        public class UplaodDTO
        {
            public Stream? Content { get; set; }
            public string? FileName { get; set; }
            public string? ContentType { get; set; }
        };
        public class SaveFile
        {
            public Stream? Content { get; set; }
            public string? FileName { get; set; }
            public int? ChatId { get; set; } 
            public int? StudentId { get; set; }
        }
        public record ChatDPFDTO(string question, string fileName , int ChatId);
    }
}
