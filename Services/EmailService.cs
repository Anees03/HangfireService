using MailKit.Net.Smtp;
using MimeKit;
using System.Collections.Generic;
using System.Threading.Tasks;

public class EmailService
{
    public async Task SendEmailAsync(string recipientEmail, string subject, string body, List<string> attachments)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Your Company", "test@example.com"));
        message.To.Add(new MailboxAddress("Contractor", recipientEmail));
        message.Subject = subject;

        var builder = new BodyBuilder
        {
            HtmlBody = body
        };

        // Attach files
        foreach (var filePath in attachments)
        {
            builder.Attachments.Add(filePath);
        }

        message.Body = builder.ToMessageBody();

        try
        {
            using var smtp = new SmtpClient();

            // Log the email sending
            Console.WriteLine("Connecting to SMTP server...");

            // Connect to Papercut on localhost with port 25
            await smtp.ConnectAsync("localhost", 25, MailKit.Security.SecureSocketOptions.None);

            Console.WriteLine("Connected to SMTP server. Sending email...");

            // No authentication is required for Papercut
            await smtp.SendAsync(message);

            Console.WriteLine("Email sent successfully!");

            await smtp.DisconnectAsync(true);
        }
        catch (Exception ex)
        {
            // Log any exceptions during email sending
            Console.WriteLine($"Error sending email: {ex.Message}");
        }
    }
}
