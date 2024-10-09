using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerMobileAuthorizationDetail
    {
        public int PworkerMobileAuthorizationId { get; set; }
        public int? WorkerId { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? MobileNo1 { get; set; }
        public string? MobileNo2 { get; set; }
        public string? MobileNo3 { get; set; }
    }
}
