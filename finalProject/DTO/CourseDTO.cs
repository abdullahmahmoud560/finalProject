namespace finalProject.DTO
{
    public class CourseDTO
    {

        public string Code { get; set; } = null!;
        public string course_Name { get; set; } = null!;
        public int Hours { get; set; }
        public string? Prerequest { get; set; }
        public string? Grade { get; set; } = null!;
    }
}
