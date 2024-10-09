using EmailServiceHangfire.Models;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.IO;

public class AttendanceReportService
{
    private readonly HSMSContext _context;
    private readonly ILogger<AttendanceReportService> _logger;

    public AttendanceReportService(HSMSContext context, ILogger<AttendanceReportService> logger)
    {
        _context = context;
        _logger = logger;
    }

    // This method fetches attendance data from the DailyAttendance and Contractor tables
    public List<WorkerAttendance> GetAttendanceDataFromDatabase(DateTime? date)
    {
        return (from da in _context.DailyAttendances
                join c in _context.Contractors on da.ContractorId equals c.PcontractorId
                join w in _context.Workers on da.WorkerId equals w.PworkerId
                join t in _context.Trades on w.TradeId equals t.PtradeId  // Join with Trade table
                where da.AttDate == new DateTime(2023, 06, 03)  // Modify the date for testing
                where da.Pdays == 1  // Only get workers who are present
                select new WorkerAttendance
                {
                    WorkerID = da.WorkerId,
                    AttendanceDate = da.AttDate,
                    TimeIn = da.TimeIn,
                    TimeOut = da.TimeOut,
                    ContractorEmail = c.EmailAddress,
                    ContractorName = c.ContractorName,
                    WorkerName = w.WorkerName,  // Assuming WorkerName is in the Workers table
                    TradeName = t.TradeName     // Get TradeName from the Trades table
                }).ToList();
    }



    public string GenerateAttendancePdf(string contractorName, DateTime? attendanceDate, List<WorkerAttendance> attendanceRecords)
    {
        try
        {
            _logger.LogInformation($"Generating PDF for contractor {contractorName}...");

            // Define the file name including the attendance date
            string fileName = $"Attendance_{contractorName}_{attendanceDate:yyyyMMdd}.pdf";
            string baseDirectory = AppContext.BaseDirectory;
            string filePath = Path.Combine(baseDirectory, "GeneratedPdfs", fileName);
            Directory.CreateDirectory(Path.Combine(baseDirectory, "GeneratedPdfs")); // Ensure the directory exists

            using (PdfWriter writer = new PdfWriter(filePath))
            {
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                // Add title and header
                document.Add(new Paragraph($"Attendance Report for {contractorName}")
                    .SetFontSize(18)
                    .SetBold());
                document.Add(new Paragraph($"Date: {attendanceDate:yyyy-MM-dd}").SetFontSize(12));
                document.Add(new Paragraph(" "));

                // Create a table with headers for Worker Attendance and set the width for each column
                float[] columnWidths = { 1, 2, 2, 2, 1.5f, 1.5f }; // Adjust the widths according to your content
                Table table = new Table(UnitValue.CreatePercentArray(columnWidths));
                table.SetWidth(UnitValue.CreatePercentValue(100)); // Set table width to 100%

                // Add headers
                table.AddHeaderCell(new Cell().Add(new Paragraph("Worker ID").SetBold()));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Worker Name").SetBold()));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Trade Name").SetBold()));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Attendance Date").SetBold()));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Time In").SetBold()));
                table.AddHeaderCell(new Cell().Add(new Paragraph("Time Out").SetBold()));

                // Add data rows
                foreach (var record in attendanceRecords)
                {
                    table.AddCell(record.WorkerID.ToString());
                    table.AddCell(record.WorkerName);
                    table.AddCell(record.TradeName);

                    table.AddCell(record.AttendanceDate.HasValue
                        ? record.AttendanceDate.Value.ToString("yyyy-MM-dd")
                        : "");

                    table.AddCell(record.TimeIn.HasValue
                        ? record.TimeIn.Value.ToString("hh\\:mm")
                        : "");

                    table.AddCell(record.TimeOut.HasValue
                        ? record.TimeOut.Value.ToString("hh\\:mm")
                        : "");
                }

                document.Add(table);
                document.Close(); // Finalize the document
            }

            return filePath; // Return the file path of the generated PDF
        }
        catch (Exception ex)
        {
            // Log the error or handle it as necessary
            _logger.LogError($"Error generating PDF for {contractorName}: {ex.Message}");
            return null;
        }
    }

}
public class WorkerAttendance
{
    public int? WorkerID { get; set; }
    public DateTime? AttendanceDate { get; set; }  // Make this nullable
    public DateTime? TimeIn { get; set; }          // Nullable TimeSpan
    public DateTime? TimeOut { get; set; }         // Nullable TimeSpan
    public string? ContractorEmail { get; set; }
    public string? ContractorName { get; set; }
    public string? WorkerName { get; set; }         // New property
    public string? TradeName { get; set; }          // New property
}
