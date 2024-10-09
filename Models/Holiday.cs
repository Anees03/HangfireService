using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class Holiday
    {
        public short HolidayId { get; set; }
        public DateTime HolidayDate { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
