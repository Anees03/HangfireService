using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class Status
    {
        public int PstatusId { get; set; }
        public string? StatusName { get; set; }
    }
}
