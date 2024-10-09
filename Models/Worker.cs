using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class Worker
    {
        public Worker()
        {
            DailyAttendances = new HashSet<DailyAttendance>();
        }

        public int PworkerId { get; set; }
        public string? WorkerName { get; set; }
        public string? FatherName { get; set; }
        public string? Cnic { get; set; }
        public DateTime? CnicexpireDate { get; set; }
        public int? BloodGroupId { get; set; }
        public string? PhoneNo { get; set; }
        public int? WorkerTypeId { get; set; }
        public int? TradeId { get; set; }
        public int? StatusId { get; set; }
        public string? StatusRemarks { get; set; }
        public DateTime? WorkerValidDate { get; set; }
        public string? Address { get; set; }
        public short? ShiftId { get; set; }
        public DateTime? Doj { get; set; }
        public DateTime? ResignDate { get; set; }
        public string? Rate { get; set; }
        public int? ReligionId { get; set; }
        public int? GenderId { get; set; }
        public DateTime? StatusDate { get; set; }
        public string? RfidcardNo { get; set; }
        public string? CnicfileName { get; set; }
        public int? SectId { get; set; }
        public int? GradeId { get; set; }
        public double? Tarate { get; set; }
        public double? NormalRate { get; set; }
        public double? Ottarate { get; set; }
        public double? OtnormalRate { get; set; }
        public string? PhoneNo2 { get; set; }
        public string? PhoneNo3 { get; set; }
        public int? ContractorId { get; set; }
        public string? Jonumber { get; set; }
        public int? CreatedBy { get; set; }
        public int? Hcid { get; set; }

        public virtual Shift? Shift { get; set; }
        public virtual ICollection<DailyAttendance> DailyAttendances { get; set; }
    }
}
