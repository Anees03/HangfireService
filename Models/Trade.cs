using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class Trade
    {
        public int PtradeId { get; set; }
        public string? TradeName { get; set; }
        public double? NormalRate { get; set; }
        public double? Tarate { get; set; }
        public double? NormalOtrate { get; set; }
        public double? Taotrate { get; set; }
        public bool? ValidateSkill { get; set; }
        public bool? DrivingLicense { get; set; }
    }
}
