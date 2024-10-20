using ClosedXML.Excel;
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
                join t in _context.Trades on w.TradeId equals t.PtradeId
                join ct in _context.WorkerTypes on w.WorkerTypeId equals ct.PworkerTypeId// Join with Trade table
                where da.AttDate == date && da.Pdays == 1  // Only get workers who are present
                
                select new WorkerAttendance
                {
                    WorkerID = da.WorkerId,
                    AttendanceDate = da.AttDate,
                    TimeIn = da.TimeIn,
                    TimeOut = da.TimeOut,
                    WorkMin = da.WorkMin,
                    ContractorEmail = c.EmailAddress,
                    ContractorName = c.ContractorName,
                    WorkerName = w.WorkerName,
                    CNIC = w.Cnic,// Assuming WorkerName is in the Workers table
                    TradeName = t.TradeName,    // Get TradeName from the Trades table
                    WorkerTypeName = ct.WorkerTypeName
                }).ToList();
    }




    public string GenerateAttendanceExcel(string contractorName, DateTime? attendanceDate, List<WorkerAttendance> attendanceRecords)
    {
        try
        {
            _logger.LogInformation($"Generating Excel for contractor {contractorName}...");

            string fileName = $"Attendance_{contractorName}_{attendanceDate:yyyyMMdd}.xlsx";
            string filePath = Path.Combine(AppContext.BaseDirectory, "GeneratedExcels", fileName);
            Directory.CreateDirectory(Path.Combine(AppContext.BaseDirectory, "GeneratedExcels"));

            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Attendance");

                worksheet.Cell(1, 1).Value = "Worker ID";
                worksheet.Cell(1, 2).Value = "Worker Name";
                worksheet.Cell(1, 3).Value = "Trade Name";
                worksheet.Cell(1, 4).Value = "Attendance Date";
                worksheet.Cell(1, 5).Value = "Time In";
                worksheet.Cell(1, 6).Value = "Time Out";
                worksheet.Cell(1, 7).Value = "WorkHours";
                worksheet.Cell(1, 8).Value = "CNIC";
                worksheet.Cell(1, 9).Value = "Contract Type";

                var headerRange = worksheet.Range("A1:I1");
                headerRange.Style.Font.Bold = true;
                headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;

                int currentRow = 2;
                foreach (var record in attendanceRecords)
                {
                    worksheet.Cell(currentRow, 1).Value = record.WorkerID.ToString();
                    worksheet.Cell(currentRow, 2).Value = record.WorkerName;
                    worksheet.Cell(currentRow, 3).Value = record.TradeName;
                    worksheet.Cell(currentRow, 4).Value = record.AttendanceDate.HasValue ? record.AttendanceDate.Value.ToString("yyyy-MM-dd") : "";
                    worksheet.Cell(currentRow, 5).Value = record.TimeIn.HasValue ? record.TimeIn.Value.ToString(@"hh\:mm") : "";
                    worksheet.Cell(currentRow, 6).Value = record.TimeOut.HasValue ? record.TimeOut.Value.ToString(@"hh\:mm") : "";

                    if (record.WorkMin.HasValue && record.WorkMin > 0)
                    {
                        int hours = record.WorkMin.Value / 60;
                        int minutes = record.WorkMin.Value % 60;
                        worksheet.Cell(currentRow, 7).Value = $"{hours:D2}:{minutes:D2}";
                    }
                    else
                    {
                        worksheet.Cell(currentRow, 7).Value = "";
                    }

                    worksheet.Cell(currentRow, 8).Value = record.CNIC;
                    worksheet.Cell(currentRow, 9).Value = record.WorkerTypeName;
                    currentRow++;
                }

                worksheet.Columns().AdjustToContents();
                workbook.SaveAs(filePath);
            }

            _logger.LogInformation($"Excel successfully generated at: {filePath}");
            return filePath;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error generating Excel for {contractorName}: {ex.Message}");
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
    public string? CNIC { get; set; }
    public short? WorkMin { get; set; }
    public string? WorkerName { get; set; }         // New property
    public string? TradeName { get; set; }
    public string? WorkerTypeName { get; set; }
    // New property
}
