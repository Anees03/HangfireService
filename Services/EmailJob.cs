using Hangfire;

public class EmailJob
{
    private readonly AttendanceReportService _attendanceService;
    private readonly EmailService _emailService;

    public EmailJob(AttendanceReportService attendanceService, EmailService emailService)
    {
        _attendanceService = attendanceService;
        _emailService = emailService;
    }

    // Schedule the job to run every day at 12 PM, but send the report for the previous day's attendance
    //public void ScheduleDailyEmailJob()
    //{
    //    Hangfire.RecurringJob.AddOrUpdate("daily-attendance-report", () => SendAttendanceReports(), "0 12 * * *");
    //}
  
    public void ScheduleDailyEmailJob()
    {
        // This cron expression schedules the job to run every day at 12 noon (0 12 * * *)
        Hangfire.RecurringJob.AddOrUpdate("daily-attendance-report", () => SendAttendanceReports(), "0 12 * * *");
    }



    // Send attendance reports to contractors for the previous day

    public async Task SendAttendanceReports()
    {
        // var yesterday = DateTime.Today.AddDays(-1); // Get the previous day's date
        var yesterday = new DateTime(2023, 06, 03);
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

            // Generate PDF for the contractor's workers
            var pdfPath = _attendanceService.GenerateAttendancePdf(contractorName,attendanceDate, contractorGroup.ToList());

            if (!string.IsNullOrEmpty(pdfPath))
            {
                // Send the email with the PDF attachment
                await _emailService.SendEmailAsync(
                    contractorEmail,
                    "Daily Attendance Report",
                    $"Dear {contractorName}, please find attached the attendance report for {attendanceDate:yyyy-MM-dd}.",
                    new List<string> { pdfPath }
                );
            }
            else
            {
                // Log or handle PDF generation failure
                Console.WriteLine($"Failed to generate PDF for contractor {contractorName}.");
            }
        }
    }
}

