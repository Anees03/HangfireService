using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class AuditLogChild
    {
        public int PauditLogChildId { get; set; }
        public int? AuditLogParentId { get; set; }
        public string? FieldName { get; set; }
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
    }
}
