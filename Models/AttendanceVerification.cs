using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class AttendanceVerification
    {
        public int PattendanceVerificationId { get; set; }
        public string? WorkerDate { get; set; }
        public int? SubmittedBy { get; set; }
        public int? SubmittedTo { get; set; }
        public DateTime? SubmittedDate { get; set; }
        public int? AttendanceStatus { get; set; }
        public string? Comment { get; set; }
        public int? SectionId { get; set; }
        public int? VerifiedByUserId { get; set; }
    }
}
