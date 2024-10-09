using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class SafetyManHour
    {
        public int PsafetyManHourId { get; set; }
        public int? TotalHours { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ClosedBy { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string? Remarks { get; set; }
        public DateTime? StartDate { get; set; }
    }
}
