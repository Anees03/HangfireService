using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmailServiceHangfire.Models
{
    public partial class HSMSContext : DbContext
    {
        public HSMSContext()
        {
        }

        public HSMSContext(DbContextOptions<HSMSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AppUser> AppUsers { get; set; } = null!;
        public virtual DbSet<AppUserMenu> AppUserMenus { get; set; } = null!;
        public virtual DbSet<AppUserRole> AppUserRoles { get; set; } = null!;
        public virtual DbSet<AppUserSection> AppUserSections { get; set; } = null!;
        public virtual DbSet<AttachmentParent> AttachmentParents { get; set; } = null!;
        public virtual DbSet<AttendanceVerification> AttendanceVerifications { get; set; } = null!;
        public virtual DbSet<AttendanceVerificationFlow> AttendanceVerificationFlows { get; set; } = null!;
        public virtual DbSet<AttendanceVerificationStatus> AttendanceVerificationStatuses { get; set; } = null!;
        public virtual DbSet<AuditLogChild> AuditLogChildren { get; set; } = null!;
        public virtual DbSet<AuditLogParent> AuditLogParents { get; set; } = null!;
        public virtual DbSet<BloodGroup> BloodGroups { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<CompanyType> CompanyTypes { get; set; } = null!;
        public virtual DbSet<Contractor> Contractors { get; set; } = null!;
        public virtual DbSet<ContractorKeyPerson> ContractorKeyPeople { get; set; } = null!;
        public virtual DbSet<ContractorKeyPersonHse> ContractorKeyPersonHses { get; set; } = null!;
        public virtual DbSet<DailyAttendance> DailyAttendances { get; set; } = null!;
        public virtual DbSet<DailyAttendanceEdit> DailyAttendanceEdits { get; set; } = null!;
        public virtual DbSet<DaysName> DaysNames { get; set; } = null!;
        public virtual DbSet<DeviceDataError> DeviceDataErrors { get; set; } = null!;
        public virtual DbSet<DeviceDatum> DeviceData { get; set; } = null!;
        public virtual DbSet<DownloadTime> DownloadTimes { get; set; } = null!;
        public virtual DbSet<DriverLicenseAuthority> DriverLicenseAuthorities { get; set; } = null!;
        public virtual DbSet<DriverLicenseCategory> DriverLicenseCategories { get; set; } = null!;
        public virtual DbSet<DriverLicenseWorkerDetailI> DriverLicenseWorkerDetailIs { get; set; } = null!;
        public virtual DbSet<Feature> Features { get; set; } = null!;
        public virtual DbSet<FflcontractorCategory> FflcontractorCategories { get; set; } = null!;
        public virtual DbSet<Gender> Genders { get; set; } = null!;
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<Holiday> Holidays { get; set; } = null!;
        public virtual DbSet<HseworkerDetail> HseworkerDetails { get; set; } = null!;
        public virtual DbSet<HsmsContractor> HsmsContractors { get; set; } = null!;
        public virtual DbSet<HsmsContractorKeyPerson> HsmsContractorKeyPeople { get; set; } = null!;
        public virtual DbSet<HsmsWorker> HsmsWorkers { get; set; } = null!;
        public virtual DbSet<MedicalWorkerDetail> MedicalWorkerDetails { get; set; } = null!;
        public virtual DbSet<NormalRate> NormalRates { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<NotificationEmail> NotificationEmails { get; set; } = null!;
        public virtual DbSet<OldWorkerDatum> OldWorkerData { get; set; } = null!;
        public virtual DbSet<Peccategory> Peccategories { get; set; } = null!;
        public virtual DbSet<Ppeitem> Ppeitems { get; set; } = null!;
        public virtual DbSet<ProcessDate> ProcessDates { get; set; } = null!;
        public virtual DbSet<ProcessRequest> ProcessRequests { get; set; } = null!;
        public virtual DbSet<Profile> Profiles { get; set; } = null!;
        public virtual DbSet<Province> Provinces { get; set; } = null!;
        public virtual DbSet<Reader> Readers { get; set; } = null!;
        public virtual DbSet<ReaderDutyCode> ReaderDutyCodes { get; set; } = null!;
        public virtual DbSet<ReaderType> ReaderTypes { get; set; } = null!;
        public virtual DbSet<Religion> Religions { get; set; } = null!;
        public virtual DbSet<Remark> Remarks { get; set; } = null!;
        public virtual DbSet<SafetyManHour> SafetyManHours { get; set; } = null!;
        public virtual DbSet<Sect> Sects { get; set; } = null!;
        public virtual DbSet<Section> Sections { get; set; } = null!;
        public virtual DbSet<ServiceLog> ServiceLogs { get; set; } = null!;
        public virtual DbSet<Shift> Shifts { get; set; } = null!;
        public virtual DbSet<ShiftChanged> ShiftChangeds { get; set; } = null!;
        public virtual DbSet<ShiftChangedEmp> ShiftChangedEmps { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<Tarate> Tarates { get; set; } = null!;
        public virtual DbSet<Trade> Trades { get; set; } = null!;
        public virtual DbSet<UserRoleFeature> UserRoleFeatures { get; set; } = null!;
        public virtual DbSet<VatAttendance> VatAttendances { get; set; } = null!;
        public virtual DbSet<VatAttendanceVerification> VatAttendanceVerifications { get; set; } = null!;
        public virtual DbSet<VatReader> VatReaders { get; set; } = null!;
        public virtual DbSet<VatServiceLog> VatServiceLogs { get; set; } = null!;
        public virtual DbSet<VatShift> VatShifts { get; set; } = null!;
        public virtual DbSet<VatShiftChanged> VatShiftChangeds { get; set; } = null!;
        public virtual DbSet<VhrAppUser> VhrAppUsers { get; set; } = null!;
        public virtual DbSet<VhrAppUserRole> VhrAppUserRoles { get; set; } = null!;
        public virtual DbSet<VhrWorkerContractor> VhrWorkerContractors { get; set; } = null!;
        public virtual DbSet<WorkShopWorker> WorkShopWorkers { get; set; } = null!;
        public virtual DbSet<Worker> Workers { get; set; } = null!;
        public virtual DbSet<WorkerContractor> WorkerContractors { get; set; } = null!;
        public virtual DbSet<WorkerEobidetail> WorkerEobidetails { get; set; } = null!;
        public virtual DbSet<WorkerFingerPrint> WorkerFingerPrints { get; set; } = null!;
        public virtual DbSet<WorkerFpdelete> WorkerFpdeletes { get; set; } = null!;
        public virtual DbSet<WorkerFpdetail> WorkerFpdetails { get; set; } = null!;
        public virtual DbSet<WorkerFpupload> WorkerFpuploads { get; set; } = null!;
        public virtual DbSet<WorkerGroupInsuranceDetail> WorkerGroupInsuranceDetails { get; set; } = null!;
        public virtual DbSet<WorkerImage> WorkerImages { get; set; } = null!;
        public virtual DbSet<WorkerInterviewDetail> WorkerInterviewDetails { get; set; } = null!;
        public virtual DbSet<WorkerMobileAuthorizationDetail> WorkerMobileAuthorizationDetails { get; set; } = null!;
        public virtual DbSet<WorkerPoliceVerificationDetail> WorkerPoliceVerificationDetails { get; set; } = null!;
        public virtual DbSet<WorkerPpedetail> WorkerPpedetails { get; set; } = null!;
        public virtual DbSet<WorkerSkillDetail> WorkerSkillDetails { get; set; } = null!;
        public virtual DbSet<WorkerSocialSecurityDetail> WorkerSocialSecurityDetails { get; set; } = null!;
        public virtual DbSet<WorkerTradeDetail> WorkerTradeDetails { get; set; } = null!;
        public virtual DbSet<WorkerType> WorkerTypes { get; set; } = null!;
        public virtual DbSet<WorkerTypeOption> WorkerTypeOptions { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-QPA3IE4;Database=HSMS;User Id=sa;Password=Cloudtek123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.HasKey(e => e.PuserId);

                entity.ToTable("AppUser", "hr");

                entity.Property(e => e.PuserId).HasColumnName("PUserID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.KeyPersonId).HasColumnName("KeyPersonID");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<AppUserMenu>(entity =>
            {
                entity.HasKey(e => e.PappUserMenuId);

                entity.ToTable("AppUserMenu", "hr");

                entity.Property(e => e.PappUserMenuId).HasColumnName("PAppUserMenuID");

                entity.Property(e => e.MappUser).HasColumnName("MAppUser");

                entity.Property(e => e.MappUserRole).HasColumnName("MAppUserRole");

                entity.Property(e => e.MattendanceEditor).HasColumnName("MAttendanceEditor");

                entity.Property(e => e.McontractType).HasColumnName("MContractType");

                entity.Property(e => e.Mcontractor).HasColumnName("MContractor");

                entity.Property(e => e.McontractorKeyPerson).HasColumnName("MContractorKeyPerson");

                entity.Property(e => e.MsafetyManhours).HasColumnName("MSafetyManhours");

                entity.Property(e => e.Msection).HasColumnName("MSection");

                entity.Property(e => e.Msettings).HasColumnName("MSettings");

                entity.Property(e => e.MshiftSetting).HasColumnName("MShiftSetting");

                entity.Property(e => e.Mtrade).HasColumnName("MTrade");

                entity.Property(e => e.MuserManagement).HasColumnName("MUserManagement");

                entity.Property(e => e.Mworker).HasColumnName("MWorker");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            });

            modelBuilder.Entity<AppUserRole>(entity =>
            {
                entity.HasKey(e => e.PappUserRoleId);

                entity.ToTable("AppUserRole", "hr");

                entity.Property(e => e.PappUserRoleId).HasColumnName("PAppUserRoleID");

                entity.Property(e => e.AppUserRoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<AppUserSection>(entity =>
            {
                entity.HasKey(e => e.PuserSectionId);

                entity.ToTable("AppUserSection", "hr");

                entity.Property(e => e.PuserSectionId).HasColumnName("PUserSectionID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<AttachmentParent>(entity =>
            {
                entity.HasKey(e => e.PattachmentParentId);

                entity.ToTable("AttachmentParent", "hsms");

                entity.Property(e => e.PattachmentParentId).HasColumnName("PAttachmentParentID");

                entity.Property(e => e.FileExtension).HasMaxLength(50);

                entity.Property(e => e.FileTypeId).HasColumnName("FileTypeID");

                entity.Property(e => e.UploadedDate).HasColumnType("datetime");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<AttendanceVerification>(entity =>
            {
                entity.HasKey(e => e.PattendanceVerificationId)
                    .HasName("PK_AttendanceVerificationFlow");

                entity.ToTable("AttendanceVerification", "att");

                entity.Property(e => e.PattendanceVerificationId).HasColumnName("PAttendanceVerificationID");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.VerifiedByUserId).HasColumnName("VerifiedByUserID");

                entity.Property(e => e.WorkerDate).HasMaxLength(50);
            });

            modelBuilder.Entity<AttendanceVerificationFlow>(entity =>
            {
                entity.HasKey(e => e.PattendanceVerificationFlowId)
                    .HasName("PK_AttendanceVerificationFlow_1");

                entity.ToTable("AttendanceVerificationFlow", "att");

                entity.Property(e => e.PattendanceVerificationFlowId).HasColumnName("PAttendanceVerificationFlowID");

                entity.Property(e => e.AttendanceVerificationId).HasColumnName("AttendanceVerificationID");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AttendanceVerificationStatus>(entity =>
            {
                entity.HasKey(e => e.PattendanceVerificationStatusId);

                entity.ToTable("AttendanceVerificationStatus", "att");

                entity.Property(e => e.PattendanceVerificationStatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("PAttendanceVerificationStatusID");

                entity.Property(e => e.VerificationStatusName).HasMaxLength(50);
            });

            modelBuilder.Entity<AuditLogChild>(entity =>
            {
                entity.HasKey(e => e.PauditLogChildId);

                entity.ToTable("AuditLogChild");

                entity.Property(e => e.PauditLogChildId).HasColumnName("PAuditLogChildID");

                entity.Property(e => e.AuditLogParentId).HasColumnName("AuditLogParentID");

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.NewValue).HasMaxLength(500);

                entity.Property(e => e.OldValue).HasMaxLength(500);
            });

            modelBuilder.Entity<AuditLogParent>(entity =>
            {
                entity.HasKey(e => e.PauditLogParentId);

                entity.ToTable("AuditLogParent");

                entity.Property(e => e.PauditLogParentId).HasColumnName("PAuditLogParentID");

                entity.Property(e => e.EditByUserId).HasColumnName("EditByUserID");

                entity.Property(e => e.EditDateTime).HasColumnType("datetime");

                entity.Property(e => e.EditUserComputerIp)
                    .HasMaxLength(500)
                    .HasColumnName("EditUserComputerIP");

                entity.Property(e => e.EditUserComputerMac).HasMaxLength(500);

                entity.Property(e => e.PrimaryKey).HasMaxLength(50);
            });

            modelBuilder.Entity<BloodGroup>(entity =>
            {
                entity.HasKey(e => e.PbloodGroupId);

                entity.ToTable("BloodGroup", "hsms");

                entity.Property(e => e.PbloodGroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("PBloodGroupID");

                entity.Property(e => e.BloodGroupName).HasMaxLength(50);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.PcityId);

                entity.ToTable("City", "hr");

                entity.Property(e => e.PcityId).HasColumnName("PCityID");

                entity.Property(e => e.CityName).HasMaxLength(50);
            });

            modelBuilder.Entity<CompanyType>(entity =>
            {
                entity.HasKey(e => e.PcompanyTypeId);

                entity.ToTable("CompanyType", "hr");

                entity.Property(e => e.PcompanyTypeId).HasColumnName("PCompanyTypeID");

                entity.Property(e => e.CompanyTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Contractor>(entity =>
            {
                entity.HasKey(e => e.PcontractorId);

                entity.ToTable("Contractor", "hsms");

                entity.Property(e => e.PcontractorId).HasColumnName("PContractorID");

                entity.Property(e => e.Address).HasMaxLength(2000);

                entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");

                entity.Property(e => e.ContractorName).HasMaxLength(500);

                entity.Property(e => e.EmailAddress).HasMaxLength(950);

                entity.Property(e => e.FflcontractorCategoryId).HasColumnName("FFLContractorCategoryID");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(550)
                    .HasColumnName("GSTNo");

                entity.Property(e => e.Ntnnumber)
                    .HasMaxLength(350)
                    .HasColumnName("NTNNumber");

                entity.Property(e => e.PeccategoryId).HasColumnName("PECCategoryID");

                entity.Property(e => e.Pecnumber)
                    .HasMaxLength(550)
                    .HasColumnName("PECNumber");

                entity.Property(e => e.Pepranumber)
                    .HasMaxLength(550)
                    .HasColumnName("PEPRANumber");

                entity.Property(e => e.PhoneNo2).HasMaxLength(550);

                entity.Property(e => e.PhoneNo3).HasMaxLength(550);

                entity.Property(e => e.PhoneNumber).HasMaxLength(150);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.Remarks).HasMaxLength(1000);

                entity.Property(e => e.SalesTaxNumber).HasMaxLength(550);
            });

            modelBuilder.Entity<ContractorKeyPerson>(entity =>
            {
                entity.HasKey(e => e.PcontractorKeyPersonId);

                entity.ToTable("ContractorKeyPerson", "hsms");

                entity.Property(e => e.PcontractorKeyPersonId).HasColumnName("PContractorKeyPersonID");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.KeyPersonCardNo).HasMaxLength(50);

                entity.Property(e => e.KeyPersonFpid).HasColumnName("KeyPersonFPID");

                entity.Property(e => e.KeyPersonName).HasMaxLength(50);

                entity.Property(e => e.PhoneNo2).HasMaxLength(50);

                entity.Property(e => e.PhoneNo3).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.Remarks).HasMaxLength(1000);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<ContractorKeyPersonHse>(entity =>
            {
                entity.HasKey(e => e.PhsekeyPersonDetailId);

                entity.ToTable("ContractorKeyPersonHSE", "hsms");

                entity.Property(e => e.PhsekeyPersonDetailId).HasColumnName("PHSEKeyPersonDetailID");

                entity.Property(e => e.ContractorKeyPersonId).HasColumnName("ContractorKeyPersonID");

                entity.Property(e => e.HseattachedFileName)
                    .HasMaxLength(50)
                    .HasColumnName("HSEAttachedFileName");

                entity.Property(e => e.SafetyOrientationApprover).HasMaxLength(50);

                entity.Property(e => e.SafetyOrientationDate).HasColumnType("datetime");

                entity.Property(e => e.SafetyOrientationExpireDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DailyAttendance>(entity =>
            {
                entity.HasKey(e => e.WorkerDate);

                entity.ToTable("DailyAttendance", "att");

                entity.HasIndex(e => e.AttDate, "IDX_DailyAttendances_AttDate");

                entity.HasIndex(e => new { e.AttDate, e.Pdays }, "IDX_DailyAttendances_AttDate_PDays");

                entity.HasIndex(e => e.AttDate, "IX_AttDate");

                entity.Property(e => e.WorkerDate).HasMaxLength(50);

                entity.Property(e => e.AttDate).HasColumnType("date");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.DutyCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Gzotmin).HasColumnName("GZOTMin");

                entity.Property(e => e.Otmin).HasColumnName("OTMin");

                entity.Property(e => e.Pdays).HasColumnName("PDays");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StatusAb).HasColumnName("StatusAB");

                entity.Property(e => e.StatusDo).HasColumnName("StatusDO");

                entity.Property(e => e.StatusEi).HasColumnName("StatusEI");

                entity.Property(e => e.StatusEo).HasColumnName("StatusEO");

                entity.Property(e => e.StatusGz).HasColumnName("StatusGZ");

                entity.Property(e => e.StatusGzot).HasColumnName("StatusGZOT");

                entity.Property(e => e.StatusIn).HasColumnName("StatusIN");

                entity.Property(e => e.StatusLi).HasColumnName("StatusLI");

                entity.Property(e => e.StatusLo).HasColumnName("StatusLO");

                entity.Property(e => e.StatusMn).HasColumnName("StatusMN");

                entity.Property(e => e.StatusOt).HasColumnName("StatusOT");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.Property(e => e.Tin0).HasColumnType("datetime");

                entity.Property(e => e.Tin1).HasColumnType("datetime");

                entity.Property(e => e.Tin10).HasColumnType("datetime");

                entity.Property(e => e.Tin11).HasColumnType("datetime");

                entity.Property(e => e.Tin12).HasColumnType("datetime");

                entity.Property(e => e.Tin13).HasColumnType("datetime");

                entity.Property(e => e.Tin14).HasColumnType("datetime");

                entity.Property(e => e.Tin15).HasColumnType("datetime");

                entity.Property(e => e.Tin2).HasColumnType("datetime");

                entity.Property(e => e.Tin3).HasColumnType("datetime");

                entity.Property(e => e.Tin4).HasColumnType("datetime");

                entity.Property(e => e.Tin5).HasColumnType("datetime");

                entity.Property(e => e.Tin6).HasColumnType("datetime");

                entity.Property(e => e.Tin7).HasColumnType("datetime");

                entity.Property(e => e.Tin8).HasColumnType("datetime");

                entity.Property(e => e.Tin9).HasColumnType("datetime");

                entity.Property(e => e.Tout0).HasColumnType("datetime");

                entity.Property(e => e.Tout1).HasColumnType("datetime");

                entity.Property(e => e.Tout10).HasColumnType("datetime");

                entity.Property(e => e.Tout11).HasColumnType("datetime");

                entity.Property(e => e.Tout12).HasColumnType("datetime");

                entity.Property(e => e.Tout13).HasColumnType("datetime");

                entity.Property(e => e.Tout14).HasColumnType("datetime");

                entity.Property(e => e.Tout15).HasColumnType("datetime");

                entity.Property(e => e.Tout2).HasColumnType("datetime");

                entity.Property(e => e.Tout3).HasColumnType("datetime");

                entity.Property(e => e.Tout4).HasColumnType("datetime");

                entity.Property(e => e.Tout5).HasColumnType("datetime");

                entity.Property(e => e.Tout6).HasColumnType("datetime");

                entity.Property(e => e.Tout7).HasColumnType("datetime");

                entity.Property(e => e.Tout8).HasColumnType("datetime");

                entity.Property(e => e.Tout9).HasColumnType("datetime");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.DailyAttendances)
                    .HasForeignKey(d => d.WorkerId)
                    .HasConstraintName("FK_DailyAttendance_Worker");
            });

            modelBuilder.Entity<DailyAttendanceEdit>(entity =>
            {
                entity.HasKey(e => e.PdailyAttendanceEditId);

                entity.ToTable("DailyAttendanceEdit", "att");

                entity.Property(e => e.PdailyAttendanceEditId).HasColumnName("PDailyAttendanceEditID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.EditDateTime).HasColumnType("datetime");

                entity.Property(e => e.NewDutyCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.NewOtmin).HasColumnName("NewOTMin");

                entity.Property(e => e.NewRemarks).HasMaxLength(50);

                entity.Property(e => e.NewTimeIn).HasColumnType("datetime");

                entity.Property(e => e.NewTimeOut).HasColumnType("datetime");

                entity.Property(e => e.NewTin1).HasColumnType("datetime");

                entity.Property(e => e.NewTin2).HasColumnType("datetime");

                entity.Property(e => e.NewTin3).HasColumnType("datetime");

                entity.Property(e => e.NewTout1).HasColumnType("datetime");

                entity.Property(e => e.NewTout2).HasColumnType("datetime");

                entity.Property(e => e.NewTout3).HasColumnType("datetime");

                entity.Property(e => e.OldDutyCode)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.OldOtmin).HasColumnName("OldOTMin");

                entity.Property(e => e.OldRemarks).HasMaxLength(50);

                entity.Property(e => e.OldTimeIn).HasColumnType("datetime");

                entity.Property(e => e.OldTimeOut).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WorkerDate).HasMaxLength(12);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<DaysName>(entity =>
            {
                entity.ToTable("DaysName", "att");

                entity.Property(e => e.DaysNameId).HasColumnName("DaysNameID");

                entity.Property(e => e.DayName).HasMaxLength(50);
            });

            modelBuilder.Entity<DeviceDataError>(entity =>
            {
                entity.HasKey(e => e.PdeviceDataErrorId);

                entity.ToTable("DeviceDataError", "att");

                entity.Property(e => e.PdeviceDataErrorId).HasColumnName("PDeviceDataErrorID");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceRegId).HasColumnName("DeviceRegID");

                entity.Property(e => e.EntryDate).HasColumnType("date");

                entity.Property(e => e.EntryTime).HasColumnType("datetime");

                entity.Property(e => e.ReaderId).HasColumnName("ReaderID");
            });

            modelBuilder.Entity<DeviceDatum>(entity =>
            {
                entity.HasKey(e => e.PdeviceDataId);

                entity.ToTable("DeviceData", "att");

                entity.Property(e => e.PdeviceDataId).HasColumnName("PDeviceDataID");

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.CardNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0000000000')")
                    .IsFixedLength();

                entity.Property(e => e.ContractorKeyPersonId).HasColumnName("ContractorKeyPersonID");

                entity.Property(e => e.EntDate).HasColumnType("date");

                entity.Property(e => e.EntTime).HasColumnType("datetime");

                entity.Property(e => e.Fpid)
                    .HasColumnName("FPID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fpiddate)
                    .HasMaxLength(50)
                    .HasColumnName("FPIDDate");

                entity.Property(e => e.Process).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReaderDutyId)
                    .HasColumnName("ReaderDutyID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReaderId).HasColumnName("ReaderID");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<DownloadTime>(entity =>
            {
                entity.HasKey(e => e.PdownloadTimeId);

                entity.ToTable("DownloadTime", "att");

                entity.Property(e => e.PdownloadTimeId).HasColumnName("PDownloadTimeID");
            });

            modelBuilder.Entity<DriverLicenseAuthority>(entity =>
            {
                entity.HasKey(e => e.PdriverLicenseIssueAuthorityId);

                entity.ToTable("DriverLicenseAuthority", "hsms");

                entity.Property(e => e.PdriverLicenseIssueAuthorityId)
                    .ValueGeneratedNever()
                    .HasColumnName("PDriverLicenseIssueAuthorityID");

                entity.Property(e => e.DriverLicenseIssueAuthorityName).HasMaxLength(50);
            });

            modelBuilder.Entity<DriverLicenseCategory>(entity =>
            {
                entity.HasKey(e => e.PlicenseCategoryId);

                entity.ToTable("DriverLicenseCategory", "hsms");

                entity.Property(e => e.PlicenseCategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("PLicenseCategoryID");

                entity.Property(e => e.LicenseCategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<DriverLicenseWorkerDetailI>(entity =>
            {
                entity.HasKey(e => e.PdriverLicenseWorkerDetailId);

                entity.ToTable("DriverLicenseWorkerDetailI", "hsms");

                entity.Property(e => e.PdriverLicenseWorkerDetailId).HasColumnName("PDriverLicenseWorkerDetailID");

                entity.Property(e => e.DriverLicenseCategoryId).HasColumnName("DriverLicenseCategoryID");

                entity.Property(e => e.DriverLicenseExpireDate).HasColumnType("datetime");

                entity.Property(e => e.DriverLicenseFileName).HasMaxLength(50);

                entity.Property(e => e.DriverLicenseIssuerId).HasColumnName("DriverLicenseIssuerID");

                entity.Property(e => e.DriverLicenseNumber).HasMaxLength(50);

                entity.Property(e => e.ValidatedBy).HasMaxLength(50);

                entity.Property(e => e.ValidatedDate).HasColumnType("datetime");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<Feature>(entity =>
            {
                entity.HasKey(e => e.PfeatureId);

                entity.ToTable("Feature", "hr");

                entity.Property(e => e.PfeatureId)
                    .ValueGeneratedNever()
                    .HasColumnName("PFeatureID");

                entity.Property(e => e.Actionlink).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OrderId).HasColumnName("OrderID");
            });

            modelBuilder.Entity<FflcontractorCategory>(entity =>
            {
                entity.HasKey(e => e.PfflcontractorCategoryId);

                entity.ToTable("FFLContractorCategory", "hr");

                entity.Property(e => e.PfflcontractorCategoryId).HasColumnName("PFFLContractorCategoryID");

                entity.Property(e => e.FflcontractorCategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("FFLContractorCategoryName");
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.PgenderId);

                entity.ToTable("Gender", "hr");

                entity.Property(e => e.PgenderId)
                    .ValueGeneratedNever()
                    .HasColumnName("PGenderID");

                entity.Property(e => e.GenderName).HasMaxLength(50);
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.HasKey(e => e.PgradeId);

                entity.ToTable("Grade", "hsms");

                entity.Property(e => e.PgradeId)
                    .ValueGeneratedNever()
                    .HasColumnName("PGradeID");

                entity.Property(e => e.GradeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Holiday>(entity =>
            {
                entity.ToTable("Holiday", "att");

                entity.Property(e => e.HolidayId)
                    .ValueGeneratedNever()
                    .HasColumnName("HolidayID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.HolidayDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HseworkerDetail>(entity =>
            {
                entity.HasKey(e => e.PhseworkerDetailId);

                entity.ToTable("HSEWorkerDetail", "hsms");

                entity.Property(e => e.PhseworkerDetailId).HasColumnName("PHSEWorkerDetailID");

                entity.Property(e => e.HseattachedFileName)
                    .HasMaxLength(50)
                    .HasColumnName("HSEAttachedFileName");

                entity.Property(e => e.SafetyOrientationApprover).HasMaxLength(50);

                entity.Property(e => e.SafetyOrientationDate).HasColumnType("datetime");

                entity.Property(e => e.SafetyOrientationExpireDate).HasColumnType("datetime");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<HsmsContractor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HSMS_Contractor");

                entity.Property(e => e.Address)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.CompanyTypeId).HasColumnName("CompanyTypeID");

                entity.Property(e => e.CompanyTypeName).HasMaxLength(50);

                entity.Property(e => e.ContractorName).HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.FflcontractorCategoryId).HasColumnName("FFLContractorCategoryID");

                entity.Property(e => e.FflcontractorCategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("FFLContractorCategoryName");

                entity.Property(e => e.Gstno)
                    .HasMaxLength(10)
                    .HasColumnName("GSTNo")
                    .IsFixedLength();

                entity.Property(e => e.Ntnnumber)
                    .HasMaxLength(50)
                    .HasColumnName("NTNNumber");

                entity.Property(e => e.PcontractorId).HasColumnName("PContractorID");

                entity.Property(e => e.PeccategoryId).HasColumnName("PECCategoryID");

                entity.Property(e => e.PeccategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("PECCategoryName");

                entity.Property(e => e.Pecnumber)
                    .HasMaxLength(50)
                    .HasColumnName("PECNumber");

                entity.Property(e => e.Pepranumber)
                    .HasMaxLength(50)
                    .HasColumnName("PEPRANumber");

                entity.Property(e => e.PhoneNo2).HasMaxLength(50);

                entity.Property(e => e.PhoneNo3).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.ProvinceName).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(1000);

                entity.Property(e => e.SalesTaxNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<HsmsContractorKeyPerson>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HSMS_ContractorKeyPerson");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.ContractorName).HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.Gstno)
                    .HasMaxLength(10)
                    .HasColumnName("GSTNo")
                    .IsFixedLength();

                entity.Property(e => e.HseattachedFileName)
                    .HasMaxLength(50)
                    .HasColumnName("HSEAttachedFileName");

                entity.Property(e => e.KeyPersonCardNo).HasMaxLength(50);

                entity.Property(e => e.KeyPersonFpid).HasColumnName("KeyPersonFPID");

                entity.Property(e => e.KeyPersonName).HasMaxLength(50);

                entity.Property(e => e.Ntnnumber)
                    .HasMaxLength(50)
                    .HasColumnName("NTNNumber");

                entity.Property(e => e.PcontractorKeyPersonId).HasColumnName("PContractorKeyPersonID");

                entity.Property(e => e.Pecnumber)
                    .HasMaxLength(50)
                    .HasColumnName("PECNumber");

                entity.Property(e => e.PhoneNo2).HasMaxLength(50);

                entity.Property(e => e.PhoneNo3).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.ProfileName).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(1000);

                entity.Property(e => e.SafetyOrientationApprover).HasMaxLength(50);

                entity.Property(e => e.SafetyOrientationDate).HasColumnType("datetime");

                entity.Property(e => e.SafetyOrientationExpireDate).HasColumnType("datetime");

                entity.Property(e => e.SalesTaxNumber).HasMaxLength(50);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusName).HasMaxLength(50);
            });

            modelBuilder.Entity<HsmsWorker>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HSMS_Worker");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.BloodGroupId).HasColumnName("BloodGroupID");

                entity.Property(e => e.BloodGroupName).HasMaxLength(50);

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.CnicexpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CNICExpireDate");

                entity.Property(e => e.CnicfileName)
                    .HasMaxLength(50)
                    .HasColumnName("CNICFileName");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.ContractorName).HasMaxLength(500);

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("DOJ");

                entity.Property(e => e.DriverLicenseCategoryId).HasColumnName("DriverLicenseCategoryID");

                entity.Property(e => e.DriverLicenseExpireDate).HasColumnType("datetime");

                entity.Property(e => e.DriverLicenseFileName).HasMaxLength(50);

                entity.Property(e => e.DriverLicenseIssuerId).HasColumnName("DriverLicenseIssuerID");

                entity.Property(e => e.DriverLicenseNumber).HasMaxLength(50);

                entity.Property(e => e.EobiattachedFileName)
                    .HasMaxLength(50)
                    .HasColumnName("EOBIAttachedFileName");

                entity.Property(e => e.Eobiexpiredate)
                    .HasColumnType("datetime")
                    .HasColumnName("EOBIExpiredate");

                entity.Property(e => e.EobiissuanceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EOBIIssuanceDate");

                entity.Property(e => e.Eobinumber)
                    .HasMaxLength(50)
                    .HasColumnName("EOBINumber");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GenderName).HasMaxLength(50);

                entity.Property(e => e.GiattachedFileName)
                    .HasMaxLength(50)
                    .HasColumnName("GIAttachedFileName");

                entity.Property(e => e.GiexpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GIExpireDate");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.GradeName).HasMaxLength(50);

                entity.Property(e => e.GroupInsuranceNumber).HasMaxLength(50);

                entity.Property(e => e.HseattachedFileName)
                    .HasMaxLength(50)
                    .HasColumnName("HSEAttachedFileName");

                entity.Property(e => e.IntervieExpireDate).HasColumnType("datetime");

                entity.Property(e => e.InterviewBy)
                    .HasMaxLength(50)
                    .HasColumnName("InterviewBY");

                entity.Property(e => e.InterviewDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.Jonumber)
                    .HasMaxLength(50)
                    .HasColumnName("JONumber");

                entity.Property(e => e.MedicalFitnessApprovedBy).HasMaxLength(50);

                entity.Property(e => e.MedicalFitnessExpireDate).HasColumnType("datetime");

                entity.Property(e => e.MedicalFitnessFileName).HasMaxLength(50);

                entity.Property(e => e.MobileNo1).HasMaxLength(50);

                entity.Property(e => e.MobileNo2).HasMaxLength(50);

                entity.Property(e => e.NormalOtrate).HasColumnName("NormalOTRate");

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.PhoneNo2).HasMaxLength(50);

                entity.Property(e => e.PhoneNo3).HasMaxLength(50);

                entity.Property(e => e.PoliceVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.PoliceVerificationExpireDate).HasColumnType("datetime");

                entity.Property(e => e.PoliceVerificationFileName).HasMaxLength(50);

                entity.Property(e => e.PworkerId).HasColumnName("PWorkerID");

                entity.Property(e => e.Rate).HasMaxLength(50);

                entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

                entity.Property(e => e.ReligionName).HasMaxLength(50);

                entity.Property(e => e.ResignDate).HasColumnType("datetime");

                entity.Property(e => e.RfidcardNo)
                    .HasMaxLength(50)
                    .HasColumnName("RFIDCardNo");

                entity.Property(e => e.SafetyOrientationApprover).HasMaxLength(50);

                entity.Property(e => e.SafetyOrientationDate).HasColumnType("datetime");

                entity.Property(e => e.SafetyOrientationExpireDate).HasColumnType("datetime");

                entity.Property(e => e.SectId).HasColumnName("SectID");

                entity.Property(e => e.SectName).HasMaxLength(50);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.ShiftName).HasMaxLength(50);

                entity.Property(e => e.SkillApprovedBy).HasMaxLength(50);

                entity.Property(e => e.SkillApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.SkillExpireDate).HasColumnType("datetime");

                entity.Property(e => e.SocialSecurityNumber).HasMaxLength(50);

                entity.Property(e => e.SsattachedFileName)
                    .HasMaxLength(50)
                    .HasColumnName("SSAttachedFileName");

                entity.Property(e => e.SsexpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SSExpireDate");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusName).HasMaxLength(50);

                entity.Property(e => e.StatusRemarks).HasMaxLength(1000);

                entity.Property(e => e.Taotrate).HasColumnName("TAOTRate");

                entity.Property(e => e.Tarate).HasColumnName("TARate");

                entity.Property(e => e.TradeId).HasColumnName("TradeID");

                entity.Property(e => e.TradeName).HasMaxLength(50);

                entity.Property(e => e.WelderCertificateApprover).HasMaxLength(50);

                entity.Property(e => e.WelderCertificateExpireDate).HasColumnType("datetime");

                entity.Property(e => e.WelderCertificateFileName).HasMaxLength(50);

                entity.Property(e => e.WelderCertificateIssueDate).HasColumnType("datetime");

                entity.Property(e => e.WelderCertificateIssuer).HasMaxLength(50);

                entity.Property(e => e.WorkerName).HasMaxLength(50);

                entity.Property(e => e.WorkerOttarate).HasColumnName("WorkerOTTARate");

                entity.Property(e => e.WorkerTarate).HasColumnName("WorkerTARate");

                entity.Property(e => e.WorkerTypeId).HasColumnName("WorkerTypeID");

                entity.Property(e => e.WorkerTypeName).HasMaxLength(50);

                entity.Property(e => e.WorkerValidDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MedicalWorkerDetail>(entity =>
            {
                entity.HasKey(e => e.PmedicalWorkerDetailId);

                entity.ToTable("MedicalWorkerDetail", "hsms");

                entity.Property(e => e.PmedicalWorkerDetailId).HasColumnName("PMedicalWorkerDetailID");

                entity.Property(e => e.MedicalFitnessApprovedBy).HasMaxLength(50);

                entity.Property(e => e.MedicalFitnessExpireDate).HasColumnType("datetime");

                entity.Property(e => e.MedicalFitnessFileName).HasMaxLength(50);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<NormalRate>(entity =>
            {
                entity.HasKey(e => e.PnormalRateId);

                entity.ToTable("NormalRate", "hsms");

                entity.Property(e => e.PnormalRateId)
                    .ValueGeneratedNever()
                    .HasColumnName("PNormalRateID");

                entity.Property(e => e.NormalRateName).HasMaxLength(50);
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasKey(e => e.PnotificationId);

                entity.ToTable("Notification", "hr");

                entity.Property(e => e.PnotificationId).HasColumnName("PNotificationID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");

                entity.Property(e => e.NotificationUrl)
                    .HasMaxLength(500)
                    .HasColumnName("NotificationURL");

                entity.Property(e => e.PrimaryId).HasColumnName("PrimaryID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<NotificationEmail>(entity =>
            {
                entity.HasKey(e => e.PemailId);

                entity.ToTable("NotificationEmail", "hr");

                entity.Property(e => e.PemailId).HasColumnName("PEmailID");

                entity.Property(e => e.Body).HasMaxLength(4000);

                entity.Property(e => e.Ccaddress)
                    .HasMaxLength(200)
                    .HasColumnName("CCAddress");

                entity.Property(e => e.CreatedByUserId).HasColumnName("CreatedByUserID");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.NotificationTypeId).HasColumnName("NotificationTypeID");

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.SendDateTime).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.ToAddress).HasMaxLength(200);
            });

            modelBuilder.Entity<OldWorkerDatum>(entity =>
            {
                entity.HasKey(e => e.PoldWorkerDataId);

                entity.ToTable("OldWorkerData", "hsms");

                entity.Property(e => e.PoldWorkerDataId).HasColumnName("POldWorkerDataID");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.Property(e => e.WorkerTypeId).HasColumnName("WorkerTypeID");

                entity.Property(e => e.WorkerValidDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Peccategory>(entity =>
            {
                entity.HasKey(e => e.PpeccatagoryId);

                entity.ToTable("PECCategory", "hr");

                entity.Property(e => e.PpeccatagoryId).HasColumnName("PPECCatagoryID");

                entity.Property(e => e.PeccategoryName)
                    .HasMaxLength(50)
                    .HasColumnName("PECCategoryName");
            });

            modelBuilder.Entity<Ppeitem>(entity =>
            {
                entity.HasKey(e => e.PppeitemId);

                entity.ToTable("PPEItem", "hr");

                entity.Property(e => e.PppeitemId).HasColumnName("PPPEItemID");

                entity.Property(e => e.PpeitemName)
                    .HasMaxLength(50)
                    .HasColumnName("PPEItemName");
            });

            modelBuilder.Entity<ProcessDate>(entity =>
            {
                entity.HasKey(e => e.ProcessDateValue);

                entity.ToTable("ProcessDate", "att");

                entity.Property(e => e.ProcessDateValue).HasColumnType("date");
            });

            modelBuilder.Entity<ProcessRequest>(entity =>
            {
                entity.HasKey(e => e.PattProcesserSchedulerId);

                entity.ToTable("ProcessRequest", "att");

                entity.Property(e => e.PattProcesserSchedulerId)
                    .ValueGeneratedNever()
                    .HasColumnName("PAttProcesserSchedulerID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Criteria).HasMaxLength(50);

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.PeriodTag).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(1000);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.HasKey(e => e.PprofileId);

                entity.ToTable("Profile", "hr");

                entity.Property(e => e.PprofileId).HasColumnName("PProfileID");

                entity.Property(e => e.ProfileName).HasMaxLength(50);
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasKey(e => e.PprovinceId);

                entity.ToTable("Province", "hr");

                entity.Property(e => e.PprovinceId).HasColumnName("PProvinceID");

                entity.Property(e => e.ProvinceName).HasMaxLength(50);
            });

            modelBuilder.Entity<Reader>(entity =>
            {
                entity.HasKey(e => e.PreaderId);

                entity.ToTable("Reader", "att");

                entity.Property(e => e.PreaderId).HasColumnName("PReaderID");

                entity.Property(e => e.IpAdd).HasMaxLength(50);

                entity.Property(e => e.RdrTypeId).HasColumnName("RdrTypeID");

                entity.Property(e => e.ReaderDutyCodeId).HasColumnName("ReaderDutyCodeID");

                entity.Property(e => e.ReaderName).HasMaxLength(50);

                entity.HasOne(d => d.RdrType)
                    .WithMany(p => p.Readers)
                    .HasForeignKey(d => d.RdrTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reader_ReaderType");
            });

            modelBuilder.Entity<ReaderDutyCode>(entity =>
            {
                entity.HasKey(e => e.RdrDuty);

                entity.ToTable("ReaderDutyCode", "att");

                entity.Property(e => e.DutyName).HasMaxLength(50);
            });

            modelBuilder.Entity<ReaderType>(entity =>
            {
                entity.HasKey(e => e.PreaderTypeId);

                entity.ToTable("ReaderType", "att");

                entity.Property(e => e.PreaderTypeId).HasColumnName("PReaderTypeID");

                entity.Property(e => e.ReaderType1)
                    .HasMaxLength(50)
                    .HasColumnName("ReaderType");

                entity.Property(e => e.ReaderTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.HasKey(e => e.PreligionId);

                entity.ToTable("Religion", "hr");

                entity.Property(e => e.PreligionId)
                    .ValueGeneratedNever()
                    .HasColumnName("PReligionID");

                entity.Property(e => e.ReligionName).HasMaxLength(50);
            });

            modelBuilder.Entity<Remark>(entity =>
            {
                entity.HasKey(e => e.PremarkId);

                entity.ToTable("Remark", "att");

                entity.Property(e => e.PremarkId).HasColumnName("PRemarkID");

                entity.Property(e => e.RemarkValue).HasMaxLength(50);

                entity.Property(e => e.RemarksName).HasMaxLength(50);
            });

            modelBuilder.Entity<SafetyManHour>(entity =>
            {
                entity.HasKey(e => e.PsafetyManHourId);

                entity.ToTable("SafetyManHour", "hsms");

                entity.Property(e => e.PsafetyManHourId).HasColumnName("PSafetyManHourID");

                entity.Property(e => e.ClosedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(1000);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Sect>(entity =>
            {
                entity.HasKey(e => e.PsectId);

                entity.ToTable("Sect", "hsms");

                entity.Property(e => e.PsectId)
                    .ValueGeneratedNever()
                    .HasColumnName("PSectID");

                entity.Property(e => e.SectName).HasMaxLength(50);
            });

            modelBuilder.Entity<Section>(entity =>
            {
                entity.HasKey(e => e.PsectionId);

                entity.ToTable("Section", "hr");

                entity.Property(e => e.PsectionId).HasColumnName("PSectionID");
            });

            modelBuilder.Entity<ServiceLog>(entity =>
            {
                entity.HasKey(e => e.PserviceLogId);

                entity.ToTable("ServiceLog", "att");

                entity.Property(e => e.PserviceLogId).HasColumnName("PServiceLogID");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ReaderId).HasColumnName("ReaderID");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasKey(e => e.PshiftId);

                entity.ToTable("Shift", "att");

                entity.Property(e => e.PshiftId).HasColumnName("PShiftID");

                entity.Property(e => e.AddEiinOt).HasColumnName("AddEIInOT");

                entity.Property(e => e.Gzdays).HasColumnName("GZDays");

                entity.Property(e => e.PresentAtIn).HasColumnName("PresentAtIN");

                entity.Property(e => e.ShiftName).HasMaxLength(50);

                entity.Property(e => e.SubtractEifromWork).HasColumnName("SubtractEIFromWork");

                entity.Property(e => e.SubtractOtfromWork).HasColumnName("SubtractOTFromWork");
            });

            modelBuilder.Entity<ShiftChanged>(entity =>
            {
                entity.HasKey(e => e.PshiftChangedId);

                entity.ToTable("ShiftChanged", "att");

                entity.Property(e => e.PshiftChangedId)
                    .ValueGeneratedNever()
                    .HasColumnName("PShiftChangedID");

                entity.Property(e => e.ChangedShiftDesc).HasMaxLength(100);

                entity.Property(e => e.DateEnd).HasColumnType("date");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ShiftChangedEmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ShiftChangedEmp", "att");

                entity.Property(e => e.DateCreated).HasColumnType("date");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.PworkerShiftChangeId).HasColumnName("PWorkerShiftChangeID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.PstatusId);

                entity.ToTable("Status", "hsms");

                entity.Property(e => e.PstatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("PStatusID");

                entity.Property(e => e.StatusName).HasMaxLength(50);
            });

            modelBuilder.Entity<Tarate>(entity =>
            {
                entity.HasKey(e => e.PtarateId);

                entity.ToTable("TARate", "hsms");

                entity.Property(e => e.PtarateId)
                    .ValueGeneratedNever()
                    .HasColumnName("PTARateID");

                entity.Property(e => e.TarateName)
                    .HasMaxLength(50)
                    .HasColumnName("TARateName");
            });

            modelBuilder.Entity<Trade>(entity =>
            {
                entity.HasKey(e => e.PtradeId)
                    .HasName("PK_Skill");

                entity.ToTable("Trade", "hsms");

                entity.Property(e => e.PtradeId)
                    .ValueGeneratedNever()
                    .HasColumnName("PTradeID");

                entity.Property(e => e.NormalOtrate).HasColumnName("NormalOTRate");

                entity.Property(e => e.Taotrate).HasColumnName("TAOTRate");

                entity.Property(e => e.Tarate).HasColumnName("TARate");

                entity.Property(e => e.TradeName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserRoleFeature>(entity =>
            {
                entity.HasKey(e => e.PuserRoleFeatureId);

                entity.ToTable("UserRoleFeature", "hr");

                entity.Property(e => e.PuserRoleFeatureId).HasColumnName("PUserRoleFeatureID");

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");
            });

            modelBuilder.Entity<VatAttendance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VAT_Attendance");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.AttDate).HasColumnType("date");

                entity.Property(e => e.BloodGroupId).HasColumnName("BloodGroupID");

                entity.Property(e => e.BloodGroupName).HasMaxLength(50);

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.CnicexpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CNICExpireDate");

                entity.Property(e => e.CnicfileName)
                    .HasMaxLength(50)
                    .HasColumnName("CNICFileName");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.ContractorName).HasMaxLength(500);

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("DOJ");

                entity.Property(e => e.DutyCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GenderName).HasMaxLength(50);

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.GradeName).HasMaxLength(50);

                entity.Property(e => e.Gzotmin).HasColumnName("GZOTMin");

                entity.Property(e => e.Otmin).HasColumnName("OTMin");

                entity.Property(e => e.Pdays).HasColumnName("PDays");

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.PworkerId).HasColumnName("PWorkerID");

                entity.Property(e => e.Rate).HasMaxLength(50);

                entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

                entity.Property(e => e.ReligionName).HasMaxLength(50);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ResignDate).HasColumnType("datetime");

                entity.Property(e => e.RfidcardNo)
                    .HasMaxLength(50)
                    .HasColumnName("RFIDCardNo");

                entity.Property(e => e.SectId).HasColumnName("SectID");

                entity.Property(e => e.SectName).HasMaxLength(50);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.ShiftName).HasMaxLength(50);

                entity.Property(e => e.StatusAb).HasColumnName("StatusAB");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusDo).HasColumnName("StatusDO");

                entity.Property(e => e.StatusEi).HasColumnName("StatusEI");

                entity.Property(e => e.StatusEo).HasColumnName("StatusEO");

                entity.Property(e => e.StatusGz).HasColumnName("StatusGZ");

                entity.Property(e => e.StatusGzot).HasColumnName("StatusGZOT");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusIn).HasColumnName("StatusIN");

                entity.Property(e => e.StatusLi).HasColumnName("StatusLI");

                entity.Property(e => e.StatusLo).HasColumnName("StatusLO");

                entity.Property(e => e.StatusMn).HasColumnName("StatusMN");

                entity.Property(e => e.StatusName).HasMaxLength(50);

                entity.Property(e => e.StatusOt).HasColumnName("StatusOT");

                entity.Property(e => e.StatusRemarks).HasMaxLength(1000);

                entity.Property(e => e.Tarate).HasColumnName("TARate");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.Property(e => e.Tin0).HasColumnType("datetime");

                entity.Property(e => e.Tin1).HasColumnType("datetime");

                entity.Property(e => e.Tin10).HasColumnType("datetime");

                entity.Property(e => e.Tin11).HasColumnType("datetime");

                entity.Property(e => e.Tin12).HasColumnType("datetime");

                entity.Property(e => e.Tin13).HasColumnType("datetime");

                entity.Property(e => e.Tin14).HasColumnType("datetime");

                entity.Property(e => e.Tin15).HasColumnType("datetime");

                entity.Property(e => e.Tin2).HasColumnType("datetime");

                entity.Property(e => e.Tin3).HasColumnType("datetime");

                entity.Property(e => e.Tin4).HasColumnType("datetime");

                entity.Property(e => e.Tin5).HasColumnType("datetime");

                entity.Property(e => e.Tin6).HasColumnType("datetime");

                entity.Property(e => e.Tin7).HasColumnType("datetime");

                entity.Property(e => e.Tin8).HasColumnType("datetime");

                entity.Property(e => e.Tin9).HasColumnType("datetime");

                entity.Property(e => e.Tout0).HasColumnType("datetime");

                entity.Property(e => e.Tout1).HasColumnType("datetime");

                entity.Property(e => e.Tout10).HasColumnType("datetime");

                entity.Property(e => e.Tout11).HasColumnType("datetime");

                entity.Property(e => e.Tout12).HasColumnType("datetime");

                entity.Property(e => e.Tout13).HasColumnType("datetime");

                entity.Property(e => e.Tout14).HasColumnType("datetime");

                entity.Property(e => e.Tout15).HasColumnType("datetime");

                entity.Property(e => e.Tout2).HasColumnType("datetime");

                entity.Property(e => e.Tout3).HasColumnType("datetime");

                entity.Property(e => e.Tout4).HasColumnType("datetime");

                entity.Property(e => e.Tout5).HasColumnType("datetime");

                entity.Property(e => e.Tout6).HasColumnType("datetime");

                entity.Property(e => e.Tout7).HasColumnType("datetime");

                entity.Property(e => e.Tout8).HasColumnType("datetime");

                entity.Property(e => e.Tout9).HasColumnType("datetime");

                entity.Property(e => e.TradeId).HasColumnName("TradeID");

                entity.Property(e => e.TradeName).HasMaxLength(50);

                entity.Property(e => e.VerificationStatusName).HasMaxLength(50);

                entity.Property(e => e.WorkerDate).HasMaxLength(50);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.Property(e => e.WorkerName).HasMaxLength(50);

                entity.Property(e => e.WorkerTypeId).HasColumnName("WorkerTypeID");

                entity.Property(e => e.WorkerTypeName).HasMaxLength(50);

                entity.Property(e => e.WorkerValidDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VatAttendanceVerification>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VAT_AttendanceVerification");

                entity.Property(e => e.AttDate).HasColumnType("date");

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.ContractorName).HasMaxLength(500);

                entity.Property(e => e.DutyCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PattendanceVerificationId).HasColumnName("PAttendanceVerificationID");

                entity.Property(e => e.Pdays).HasColumnName("PDays");

                entity.Property(e => e.PsectionId).HasColumnName("PSectionID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SubmittedByUserName).HasMaxLength(50);

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.Property(e => e.SubmmitedToUserName).HasMaxLength(50);

                entity.Property(e => e.Tarate).HasColumnName("TARate");

                entity.Property(e => e.TimeIn).HasColumnType("datetime");

                entity.Property(e => e.TimeOut).HasColumnType("datetime");

                entity.Property(e => e.TradeId).HasColumnName("TradeID");

                entity.Property(e => e.TradeName).HasMaxLength(50);

                entity.Property(e => e.VerificationStatusName).HasMaxLength(50);

                entity.Property(e => e.VerifiedByUserId).HasColumnName("VerifiedByUserID");

                entity.Property(e => e.VerifiedByUserName).HasMaxLength(50);

                entity.Property(e => e.WorkerDate).HasMaxLength(50);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.Property(e => e.WorkerName).HasMaxLength(50);

                entity.Property(e => e.WorkerTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<VatReader>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VAT_Reader");

                entity.Property(e => e.DutyName).HasMaxLength(50);

                entity.Property(e => e.IpAdd).HasMaxLength(50);

                entity.Property(e => e.PreaderId).HasColumnName("PReaderID");

                entity.Property(e => e.RdrTypeId).HasColumnName("RdrTypeID");

                entity.Property(e => e.ReaderDutyCodeId).HasColumnName("ReaderDutyCodeID");

                entity.Property(e => e.ReaderName).HasMaxLength(50);

                entity.Property(e => e.ReaderType).HasMaxLength(50);

                entity.Property(e => e.ReaderTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<VatServiceLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VAT_ServiceLog");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.DutyName).HasMaxLength(50);

                entity.Property(e => e.IpAdd).HasMaxLength(50);

                entity.Property(e => e.PreaderId).HasColumnName("PReaderID");

                entity.Property(e => e.PserviceLogId).HasColumnName("PServiceLogID");

                entity.Property(e => e.ReaderDutyCodeId).HasColumnName("ReaderDutyCodeID");

                entity.Property(e => e.ReaderName).HasMaxLength(50);

                entity.Property(e => e.ReaderType).HasMaxLength(50);

                entity.Property(e => e.ReaderTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<VatShift>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VAT_Shift");

                entity.Property(e => e.AddEiinOt).HasColumnName("AddEIInOT");

                entity.Property(e => e.DayOff1Name).HasMaxLength(50);

                entity.Property(e => e.DayOff2Name).HasMaxLength(50);

                entity.Property(e => e.Gzdays).HasColumnName("GZDays");

                entity.Property(e => e.PresentAtIn).HasColumnName("PresentAtIN");

                entity.Property(e => e.PshiftId).HasColumnName("PShiftID");

                entity.Property(e => e.ShiftName).HasMaxLength(50);

                entity.Property(e => e.SubtractEifromWork).HasColumnName("SubtractEIFromWork");

                entity.Property(e => e.SubtractOtfromWork).HasColumnName("SubtractOTFromWork");
            });

            modelBuilder.Entity<VatShiftChanged>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VAT_ShiftChanged");

                entity.Property(e => e.ChangedShiftDesc).HasMaxLength(100);

                entity.Property(e => e.DateEnd).HasColumnType("date");

                entity.Property(e => e.DateStart).HasColumnType("date");

                entity.Property(e => e.DayOff1Name).HasMaxLength(50);

                entity.Property(e => e.DayOff2Name).HasMaxLength(50);

                entity.Property(e => e.PshiftChangedId).HasColumnName("PShiftChangedID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.ShiftName).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<VhrAppUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VHR_AppUser");

                entity.Property(e => e.AppUserRoleName).HasMaxLength(50);

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.KeyPersonId).HasColumnName("KeyPersonID");

                entity.Property(e => e.KeyPersonName).HasMaxLength(50);

                entity.Property(e => e.PuserId).HasColumnName("PUserID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionNames).IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<VhrAppUserRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VHR_AppUserRole");

                entity.Property(e => e.AppUserRoleName).HasMaxLength(50);

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");

                entity.Property(e => e.MappUser).HasColumnName("MAppUser");

                entity.Property(e => e.MappUserRole).HasColumnName("MAppUserRole");

                entity.Property(e => e.MattendanceEditor).HasColumnName("MAttendanceEditor");

                entity.Property(e => e.McontractType).HasColumnName("MContractType");

                entity.Property(e => e.Mcontractor).HasColumnName("MContractor");

                entity.Property(e => e.McontractorKeyPerson).HasColumnName("MContractorKeyPerson");

                entity.Property(e => e.MsafetyManhours).HasColumnName("MSafetyManhours");

                entity.Property(e => e.Msection).HasColumnName("MSection");

                entity.Property(e => e.Msettings).HasColumnName("MSettings");

                entity.Property(e => e.MshiftSetting).HasColumnName("MShiftSetting");

                entity.Property(e => e.Mtrade).HasColumnName("MTrade");

                entity.Property(e => e.MuserManagement).HasColumnName("MUserManagement");

                entity.Property(e => e.Mworker).HasColumnName("MWorker");

                entity.Property(e => e.PappUserRoleId).HasColumnName("PAppUserRoleID");

                entity.Property(e => e.PuserRoleFeatureId).HasColumnName("PUserRoleFeatureID");
            });

            modelBuilder.Entity<VhrWorkerContractor>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VHR_WorkerContractor");

                entity.Property(e => e.ContractorName).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.PworkerContractorId).HasColumnName("PWorkerContractorID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.Property(e => e.WorkerName).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkShopWorker>(entity =>
            {
                entity.HasKey(e => e.PworkShopWorkerId);

                entity.ToTable("WorkShopWorker", "hsms");

                entity.Property(e => e.PworkShopWorkerId).HasColumnName("PWorkShopWorkerID");

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.WelderCertificateApprover).HasMaxLength(50);

                entity.Property(e => e.WelderCertificateExpireDate).HasColumnType("datetime");

                entity.Property(e => e.WelderCertificateFileName).HasMaxLength(50);

                entity.Property(e => e.WelderCertificateIssueDate).HasColumnType("datetime");

                entity.Property(e => e.WelderCertificateIssuer).HasMaxLength(50);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.HasKey(e => e.PworkerId)
                    .HasName("PK_hsms.Worker");

                entity.ToTable("Worker", "hsms");

                entity.Property(e => e.PworkerId).HasColumnName("PWorkerID");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.BloodGroupId).HasColumnName("BloodGroupID");

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.CnicexpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CNICExpireDate");

                entity.Property(e => e.CnicfileName)
                    .HasMaxLength(50)
                    .HasColumnName("CNICFileName");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("DOJ");

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GradeId).HasColumnName("GradeID");

                entity.Property(e => e.Hcid).HasColumnName("HCID");

                entity.Property(e => e.Jonumber)
                    .HasMaxLength(50)
                    .HasColumnName("JONumber");

                entity.Property(e => e.OtnormalRate).HasColumnName("OTNormalRate");

                entity.Property(e => e.Ottarate).HasColumnName("OTTARate");

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.PhoneNo2).HasMaxLength(50);

                entity.Property(e => e.PhoneNo3).HasMaxLength(50);

                entity.Property(e => e.Rate).HasMaxLength(50);

                entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

                entity.Property(e => e.ResignDate).HasColumnType("datetime");

                entity.Property(e => e.RfidcardNo)
                    .HasMaxLength(50)
                    .HasColumnName("RFIDCardNo");

                entity.Property(e => e.SectId).HasColumnName("SectID");

                entity.Property(e => e.ShiftId).HasColumnName("ShiftID");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusRemarks).HasMaxLength(1000);

                entity.Property(e => e.Tarate).HasColumnName("TARate");

                entity.Property(e => e.TradeId).HasColumnName("TradeID");

                entity.Property(e => e.WorkerName).HasMaxLength(50);

                entity.Property(e => e.WorkerTypeId).HasColumnName("WorkerTypeID");

                entity.Property(e => e.WorkerValidDate).HasColumnType("datetime");

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.Workers)
                    .HasForeignKey(d => d.ShiftId)
                    .HasConstraintName("FK_Worker_Shift");
            });

            modelBuilder.Entity<WorkerContractor>(entity =>
            {
                entity.HasKey(e => e.PworkerContractorId);

                entity.ToTable("WorkerContractor", "hr");

                entity.Property(e => e.PworkerContractorId).HasColumnName("PWorkerContractorID");

                entity.Property(e => e.ContractorId).HasColumnName("ContractorID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<WorkerEobidetail>(entity =>
            {
                entity.HasKey(e => e.PworkerEobidetailId);

                entity.ToTable("WorkerEOBIDetail", "hsms");

                entity.Property(e => e.PworkerEobidetailId).HasColumnName("PWorkerEOBIDetailID");

                entity.Property(e => e.EobiattachedFileName)
                    .HasMaxLength(50)
                    .HasColumnName("EOBIAttachedFileName");

                entity.Property(e => e.Eobiexpiredate)
                    .HasColumnType("datetime")
                    .HasColumnName("EOBIExpiredate");

                entity.Property(e => e.EobiissuanceDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EOBIIssuanceDate");

                entity.Property(e => e.Eobinumber)
                    .HasMaxLength(50)
                    .HasColumnName("EOBINumber");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<WorkerFingerPrint>(entity =>
            {
                entity.HasKey(e => e.WorkerId);

                entity.ToTable("WorkerFingerPrint", "hsms");

                entity.Property(e => e.WorkerId)
                    .ValueGeneratedNever()
                    .HasColumnName("WorkerID");

                entity.Property(e => e.Fp1).HasColumnName("FP1");

                entity.Property(e => e.Fp2).HasColumnName("FP2");

                entity.Property(e => e.Fp3).HasColumnName("FP3");

                entity.Property(e => e.Fp4).HasColumnName("FP4");

                entity.Property(e => e.Fp5).HasColumnName("FP5");

                entity.Property(e => e.FpupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("FPUpdatedDT");
            });

            modelBuilder.Entity<WorkerFpdelete>(entity =>
            {
                entity.ToTable("WorkerFPDelete", "hsms");

                entity.Property(e => e.WorkerFpdeleteId).HasColumnName("WorkerFPDeleteID");

                entity.Property(e => e.AddedDate).HasColumnType("date");

                entity.Property(e => e.CreatedDt).HasColumnName("CreatedDT");

                entity.Property(e => e.DeleatedReson).HasMaxLength(100);

                entity.Property(e => e.DeletedDt).HasColumnName("DeletedDT");

                entity.Property(e => e.ExpireDate).HasColumnType("date");

                entity.Property(e => e.ReaderId).HasColumnName("ReaderID");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<WorkerFpdetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("WorkerFPDetails");

                entity.Property(e => e.Cnic)
                    .HasMaxLength(50)
                    .HasColumnName("CNIC");

                entity.Property(e => e.CnicexpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CNICExpireDate");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("DOJ");

                entity.Property(e => e.Fp1).HasColumnName("FP1");

                entity.Property(e => e.Fp2).HasColumnName("FP2");

                entity.Property(e => e.Fp3).HasColumnName("FP3");

                entity.Property(e => e.Fp4).HasColumnName("FP4");

                entity.Property(e => e.Fp5).HasColumnName("FP5");

                entity.Property(e => e.FpupdatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("FPUpdatedDT");

                entity.Property(e => e.GradeName).HasMaxLength(50);

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.PhoneNo2).HasMaxLength(50);

                entity.Property(e => e.PhoneNo3).HasMaxLength(50);

                entity.Property(e => e.ResignDate).HasColumnType("datetime");

                entity.Property(e => e.SectName).HasMaxLength(50);

                entity.Property(e => e.StatusName).HasMaxLength(50);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");

                entity.Property(e => e.WorkerName).HasMaxLength(50);

                entity.Property(e => e.WorkerTypeName).HasMaxLength(50);

                entity.Property(e => e.WorkerValidDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WorkerFpupload>(entity =>
            {
                entity.ToTable("WorkerFPUpload", "hsms");

                entity.Property(e => e.WorkerFpuploadId).HasColumnName("WorkerFPUploadID");

                entity.Property(e => e.CreatedDt)
                    .HasColumnType("datetime")
                    .HasColumnName("CreatedDT");

                entity.Property(e => e.IsRfid).HasColumnName("IsRFID");

                entity.Property(e => e.ReaderId).HasColumnName("ReaderID");

                entity.Property(e => e.RfidcardNo).HasColumnName("RFIDCardNo");

                entity.Property(e => e.UploadedDt).HasColumnName("UploadedDT");

                entity.Property(e => e.WorkerId)
                    .HasMaxLength(10)
                    .HasColumnName("WorkerID")
                    .IsFixedLength();

                entity.Property(e => e.WorkerName).HasMaxLength(100);
            });

            modelBuilder.Entity<WorkerGroupInsuranceDetail>(entity =>
            {
                entity.HasKey(e => e.PworkerGroupInsuranceDetailId);

                entity.ToTable("WorkerGroupInsuranceDetail", "hsms");

                entity.Property(e => e.PworkerGroupInsuranceDetailId).HasColumnName("PWorkerGroupInsuranceDetailID");

                entity.Property(e => e.GiattachedFileName)
                    .HasMaxLength(50)
                    .HasColumnName("GIAttachedFileName");

                entity.Property(e => e.GiexpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GIExpireDate");

                entity.Property(e => e.GroupInsuranceNumber).HasMaxLength(50);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<WorkerImage>(entity =>
            {
                entity.HasKey(e => e.PworkerId);

                entity.ToTable("WorkerImage", "hr");

                entity.Property(e => e.PworkerId)
                    .ValueGeneratedNever()
                    .HasColumnName("PWorkerID");

                entity.Property(e => e.WorkerPic).HasColumnType("image");
            });

            modelBuilder.Entity<WorkerInterviewDetail>(entity =>
            {
                entity.HasKey(e => e.PworkerInterviewDetailId);

                entity.ToTable("WorkerInterviewDetail", "hsms");

                entity.Property(e => e.PworkerInterviewDetailId).HasColumnName("PWorkerInterviewDetailID");

                entity.Property(e => e.IntervieExpireDate).HasColumnType("datetime");

                entity.Property(e => e.InterviewBy)
                    .HasMaxLength(50)
                    .HasColumnName("InterviewBY");

                entity.Property(e => e.InterviewDate).HasColumnType("datetime");

                entity.Property(e => e.InterviewFileName).HasMaxLength(50);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<WorkerMobileAuthorizationDetail>(entity =>
            {
                entity.HasKey(e => e.PworkerMobileAuthorizationId);

                entity.ToTable("WorkerMobileAuthorizationDetail", "hsms");

                entity.Property(e => e.PworkerMobileAuthorizationId).HasColumnName("PWorkerMobileAuthorizationID");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNo1).HasMaxLength(50);

                entity.Property(e => e.MobileNo2).HasMaxLength(50);

                entity.Property(e => e.MobileNo3).HasMaxLength(50);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<WorkerPoliceVerificationDetail>(entity =>
            {
                entity.HasKey(e => e.PpoliceVerificationWorkerDetailId);

                entity.ToTable("WorkerPoliceVerificationDetail", "hsms");

                entity.Property(e => e.PpoliceVerificationWorkerDetailId).HasColumnName("PPoliceVerificationWorkerDetailID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.PoliceVerificationDate).HasColumnType("datetime");

                entity.Property(e => e.PoliceVerificationExpireDate).HasColumnType("datetime");

                entity.Property(e => e.PoliceVerificationFileName).HasMaxLength(50);

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<WorkerPpedetail>(entity =>
            {
                entity.HasKey(e => e.Pppeid);

                entity.ToTable("WorkerPPEDetail", "hsms");

                entity.Property(e => e.Pppeid).HasColumnName("PPPEID");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.PpefileName)
                    .HasMaxLength(50)
                    .HasColumnName("PPEFileName");

                entity.Property(e => e.PpeitemId).HasColumnName("PPEItemID");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<WorkerSkillDetail>(entity =>
            {
                entity.HasKey(e => e.PworkerSkillId);

                entity.ToTable("WorkerSkillDetail", "hsms");

                entity.Property(e => e.PworkerSkillId).HasColumnName("PWorkerSkillID");

                entity.Property(e => e.SkillApprovedBy).HasMaxLength(50);

                entity.Property(e => e.SkillApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.SkillExpireDate).HasColumnType("datetime");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<WorkerSocialSecurityDetail>(entity =>
            {
                entity.HasKey(e => e.PworkerSocialSecurityDetailId);

                entity.ToTable("WorkerSocialSecurityDetail", "hsms");

                entity.Property(e => e.PworkerSocialSecurityDetailId).HasColumnName("PWorkerSocialSecurityDetailID");

                entity.Property(e => e.SocialSecurityNumber).HasMaxLength(50);

                entity.Property(e => e.SsattachedFileName)
                    .HasMaxLength(50)
                    .HasColumnName("SSAttachedFileName");

                entity.Property(e => e.SsexpireDate)
                    .HasColumnType("datetime")
                    .HasColumnName("SSExpireDate");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<WorkerTradeDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WorkerTradeDetail", "hsms");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.NormalOtrate).HasColumnName("NormalOTRate");

                entity.Property(e => e.PworkerTradeDetailId).HasColumnName("PWorkerTradeDetailID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Taotrate).HasColumnName("TAOTRate");

                entity.Property(e => e.Tarate).HasColumnName("TARate");

                entity.Property(e => e.TradeId).HasColumnName("TradeID");

                entity.Property(e => e.WorkerId).HasColumnName("WorkerID");
            });

            modelBuilder.Entity<WorkerType>(entity =>
            {
                entity.HasKey(e => e.PworkerTypeId);

                entity.ToTable("WorkerType", "hsms");

                entity.Property(e => e.PworkerTypeId).HasColumnName("PWorkerTypeID");

                entity.Property(e => e.WorkerTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkerTypeOption>(entity =>
            {
                entity.HasKey(e => e.PworkerTypeOptionsId);

                entity.ToTable("WorkerTypeOptions", "hr");

                entity.Property(e => e.PworkerTypeOptionsId).HasColumnName("PWorkerTypeOptionsID");

                entity.Property(e => e.FeatureId).HasColumnName("FeatureID");

                entity.Property(e => e.WorkerTypeId).HasColumnName("WorkerTypeID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
