using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerTypeOption
    {
        public int PworkerTypeOptionsId { get; set; }
        public int? WorkerTypeId { get; set; }
        public int? FeatureId { get; set; }
    }
}
