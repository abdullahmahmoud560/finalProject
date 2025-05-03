using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

public class EmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<string> SendEmailAsync(string toEmail, string subject,string token)
    {
        try
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Eduguideai", _configuration["EmailConfiguration:From"]));
            message.ReplyTo.Add(new MailboxAddress("Eduguideai", "support@gmail.com"));
            message.To.Add(new MailboxAddress("", toEmail)); 
            message.Subject = subject;
            var yesLink = $"https://eduguideai.runasp.net/api/api/account/activate?token={token}";

            var body = $@"
<!DOCTYPE html>
<html lang=""en"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Confirm Your Account - EduguideAI</title>
</head>
<body style=""font-family: Arial, sans-serif; color: #333; text-align: center; padding: 20px;"">
    <div style=""max-width: 600px; margin: auto; border: 1px solid #ddd; border-radius: 10px; padding: 20px; background-color: #f9f9f9;"">
        <h2 style=""color: #4CAF50;"">Did You Create an Account on EduguideAI?</h2>
        <p style=""font-size: 16px;"">Someone used your email to create an account.</p>
        <p style=""font-size: 16px;"">If it was you, please confirm to activate your account:</p>

        <div style=""margin-top: 30px;"">
            <a href=""{yesLink}"" target=""_blank"" 
               style=""display: inline-block; background-color: #4CAF50; color: #fff; padding: 12px 20px; 
                      text-decoration: none; font-size: 16px; border-radius: 5px;"">
                ✅ Yes, it was me
            </a>
        </div>

        <p style=""font-size: 14px; margin-top: 30px;"">If you don't confirm, your account will not be activated.</p>

        <hr style=""margin:30px 0;""/>
        <p style=""font-size: 14px; color: #777;"">
            Best regards,<br/>
            The <strong>EduguideAI</strong> Team<br/>
            <a href=""https://edu-guide-ai.vercel.app"" target=""_blank"">eduguideai.com</a><br/>
            Support: <a href=""mailto:support@eduguideai.com"">support@eduguideai.com</a>
        </p>
    </div>
</body>
</html>";


            // إنشاء هيكل الرسالة مع دعم HTML
            var bodyBuilder = new BodyBuilder
            {
                HtmlBody = body
            };

            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_configuration["EmailConfiguration:SmtpServer"], int.Parse(_configuration["EmailConfiguration:Port"]!), SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(_configuration["EmailConfiguration:Username"], _configuration["EmailConfiguration:Password"]);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
            return("Email sent successfully.");
        }
        catch (Exception ex)
        {
           return ($"Error sending email: {ex.Message}");
        }
    }
}
