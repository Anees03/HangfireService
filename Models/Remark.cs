using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class Remark
    {
        public byte PremarkId { get; set; }
        public string? RemarksName { get; set; }
        public string? RemarkValue { get; set; }
        public bool? Enable { get; set; }
    }
}
