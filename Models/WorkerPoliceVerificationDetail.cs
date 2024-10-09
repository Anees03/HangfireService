using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerPoliceVerificationDetail
    {
        public int PpoliceVerificationWorkerDetailId { get; set; }
        public int? WorkerId { get; set; }
        public DateTime? PoliceVerificationDate { get; set; }
        public DateTime? PoliceVerificationExpireDate { get; set; }
        public string? PoliceVerificationFileName { get; set; }
        public int? CityId { get; set; }
    }
}
