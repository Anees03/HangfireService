using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class VatServiceLog
    {
        public short PreaderId { get; set; }
        public short IpPort { get; set; }
        public string IpAdd { get; set; } = null!;
        public string ReaderName { get; set; } = null!;
        public byte ReaderDutyCodeId { get; set; }
        public string? ReaderType { get; set; }
        public string ReaderTypeName { get; set; } = null!;
        public string? DutyName { get; set; }
        public bool Status { get; set; }
        public int PserviceLogId { get; set; }
        public byte ErrorCode { get; set; }
        public string Description { get; set; } = null!;
        public DateTime DateTime { get; set; }
        public bool? Processed { get; set; }
    }
}
