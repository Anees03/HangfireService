using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerPpedetail
    {
        public int Pppeid { get; set; }
        public int? WorkerId { get; set; }
        public int? PpeitemId { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? PpefileName { get; set; }
    }
}
