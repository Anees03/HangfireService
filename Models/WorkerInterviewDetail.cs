using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class WorkerInterviewDetail
    {
        public int PworkerInterviewDetailId { get; set; }
        public int? WorkerId { get; set; }
        public string? InterviewBy { get; set; }
        public DateTime? InterviewDate { get; set; }
        public DateTime? IntervieExpireDate { get; set; }
        public string? InterviewFileName { get; set; }
        public int? SectionId { get; set; }
        public int? Counter { get; set; }
    }
}
