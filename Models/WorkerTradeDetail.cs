using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerTradeDetail
    {
        public int? PworkerTradeDetailId { get; set; }
        public int? WorkerId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TradeId { get; set; }
        public double? NormalRate { get; set; }
        public double? Tarate { get; set; }
        public double? NormalOtrate { get; set; }
        public double? Taotrate { get; set; }
    }
}
