using MailKit.Net.Smtp;
using MimeKit;
using System.Collections.Generic;
using System.Threading.Tasks;

public class SmtpSettings
{
    public string Server { get; set; }
    public int Port { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}

public class EmailService
{
    private readonly SmtpSettings _smtpSettings;
    private readonly ILogger<EmailService> _logger;

    public EmailService(ILogger<EmailService> logger)
    {
        _logger = logger;
        _smtpSettings = new SmtpSettings
        {
            Server = Environment.GetEnvironmentVariable("SMTP_SERVER"),
            Port = int.Parse(Environment.GetEnvironmentVariable("SMTP_PORT")),
            Username = Environment.GetEnvironmentVariable("SMTP_USERNAME"),
            Password = Environment.GetEnvironmentVariable("SMTP_PASSWORD")
        };
    }

    public async Task SendEmailAsync(string recipientEmail, string subject, string ContractorName, List<string> attachments)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("FFL- HSMS", _smtpSettings.Username)); // Use actual sender email
        message.To.Add(new MailboxAddress("Contractor", recipientEmail));
        message.Subject = subject;

        var builder = new BodyBuilder
        {
            HtmlBody = $@"
        <html>
        <body>
            <h2 style='color: #4CAF50;'>Dear {ContractorName},</h2>
            <p>Please find attached today's attendance report.</p>
            <p>If you have any questions or concerns, feel free to contact us.</p>
            <br />
            <p style='font-size: 12px; color: grey;'>This email is automatically generated. Please do not reply.</p>
            <br />
            <p style='font-size: 10px; color: grey;'>
                The information contained in or attached to this communication is intended solely for the use of the individual or entity to whom it is addressed and others authorized to receive it. It may contain confidential or legally privileged information. If you are not the intended recipient you are hereby notified that any disclosure, copying, distribution or taking any action in reliance on the contents of this information is strictly prohibited and may be unlawful. If you have received this communication in error, please notify me immediately by responding to this email and then delete it from your system. We are neither liable for the proper and complete transmission of the information contained in this communication nor for any delay in its receipt.
            </p>
        </body>
        </html>"
        };

        // Attach files
        foreach (var filePath in attachments)
        {
            builder.Attachments.Add(filePath);
        }

        message.Body = builder.ToMessageBody();

        await RetrySendEmailAsync(message, recipientEmail, ContractorName);
    }

    private async Task RetrySendEmailAsync(MimeMessage message, string recipientEmail, string ContractorName)
    {
        int retryCount = 0;
        const int maxRetries = 3;
        bool emailSent = false;

        while (retryCount < maxRetries && !emailSent)
        {
            try
            {
                using var smtp = new SmtpClient();

                _logger.LogInformation($"Connecting to SMTP server to send email to {ContractorName} ({recipientEmail})....");
                // Connect to your actual SMTP server
                await smtp.ConnectAsync(_smtpSettings.Server, _smtpSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);

                // Authenticate with your credentials
                await smtp.AuthenticateAsync(_smtpSettings.Username, _smtpSettings.Password);
                _logger.LogInformation($"Connected to SMTP server. Sending email to {ContractorName}...");

                await smtp.SendAsync(message);
                _logger.LogInformation($"Email Sent Successfully to {ContractorName} ({recipientEmail})!");

                await smtp.DisconnectAsync(true);
                emailSent = true;  // Mark email as sent successfully
            }
            catch (MailKit.Net.Smtp.SmtpCommandException ex) when (ex.StatusCode == MailKit.Net.Smtp.SmtpStatusCode.TransactionFailed ||
                                                          ex.StatusCode == MailKit.Net.Smtp.SmtpStatusCode.ServiceNotAvailable ||
                                                          ex.StatusCode == MailKit.Net.Smtp.SmtpStatusCode.InsufficientStorage)
            {
                // Throttling or transient errors: Retry with exponential backoff
                retryCount++;
                _logger.LogError($"Failed to send email to {ContractorName} ({recipientEmail}). Attempt {retryCount} of {maxRetries}. Error: {ex.Message}");
                await Task.Delay(TimeSpan.FromSeconds(Math.Pow(2, retryCount))); // Exponential backoff delay
            }

            catch (Exception ex)
            {
                // Non-transient errors: Do not retry
                _logger.LogError($"Non-transient error occurred: Failed to send email to {ContractorName} ({recipientEmail}). Error: {ex.Message}");
                break;
            }
        }

        if (!emailSent)
        {
            _logger.LogError($"Failed to send email to {ContractorName} ({recipientEmail}) after {maxRetries} attempts.");
        }
    }
}
