using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerFpdetail
    {
        public int WorkerId { get; set; }
        public string? Fp1 { get; set; }
        public string? Fp2 { get; set; }
        public string? Fp3 { get; set; }
        public string? Fp4 { get; set; }
        public string? Fp5 { get; set; }
        public DateTime? FpupdatedDt { get; set; }
        public string? WorkerName { get; set; }
        public string? Cnic { get; set; }
        public string? WorkerTypeName { get; set; }
        public string? StatusName { get; set; }
        public string? SectName { get; set; }
        public string? GradeName { get; set; }
        public string? PhoneNo2 { get; set; }
        public string? PhoneNo3 { get; set; }
        public DateTime? WorkerValidDate { get; set; }
        public DateTime? Doj { get; set; }
        public DateTime? ResignDate { get; set; }
        public string? PhoneNo { get; set; }
        public DateTime? CnicexpireDate { get; set; }
    }
}
