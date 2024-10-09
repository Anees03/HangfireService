using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class VhrWorkerContractor
    {
        public string? ContractorName { get; set; }
        public int? WorkerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int PworkerContractorId { get; set; }
        public string? WorkerName { get; set; }
    }
}
