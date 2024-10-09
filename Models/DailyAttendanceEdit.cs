using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class DailyAttendanceEdit
    {
        public int PdailyAttendanceEditId { get; set; }
        public int? WorkerId { get; set; }
        public DateTime? EditDateTime { get; set; }
        public DateTime? OldTimeIn { get; set; }
        public DateTime? OldTimeOut { get; set; }
        public DateTime? NewTimeIn { get; set; }
        public DateTime? NewTimeOut { get; set; }
        public int? NewOtmin { get; set; }
        public string? WorkerDate { get; set; }
        public bool? Process { get; set; }
        public string? OldDutyCode { get; set; }
        public TimeSpan? OldDutyTime { get; set; }
        public string? NewDutyCode { get; set; }
        public TimeSpan? NewDutyTime { get; set; }
        public int? UserId { get; set; }
        public short? CompanyId { get; set; }
        public string? OldRemarks { get; set; }
        public int? OldOtmin { get; set; }
        public string? NewRemarks { get; set; }
        public short? OldShiftMin { get; set; }
        public short? NewShiftMin { get; set; }
        public DateTime? NewTin1 { get; set; }
        public DateTime? NewTout1 { get; set; }
        public DateTime? NewTin2 { get; set; }
        public DateTime? NewTout2 { get; set; }
        public DateTime? NewTin3 { get; set; }
        public DateTime? NewTout3 { get; set; }
    }
}
