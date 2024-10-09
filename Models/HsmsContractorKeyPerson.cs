using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class HsmsContractorKeyPerson
    {
        public int PcontractorKeyPersonId { get; set; }
        public int? KeyPersonFpid { get; set; }
        public string? KeyPersonCardNo { get; set; }
        public string? Cnic { get; set; }
        public string? EmailAddress { get; set; }
        public string? Address { get; set; }
        public string? KeyPersonName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Remarks { get; set; }
        public string? ContractorName { get; set; }
        public string? Ntnnumber { get; set; }
        public string? PhoneNo3 { get; set; }
        public string? PhoneNo2 { get; set; }
        public bool? SecuritySupervisor { get; set; }
        public bool? IsUpdated { get; set; }
        public string? Gstno { get; set; }
        public string? Pecnumber { get; set; }
        public string? SalesTaxNumber { get; set; }
        public string? HseattachedFileName { get; set; }
        public string? SafetyOrientationApprover { get; set; }
        public DateTime? SafetyOrientationExpireDate { get; set; }
        public DateTime? SafetyOrientationDate { get; set; }
        public int? ContractorId { get; set; }
        public string? StatusName { get; set; }
        public int? StatusId { get; set; }
        public string? ProfileName { get; set; }
        public int? ProfileId { get; set; }
        public bool? IsMasterSecurityUser { get; set; }
    }
}
