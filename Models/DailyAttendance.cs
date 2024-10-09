using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class DailyAttendance
    {
        public string WorkerDate { get; set; } = null!;
        public DateTime? AttDate { get; set; }
        public int? ContractorId { get; set; }
        public int? WorkerId { get; set; }
        public string? DutyCode { get; set; }
        public TimeSpan? DutyTime { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public short? WorkMin { get; set; }
        public double? Pdays { get; set; }
        public double? AbDays { get; set; }
        public double? LeaveDays { get; set; }
        public short? LateIn { get; set; }
        public short? LateOut { get; set; }
        public short? EarlyIn { get; set; }
        public short? EarlyOut { get; set; }
        public short? Otmin { get; set; }
        public short? Gzotmin { get; set; }
        public short? BreakMin { get; set; }
        public bool? StatusP { get; set; }
        public bool? StatusAb { get; set; }
        public bool? StatusLi { get; set; }
        public bool? StatusLo { get; set; }
        public bool? StatusEi { get; set; }
        public bool? StatusEo { get; set; }
        public bool? StatusOt { get; set; }
        public bool? StatusGzot { get; set; }
        public bool? StatusGz { get; set; }
        public bool? StatusDo { get; set; }
        public bool? StatusLeave { get; set; }
        public bool? StatusMn { get; set; }
        public bool? StatusBreak { get; set; }
        public short? ShifMin { get; set; }
        public short? BreakMins { get; set; }
        public string? Remarks { get; set; }
        public DateTime? Tin0 { get; set; }
        public DateTime? Tout0 { get; set; }
        public DateTime? Tin1 { get; set; }
        public DateTime? Tout1 { get; set; }
        public DateTime? Tin2 { get; set; }
        public DateTime? Tout2 { get; set; }
        public DateTime? Tin3 { get; set; }
        public DateTime? Tout3 { get; set; }
        public DateTime? Tin4 { get; set; }
        public DateTime? Tout4 { get; set; }
        public DateTime? Tin5 { get; set; }
        public DateTime? Tout5 { get; set; }
        public DateTime? Tin6 { get; set; }
        public DateTime? Tout6 { get; set; }
        public DateTime? Tin7 { get; set; }
        public DateTime? Tout7 { get; set; }
        public DateTime? Tin8 { get; set; }
        public DateTime? Tout8 { get; set; }
        public DateTime? Tin9 { get; set; }
        public DateTime? Tout9 { get; set; }
        public DateTime? Tin10 { get; set; }
        public DateTime? Tout10 { get; set; }
        public DateTime? Tin11 { get; set; }
        public DateTime? Tout11 { get; set; }
        public DateTime? Tin12 { get; set; }
        public DateTime? Tout12 { get; set; }
        public DateTime? Tin13 { get; set; }
        public DateTime? Tout13 { get; set; }
        public DateTime? Tin14 { get; set; }
        public DateTime? Tout14 { get; set; }
        public DateTime? Tin15 { get; set; }
        public DateTime? Tout15 { get; set; }
        public bool? StatusIn { get; set; }
        public int? AttendanceVerificationStatus { get; set; }

        public virtual Worker? Worker { get; set; }
    }
}
