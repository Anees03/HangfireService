using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class AttachmentParent
    {
        public int PattachmentParentId { get; set; }
        public int? WorkerId { get; set; }
        public int? FileTypeId { get; set; }
        public string? FileExtension { get; set; }
        public DateTime? UploadedDate { get; set; }
    }
}
