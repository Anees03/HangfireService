using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class Reader
    {
        public short PreaderId { get; set; }
        public string ReaderName { get; set; } = null!;
        public byte ReaderDutyCodeId { get; set; }
        public string IpAdd { get; set; } = null!;
        public short IpPort { get; set; }
        public byte RdrTypeId { get; set; }
        public bool Status { get; set; }
        public bool ClearRecords { get; set; }

        public virtual ReaderType RdrType { get; set; } = null!;
    }
}
