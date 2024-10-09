using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class AppUser
    {
        public int PuserId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int? WorkerId { get; set; }
        public int? UserRoleId { get; set; }
        public bool? UserStatus { get; set; }
        public string? Email { get; set; }
        public int? KeyPersonId { get; set; }
    }
}
