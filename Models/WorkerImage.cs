using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerImage
    {
        public int PworkerId { get; set; }
        public byte[]? WorkerPic { get; set; }
    }
}
