using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class ContractorKeyPerson
    {
        public int PcontractorKeyPersonId { get; set; }
        public int? KeyPersonFpid { get; set; }
        public string? KeyPersonCardNo { get; set; }
        public string? Cnic { get; set; }
        public string? EmailAddress { get; set; }
        public string? Address { get; set; }
        public int? ContractorId { get; set; }
        public string? Remarks { get; set; }
        public int? StatusId { get; set; }
        public string? PhoneNumber { get; set; }
        public string? KeyPersonName { get; set; }
        public bool? IsUpdated { get; set; }
        public bool? SecuritySupervisor { get; set; }
        public string? PhoneNo2 { get; set; }
        public string? PhoneNo3 { get; set; }
        public int? ProfileId { get; set; }
        public bool? IsMasterSecurityUser { get; set; }
    }
}
