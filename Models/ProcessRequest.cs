using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class ProcessRequest
    {
        public int PattProcesserSchedulerId { get; set; }
        public string PeriodTag { get; set; } = null!;
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public short CatId { get; set; }
        public bool? ProcessingDone { get; set; }
        public string? Criteria { get; set; }
        public bool? ProcessCat { get; set; }
        public int? UserId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? SystemGenerated { get; set; }
        public string? Remarks { get; set; }
    }
}
