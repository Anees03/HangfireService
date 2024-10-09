using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class Feature
    {
        public int PfeatureId { get; set; }
        public string? Name { get; set; }
        public string? Actionlink { get; set; }
        public bool? IsMenu { get; set; }
        public int? OrderId { get; set; }
    }
}
