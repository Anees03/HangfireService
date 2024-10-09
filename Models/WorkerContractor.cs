using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerContractor
    {
        public int PworkerContractorId { get; set; }
        public int? WorkerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? ContractorId { get; set; }
    }
}
