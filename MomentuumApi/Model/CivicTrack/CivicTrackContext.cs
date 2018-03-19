using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace MomentuumApi.Model.CivicTrack
{
    public partial class CivicTrackContext : DbContext
    {
        public virtual DbSet<Mail> Mail { get; set; }
        public virtual DbSet<TblImport> TblImport { get; set; }
        public virtual DbSet<TblImportHdr> TblImportHdr { get; set; }
        public virtual DbSet<TblIntention> TblIntention { get; set; }
        public virtual DbSet<TblNotice> TblNotice { get; set; }
        public virtual DbSet<TblPollResultsIp> TblPollResultsIp { get; set; }
        public virtual DbSet<TblRoundCase> TblRoundCase { get; set; }
        public virtual DbSet<TblRoundtablequeue> TblRoundtablequeue { get; set; }
        public virtual DbSet<TblVoter> TblVoter { get; set; }
        public virtual DbSet<TblEmployees> TblEmployees { get; set; }
        public virtual DbSet<TblCase> TblCase { get; set; }
        public virtual DbSet<TblCaseItem> TblCaseItem { get; set; }


        public CivicTrackContext(DbContextOptions<CivicTrackContext> options) : base(options)
        { }

        // Unable to generate entity type for table 'dbo.Lst_importfieldnames'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tbl_ltrTemplate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Lst_ImportfieldXref'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Calendar'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_jobcnt'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.streettype_symbols'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_blastemail'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_calljobs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_correspondence'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CIMS_survey'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_emailReminder'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_exceptions'. Please see the warning messages.
        // Unable to generate entity type for table 'yeatman.tbl_reportname'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_help'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_reportname'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_casegroups'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_filelist'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_ticket'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tbl_importType'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_casegrouplist'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_dispurse'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tbl_LtrXRef'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ethnicity'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_surresults'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_activity'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_casecode'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_caseitemaction'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_log_history'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_casestatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_locations'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_casetype'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_cust1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_batchinfo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_cust2'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_cust3'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_docname'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_direction'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_logtrans'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_dispurseaccount'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_dispursecode'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_donorcode'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_logtrans_history'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_donorstatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_Gender'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_intention'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_invoicejobs'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_issue'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_notecode'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_payment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_CICcaseitem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_pda'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_ciccasecode'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_pdaid'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_ciccaseitemaction'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_polls'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_ciccasestatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_donor'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_province'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_ciccasetype'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_salutation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_case'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_cicCBSA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_seq'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_ciccdnstatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_shift'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_cicconsulate'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_signlocation'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_cicrelationship'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_signsize'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_signstatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_uploadFolder_audit'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_status'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_streettype'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_suffix'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_dup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_type'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_volstatus'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_wrapupcode'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.messages'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NICKNAMES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Settings'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_groups'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_grouplist'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_config'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Documents'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_StreetNames'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_caseitem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.user_riding'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_class'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_productionfiles'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_testundecided'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Attachment'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_CICcase'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_testtemp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.user_poll'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Upload'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_volunteer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_files'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Thoughts'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.QueryAddress'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_sign'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_subtype'. Please see the warning messages.
        // Unable to generate entity type for table 'ivrnet.tbl_ivrnet'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_script'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_PollQuestion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_polllocations'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_PollCurrent'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_PollAnswer'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Poll'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.mike_case_codes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_notes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Postal Codes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.phonelist'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_News'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EMAILLIST'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Folders'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Attachment_case'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_survey'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_employees_admin'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_EmployeeTypes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_logtransSQL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_surveyresults'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_surveyresults1'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Tbl_ECImport'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_countries'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_image_details'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.forums'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_image_label'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_notecode_bak'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_emailgroup'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.user_poll_load'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_roundcaseitem'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_emaillist'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_emailmessage'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Chart_content'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_import_case'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Charts'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TBL_IMPORT_note'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_emailcampaign'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CIMSFormat'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_Employees'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CIMSImport'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_exportid'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.lst_editlist'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_mpusers'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1433;Database=VT;Trusted_Connection=False;uid=sa;pwd=password@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //manual addition, due to lack of primary key 

            modelBuilder.Entity<TblCase>(entity =>
            {
                entity.HasKey(e => e.Caseid);

                entity.ToTable("tbl_case");

                entity.Property(e => e.Caseid).HasColumnName("caseid");

                entity.Property(e => e.CaseAssignedTo)
                    .HasColumnName("caseAssignedTo")
                    .HasMaxLength(50);

               
                entity.Property(e => e.CaseClosedDate).HasMaxLength(25);

                entity.Property(e => e.CaseCode).HasMaxLength(50);

                entity.Property(e => e.CaseNature).HasColumnName("caseNature");

                entity.Property(e => e.CaseOpenDate)
                    .HasColumnName("caseOpenDate")
                    .HasMaxLength(25);

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
              

               entity.Property(e => e.Deleted)
                   .HasColumnName("deleted")
                   .HasMaxLength(25);

               entity.Property(e => e.IdVoter).HasColumnName("id");
               entity.Property(e => e.TempCaseId).HasColumnName("tempcaseid");
                entity.Property(e => e.Timeprocess)
                    .HasColumnName("timeprocess")
                     .HasMaxLength(25);
                /* Not in new db
             entity.Property(e => e.Createddate)
                 .HasColumnName("createddate")
                 .HasMaxLength(255)
                 .HasDefaultValueSql("(getdate())");
                 */

                /* Not in new db
                entity.Property(e => e.Updateddate)
                    .HasColumnName("updateddate")
                    .HasMaxLength(255)
                    .HasDefaultValueSql("(getdate())");
                    */

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(25);
                // new column
                entity.Property(e => e.Subtype)
                   .HasColumnName("subtype")
                   .HasMaxLength(50);
                //new column
                entity.Property(e => e.Casesin)
                  .HasColumnName("casesin")
                  .HasMaxLength(20);


                //entity.HasOne(d => d.IdNavigation)
                //    .WithMany()
                //    .HasForeignKey(d => d.IdClient)
                //    .HasConstraintName("FK_tbl_case_tbl_client");
            });

            // Manual addition of Case Items due to lack of Primary Key on this table 

            modelBuilder.Entity<TblCaseItem>(entity =>
            {
                entity.ToTable("tbl_caseitem");
                entity.HasKey(e => e.IntId);

                entity.Property(e => e.IntId).HasColumnName("intid");

                entity.Property(e => e.Caseid).HasColumnName("caseid");
                entity.Property(e => e.CaseItemDate).HasColumnName("caseitemdate").HasMaxLength(25);

                entity.Property(e => e.CaseItemDescription).HasColumnName("caseitemdescription").HasMaxLength(150);

                entity.Property(e => e.CaseItemStatus).HasColumnName("caseitemstatus").HasMaxLength(100);

                entity.Property(e => e.CaseItemDetail).HasColumnName("caseitemdetail");

                entity.Property(e => e.CaseItemAction).HasColumnName("caseitemaction").HasMaxLength(50);

                entity.Property(e => e.CaseItemAssigned).HasColumnName("caseitemassigned").HasMaxLength(50);

                entity.Property(e => e.CaseItemFollowUpdate).HasColumnName("caseitemfollowupdate").HasMaxLength(25);

                entity.Property(e => e.Deleted).HasColumnName("deleted").HasMaxLength(25);

                entity.Property(e => e.UserId).HasColumnName("userid").HasMaxLength(25);

                /* not in new db
                entity.Property(e => e.TimeProcess).HasColumnName("timeprocess").HasMaxLength(25);

                entity.Property(e => e.Priority).HasColumnName("priority").HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasColumnName("createdby").HasMaxLength(255);

                entity.Property(e => e.CreatedDate).HasColumnName("createddate").HasMaxLength(255);

                entity.Property(e => e.UpdatedDate).HasColumnName("updateddate").HasMaxLength(255);
                */
            });




            modelBuilder.Entity<Mail>(entity =>
            {
                entity.HasKey(e => e.GcGuid);

                entity.Property(e => e.GcGuid)
                    .HasColumnName("gc_guid")
                    .ValueGeneratedNever();

                entity.Property(e => e.GcAlternateRecipientAllowed)
                    .HasColumnName("gc_AlternateRecipientAllowed")
                    .HasColumnType("char(1)");

                entity.Property(e => e.GcAutoForwarded)
                    .HasColumnName("gc_AutoForwarded")
                    .HasColumnType("char(1)");

                entity.Property(e => e.GcBcc)
                    .HasColumnName("gc_BCC")
                    .HasMaxLength(1700)
                    .IsUnicode(false);

                entity.Property(e => e.GcBillingInformation)
                    .HasColumnName("gc_BillingInformation")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.GcCategories)
                    .HasColumnName("gc_Categories")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.GcCc)
                    .HasColumnName("gc_CC")
                    .HasMaxLength(1700)
                    .IsUnicode(false);

                entity.Property(e => e.GcCompanies)
                    .HasColumnName("gc_Companies")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.GcCreationTime)
                    .HasColumnName("gc_CreationTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.GcDeferredDeliveryTime)
                    .HasColumnName("gc_DeferredDeliveryTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.GcDeleteAfterSubmit)
                    .HasColumnName("gc_DeleteAfterSubmit")
                    .HasColumnType("char(1)");

                entity.Property(e => e.GcExpiryTime)
                    .HasColumnName("gc_ExpiryTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.GcFlagDueBy)
                    .HasColumnName("gc_FlagDueBy")
                    .HasColumnType("datetime");

                entity.Property(e => e.GcFlagRequest)
                    .HasColumnName("gc_FlagRequest")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GcFlagStatus).HasColumnName("gc_FlagStatus");

                entity.Property(e => e.GcHtmlbody)
                    .HasColumnName("gc_HTMLBody")
                    .HasColumnType("text");

                entity.Property(e => e.GcImportance).HasColumnName("gc_Importance");

                entity.Property(e => e.GcInternetCodepage).HasColumnName("gc_InternetCodepage");

                entity.Property(e => e.GcLastModificationTime)
                    .HasColumnName("gc_LastModificationTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.GcMileage)
                    .HasColumnName("gc_Mileage")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GcNoAging)
                    .HasColumnName("gc_NoAging")
                    .HasColumnType("char(1)");

                entity.Property(e => e.GcOriginatorDeliveryReportRequested)
                    .HasColumnName("gc_OriginatorDeliveryReportRequested")
                    .HasColumnType("char(1)");

                entity.Property(e => e.GcReadReceiptRequested)
                    .HasColumnName("gc_ReadReceiptRequested")
                    .HasColumnType("char(1)");

                entity.Property(e => e.GcReceivedByName)
                    .HasColumnName("gc_ReceivedByName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GcReceivedOnBehalfOfName)
                    .HasColumnName("gc_ReceivedOnBehalfOfName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GcReceivedTime)
                    .HasColumnName("gc_ReceivedTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.GcRecipientReassignmentProhibited)
                    .HasColumnName("gc_RecipientReassignmentProhibited")
                    .HasColumnType("char(1)");

                entity.Property(e => e.GcRemoteStatus).HasColumnName("gc_RemoteStatus");

                entity.Property(e => e.GcReplyRecipientNames)
                    .HasColumnName("gc_ReplyRecipientNames")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.GcSenderEmailAddress)
                    .HasColumnName("gc_SenderEmailAddress")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.GcSenderEmailType)
                    .HasColumnName("gc_SenderEmailType")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GcSenderName)
                    .HasColumnName("gc_SenderName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GcSensitivity).HasColumnName("gc_Sensitivity");

                entity.Property(e => e.GcSentOn)
                    .HasColumnName("gc_SentOn")
                    .HasColumnType("datetime");

                entity.Property(e => e.GcSentOnBehalfOfName)
                    .HasColumnName("gc_SentOnBehalfOfName")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GcSubject)
                    .HasColumnName("gc_Subject")
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.GcTo)
                    .HasColumnName("gc_To")
                    .HasMaxLength(1700)
                    .IsUnicode(false);

                entity.Property(e => e.GcUnread)
                    .HasColumnName("gc_Unread")
                    .HasColumnType("char(1)");

                entity.Property(e => e.Messageid)
                    .HasColumnName("messageid")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Riding)
                    .HasColumnName("riding")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblImport>(entity =>
            {
                entity.HasKey(e => e.RowId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Tbl_Import");

                entity.HasIndex(e => new { e.Riding, e.Lastname, e.HouseNumber, e.StreetName, e.FirstName })
                    .HasName("ind_import")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(50);

                entity.Property(e => e.Cellarea)
                    .HasColumnName("cellarea")
                    .HasMaxLength(55);

                entity.Property(e => e.Cellphone)
                    .HasColumnName("cellphone")
                    .HasMaxLength(55);

                entity.Property(e => e.Cellphonefuill)
                    .HasColumnName("cellphonefuill")
                    .HasMaxLength(55);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CityState)
                    .HasColumnName("city_state")
                    .HasMaxLength(100);

                entity.Property(e => e.CityStateZip)
                    .HasColumnName("city_state_zip")
                    .HasMaxLength(120);

                entity.Property(e => e.ClassDetails).HasMaxLength(35);

                entity.Property(e => e.Companyid).HasColumnName("companyid");

                entity.Property(e => e.Cust1)
                    .HasColumnName("cust1")
                    .HasMaxLength(50);

                entity.Property(e => e.Cust2)
                    .HasColumnName("cust2")
                    .HasMaxLength(50);

                entity.Property(e => e.Cust3)
                    .HasColumnName("cust3")
                    .HasMaxLength(50);

                entity.Property(e => e.Department).HasColumnName("department");

                entity.Property(e => e.Dnc).HasColumnName("DNC");

                entity.Property(e => e.Dne).HasColumnName("DNE");

                entity.Property(e => e.Dnm).HasColumnName("DNM");

                entity.Property(e => e.Donoramount)
                    .HasColumnName("donoramount")
                    .HasMaxLength(80);

                entity.Property(e => e.Donorstatus)
                    .HasColumnName("donorstatus")
                    .HasMaxLength(80);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(125);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(150);

                entity.Property(e => e.Extension)
                    .HasColumnName("EXTENSION")
                    .HasMaxLength(50);

                entity.Property(e => e.FaxArea).HasMaxLength(55);

                entity.Property(e => e.FaxPhone).HasMaxLength(55);

                entity.Property(e => e.Faxphonefull)
                    .HasColumnName("faxphonefull")
                    .HasMaxLength(55);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Firstchoice)
                    .HasColumnName("firstchoice")
                    .HasMaxLength(50);

                entity.Property(e => e.Firstlastname)
                    .HasColumnName("firstlastname")
                    .HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.HomeArea).HasMaxLength(55);

                entity.Property(e => e.HomePhone).HasMaxLength(55);

                entity.Property(e => e.Homephonefull)
                    .HasColumnName("homephonefull")
                    .HasMaxLength(55);

                entity.Property(e => e.HouseNumber).HasMaxLength(50);

                entity.Property(e => e.HousenumberStreetnameApt)
                    .HasColumnName("housenumber_streetname_apt")
                    .HasMaxLength(150);

                entity.Property(e => e.HousenumberStreetnameType)
                    .HasColumnName("housenumber_streetname_type")
                    .HasMaxLength(180);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.ImportHdrId).HasColumnName("ImportHdrID");

                entity.Property(e => e.Importvalue)
                    .HasColumnName("importvalue")
                    .HasMaxLength(60);

                entity.Property(e => e.Issue)
                    .HasColumnName("issue")
                    .HasMaxLength(50);

                entity.Property(e => e.Jobtitle).HasColumnName("jobtitle");

                entity.Property(e => e.Label1).HasMaxLength(50);

                entity.Property(e => e.Label2).HasMaxLength(50);

                entity.Property(e => e.Label3).HasMaxLength(50);

                entity.Property(e => e.Lastbldgnum)
                    .HasColumnName("lastbldgnum")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastfirstname)
                    .HasColumnName("lastfirstname")
                    .HasMaxLength(100);

                entity.Property(e => e.Lastname).HasMaxLength(50);

                entity.Property(e => e.Laststeetname)
                    .HasColumnName("laststeetname")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastzip)
                    .HasColumnName("lastzip")
                    .HasMaxLength(57);

                entity.Property(e => e.Memberdate)
                    .HasColumnName("memberdate")
                    .HasMaxLength(80);

                entity.Property(e => e.Memberstatus)
                    .HasColumnName("memberstatus")
                    .HasMaxLength(80);

                entity.Property(e => e.Middlename).HasMaxLength(50);

                entity.Property(e => e.Newvalue)
                    .HasColumnName("newvalue")
                    .HasMaxLength(50);

                entity.Property(e => e.Nickname).HasMaxLength(50);

                entity.Property(e => e.Notecode)
                    .HasColumnName("notecode")
                    .HasMaxLength(50);

                entity.Property(e => e.Notedescrip).HasColumnName("notedescrip");

                entity.Property(e => e.Notedetail).HasColumnName("notedetail");

                entity.Property(e => e.Notes).HasColumnName("notes");

                entity.Property(e => e.Notesubject)
                    .HasColumnName("notesubject")
                    .HasMaxLength(80);

                entity.Property(e => e.Occupation).HasMaxLength(150);

                entity.Property(e => e.PersonBusinessAddress)
                    .HasColumnName("personBusinessAddress")
                    .HasMaxLength(500);

                entity.Property(e => e.Poll).HasMaxLength(50);

                entity.Property(e => e.Riding).HasMaxLength(50);

                entity.Property(e => e.RuralAddress1).HasMaxLength(400);

                entity.Property(e => e.RuralAddress2).HasMaxLength(300);

                entity.Property(e => e.RuralCity).HasMaxLength(100);

                entity.Property(e => e.RuralState).HasMaxLength(50);

                entity.Property(e => e.Ruralzip).HasMaxLength(50);

                entity.Property(e => e.Salutation).HasMaxLength(50);

                entity.Property(e => e.Seq).HasMaxLength(50);

                entity.Property(e => e.SignedOut).HasMaxLength(42);

                entity.Property(e => e.Signedoutdate)
                    .HasColumnName("signedoutdate")
                    .HasMaxLength(55);

                entity.Property(e => e.Signstatus)
                    .HasColumnName("signstatus")
                    .HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(30);

                entity.Property(e => e.Status).HasMaxLength(45);

                entity.Property(e => e.StreetDirection).HasMaxLength(50);

                entity.Property(e => e.StreetName).HasMaxLength(200);

                entity.Property(e => e.StreetNumSfx).HasMaxLength(50);

                entity.Property(e => e.StreetType).HasMaxLength(50);

                entity.Property(e => e.StreetnameType)
                    .HasColumnName("streetname_type")
                    .HasMaxLength(500);

                entity.Property(e => e.Suffix).HasMaxLength(50);

                entity.Property(e => e.Tablename)
                    .HasColumnName("tablename")
                    .HasMaxLength(50);

                entity.Property(e => e.Tablevalue)
                    .HasColumnName("tablevalue")
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(35);

                entity.Property(e => e.UnitNo).HasMaxLength(20);

                entity.Property(e => e.Volactivity)
                    .HasColumnName("volactivity")
                    .HasMaxLength(50);

                entity.Property(e => e.Volstatus).HasMaxLength(50);

                entity.Property(e => e.VoterId)
                    .HasColumnName("VoterID")
                    .HasMaxLength(50);

                entity.Property(e => e.VoterYd2)
                    .HasColumnName("VoterYD2")
                    .HasMaxLength(50);

                entity.Property(e => e.Voterid3).HasColumnName("voterid3");

                entity.Property(e => e.Website).HasColumnName("website");

                entity.Property(e => e.WorkArea).HasMaxLength(55);

                entity.Property(e => e.WorkPhone).HasMaxLength(55);

                entity.Property(e => e.Workphonefull)
                    .HasColumnName("workphonefull")
                    .HasMaxLength(55);

                entity.Property(e => e.Zip).HasMaxLength(50);
            });

            modelBuilder.Entity<TblImportHdr>(entity =>
            {
                entity.HasKey(e => e.ImportHdrId);

                entity.ToTable("tbl_import_hdr");

                entity.Property(e => e.ImportHdrId).HasColumnName("ImportHdrID");

                entity.Property(e => e.ClientLogin)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Complete).HasMaxLength(10);

                entity.Property(e => e.ExecutionEnd).HasColumnType("datetime");

                entity.Property(e => e.ExecutionStart).HasColumnType("datetime");

                entity.Property(e => e.ImportTypeId).HasColumnName("ImportTypeID");

                entity.Property(e => e.ImportedFiles).IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblIntention>(entity =>
            {
                entity.HasKey(e => e.IntId);

                entity.ToTable("tbl_intention");

                entity.HasIndex(e => e.IntId)
                    .HasName("missing_index_1408_1407");

                entity.HasIndex(e => new { e.Deleted, e.WrapUpCode })
                    .HasName("idx_stream1_intention");

                entity.HasIndex(e => new { e.Deleted, e.FirstChoice, e.Id })
                    .HasName("idx_stream_int");

                entity.HasIndex(e => new { e.Id, e.IntId, e.Deleted })
                    .HasName("missing_index_1447_1446");

                entity.HasIndex(e => new { e.Intriding, e.Deleted, e.FirstChoice })
                    .HasName("index_intention1");

                entity.HasIndex(e => new { e.Intriding, e.Deleted, e.Id })
                    .HasName("tbl_intention3");

                entity.HasIndex(e => new { e.Intriding, e.Deleted, e.FirstChoice, e.PrimaryIssue })
                    .HasName("idx_intention");

                entity.Property(e => e.IntId).HasColumnName("IntID");

                entity.Property(e => e.Age).HasMaxLength(1);

                entity.Property(e => e.Callback).HasMaxLength(20);

                entity.Property(e => e.Deleted).HasMaxLength(15);

                entity.Property(e => e.FirstChoice).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Intriding)
                    .HasColumnName("intriding")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryIssue).HasMaxLength(150);

                entity.Property(e => e.SecondChoice).HasMaxLength(50);

                entity.Property(e => e.SecondaryIssue).HasMaxLength(50);

                entity.Property(e => e.Source).HasMaxLength(20);

                entity.Property(e => e.Tempid).HasColumnName("tempid");

                entity.Property(e => e.Timeprocess)
                    .HasColumnName("timeprocess")
                    .HasMaxLength(30);

                entity.Property(e => e.Userid).HasMaxLength(50);

                entity.Property(e => e.WrapUpCode).HasMaxLength(20);
            });

            modelBuilder.Entity<TblNotice>(entity =>
            {
                entity.ToTable("tbl_notice");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Listtext).HasColumnName("listtext");
            });

            modelBuilder.Entity<TblPollResultsIp>(entity =>
            {
                entity.HasKey(e => e.FdPollResultsIpid);

                entity.ToTable("tbl_PollResultsIP");

                entity.Property(e => e.FdPollResultsIpid).HasColumnName("fdPollResultsIPID");

                entity.Property(e => e.FdPollId).HasColumnName("fdPollID");

                entity.Property(e => e.FdPollResults)
                    .HasColumnName("fdPollResults")
                    .HasColumnType("ntext");

                entity.Property(e => e.FdPollResultsEmail)
                    .HasColumnName("fdPollResultsEmail")
                    .HasMaxLength(100);

                entity.Property(e => e.FdPollResultsIp)
                    .HasColumnName("fdPollResultsIP")
                    .HasMaxLength(50);

                entity.Property(e => e.FdPollResultsIpdate)
                    .HasColumnName("fdPollResultsIPDate")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<TblRoundCase>(entity =>
            {
                entity.HasKey(e => e.CaseId);

                entity.ToTable("tbl_roundCase");

                entity.Property(e => e.CaseId).HasColumnName("caseId");

                entity.Property(e => e.Attended).HasColumnName("attended");

                entity.Property(e => e.CaseBringForwardDate)
                    .HasColumnName("caseBringForwardDate")
                    .HasMaxLength(30);

                entity.Property(e => e.CaseClosedDate)
                    .HasColumnName("caseClosedDate")
                    .HasMaxLength(30);

                entity.Property(e => e.CaseDescription)
                    .HasColumnName("caseDescription")
                    .HasMaxLength(250);

                entity.Property(e => e.CaseDetail).HasColumnName("caseDetail");

                entity.Property(e => e.CaseOpenDate)
                    .HasColumnName("caseOpenDate")
                    .HasMaxLength(30);

                entity.Property(e => e.CaseRoundTableDate)
                    .HasColumnName("caseRoundTableDate")
                    .HasMaxLength(30);

                entity.Property(e => e.CaseStatus)
                    .HasColumnName("caseStatus")
                    .HasMaxLength(100);

                entity.Property(e => e.CaseSubType)
                    .HasColumnName("caseSubType")
                    .HasMaxLength(100);

                entity.Property(e => e.CaseType)
                    .HasColumnName("caseType")
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(50);

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasMaxLength(25);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasMaxLength(150);

                entity.Property(e => e.Riding)
                    .HasColumnName("riding")
                    .HasMaxLength(20);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasMaxLength(10);

                entity.Property(e => e.Timeprocess)
                    .HasColumnName("timeprocess")
                    .HasMaxLength(100);

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<TblRoundtablequeue>(entity =>
            {
                entity.HasKey(e => new { e.Caseid, e.Voterid });

                entity.ToTable("tbl_roundtablequeue");

                entity.Property(e => e.Caseid).HasColumnName("caseid");

                entity.Property(e => e.Voterid).HasColumnName("voterid");

                entity.Property(e => e.Locktime)
                    .HasColumnName("locktime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Riding)
                    .IsRequired()
                    .HasColumnName("riding")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblEmployees>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);

                entity.ToTable("tbl_Employees");

                entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");

                entity.Property(e => e.Attemptcount).HasColumnName("attemptcount");

                entity.Property(e => e.Riding)
                    .HasColumnName("riding")
                    .HasMaxLength(10);

                entity.Property(e => e.EmailAddress).HasMaxLength(100);

                entity.Property(e => e.EmployeeLogin).HasMaxLength(50);

                entity.Property(e => e.EmployeeName).HasMaxLength(100);

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

            modelBuilder.Entity<TblVoter>(entity =>
            {
                entity.ToTable("tbl_voter");

                entity.HasIndex(e => new { e.Occupation, e.Riding })
                    .HasName("Riding_Occupation");

                entity.HasIndex(e => new { e.Riding, e.Companyid })
                    .HasName("Riding_Company");

                entity.HasIndex(e => new { e.Riding, e.Email })
                    .HasName("idx_email");

                entity.HasIndex(e => new { e.Riding, e.Id })
                    .HasName("idx_voter");

                entity.HasIndex(e => new { e.Riding, e.SignedOut })
                    .HasName("signedout");

                entity.HasIndex(e => new { e.Riding, e.VoterId })
                    .HasName("vtrid_idx");

                entity.HasIndex(e => new { e.Status, e.Riding })
                    .HasName("missing_index_1487_1486");

                entity.HasIndex(e => new { e.Lastname, e.Status, e.Riding })
                    .HasName("missing_index_1462_1461");

                entity.HasIndex(e => new { e.Riding, e.Status, e.Id })
                    .HasName("idx_voter5")
                    .IsUnique();

                entity.HasIndex(e => new { e.Lastname, e.Poll, e.Status, e.Riding })
                    .HasName("missing_index_1466_1465");

                entity.HasIndex(e => new { e.Riding, e.Lastname, e.FirstName, e.StreetName, e.Poll, e.HomePhone, e.Score })
                    .HasName("idx_voter2");

                entity.HasIndex(e => new { e.Lastname, e.FirstName, e.UnitNo, e.StreetType, e.Poll, e.Seq, e.HomeArea, e.HomePhone, e.HouseNumber, e.StreetName, e.Zip, e.Riding, e.Id })
                    .HasName("missing_index_1275_1274");

                entity.HasIndex(e => new { e.Id, e.Lastname, e.FirstName, e.UnitNo, e.HouseNumber, e.StreetName, e.StreetType, e.City, e.Zip, e.Poll, e.Seq, e.HomeArea, e.HomePhone, e.Status, e.Riding })
                    .HasName("missing_index_1686_1685");

                entity.HasIndex(e => new { e.Id, e.Lastname, e.FirstName, e.UnitNo, e.HouseNumber, e.StreetName, e.StreetType, e.Poll, e.Seq, e.HomeArea, e.Score, e.SignedOut, e.Signedoutdate, e.Status, e.Riding, e.Dnc, e.HomePhone })
                    .HasName("missing_index_1374_1373");

                entity.HasIndex(e => new { e.Id, e.Lastname, e.FirstName, e.UnitNo, e.HouseNumber, e.StreetName, e.StreetType, e.Poll, e.Seq, e.HomeArea, e.SignedOut, e.Signedoutdate, e.Status, e.Riding, e.Dnc, e.HomePhone, e.Score })
                    .HasName("missing_index_1372_1371");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(2);

                entity.Property(e => e.Cellarea)
                    .HasColumnName("cellarea")
                    .HasMaxLength(6);

                entity.Property(e => e.Cellphone)
                    .HasColumnName("cellphone")
                    .HasMaxLength(8);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Class).HasMaxLength(15);

                entity.Property(e => e.Companyid).HasColumnName("companyid");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(100);

                entity.Property(e => e.Cust1)
                    .HasColumnName("cust1")
                    .HasMaxLength(30);

                entity.Property(e => e.Cust2)
                    .HasColumnName("cust2")
                    .HasMaxLength(30);

                entity.Property(e => e.Cust3)
                    .HasColumnName("cust3")
                    .HasMaxLength(30);

                entity.Property(e => e.Department).HasMaxLength(250);

                entity.Property(e => e.Dnc).HasColumnName("DNC");

                entity.Property(e => e.Dne).HasColumnName("DNE");

                entity.Property(e => e.Dnm).HasColumnName("DNM");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(125);

                entity.Property(e => e.Email2)
                    .HasColumnName("email2")
                    .HasMaxLength(250);

                entity.Property(e => e.Extension)
                    .HasColumnName("EXTENSION")
                    .HasMaxLength(10);

                entity.Property(e => e.FaxArea).HasMaxLength(15);

                entity.Property(e => e.FaxPhone).HasMaxLength(15);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.HomeArea).HasMaxLength(6);

                entity.Property(e => e.HomePhone).HasMaxLength(8);

                entity.Property(e => e.HouseNumber).HasMaxLength(20);

                entity.Property(e => e.Intaptno)
                    .HasColumnName("intaptno")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Intcellarea)
                    .HasColumnName("intcellarea")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Intcellcode)
                    .HasColumnName("intcellcode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Intcellphone)
                    .HasColumnName("intcellphone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Intcity)
                    .HasColumnName("intcity")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Intdirection)
                    .HasColumnName("intdirection")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Intfaxarea)
                    .HasColumnName("intfaxarea")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Intfaxcode)
                    .HasColumnName("intfaxcode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Intfaxphone)
                    .HasColumnName("intfaxphone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Inthomearea)
                    .HasColumnName("inthomearea")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Inthomecode)
                    .HasColumnName("inthomecode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Inthomephone)
                    .HasColumnName("inthomephone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Intpostalcode)
                    .HasColumnName("intpostalcode")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Intprovince)
                    .HasColumnName("intprovince")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Intstreetname)
                    .HasColumnName("intstreetname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Intstreetno)
                    .HasColumnName("intstreetno")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Intstreettype)
                    .HasColumnName("intstreettype")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Intworkarea)
                    .HasColumnName("intworkarea")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Intworkcode)
                    .HasColumnName("intworkcode")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Intworkextension)
                    .HasColumnName("intworkextension")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Intworkphone)
                    .HasColumnName("intworkphone")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Jobtitle).HasMaxLength(250);

                entity.Property(e => e.Language)
                    .HasColumnName("language")
                    .HasMaxLength(20);

                entity.Property(e => e.Lastbldgnum)
                    .HasColumnName("lastbldgnum")
                    .HasMaxLength(10);

                entity.Property(e => e.Lastname).HasMaxLength(255);

                entity.Property(e => e.Laststeetname)
                    .HasColumnName("laststeetname")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastzip)
                    .HasColumnName("lastzip")
                    .HasMaxLength(7);

                entity.Property(e => e.Matchid)
                    .HasColumnName("matchid")
                    .HasMaxLength(50);

                entity.Property(e => e.Middlename).HasMaxLength(255);

                entity.Property(e => e.Nickname).HasMaxLength(30);

                entity.Property(e => e.Occupation).HasMaxLength(150);

                entity.Property(e => e.PersonBusinessAddress)
                    .HasColumnName("personBusinessAddress")
                    .HasMaxLength(500);

                entity.Property(e => e.Poll).HasMaxLength(20);

                entity.Property(e => e.Riding).HasMaxLength(20);

                entity.Property(e => e.RoundCaseSubType)
                    .HasColumnName("roundCaseSubType")
                    .HasMaxLength(100);

                entity.Property(e => e.RuralAddress1).HasMaxLength(255);

                entity.Property(e => e.RuralAddress2).HasMaxLength(100);

                entity.Property(e => e.RuralCity).HasMaxLength(100);

                entity.Property(e => e.RuralState).HasMaxLength(2);

                entity.Property(e => e.Ruralzip).HasMaxLength(10);

                entity.Property(e => e.Salutation).HasMaxLength(10);

                entity.Property(e => e.Seq).HasMaxLength(20);

                entity.Property(e => e.SignedOut).HasMaxLength(12);

                entity.Property(e => e.Signedoutdate)
                    .HasColumnName("signedoutdate")
                    .HasMaxLength(25);

                entity.Property(e => e.Sin)
                    .HasColumnName("SIN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(30);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.StreetDirection).HasMaxLength(4);

                entity.Property(e => e.StreetName).HasMaxLength(255);

                entity.Property(e => e.StreetNumSfx).HasMaxLength(50);

                entity.Property(e => e.StreetType).HasMaxLength(9);

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Ucinumber)
                    .HasColumnName("ucinumber")
                    .HasMaxLength(255);

                entity.Property(e => e.UnitNo).HasMaxLength(50);

                entity.Property(e => e.VoterId)
                    .HasColumnName("VoterID")
                    .HasMaxLength(50);

                entity.Property(e => e.VoterId2)
                    .HasColumnName("VoterID2")
                    .HasMaxLength(50);

                entity.Property(e => e.VoterId3)
                    .HasColumnName("VoterID3")
                    .HasMaxLength(50);

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkArea).HasMaxLength(50);

                entity.Property(e => e.WorkPhone).HasMaxLength(100);

                entity.Property(e => e.Zip).HasMaxLength(50);
            });
        }
    }
}
