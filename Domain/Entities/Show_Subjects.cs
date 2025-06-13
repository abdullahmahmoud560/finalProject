using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Show_Subjects
    {
        public string? code { get; set; }
        public string? course_Name_en { get; set; }
        public string? course_Name_ar { get; set; }
        public int? hours { get; set; }
        public string? prerequest_en { get; set; }
        public string? prerequest_ar { get; set; }
        [NotMapped]
        public string? grade { get; set; }
    }

    [Table("AI Requirements_Compulsory")]
    public class AI_Compulsory : Show_Subjects
    {
        [Key]
        public new string? code { get; set; }
    }

    [Table("AI Requirements_Electives")]
    public class AI_Electives : Show_Subjects
    {
        [Key]
        public new string? code { get; set; }
    }

    [Table("CS Requirements_Compulsory")]
    public class CS_Compulsory : Show_Subjects
    {
        [Key]
        public new string? code { get; set; }
    }

    [Table("CS Requirements_Electives")]
    public class CS_Electives : Show_Subjects
    {
        [Key]
        public new string? code { get; set; }
    }

    [Table("Faculty Requirements_Compulsory")]
    public class Faculty_Compulsory : Show_Subjects
    {
        [Key]
        public new string? code { get; set; }
    }

    [Table("Faculty Requirements_Electives")]
    public class Faculty_Electives : Show_Subjects
    {
        [Key]
        public new string? code { get; set; }
    }

    [Table("General Requirements_Compulsory")]
    public class General_Compulsory : Show_Subjects
    {
        [Key]
        public new string? code { get; set; }
    }

    [Table("General Requirements_Electives")]
    public class General_Electives : Show_Subjects
    {
        [Key]
        public new string? code { get; set; }
    }

    [Table("IS Requirements_Compulsory")]
    public class IS_Compulsory : Show_Subjects
    {
        [Key]
        public new string? code { get; set; }
    }

    [Table("IS Requirements_Electives")]
    public class IS_Electives : Show_Subjects
    {
        [Key]
        public new string? code { get; set; }
    }

    [Table("IT Requirements_Compulsory")]
    public class IT_Compulsory : Show_Subjects
    {
        [Key]
        public new string? code { get; set; }
    }

    [Table("IT Requirements_Electives")]
    public class IT_Electives : Show_Subjects
    {
        [Key]
        public new string? code { get; set; }
    }
}
