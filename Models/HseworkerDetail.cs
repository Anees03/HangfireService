using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class HseworkerDetail
    {
        public int PhseworkerDetailId { get; set; }
        public DateTime? SafetyOrientationDate { get; set; }
        public DateTime? SafetyOrientationExpireDate { get; set; }
        public string? SafetyOrientationApprover { get; set; }
        public int? WorkerId { get; set; }
        public string? HseattachedFileName { get; set; }
    }
}
