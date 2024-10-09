using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerEobidetail
    {
        public int PworkerEobidetailId { get; set; }
        public int? WorkerId { get; set; }
        public string? Eobinumber { get; set; }
        public DateTime? Eobiexpiredate { get; set; }
        public string? EobiattachedFileName { get; set; }
        public DateTime? EobiissuanceDate { get; set; }
    }
}
