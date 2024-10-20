using Hangfire;

public class EmailJob
{
    private readonly AttendanceReportService _attendanceService;
    private readonly EmailService _emailService;
    private readonly ILogger<EmailJob> _logger;

    public EmailJob(AttendanceReportService attendanceService, EmailService emailService, ILogger<EmailJob> logger)
    {
        _attendanceService = attendanceService;
        _emailService = emailService;
        _logger = logger;
    }

    // Schedule the job to run every day at 9 AM
    public void ScheduleDailyEmailJob()
    {
        Hangfire.RecurringJob.AddOrUpdate("daily-attendance-report",
            () => SendAttendanceReports(),
            "0 9 * * *");  // Hangfire CRON expression for 9 AM daily
    }

    // Send attendance reports to contractors for the previous day
    public async Task SendAttendanceReports()
    {
        var yesterday = DateTime.Today.AddDays(-1); // Get the previous day's date

        // Get attendance data for yesterday
        var attendanceData = _attendanceService.GetAttendanceDataFromDatabase(yesterday);

        // Group attendance data by contractor email and attendance date
        var groupedByContractor = attendanceData
            .GroupBy(a => new { a.ContractorEmail, a.AttendanceDate, a.ContractorName });

        foreach (var contractorGroup in groupedByContractor)
        {
            var contractorEmail = contractorGroup.Key.ContractorEmail;
            var contractorName = contractorGroup.Key.ContractorName;
            var attendanceDate = contractorGroup.Key.AttendanceDate;

            var excelPath = _attendanceService.GenerateAttendanceExcel(contractorName, attendanceDate, contractorGroup.ToList());

            if (!string.IsNullOrEmpty(excelPath))
            {
                // Retry Logic: Using Exponential Backoff for retrying email sending
                int retryCount = 0;
                int maxRetries = 5;
                bool isEmailSent = false;
                TimeSpan delay = TimeSpan.FromSeconds(10);  // Initial delay of 10 seconds

                while (!isEmailSent && retryCount < maxRetries)
                {
                    try
                    {
                        await _emailService.SendEmailAsync(contractorEmail, "Daily Attendance Report", contractorName, new List<string> { excelPath });
                        _logger.LogInformation($"Email successfully sent to {contractorName} ({contractorEmail})");
                        isEmailSent = true; // Set flag to exit loop
                    }
                    catch (Exception ex)
                    {
                        retryCount++;
                        _logger.LogError($"Error sending email to {contractorEmail}. Attempt {retryCount} of {maxRetries}. Error: {ex.Message}");

                        if (retryCount < maxRetries)
                        {
                            await Task.Delay(delay);
                            // Double the delay for exponential backoff
                            delay = delay * 2;  // 10s, 20s, 40s, etc.
                        }
                        else
                        {
                            _logger.LogError($"Failed to send email to {contractorEmail} after {maxRetries} attempts.");
                        }
                    }
                }
            }
            else
            {
                _logger.LogError($"Failed to generate Excel for contractor {contractorName}.");
            }
        }
    }
}
