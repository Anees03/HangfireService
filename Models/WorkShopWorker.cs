using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkShopWorker
    {
        public int PworkShopWorkerId { get; set; }
        public int? WorkerId { get; set; }
        public DateTime? WelderCertificateExpireDate { get; set; }
        public DateTime? WelderCertificateIssueDate { get; set; }
        public string? WelderCertificateFileName { get; set; }
        public string? WelderCertificateIssuer { get; set; }
        public string? WelderCertificateApprover { get; set; }
        public int? SectionId { get; set; }
    }
}
