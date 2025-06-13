namespace Application.Interfaces
{
    public interface IEmailService
    {
        public Task<string> SendEmailAsync(string toEmail, string subject, string token);
        public Task<string> ResetPassword(string toEmail, string subject, string token);
    }
}
