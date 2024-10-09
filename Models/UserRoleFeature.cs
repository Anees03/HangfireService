using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class UserRoleFeature
    {
        public int PuserRoleFeatureId { get; set; }
        public int? UserRoleId { get; set; }
        public int? FeatureId { get; set; }
    }
}
