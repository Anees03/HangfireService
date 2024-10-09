using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerSocialSecurityDetail
    {
        public int PworkerSocialSecurityDetailId { get; set; }
        public int? WorkerId { get; set; }
        public string? SocialSecurityNumber { get; set; }
        public DateTime? SsexpireDate { get; set; }
        public string? SsattachedFileName { get; set; }
    }
}
