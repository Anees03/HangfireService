using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class HsmsContractor
    {
        public int PcontractorId { get; set; }
        public string? ContractorName { get; set; }
        public string? Ntnnumber { get; set; }
        public string? EmailAddress { get; set; }
        public bool? Status { get; set; }
        public string? Remarks { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? PhoneNo2 { get; set; }
        public string? PhoneNo3 { get; set; }
        public string? Gstno { get; set; }
        public int? ProvinceId { get; set; }
        public string? SalesTaxNumber { get; set; }
        public string? Pecnumber { get; set; }
        public int? PeccategoryId { get; set; }
        public string? Pepranumber { get; set; }
        public int? FflcontractorCategoryId { get; set; }
        public int? CompanyTypeId { get; set; }
        public string? ProvinceName { get; set; }
        public string? FflcontractorCategoryName { get; set; }
        public string? PeccategoryName { get; set; }
        public string? CompanyTypeName { get; set; }
        public int? Expr1 { get; set; }
    }
}
