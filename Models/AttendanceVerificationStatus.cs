using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class AttendanceVerificationStatus
    {
        public int PattendanceVerificationStatusId { get; set; }
        public string? VerificationStatusName { get; set; }
    }
}
