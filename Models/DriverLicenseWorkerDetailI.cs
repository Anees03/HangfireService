using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class DriverLicenseWorkerDetailI
    {
        public int PdriverLicenseWorkerDetailId { get; set; }
        public int? WorkerId { get; set; }
        public string? DriverLicenseNumber { get; set; }
        public DateTime? DriverLicenseExpireDate { get; set; }
        public int? DriverLicenseIssuerId { get; set; }
        public int? DriverLicenseCategoryId { get; set; }
        public string? DriverLicenseFileName { get; set; }
        public string? ValidatedBy { get; set; }
        public DateTime? ValidatedDate { get; set; }
    }
}
