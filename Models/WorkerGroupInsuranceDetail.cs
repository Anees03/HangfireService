using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerGroupInsuranceDetail
    {
        public int PworkerGroupInsuranceDetailId { get; set; }
        public int? WorkerId { get; set; }
        public string? GroupInsuranceNumber { get; set; }
        public DateTime? GiexpireDate { get; set; }
        public string? GiattachedFileName { get; set; }
    }
}
