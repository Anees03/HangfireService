using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class Ppeitem
    {
        public int PppeitemId { get; set; }
        public string? PpeitemName { get; set; }
        public double? ExpiryDuration { get; set; }
    }
}
