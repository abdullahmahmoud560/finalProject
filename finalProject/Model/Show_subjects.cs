using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finalProject.Models
{
    public class Show_Subjects
    {
        [Key]
        public string? code { get; set; }
        public string? course_Name { get; set; }
        public int? hours { get; set; }
        public string? prerequest { get; set; }
        [NotMapped]
        public string? grade { get; set; }
    }

    [Table("AI Requirements_Compulsory")]
    public class AI_Compulsory : Show_Subjects
    {
    }

    [Table("AI Requirements_Electives")]
    public class AI_Electives : Show_Subjects
    {
    }

    [Table("CS Requirements_Compulsory")]
    public class CS_Compulsory : Show_Subjects
    {
    }

    [Table("CS Requirements_Electives")]
    public class CS_Electives : Show_Subjects
    {
    }

    [Table("Faculty Requirements_Compulsory")]
    public class Faculty_Compulsory : Show_Subjects
    {
    }

    [Table("Faculty Requirements_Electives")]
    public class Faculty_Electives : Show_Subjects
    {
    }

    [Table("General Requirements_Compulsory")]
    public class General_Compulsory : Show_Subjects
    {
    }

    [Table("General Requirements_Electives")]
    public class General_Electives : Show_Subjects
    {
    }


    [Table("IS Requirements_Compulsory")]
    public class IS_Compulsory : Show_Subjects
    {
    }


    [Table("IS Requirements_Electives")]
    public class IS_Electives : Show_Subjects
    {
    }

    [Table("IT Requirements_Compulsory")]
    public class IT_Compulsory : Show_Subjects
    {
    }

    [Table("IT Requirements_Electives")]
    public class IT_Electives : Show_Subjects
    {
    }
}
