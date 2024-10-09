using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerFpupload
    {
        public long WorkerFpuploadId { get; set; }
        public string? WorkerId { get; set; }
        public string? WorkerName { get; set; }
        public DateTime? UploadedDt { get; set; }
        public int? RfidcardNo { get; set; }
        public bool? IsRfid { get; set; }
        public DateTime? CreatedDt { get; set; }
        public int? ReaderId { get; set; }
        public bool? IsCompleted { get; set; }
        public string? ServiceMessage { get; set; }
        public int? Attempts { get; set; }
    }
}
