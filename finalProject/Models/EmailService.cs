using MimeKit;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using System.Configuration;

public class EmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<string> SendEmailAsync(string toEmail, string subject, string body)
    {
        try
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Eduguideai", _configuration["EmailConfiguration:From"]));  
            message.To.Add(new MailboxAddress("", toEmail)); 
            message.Subject = subject;
            message.Body = new TextPart("plain") { Text = body };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync(_configuration["EmailConfiguration:SmtpServer"], int.Parse(_configuration["EmailConfiguration:Port"]), true);
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
