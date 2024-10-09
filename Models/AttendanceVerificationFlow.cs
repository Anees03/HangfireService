using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class AttendanceVerificationFlow
    {
        public int PattendanceVerificationFlowId { get; set; }
        public int? AttendanceVerificationId { get; set; }
        public int? SubmittedBy { get; set; }
        public int? SubmittedTo { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public string? Comment { get; set; }
        public int? AtVerificationStatus { get; set; }
    }
}
