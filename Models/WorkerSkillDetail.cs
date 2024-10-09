using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerSkillDetail
    {
        public int PworkerSkillId { get; set; }
        public int? WorkerId { get; set; }
        public string? SkillApprovedBy { get; set; }
        public DateTime? SkillApprovedDate { get; set; }
        public DateTime? SkillExpireDate { get; set; }
    }
}
