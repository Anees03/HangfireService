using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class DownloadTime
    {
        public byte PdownloadTimeId { get; set; }
        public TimeSpan? DownTime { get; set; }
    }
}
