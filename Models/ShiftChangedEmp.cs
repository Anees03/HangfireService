using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class ShiftChangedEmp
    {
        public int PworkerShiftChangeId { get; set; }
        public int? WorkerId { get; set; }
        public short? ShiftId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
