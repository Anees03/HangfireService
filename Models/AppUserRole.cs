using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class AppUserRole
    {
        public int PappUserRoleId { get; set; }
        public string? AppUserRoleName { get; set; }
        public bool? CanCreate { get; set; }
        public bool? CanEdit { get; set; }
        public bool? CanDelete { get; set; }
    }
}
