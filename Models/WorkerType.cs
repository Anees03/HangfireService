using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerType
    {
        public int PworkerTypeId { get; set; }
        public string? WorkerTypeName { get; set; }
        public bool? Status { get; set; }
    }
}
