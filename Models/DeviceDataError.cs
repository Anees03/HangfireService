using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class DeviceDataError
    {
        public int PdeviceDataErrorId { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? EntryTime { get; set; }
        public DateTime? AddedDate { get; set; }
        public short? ReaderId { get; set; }
        public byte? RdrDutyCode { get; set; }
        public int? DeviceRegId { get; set; }
        public int? ModeOfEntry { get; set; }
    }
}
