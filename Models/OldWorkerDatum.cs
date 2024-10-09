using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class OldWorkerDatum
    {
        public int PoldWorkerDataId { get; set; }
        public int? WorkerId { get; set; }
        public int WorkerTypeId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public DateTime? WorkerValidDate { get; set; }
    }
}
