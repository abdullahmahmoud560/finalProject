namespace finalProject.Models
{
    public class DTOprofile
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string? password { get; set; }
        public IFormFile? profilePic { get; set; }
    }
}
