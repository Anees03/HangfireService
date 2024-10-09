using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class DeviceDatum
    {
        public long PdeviceDataId { get; set; }
        public int WorkerId { get; set; }
        public string Fpiddate { get; set; } = null!;
        public int? Fpid { get; set; }
        public int? ContractorKeyPersonId { get; set; }
        public string? CardNo { get; set; }
        public DateTime EntDate { get; set; }
        public DateTime EntTime { get; set; }
        public short ReaderId { get; set; }
        public byte? ReaderDutyId { get; set; }
        public bool? Process { get; set; }
        public DateTime? AddedDate { get; set; }
        public int? ModeOfEntry { get; set; }
        public bool? IsMasterSecurityUser { get; set; }
    }
}
