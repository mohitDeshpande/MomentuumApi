using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MomentuumApi.Model
{
    public partial class MobileDBContext : DbContext
    {
        public virtual DbSet<LstType> LstType { get; set; }
        public virtual DbSet<TblCase> TblCase { get; set; }
        public virtual DbSet<TblClient> TblClient { get; set; }
        public virtual DbSet<TblClientAdminInfo> TblClientAdminInfo { get; set; }
        public virtual DbSet<TblClientPhone> TblClientPhone { get; set; }
        public virtual DbSet<TblClientSource> TblClientSource { get; set; }
        public virtual DbSet<TblEmailattachment> TblEmailattachment { get; set; }
        public virtual DbSet<TblEmployees> TblEmployees { get; set; }
        public virtual DbSet<TblLocationAddress> TblLocationAddress { get; set; }
        public virtual DbSet<TblPlan> TblPlan { get; set; }

        // Unable to generate entity type for table 'dbo.lst_casecode'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_casestatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_casetype'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_class'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_source'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_status'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_logtrans'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tbl_ltrTemplate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_caseitem'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1433;Database=MobileDB;Trusted_Connection=False;uid=sa;pwd=password@123");
            }
        }

        public MobileDBContext(DbContextOptions<MobileDBContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LstType>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("lst_type");

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("nchar(10)");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(20);

                entity.Property(e => e.Listtext)
                    .HasColumnName("listtext")
                    .HasMaxLength(255);

                entity.Property(e => e.Refid).HasColumnName("refid");

                entity.Property(e => e.Score).HasColumnName("score");
            });

            modelBuilder.Entity<TblCase>(entity =>
            {
                entity.HasKey(e => e.Caseid);

                entity.ToTable("tbl_case");

                entity.Property(e => e.Caseid).HasColumnName("caseid");

                entity.Property(e => e.CaseAssignedTo)
                    .HasColumnName("caseAssignedTo")
                    .HasMaxLength(25);

                entity.Property(e => e.CaseClosedDate).HasColumnType("datetime");

                entity.Property(e => e.CaseCode).HasMaxLength(50);

                entity.Property(e => e.CaseNature).HasColumnName("caseNature");

                entity.Property(e => e.CaseOpenDate)
                    .HasColumnName("caseOpenDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CaseSource).HasMaxLength(25);

                entity.Property(e => e.Casedescription)
                    .HasColumnName("casedescription")
                    .HasMaxLength(2000);

                entity.Property(e => e.Casestatus)
                    .HasColumnName("casestatus")
                    .HasMaxLength(300);

                entity.Property(e => e.Casetype)
                    .HasColumnName("casetype")
                    .HasMaxLength(25);

                entity.Property(e => e.Createdby)
                    .HasColumnName("createdby")
                    .HasMaxLength(255);

                entity.Property(e => e.Createddate)
                    .HasColumnName("createddate")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasMaxLength(25);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Timeprocess)
                    .HasColumnName("timeprocess")
                    .HasColumnType("datetime");

                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(25);

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.TblCase)
                    .HasForeignKey(d => d.Id)
                    .HasConstraintName("FK_tbl_case_tbl_client");
            });

            modelBuilder.Entity<TblClient>(entity =>
            {
                entity.ToTable("tbl_client");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressLine1).HasMaxLength(150);

                entity.Property(e => e.AddressLine2).HasMaxLength(150);

                entity.Property(e => e.AlsoKnownAs).HasMaxLength(60);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Class).HasMaxLength(25);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cust1)
                    .HasColumnName("cust1")
                    .HasMaxLength(30);

                entity.Property(e => e.Cust2)
                    .HasColumnName("cust2")
                    .HasMaxLength(30);

                entity.Property(e => e.Cust3)
                    .HasColumnName("cust3")
                    .HasMaxLength(30);

                entity.Property(e => e.Division)
                    .HasColumnName("division")
                    .HasMaxLength(20);

                entity.Property(e => e.Dnc).HasColumnName("DNC");

                entity.Property(e => e.Dne).HasColumnName("DNE");

                entity.Property(e => e.Dnm).HasColumnName("DNM");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(125);

                entity.Property(e => e.Extension)
                    .HasColumnName("EXTENSION")
                    .HasMaxLength(10);

                entity.Property(e => e.FaxArea).HasMaxLength(15);

                entity.Property(e => e.FaxPhone).HasMaxLength(15);

                entity.Property(e => e.Filename)
                    .HasColumnName("filename")
                    .HasMaxLength(80);

                entity.Property(e => e.FirstName).HasMaxLength(60);

                entity.Property(e => e.HomeArea).HasMaxLength(3);

                entity.Property(e => e.HomePhone).HasMaxLength(8);

                entity.Property(e => e.LastModifiedBy)
                    .HasColumnName("last_modified_by")
                    .HasMaxLength(50);

                entity.Property(e => e.LastModifiedTimestamp)
                    .HasColumnName("last_modified_timestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Lastname).HasMaxLength(60);

                entity.Property(e => e.MaidenName).HasMaxLength(60);

                entity.Property(e => e.MainPhone).HasMaxLength(20);

                entity.Property(e => e.MainPhoneType).HasMaxLength(20);

                entity.Property(e => e.MaritalStatus).HasMaxLength(50);

                entity.Property(e => e.Middlename).HasMaxLength(30);

                entity.Property(e => e.PreferredContact)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'main')");

                entity.Property(e => e.Seq)
                    .HasColumnName("seq")
                    .HasMaxLength(20);

                entity.Property(e => e.SignedOut).HasMaxLength(12);

                entity.Property(e => e.Sin).HasColumnName("SIN");

                entity.Property(e => e.SpouseAlsoKnownAs).HasMaxLength(60);

                entity.Property(e => e.SpouseFirstName).HasMaxLength(60);

                entity.Property(e => e.SpouseLastName).HasMaxLength(60);

                entity.Property(e => e.SpouseMaidenName).HasMaxLength(60);

                entity.Property(e => e.SpouseMiddleName).HasMaxLength(30);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(15);

                entity.Property(e => e.Type).HasMaxLength(15);

                entity.Property(e => e.WorkArea).HasMaxLength(5);

                entity.Property(e => e.WorkPhone).HasMaxLength(15);

                entity.Property(e => e.Zip).HasMaxLength(10);
            });

            modelBuilder.Entity<TblClientAdminInfo>(entity =>
            {
                entity.HasKey(e => e.ClientAdminInfoId);

                entity.ToTable("tbl_client_admin_info");

                entity.Property(e => e.ClientAdminInfoId).HasColumnName("ClientAdminInfoID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.CourtName).HasMaxLength(500);

                entity.Property(e => e.CourtNumber).HasMaxLength(500);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DateAppointed).HasColumnType("datetime");

                entity.Property(e => e.DateDeemedAccepted).HasColumnType("datetime");

                entity.Property(e => e.DateSent).HasColumnType("datetime");

                entity.Property(e => e.District).HasMaxLength(500);

                entity.Property(e => e.Division).HasMaxLength(50);

                entity.Property(e => e.DivisionNumber).HasMaxLength(500);

                entity.Property(e => e.EstateAdministrator).HasMaxLength(500);

                entity.Property(e => e.FileAdminVersion).HasMaxLength(500);

                entity.Property(e => e.FileMgr).HasMaxLength(500);

                entity.Property(e => e.FilingAgent).HasMaxLength(500);

                entity.Property(e => e.IimeetingOn)
                    .HasColumnName("IIMeetingOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.InitialContact).HasColumnType("datetime");

                entity.Property(e => e.InitialInterview).HasMaxLength(500);

                entity.Property(e => e.InsolvencyDate).HasColumnType("datetime");

                entity.Property(e => e.IntakeAgent).HasMaxLength(500);

                entity.Property(e => e.Location).HasMaxLength(500);

                entity.Property(e => e.MeetingDate).HasColumnType("datetime");

                entity.Property(e => e.SignupDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(500);

                entity.Property(e => e.Technician).HasMaxLength(500);

                entity.Property(e => e.Trustee).HasMaxLength(500);

                entity.Property(e => e._45days)
                    .HasColumnName("45Days")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblClientPhone>(entity =>
            {
                entity.HasKey(e => e.ClientPhoneId);

                entity.ToTable("tbl_client_phone");

                entity.Property(e => e.ClientPhoneId).HasColumnName("ClientPhoneID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.PhoneNumber).HasMaxLength(20);

                entity.Property(e => e.PhoneType).HasMaxLength(20);
            });

            modelBuilder.Entity<TblClientSource>(entity =>
            {
                entity.HasKey(e => e.ClientSourceId);

                entity.ToTable("tbl_client_source");

                entity.Property(e => e.ClientSourceId).HasColumnName("ClientSourceID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.SourceCode).HasMaxLength(5);
            });

            modelBuilder.Entity<TblEmailattachment>(entity =>
            {
                entity.ToTable("tbl_emailattachment");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Division).HasMaxLength(50);

                entity.Property(e => e.FilePathUrl).HasMaxLength(1000);
            });

            modelBuilder.Entity<TblEmployees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("tbl_Employees");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.Attemptcount).HasColumnName("attemptcount");

                entity.Property(e => e.Division)
                    .HasColumnName("division")
                    .HasMaxLength(10);

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.EmployeeLogin).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(100);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.HomePhone).HasMaxLength(11);

                entity.Property(e => e.LastLogin).HasColumnType("datetime");

                entity.Property(e => e.MobilePhone).HasMaxLength(11);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UsrPassword)
                    .HasColumnName("usrPassword")
                    .HasMaxLength(20);

                entity.Property(e => e.WorkPhone).HasMaxLength(11);

                entity.Property(e => e.WorkPhoneExt).HasMaxLength(5);
            });

            modelBuilder.Entity<TblLocationAddress>(entity =>
            {
                entity.HasKey(e => e.LocationAddressId);

                entity.ToTable("tbl_location_address");

                entity.Property(e => e.LocationAddressId).HasColumnName("location_address_id");

                entity.Property(e => e.Address1)
                    .IsRequired()
                    .HasColumnName("address1")
                    .HasMaxLength(100);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(100);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(100);

                entity.Property(e => e.CreatedBy).HasColumnName("created_by");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Division)
                    .IsRequired()
                    .HasColumnName("division")
                    .HasMaxLength(10);

                entity.Property(e => e.LocationId).HasColumnName("location_id");

                entity.Property(e => e.ModifiedBy).HasColumnName("modified_by");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasColumnName("state")
                    .HasMaxLength(100);

                entity.Property(e => e.Zip)
                    .IsRequired()
                    .HasColumnName("zip")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TblPlan>(entity =>
            {
                entity.HasKey(e => e.PlanId);

                entity.ToTable("tbl_plan");

                entity.Property(e => e.PlanId).HasColumnName("plan_id");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasColumnName("bank")
                    .HasMaxLength(50);

                entity.Property(e => e.BankAccountNo)
                    .IsRequired()
                    .HasColumnName("bank_account_no")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.BankDesignationNo)
                    .IsRequired()
                    .HasColumnName("bank_designation_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankInstituteNo)
                    .IsRequired()
                    .HasColumnName("bank_institute_no")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.BankTransitNo)
                    .IsRequired()
                    .HasColumnName("bank_transit_no")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ChildPlanId)
                    .HasColumnName("child_plan_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedEmployeeId).HasColumnName("created_employee_id");

                entity.Property(e => e.Division)
                    .IsRequired()
                    .HasColumnName("division")
                    .HasMaxLength(10);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnName("modified_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedEmployeeId).HasColumnName("modified_employee_id");

                entity.Property(e => e.ParentPlanId)
                    .HasColumnName("parent_plan_id")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("payment_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlanAmount).HasColumnName("plan_amount");

                entity.Property(e => e.PlanType)
                    .IsRequired()
                    .HasColumnName("plan_type")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TotalFees).HasColumnName("total_fees");
            });
        }
    }
}
