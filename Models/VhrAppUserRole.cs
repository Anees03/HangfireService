using System;
using System.Collections.Generic;

namespace EmailServiceHangfire.Models
{
    public partial class VhrAppUserRole
    {
        public int? FeatureId { get; set; }
        public int? PuserRoleFeatureId { get; set; }
        public string? AppUserRoleName { get; set; }
        public int PappUserRoleId { get; set; }
        public bool? Mworker { get; set; }
        public bool? WorkerAdd { get; set; }
        public bool? WorkerEdit { get; set; }
        public bool? Mcontractor { get; set; }
        public bool? ContractorAdd { get; set; }
        public bool? ContractorEdit { get; set; }
        public bool? McontractorKeyPerson { get; set; }
        public bool? KeyPersonAdd { get; set; }
        public bool? KeyPersonEdit { get; set; }
        public bool? KeyPersonView { get; set; }
        public bool? MsafetyManhours { get; set; }
        public bool? SafetyManhoursEdit { get; set; }
        public bool? McontractType { get; set; }
        public bool? ContractTypeAdd { get; set; }
        public bool? ContractTypeEdit { get; set; }
        public bool? Mtrade { get; set; }
        public bool? TradeEdit { get; set; }
        public bool? MappUser { get; set; }
        public bool? MappUserRole { get; set; }
        public bool? AppUserAdd { get; set; }
        public bool? AppUserEdit { get; set; }
        public bool? AppUserRoleAdd { get; set; }
        public bool? AppUserRoleEdit { get; set; }
        public bool? Msettings { get; set; }
        public bool? Holidays { get; set; }
        public bool? Readers { get; set; }
        public bool? DownloadTimes { get; set; }
        public bool? MattendanceEditor { get; set; }
        public bool? DailyAttendance { get; set; }
        public bool? MonthlyAttendance { get; set; }
        public bool? ProcessAttendance { get; set; }
        public bool? MshiftSetting { get; set; }
        public bool? Shift { get; set; }
        public bool? ShiftChange { get; set; }
        public bool? Reports { get; set; }
        public bool? Msection { get; set; }
        public bool? SectionAdd { get; set; }
        public bool? SectionEdit { get; set; }
        public bool? MuserManagement { get; set; }
        public bool? TradeAdd { get; set; }
    }
}
