using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class MedicalWorkerDetail
    {
        public int PmedicalWorkerDetailId { get; set; }
        public int? WorkerId { get; set; }
        public DateTime? MedicalFitnessExpireDate { get; set; }
        public string? MedicalFitnessFileName { get; set; }
        public string? MedicalFitnessApprovedBy { get; set; }
    }
}
