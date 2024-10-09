using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class Notification
    {
        public int PnotificationId { get; set; }
        public int? UserId { get; set; }
        public string? NotificationUrl { get; set; }
        public int? NotificationTypeId { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? PrimaryId { get; set; }
    }
}
