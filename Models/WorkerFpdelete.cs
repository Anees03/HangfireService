using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerFpdelete
    {
        public long WorkerFpdeleteId { get; set; }
        public int? WorkerId { get; set; }
        public DateTime? DeletedDt { get; set; }
        public string? DeleatedReson { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int? ReaderId { get; set; }
        public bool? IsCompleted { get; set; }
        public string? ServiceMessage { get; set; }
        public int? Attempts { get; set; }
    }
}
