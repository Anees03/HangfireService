using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class Gender
    {
        public int PgenderId { get; set; }
        public string? GenderName { get; set; }
    }
}
