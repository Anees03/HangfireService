using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class AuditLogParent
    {
        public int PauditLogParentId { get; set; }
        public int? ControllerName { get; set; }
        public int? ActionName { get; set; }
        public DateTime? EditDateTime { get; set; }
        public int? EditByUserId { get; set; }
        public string? EditUserComputerIp { get; set; }
        public string? EditUserComputerMac { get; set; }
        public string? PrimaryKey { get; set; }
    }
}
