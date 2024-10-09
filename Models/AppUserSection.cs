using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class AppUserSection
    {
        public int PuserSectionId { get; set; }
        public int? UserId { get; set; }
        public int? SectionId { get; set; }
    }
}
