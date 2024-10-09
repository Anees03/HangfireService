using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class NotificationEmail
    {
        public long PemailId { get; set; }
        public string? ToAddress { get; set; }
        public string? Ccaddress { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public bool? IsSent { get; set; }
        public int? NotificationTypeId { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public DateTime? SendDateTime { get; set; }
        public int? CreatedByUserId { get; set; }
        public string? Remarks { get; set; }
    }
}
