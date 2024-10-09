using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class ContractorKeyPersonHse
    {
        public int PhsekeyPersonDetailId { get; set; }
        public DateTime? SafetyOrientationDate { get; set; }
        public DateTime? SafetyOrientationExpireDate { get; set; }
        public string? SafetyOrientationApprover { get; set; }
        public int? ContractorKeyPersonId { get; set; }
        public string? HseattachedFileName { get; set; }
    }
}
