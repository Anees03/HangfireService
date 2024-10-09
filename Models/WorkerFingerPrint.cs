using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerFingerPrint
    {
        public int WorkerId { get; set; }
        public string? Fp1 { get; set; }
        public string? Fp2 { get; set; }
        public string? Fp3 { get; set; }
        public string? Fp4 { get; set; }
        public string? Fp5 { get; set; }
        public DateTime? FpupdatedDt { get; set; }
    }
}
