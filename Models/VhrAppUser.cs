using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class VhrAppUser
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int? WorkerId { get; set; }
        public bool? UserStatus { get; set; }
        public string? AppUserRoleName { get; set; }
        public bool? CanCreate { get; set; }
        public bool? CanEdit { get; set; }
        public bool? CanDelete { get; set; }
        public int? UserRoleId { get; set; }
        public int? KeyPersonId { get; set; }
        public string? KeyPersonName { get; set; }
        public int? ContractorId { get; set; }
        public string? SectionNames { get; set; }
        public int PuserId { get; set; }
        public string? SectionName { get; set; }
        public int? SectionId { get; set; }
    }
}
