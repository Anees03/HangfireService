using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class ServiceLog
    {
        public int PserviceLogId { get; set; }
        public byte ErrorCode { get; set; }
        public string Description { get; set; } = null!;
        public DateTime DateTime { get; set; }
        public short ReaderId { get; set; }
        public bool? Processed { get; set; }
    }
}
