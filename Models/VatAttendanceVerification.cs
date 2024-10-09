using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class VatAttendanceVerification
    {
        public string? VerificationStatusName { get; set; }
        public DateTime? AttDate { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public short? WorkMin { get; set; }
        public string? SubmittedByUserName { get; set; }
        public string? SectionName { get; set; }
        public string? SubmmitedToUserName { get; set; }
        public int? PsectionId { get; set; }
        public string? WorkerName { get; set; }
        public string? TradeName { get; set; }
        public string? Cnic { get; set; }
        public int PattendanceVerificationId { get; set; }
        public int? SubmittedBy { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public int? AttendanceStatus { get; set; }
        public string? Comment { get; set; }
        public int? SectionId { get; set; }
        public int? SubmittedTo { get; set; }
        public string? WorkerDate { get; set; }
        public int? WorkerId { get; set; }
        public TimeSpan? DutyTime { get; set; }
        public string? ContractorName { get; set; }
        public string? WorkerTypeName { get; set; }
        public string? Remarks { get; set; }
        public double? Pdays { get; set; }
        public int? ContractorId { get; set; }
        public string? DutyCode { get; set; }
        public short? ShifMin { get; set; }
        public int? TradeId { get; set; }
        public double? Tarate { get; set; }
        public int? VerifiedByUserId { get; set; }
        public string? VerifiedByUserName { get; set; }
    }
}
