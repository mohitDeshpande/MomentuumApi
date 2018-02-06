/*    ==Scripting Parameters==

    Source Database Engine Edition : Microsoft Azure SQL Database Edition
    Source Database Engine Type : Microsoft Azure SQL Database

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [MobileDB]    Script Date: 2018-01-31 2:07:29 PM ******/
CREATE DATABASE [MobileDB]
GO
ALTER DATABASE [MobileDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MobileDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MobileDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MobileDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MobileDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MobileDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MobileDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MobileDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MobileDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MobileDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MobileDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MobileDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MobileDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MobileDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MobileDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MobileDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MobileDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MobileDB] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [MobileDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MobileDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [MobileDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MobileDB] SET  MULTI_USER 
GO
ALTER DATABASE [MobileDB] SET DB_CHAINING OFF 
GO

ALTER DATABASE [MobileDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [MobileDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO)
GO
USE [MobileDB]
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [MobileDB]
GO
/****** Object:  Table [dbo].[lst_casecode]    Script Date: 2018-01-31 2:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lst_casecode](
	[id] [nvarchar](20) NULL,
	[listtext] [nvarchar](50) NULL,
	[Code] [nvarchar](5) NULL,
	[refid] [int] NULL,
	[score] [int] NULL
)
GO
/****** Object:  Table [dbo].[lst_casestatus]    Script Date: 2018-01-31 2:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lst_casestatus](
	[id] [nvarchar](20) NULL,
	[listtext] [nvarchar](20) NULL,
	[Code] [nvarchar](5) NULL,
	[refid] [int] NULL,
	[score] [int] NULL
)
GO
/****** Object:  Table [dbo].[lst_casetype]    Script Date: 2018-01-31 2:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lst_casetype](
	[id] [nvarchar](20) NULL,
	[listtext] [nvarchar](70) NULL,
	[Code] [nvarchar](5) NULL,
	[refid] [int] NULL,
	[score] [int] NULL
)
GO
/****** Object:  Table [dbo].[lst_class]    Script Date: 2018-01-31 2:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lst_class](
	[listtext] [nvarchar](25) NULL,
	[ID] [nvarchar](20) NULL,
	[Code] [nvarchar](5) NULL,
	[refid] [int] NULL,
	[score] [int] NULL
)
GO
/****** Object:  Table [dbo].[lst_source]    Script Date: 2018-01-31 2:07:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lst_source](
	[listtext] [nvarchar](150) NULL,
	[listtext_fr] [nvarchar](250) NULL,
	[ID] [nvarchar](20) NULL,
	[Code] [nvarchar](5) NULL,
	[refid] [int] NULL,
	[score] [int] NULL
)
GO
/****** Object:  Table [dbo].[lst_status]    Script Date: 2018-01-31 2:07:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lst_status](
	[listtext] [nvarchar](20) NULL,
	[listtext_fr] [nvarchar](50) NULL,
	[id] [nvarchar](20) NULL,
	[refid] [int] NULL
)
GO
/****** Object:  Table [dbo].[lst_type]    Script Date: 2018-01-31 2:07:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[lst_type](
	[location_id] [int] IDENTITY(1,1) NOT NULL,
	[listtext] [nvarchar](255) NULL,
	[id] [nvarchar](20) NULL,
	[refid] [int] NULL,
	[score] [int] NULL,
	[code] [nchar](10) NULL,
 CONSTRAINT [PK_lst_type] PRIMARY KEY CLUSTERED 
(
	[location_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
/****** Object:  Table [dbo].[tbl_case]    Script Date: 2018-01-31 2:07:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_case](
	[id] [int] NULL,
	[caseid] [int] IDENTITY(1,1) NOT NULL,
	[caseOpenDate] [datetime] NULL,
	[casetype] [nvarchar](25) NULL,
	[casedescription] [nvarchar](2000) NULL,
	[casestatus] [nvarchar](300) NULL,
	[caseAssignedTo] [nvarchar](25) NULL,
	[caseNature] [nvarchar](max) NULL,
	[CaseClosedDate] [datetime] NULL,
	[CaseCode] [nvarchar](50) NULL,
	[CaseSource] [nvarchar](25) NULL,
	[deleted] [nvarchar](25) NULL,
	[timeprocess] [datetime] NULL,
	[userid] [nvarchar](25) NULL,
	[createdby] [nvarchar](255) NULL,
	[createddate] [nvarchar](255) NULL,
	[updateddate] [nvarchar](255) NULL,
 CONSTRAINT [PK_tbl_case] PRIMARY KEY CLUSTERED 
(
	[caseid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
/****** Object:  Table [dbo].[tbl_client]    Script Date: 2018-01-31 2:07:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_client](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](15) NULL,
	[Class] [nvarchar](25) NULL,
	[Status] [nvarchar](15) NULL,
	[Lastname] [nvarchar](60) NULL,
	[FirstName] [nvarchar](60) NULL,
	[Middlename] [nvarchar](30) NULL,
	[MaidenName] [nvarchar](60) NULL,
	[AlsoKnownAs] [nvarchar](60) NULL,
	[MaritalStatus] [nvarchar](50) NULL,
	[SpouseFirstName] [nvarchar](60) NULL,
	[SpouseMiddleName] [nvarchar](30) NULL,
	[SpouseLastName] [nvarchar](60) NULL,
	[SpouseMaidenName] [nvarchar](60) NULL,
	[SpouseAlsoKnownAs] [nvarchar](60) NULL,
	[AddressLine1] [nvarchar](150) NULL,
	[AddressLine2] [nvarchar](150) NULL,
	[City] [nvarchar](100) NULL,
	[State] [nvarchar](50) NULL,
	[Zip] [nvarchar](10) NULL,
	[division] [nvarchar](20) NULL,
	[filename] [nvarchar](80) NULL,
	[MainPhone] [nvarchar](20) NULL,
	[MainPhoneType] [nvarchar](20) NULL,
	[HomeArea] [nvarchar](3) NULL,
	[HomePhone] [nvarchar](8) NULL,
	[EXTENSION] [nvarchar](10) NULL,
	[WorkArea] [nvarchar](5) NULL,
	[WorkPhone] [nvarchar](15) NULL,
	[FaxArea] [nvarchar](15) NULL,
	[FaxPhone] [nvarchar](15) NULL,
	[EMail] [nvarchar](125) NULL,
	[Score] [int] NULL,
	[SignedOut] [nvarchar](12) NULL,
	[Complete] [int] NULL,
	[cust1] [nvarchar](30) NULL,
	[cust2] [nvarchar](30) NULL,
	[cust3] [nvarchar](30) NULL,
	[DNC] [bit] NULL,
	[DNM] [bit] NULL,
	[DNE] [bit] NULL,
	[SIN] [int] NULL,
	[DOB] [datetime] NULL,
	[PreferredContact] [nvarchar](100) NULL,
	[created_by] [nvarchar](50) NULL,
	[created_date] [datetime] NULL,
	[last_modified_by] [nvarchar](50) NULL,
	[last_modified_timestamp] [datetime] NULL,
	[seq] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbl_client] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
/****** Object:  Table [dbo].[tbl_client_admin_info]    Script Date: 2018-01-31 2:07:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_client_admin_info](
	[ClientAdminInfoID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[Division] [nvarchar](50) NULL,
	[SignupDate] [datetime] NULL,
	[InsolvencyDate] [datetime] NULL,
	[InitialContact] [datetime] NULL,
	[DateAppointed] [datetime] NULL,
	[IIMeetingOn] [datetime] NULL,
	[DateSent] [datetime] NULL,
	[45Days] [datetime] NULL,
	[DateDeemedAccepted] [datetime] NULL,
	[Trustee] [nvarchar](500) NULL,
	[EstateAdministrator] [nvarchar](500) NULL,
	[Technician] [nvarchar](500) NULL,
	[InitialInterview] [nvarchar](500) NULL,
	[FileAdminVersion] [nvarchar](500) NULL,
	[CourtName] [nvarchar](500) NULL,
	[CourtNumber] [nvarchar](500) NULL,
	[DivisionNumber] [nvarchar](500) NULL,
	[District] [nvarchar](500) NULL,
	[Location] [nvarchar](500) NULL,
	[FileMgr] [nvarchar](500) NULL,
	[Status] [nvarchar](500) NULL,
	[CreatedDate] [datetime] NULL,
	[MeetingDate] [datetime] NULL,
	[IntakeAgent] [nvarchar](500) NULL,
	[FilingAgent] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientAdminInfoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
/****** Object:  Table [dbo].[tbl_client_phone]    Script Date: 2018-01-31 2:07:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_client_phone](
	[ClientPhoneID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NULL,
	[DisplayOrder] [int] NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[PhoneType] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientPhoneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
/****** Object:  Table [dbo].[tbl_client_source]    Script Date: 2018-01-31 2:07:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_client_source](
	[ClientSourceID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NOT NULL,
	[SourceCode] [nvarchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[ClientSourceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
/****** Object:  Table [dbo].[tbl_emailattachment]    Script Date: 2018-01-31 2:07:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_emailattachment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TemplateId] [int] NULL,
	[FilePathUrl] [nvarchar](1000) NULL,
	[Division] [nvarchar](50) NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_tbl_emailattachment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
/****** Object:  Table [dbo].[tbl_Employees]    Script Date: 2018-01-31 2:07:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Employees](
	[Employee_ID] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [datetime] NULL,
	[EndDate] [datetime] NULL,
	[EmployeeLogin] [nvarchar](50) NULL,
	[EmployeeName] [nvarchar](100) NULL,
	[EmailAddress] [nvarchar](100) NULL,
	[usrPassword] [nvarchar](20) NULL,
	[Active] [bit] NULL,
	[attemptcount] [int] NULL,
	[LastLogin] [datetime] NULL,
	[HomePhone] [nvarchar](11) NULL,
	[MobilePhone] [nvarchar](11) NULL,
	[WorkPhone] [nvarchar](11) NULL,
	[WorkPhoneExt] [nvarchar](5) NULL,
	[division] [nvarchar](10) NULL,
 CONSTRAINT [PK_tbl_Employees] PRIMARY KEY CLUSTERED 
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
/****** Object:  Table [dbo].[tbl_location_address]    Script Date: 2018-01-31 2:07:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_location_address](
	[location_address_id] [int] IDENTITY(1,1) NOT NULL,
	[location_id] [int] NOT NULL,
	[division] [nvarchar](10) NOT NULL,
	[address1] [nvarchar](100) NOT NULL,
	[address2] [nvarchar](100) NULL,
	[city] [nvarchar](100) NOT NULL,
	[state] [nvarchar](100) NOT NULL,
	[zip] [nvarchar](50) NOT NULL,
	[modified_by] [int] NOT NULL,
	[modified_date] [datetime] NOT NULL,
	[created_by] [int] NOT NULL,
	[created_date] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[location_address_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
/****** Object:  Table [dbo].[tbl_log]    Script Date: 2018-01-31 2:07:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_log](
	[luserid] [nvarchar](50) NULL,
	[lpassword] [nvarchar](50) NULL,
	[ltimestamp] [nvarchar](50) NULL,
	[logip] [nvarchar](50) NULL
)
GO
/****** Object:  Table [dbo].[tbl_logtrans]    Script Date: 2018-01-31 2:07:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_logtrans](
	[luserid] [nvarchar](50) NULL,
	[lpassword] [nvarchar](50) NULL,
	[ltimestamp] [nvarchar](50) NULL,
	[logip] [nvarchar](50) NULL,
	[url] [nvarchar](250) NULL,
	[querystring] [nvarchar](250) NULL,
	[sessionid] [nvarchar](30) NULL
)
GO
/****** Object:  Table [dbo].[Tbl_ltrTemplate]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tbl_ltrTemplate](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TimeCreated] [datetime] NOT NULL,
	[TemplateName] [varchar](128) NOT NULL,
	[TemplateDescription] [varchar](256) NULL,
	[Templatebody] [varchar](2048) NULL,
	[TemplateHeader] [varchar](1024) NULL,
	[TemplateFooter] [varchar](1024) NULL,
	[division] [nvarchar](50) NULL
)
GO
/****** Object:  Table [dbo].[tbl_plan]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_plan](
	[plan_id] [int] IDENTITY(1,1) NOT NULL,
	[division] [nvarchar](10) NOT NULL,
	[client_id] [int] NOT NULL,
	[parent_plan_id] [int] NOT NULL,
	[child_plan_id] [int] NOT NULL,
	[plan_amount] [decimal](18, 2) NOT NULL,
	[balance] [decimal](18, 2) NOT NULL,
	[total_fees] [decimal](18, 2) NOT NULL,
	[start_date] [datetime] NOT NULL,
	[end_date] [datetime] NOT NULL,
	[bank] [nvarchar](50) NOT NULL,
	[bank_transit_no] [varchar](5) NOT NULL,
	[bank_institute_no] [varchar](3) NOT NULL,
	[bank_designation_no] [varchar](50) NOT NULL,
	[bank_account_no] [varchar](12) NOT NULL,
	[plan_type] [varchar](3) NOT NULL,
	[status] [varchar](1) NOT NULL,
	[payment_date] [datetime] NULL,
	[modified_employee_id] [int] NOT NULL,
	[modified_date] [datetime] NOT NULL,
	[created_employee_id] [int] NOT NULL,
	[created_date] [datetime] NOT NULL,
 CONSTRAINT [PK_tbl_proposal] PRIMARY KEY CLUSTERED 
(
	[plan_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

/****** Object:  Table [dbo].[tbl_caseitem]    Script Date: 2018-01-31 2:12:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tbl_caseitem](
	[caseid] [int] NULL,
	[intid] [int] IDENTITY(1,1) NOT NULL,
	[caseitemdate] [nvarchar](25) NULL,
	[caseitemdescription] [nvarchar](150) NULL,
	[caseitemstatus] [nvarchar](25) NULL,
	[caseitemdetail] [nvarchar](4000) NULL,
	[caseitemaction] [nvarchar](25) NULL,
	[caseitemassigned] [nvarchar](25) NULL,
	[caseitemfollowupdate] [nvarchar](25) NULL,
	[deleted] [nvarchar](25) NULL,
	[userid] [nvarchar](25) NULL,
	[timeprocess] [nvarchar](25) NULL,
	[priority] [nvarchar](50) NULL,
	[createdby] [nvarchar](255) NULL,
	[createddate] [nvarchar](255) NULL,
	[updateddate] [nvarchar](255) NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[tbl_caseitem] ADD  CONSTRAINT [CASEITEM_CREATE_DATE_DEFAULTE]  DEFAULT (getdate()) FOR [createddate]
GO

ALTER TABLE [dbo].[tbl_caseitem] ADD  CONSTRAINT [CASEITEM_UPDATE_DATE_DEFAULTE]  DEFAULT (getdate()) FOR [updateddate]
GO


ALTER TABLE [dbo].[tbl_case] ADD  CONSTRAINT [CREATE_DATE_DEFAULTE]  DEFAULT (getdate()) FOR [createddate]
GO
ALTER TABLE [dbo].[tbl_case] ADD  CONSTRAINT [UPDATE_DATE_DEFAULTE]  DEFAULT (getdate()) FOR [updateddate]
GO
ALTER TABLE [dbo].[tbl_client] ADD  CONSTRAINT [DF_tbl_client2_DNC]  DEFAULT ((0)) FOR [DNC]
GO
ALTER TABLE [dbo].[tbl_client] ADD  CONSTRAINT [DF_tbl_client2_DNM]  DEFAULT ((0)) FOR [DNM]
GO
ALTER TABLE [dbo].[tbl_client] ADD  CONSTRAINT [DF_tbl_client2_DNE]  DEFAULT ((0)) FOR [DNE]
GO
ALTER TABLE [dbo].[tbl_client] ADD  CONSTRAINT [DF_tbl_client_PreferredContact]  DEFAULT (N'main') FOR [PreferredContact]
GO
ALTER TABLE [dbo].[tbl_client] ADD  DEFAULT (getdate()) FOR [created_date]
GO
ALTER TABLE [dbo].[tbl_client] ADD  DEFAULT (getdate()) FOR [last_modified_timestamp]
GO
ALTER TABLE [dbo].[tbl_emailattachment] ADD  CONSTRAINT [DF_tbl_emailattachment_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[tbl_location_address] ADD  DEFAULT (getdate()) FOR [modified_date]
GO
ALTER TABLE [dbo].[tbl_location_address] ADD  DEFAULT (getdate()) FOR [created_date]
GO
ALTER TABLE [dbo].[tbl_plan] ADD  CONSTRAINT [DF_tbl_plan_parent_plan_id]  DEFAULT ((0)) FOR [parent_plan_id]
GO
ALTER TABLE [dbo].[tbl_plan] ADD  CONSTRAINT [DF_tbl_plan_child_plan_id]  DEFAULT ((0)) FOR [child_plan_id]
GO
ALTER TABLE [dbo].[tbl_case]  WITH CHECK ADD  CONSTRAINT [FK_tbl_case_tbl_client] FOREIGN KEY([id])
REFERENCES [dbo].[tbl_client] ([ID])
GO
ALTER TABLE [dbo].[tbl_case] CHECK CONSTRAINT [FK_tbl_case_tbl_client]
GO
/****** Object:  StoredProcedure [dbo].[CreateCase]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[CreateCase]
 @id			   int,      
 @caseopendate     nvarchar(25) = null,
 @casetype         nvarchar(25) = null,
 @casedescription   nvarchar(150)= null,
 @casestatus       nvarchar(15) = null,
 @casenssignedto   nvarchar(25) = null,
 @casenature       nvarchar(max) = null,
 @casecloseddate   nvarchar(25) = null,
 @casecode         nvarchar(50) = null,
 @userid           nvarchar(25) = null,  
 @createdby        nvarchar(25) = null,
 @casefollowupdate DateTime = null,
 @timeprocess      nvarchar(25) = null
AS
BEGIN
	
	SET NOCOUNT ON;

	INSERT INTO [dbo].[tbl_case]
           ([id]           
           ,[caseOpenDate]
           ,[casetype]
           ,[casedescription]
           ,[casestatus]
           ,[caseAssignedTo]
           ,[caseNature]
           ,[CaseClosedDate]
           ,[CaseCode]           
           ,[deleted]
           ,[timeprocess]
           ,[userid]
           ,[createdby]           
           ,[updateddate])
     VALUES
     (@id           
      ,@caseopendate
      ,@casetype
      ,@casedescription
      ,@casestatus
      ,@casenssignedto
      ,@casenature
      ,@casecloseddate
      ,@casecode        
      ,'false'
      ,@timeprocess
      ,@userid
      ,@createdby     
      ,getdate()      
      )

	  SELECT CAST(scope_identity() AS int)
    
END
GO
/****** Object:  StoredProcedure [dbo].[loginlogip]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[loginlogip]  @struserID varchar(15), @strpassword varchar(25), @logip varchar(25)
 AS 
INSERT INTO tbl_log (luserid, lpassword, ltimestamp, logip)  VALUES (@struserID,@strpassword,CONVERT(char(30), CURRENT_TIMESTAMP)
,@logip)

GO
/****** Object:  StoredProcedure [dbo].[loginlogtrans]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[loginlogtrans]  @struserID varchar(15), @strpassword varchar(25), @logip varchar(25),@url varchar(250),@querystring varchar(250),@sessionid varchar(250)
 AS 
 DECLARE @CURRENT_DT_TIME CHAR(30)
 SET @CURRENT_DT_TIME=CONVERT(char(30), CURRENT_TIMESTAMP)

INSERT INTO tbl_logtrans (luserid, lpassword, ltimestamp, logip,url,querystring,sessionid) 
VALUES					 (@struserID,@strpassword,@CURRENT_DT_TIME,@logip,@url,@querystring,@sessionid)
GO
/****** Object:  StoredProcedure [dbo].[sp_employeebylogin]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO

CREATE PROCEDURE [dbo].[sp_employeebylogin] @loginname varchar(50)
 AS 
SELECT * FROM tbl_employees WHERE (employeelogin = @loginname)

GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO
CREATE PROCEDURE [dbo].[sp_login] @username varchar(50)
 AS 
update tbl_employees set attemptcount = 0 where employeelogin = @username
UPDATE tbl_employees SET lastlogin = getdate() WHERE employeelogin = @username

select Employee_id from tbl_employees where employeelogin = @username
GO
/****** Object:  StoredProcedure [dbo].[sp_pop]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_pop] @ridingname varchar(10), @num as int
 AS 
if @num = 0
begin
 if not exists(select listtext from lst_type where id = @ridingname)
   begin
    select listtext from  lst_type where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_type where id = @ridingname order by refid
   end
end
if @num = 1
begin
 if not exists(select listtext from lst_class where id = @ridingname)
   begin
    select listtext from  lst_class where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_class where id = @ridingname order by refid
   end
end
if @num = 2
begin
 if not exists(select listtext from lst_status where id = @ridingname)
   begin
    select listtext from  lst_status where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_status where id = @ridingname order by refid
   end
end
if @num = 3
begin
 if not exists(select listtext from lst_wrapupcode where id = @ridingname)
   begin
    select listtext from  lst_wrapupcode where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_wrapupcode where id = @ridingname order by refid
   end
end
if @num = 4
begin
 if not exists(select listtext from lst_intention where id = @ridingname)
   begin
    select listtext from  lst_intention where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_intention where id = @ridingname order by refid
   end
end
if @num = 5
begin
 if not exists(select listtext from lst_issue where id = @ridingname)
   begin
    select listtext from  lst_issue where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_issue where id = @ridingname order by refid
   end
end
if @num = 6
begin
 if not exists(select listtext from lst_checklist where id = @ridingname)
   begin
    select listtext from  lst_checklist where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_checklist where id = @ridingname order by refid
   end
end
if @num = 7
begin
 if not exists(select listtext from lst_activity where id = @ridingname)
   begin
    select listtext from  lst_activity where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_activity where id = @ridingname order by refid
   end
end
if @num = 8
begin
 if not exists(select listtext from lst_donorstatus where id = @ridingname)
   begin
    select listtext from  lst_donorstatus where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_donorstatus where id = @ridingname order by refid
   end
end
if @num = 9
begin
 if not exists(select listtext from lst_donorcode where id = @ridingname)
   begin
    select listtext from  lst_donorcode where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_donorcode where id = @ridingname order by refid
   end
end
if @num = 10
begin
 if not exists(select listtext from lst_notecode where id = @ridingname)
   begin
    select listtext from  lst_notecode where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_notecode where id = @ridingname order by refid
   end
end
if @num = 11
begin
 if not exists(select listtext from lst_salutation where id = @ridingname)
   begin
    select listtext from  lst_salutation where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_salutation where id = @ridingname order by refid
   end
end
if @num = 12
begin
 if not exists(select listtext from lst_suffix where id = @ridingname)
   begin
    select listtext from  lst_suffix where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_suffix where id = @ridingname order by refid
   end
end
if @num = 13
begin
 if not exists(select listtext from lst_streettype where id = @ridingname)
   begin
    select listtext from  lst_streettype where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_streettype where id = @ridingname order by refid
   end
end
if @num = 14
begin
 if not exists(select listtext from lst_direction where id = @ridingname)
   begin
    select listtext from  lst_direction where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_direction where id = @ridingname order by refid
   end
end
if @num = 15
begin
 if not exists(select listtext from lst_province where id = @ridingname)
   begin
    select listtext from  lst_province where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_province where id = @ridingname order by refid
   end
end
if @num = 16
begin
 if not exists(select listtext from lst_cust1 where id = @ridingname)
   begin
    select listtext from  lst_cust1 where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_cust1 where id = @ridingname order by refid
   end
end
if @num = 17
begin
 if not exists(select listtext from lst_cust2 where id = @ridingname)
   begin
    select listtext from  lst_cust2 where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_cust2 where id = @ridingname order by refid
   end
end
if @num = 18
begin
 if not exists(select listtext from lst_cust3 where id = @ridingname)
   begin
    select listtext from  lst_cust3 where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_cust3 where id = @ridingname order by refid
   end
end

if @num = 19
begin
 if not exists(select listtext from lst_docname where id = @ridingname)
   begin
    select listtext from  lst_docname where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_docname where id = @ridingname order by refid
   end
end

if @num = 20
begin
 if not exists(select listtext from lst_casecode where id = @ridingname)
   begin
    select listtext from  lst_casecode where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_casecode where id = @ridingname order by refid
   end
end

if @num = 21
begin
 if not exists(select listtext from lst_casetype where id = @ridingname)
   begin
    select listtext from  lst_casetype where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_casetype where id = @ridingname order by refid
   end
end

if @num = 22
begin
 if not exists(select listtext from lst_casestatus where id = @ridingname)
   begin
    select listtext from  lst_casestatus where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_casestatus where id = @ridingname order by refid
   end
end

if @num = 23
begin
 if not exists(select listtext from lst_shift where id = @ridingname)
   begin
    select listtext from  lst_shift where id = '0000' 
   end
   else
   begin
     select listtext from  lst_shift where id = @ridingname 
   end
end

if @num = 24
begin
 if not exists(select listtext from lst_dispurseaccount where id = @ridingname)
   begin
    select listtext from  lst_dispurseaccount where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_dispurseaccount where id = @ridingname order by refid
   end
end


if @num = 25
begin
 if not exists(select listtext from lst_dispursecode where id = @ridingname)
   begin
    select listtext from  lst_dispursecode where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_dispursecode where id = @ridingname order by refid
   end
end

if @num = 26
begin
 if not exists(select listtext from lst_caseitemaction where id = @ridingname)
   begin
    select listtext from  lst_caseitemaction where id = '0000' order by refid
   end
   else
   begin
     select listtext from  lst_caseitemaction where id = @ridingname order by refid
   end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_update_atempt_count]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_update_atempt_count] 
	@employeeLogin nvarchar(100)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	declare @attemptCount int
	set @attemptCount = 0

	select @attemptCount = attemptCount from tbl_employees where employeelogin =  @employeeLogin

	if (@attemptCount+1 > 3) begin
		set @attemptCount = @attemptCount + 1
		update tbl_employees
		set [Active] = 0
		where employeelogin = @employeeLogin

	end else begin
		set @attemptCount = @attemptCount + 1
		update tbl_employees
		set attemptCount = @attemptCount
		where employeelogin = @employeeLogin
	end

	select @attemptCount as attemptCount
   
END
GO
/****** Object:  StoredProcedure [dbo].[usp_agents__find_by_location]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_agents__find_by_location]
	@prm_division		NVARCHAR(50),
	@prm_location_id	INT
AS
BEGIN
	
	SELECT
		a.[employee_id],
		a.[EmployeeLogin] AS [employee_login],
		a.[employeename] AS [name],
		c.[email],
		c.[password]
	FROM
		[dbo].[tbl_employees] a WITH (NOLOCK)
	INNER JOIN
		[dbo].[tbl_agent_location] b WITH (NOLOCK)
	ON
		b.[employee_id] = a.[Employee_ID]
	INNER JOIN 
		[dbo].[tbl_agent_email] c WITH (NOLOCK)
	ON
		c.[employee_id] = b.[employee_id]
	WHERE
		a.[division] = @prm_division
	AND
		b.[location_id] = @prm_location_id
	ORDER BY
		a.[EmployeeName]

END
GO
/****** Object:  StoredProcedure [dbo].[usp_case_code__get_all]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[usp_case_code__get_all]
	@prm_division	nvarchar(50)
AS
BEGIN

	IF NOT EXISTS (SELECT 1 FROM [dbo].[lst_casecode] WITH (NOLOCK) WHERE [id] = @prm_division)
	SET @prm_division = '0000'
	
	SELECT
		[id],
		[listtext],
		[Code],
		[refid],
		[score]
	FROM
		[dbo].[lst_casecode] WITH (NOLOCK)
	WHERE
		id = @prm_division
	ORDER BY
		[refid]

END
GO
/****** Object:  StoredProcedure [dbo].[usp_case_status__get_all]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[usp_case_status__get_all]
	@prm_division	nvarchar(50)
AS
BEGIN

	IF NOT EXISTS (SELECT 1 FROM [dbo].[lst_casestatus] WITH (NOLOCK) WHERE [id] = @prm_division)
	SET @prm_division = '0000'
	
	SELECT
		[id],
		[listtext],
		[Code],
		[refid]
	FROM
		[dbo].[lst_casestatus] WITH (NOLOCK)
	WHERE
		id = @prm_division
	ORDER BY
		[refid]

END
GO
/****** Object:  StoredProcedure [dbo].[usp_case_type__get_all]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[usp_case_type__get_all]
	@prm_division	nvarchar(50)
AS
BEGIN

	IF NOT EXISTS (SELECT 1 FROM [dbo].[lst_casetype] WITH (NOLOCK) WHERE [id] = @prm_division)
	SET @prm_division = '0000'
	
	SELECT
		[id],
		[listtext],
		[Code],
		[refid],
		[score]
	FROM
		[dbo].[lst_casetype] WITH (NOLOCK)
	WHERE
		id = @prm_division
	ORDER BY
		[refid]

END
GO
/****** Object:  StoredProcedure [dbo].[usp_client__add]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_client__add]
	@Division	NVARCHAR(50),
	@FirstName	NVARCHAR(60),
	@MiddleName	NVARCHAR(30),
	@LastName	NVARCHAR(60),
	@MaidenName	NVARCHAR(60),
	@AlsoKnownAs	NVARCHAR(60),
	@MaritalStatus	NVARCHAR(50),
	@SpouseFirstName	NVARCHAR(60),
	@SpouseMiddleName	NVARCHAR(30),
	@SpouseLastName	NVARCHAR(60),
	@SpouseMaidenName	NVARCHAR(60),
	@SpouseAlsoKnownAs	NVARCHAR(60),
	@MainPhone	NVARCHAR(20),
	@MainPhoneType	NVARCHAR(10),
	@Email	NVARCHAR(125),
	@AddressLine1	NVARCHAR(150),
	@AddressLine2	NVARCHAR(150),
	@City	NVARCHAR(100),
	@Province	NVARCHAR(100),
	@PostalCode	NVARCHAR(20),
	@DNC	BIT,
	@DNM	BIT,
	@DNE	BIT,
	@ScheduleDate	NVARCHAR(30) = NULL,
	@ScheduleTime	NVARCHAR(30) = NULL,
	@Type	NVARCHAR(15) =	NULL,
	@Class	NVARCHAR(25) =	NULL,
	@PreferredContact	NVARCHAR(100) = NULL,
	@CreatedBy	INT
AS
BEGIN

	INSERT INTO [dbo].[tbl_client]
	(		
		[Lastname]
		,[FirstName]
		,[Middlename]
		,[MaidenName]
		,[AlsoKnownAs]
		,[MaritalStatus]
		,[SpouseFirstName]
		,[SpouseMiddleName]
		,[SpouseLastName]
		,[SpouseMaidenName]
		,[SpouseAlsoKnownAs]
		,[AddressLine1]
		,[AddressLine2]
		,[City]
		,[State]
		,[Zip]
		,[division]
		,[filename]
		,[MainPhone]
		,[MainPhoneType]
		,[EMail]
		,[cust1]
		,[cust2]
		,[cust3]
		,[DNC]
		,[DNM]
		,[DNE]
		,[Type]
		,[Class]
		,[PreferredContact]
		,[created_by]
	)
	SELECT
		@Lastname
		,@FirstName
		,@Middlename
		,@MaidenName
		,@AlsoKnownAs
		,@MaritalStatus
		,@SpouseFirstName
		,@SpouseMiddleName
		,@SpouseLastName
		,@SpouseMaidenName
		,@SpouseAlsoKnownAs
		,@AddressLine1
		,@AddressLine2
		,@City
		,@Province
		,@PostalCode
		,@division
		,LTRIM(RTRIM(REPLACE(@LastName, '''', '') + REPLACE(@FirstName, '''', '')))		
		,@MainPhone
		,@MainPhoneType
		,@EMail
		,@ScheduleDate
		,@ScheduleDate
		,@ScheduleTime
		,@DNC
		,@DNM
		,@DNE
		,@Type
		,@Class
		,@PreferredContact
		,ISNULL((SELECT [EmployeeLogin] FROM [dbo].[tbl_employees] WITH (NOLOCK) WHERE [Employee_ID] = @CreatedBy), '')	

	SELECT CONVERT(INT, @@IDENTITY) AS [ID]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_client__find_by_id]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_client__find_by_id]
	@Division	NVARCHAR(50),
	@ClientID	INT
AS
BEGIN

	SELECT * FROM [dbo].[tbl_client] WITH (NOLOCK) WHERE [ID] = @ClientID AND [division] = @Division

	SELECT * FROM [dbo].[tbl_client_phone] WITH (NOLOCK) WHERE [ClientID] = @ClientID ORDER BY [DisplayOrder]

	SELECT * FROM [dbo].[tbl_client_admin_info] WITH (NOLOCK) WHERE [ClientID] = @ClientID
	
END
GO
/****** Object:  StoredProcedure [dbo].[usp_client__update]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[usp_client__update]
	@ClientID	INT,
	@Division	NVARCHAR(50) = NULL,
	@Filename	NVARCHAR(60) = NULL,
	@EstateNumber	NVARCHAR(50) = NULL,
	@FirstName	NVARCHAR(60),
	@MiddleName	NVARCHAR(30) = NULL,
	@LastName	NVARCHAR(60),
	@MaidenName	NVARCHAR(60) = NULL,
	@AlsoKnownAs	NVARCHAR(60) = NULL,
	@MaritalStatus	NVARCHAR(50) = NULL,
	@SpouseFirstName	NVARCHAR(60) = NULL,
	@SpouseMiddleName	NVARCHAR(30) = NULL,
	@SpouseLastName	NVARCHAR(60) = NULL,
	@SpouseMaidenName	NVARCHAR(60) = NULL,
	@SpouseAlsoKnownAs	NVARCHAR(60) = NULL,
	@MainPhone	NVARCHAR(20),
	@MainPhoneType	NVARCHAR(10),
	@Email	NVARCHAR(125) = NULL,
	@AddressLine1	NVARCHAR(150) = NULL,
	@AddressLine2	NVARCHAR(150) = NULL,
	@City	NVARCHAR(100) = NULL,
	@Province	NVARCHAR(100) = NULL,
	@PostalCode	NVARCHAR(20) = NULL,
	@DNC	BIT,
	@DNM	BIT,
	@DNE	BIT,
	@Gender	NVARCHAR(50) = NULL,
	@DOB	DATETIME = NULL,
	@PreferredContact	NVARCHAR(100) = NULL
AS
BEGIN

	UPDATE 
		[dbo].[tbl_client]
	SET 	
		[Filename] = @Filename,
		[Seq] = @EstateNumber,
		[FirstName] = @FirstName,
		[MiddleName] = @MiddleName,
		[LastName] = @LastName,
		[MaidenName] = @MaidenName,
		[AlsoKnownAs] = @AlsoKnownAs,
		[MaritalStatus] = @MaritalStatus,
		[SpouseFirstName] = @SpouseFirstName,
		[SpouseMiddleName] = @SpouseMiddleName,
		[SpouseLastName] = @SpouseLastName,
		[SpouseMaidenName] = @SpouseMaidenName,
		[SpouseAlsoKnownAs] = @SpouseAlsoKnownAs,
		[MainPhone] = @MainPhone,
		[MainPhoneType] = @MainPhoneType,
		[EMail] = @Email,
		[AddressLine1] = @AddressLine1,
		[AddressLine2] = @AddressLine2,
		[City] = @City,
		[State] = @Province,
		[Zip] = @PostalCode,
		[DNC] = @DNC,
		[DNM] = @DNM,
		[DNE] = @DNE,		
		[DOB] = @DOB,
		[PreferredContact] = @PreferredContact
	WHERE 
		[ID] = @ClientID

END
GO
/****** Object:  StoredProcedure [dbo].[usp_client_info__add]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create PROCEDURE [dbo].[usp_client_info__add]
	@ClientID	INT,
	@Division	NVARCHAR(50) = NULL,
	@SignupDate	DATETIME = NULL,
	@InsolvencyDate	DATETIME = NULL,
	@InitialContact	DATETIME = NULL,
	@DateAppointed	DATETIME = NULL,
	@IIMeetingOn	DATETIME = NULL,
	@DateSent	DATETIME = NULL,
	@45Days	DATETIME = NULL,
	@DateDeemedAccepted	DATETIME = NULL,
	@Trustee	NVARCHAR(500) = NULL,
	@EstateAdministrator	NVARCHAR(500) = NULL,
	@Technician	NVARCHAR(500) = NULL,
	@InitialInterview	NVARCHAR(500) = NULL,
	@FileAdminVersion	NVARCHAR(500) = NULL,
	@CourtName	NVARCHAR(500) = NULL,
	@CourtNumber	NVARCHAR(500) = NULL,
	@DivisionNumber	NVARCHAR(500) = NULL,
	@District	NVARCHAR(500) = NULL,
	@Location	NVARCHAR(500) = NULL,
	@FileMgr	NVARCHAR(500) = NULL,
	@Status	NVARCHAR(500) = NULL,
	@CreatedDate	DATETIME = NULL,
	@MeetingDate	DATETIME = NULL,
	@IntakeAgent	NVARCHAR(500) = NULL,
	@FilingAgent	NVARCHAR(500) = NULL
AS
BEGIN

	IF EXISTS (SELECT 1 FROM [dbo].[tbl_client_admin_info] WHERE [ClientID] = @ClientID)
	BEGIN

		UPDATE 
			[dbo].[tbl_client_admin_info]
		SET
			[Division] = @Division,
			[SignupDate] = @SignupDate,
			[InsolvencyDate] = @InsolvencyDate,
			[InitialContact] = @InitialContact,
			[DateAppointed] = @DateAppointed,
			[IIMeetingOn] = @IIMeetingOn,
			[DateSent] = @DateSent,
			[45Days] = @45Days,
			[DateDeemedAccepted] = @DateDeemedAccepted,
			[Trustee] = @Trustee,
			[EstateAdministrator] = @EstateAdministrator,
			[Technician] = @Technician,
			[InitialInterview] = @InitialInterview,
			[FileAdminVersion] = @FileAdminVersion,
			[CourtName] = @CourtName,
			[CourtNumber] = @CourtNumber,
			[DivisionNumber] = @DivisionNumber,
			[District] = @District,
			[Location] = @Location,
			[FileMgr] = @FileMgr,
			[Status] = @Status,
			[CreatedDate] = @CreatedDate,
			[MeetingDate] = @MeetingDate,
			[IntakeAgent] = @IntakeAgent,
			[FilingAgent] = @FilingAgent
		WHERE
			[ClientID] = @ClientID

	END
	ELSE
	BEGIN

		INSERT INTO [dbo].[tbl_client_admin_info]
		([ClientID]
           ,[Division]
           ,[SignupDate]
           ,[InsolvencyDate]
		   ,[InitialContact]
           ,[DateAppointed]
           ,[IIMeetingOn]
           ,[DateSent]
           ,[45Days]
           ,[DateDeemedAccepted]
           ,[Trustee]
           ,[EstateAdministrator]
           ,[Technician]
           ,[InitialInterview]
           ,[FileAdminVersion]
           ,[CourtName]
           ,[CourtNumber]
           ,[DivisionNumber]
           ,[District]
           ,[Location]
           ,[FileMgr]
           ,[Status]
           ,[CreatedDate]
           ,[MeetingDate]
           ,[IntakeAgent]
           ,[FilingAgent])
		VALUES
           (@ClientID
           ,@Division
           ,@SignupDate
           ,@InsolvencyDate
		   ,@InitialContact
           ,@DateAppointed
           ,@IIMeetingOn
           ,@DateSent
           ,@45Days
           ,@DateDeemedAccepted
           ,@Trustee
           ,@EstateAdministrator
           ,@Technician
           ,@InitialInterview
           ,@FileAdminVersion
           ,@CourtName
           ,@CourtNumber
           ,@DivisionNumber
           ,@District
           ,@Location
           ,@FileMgr
           ,@Status
           ,@CreatedDate
           ,@MeetingDate
           ,@IntakeAgent
           ,@FilingAgent)

	END

END
GO
/****** Object:  StoredProcedure [dbo].[usp_client_phone__add]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_client_phone__add]
	@ClientID	INT,
	@DisplayOrder	INT,
	@PhoneNumber	NVARCHAR(20),
	@PhoneType	NVARCHAR(20)
AS
BEGIN

	IF EXISTS (SELECT 1 FROM [dbo].[tbl_client_phone] WITH (NOLOCK) WHERE [ClientID] = @ClientID AND [DisplayOrder] = @DisplayOrder)
	BEGIN

		UPDATE
			[dbo].[tbl_client_phone]
		SET
			[PhoneNumber] = @PhoneNumber,
			[PhoneType]	= @PhoneType
		WHERE
			[ClientID] = @ClientID
		AND
			[DisplayOrder] = @DisplayOrder

	END
	ELSE
	BEGIN

		INSERT INTO [dbo].[tbl_client_phone]
           ([ClientID]
           ,[DisplayOrder]
           ,[PhoneNumber]
           ,[PhoneType])
		VALUES
           (@ClientID
           ,@DisplayOrder
           ,@PhoneNumber
           ,@PhoneType)

	END

END
GO
/****** Object:  StoredProcedure [dbo].[usp_client_source__add]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_client_source__add]
	@ClientID	INT,
	@Sources	NVARCHAR(MAX)
AS
BEGIN

	DECLARE @Data TABLE
	(
		[SourceCode]	NVARCHAR(5)
	)
	INSERT INTO @Data SELECT [value] FROM [dbo].[fn_split](@Sources, ',') WHERE ISNULL([value], '') <> ''

	INSERT INTO [dbo].[tbl_client_source] ([ClientID], [SourceCode])
	SELECT @ClientID, a.[SourceCode] FROM @Data a WHERE NOT EXISTS (SELECT 1 FROM [dbo].[tbl_client_source] WITH (NOLOCK) WHERE [ClientID] = @ClientID AND [SourceCode] = a.[SourceCode])

END
GO
/****** Object:  StoredProcedure [dbo].[usp_email_template__get_all]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_email_template__get_all]
	@prm_division	NVARCHAR(50)
AS
BEGIN

	SELECT
		a.*,
		(SELECT TOP 1 [FilePathUrl] FROM [dbo].[tbl_emailattachment] WITH (NOLOCK) WHERE [TemplateID] = a.[ID] AND [isDeleted] = 0 ORDER BY [ID] DESC) AS [FilePathUrl]
	FROM 
		[dbo].[tbl_ltrTemplate] a WITH (NOLOCK) 
	WHERE 
		a.[division] = @prm_division 
	ORDER BY 
		a.[TemplateName]

END
GO
/****** Object:  StoredProcedure [dbo].[usp_location__find_by_division]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_location__find_by_division]
	@prm_division	NVARCHAR(50)
AS
BEGIN

	SELECT [location_id]
      ,[listtext]
      ,[id] AS [division]
      ,[refid]
      ,[score]
      ,[code] FROM [dbo].[lst_type] WITH (NOLOCK) WHERE [id] = @prm_division ORDER BY [listtext]

END
GO
/****** Object:  StoredProcedure [dbo].[usp_location__get_all]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_location__get_all]
	@prm_division	nvarchar(10)
AS
BEGIN

	IF NOT EXISTS (SELECT [listtext] FROM [lst_type] WITH (NOLOCK) WHERE [id] = @prm_division)
	BEGIN

		SELECT 
			[listtext] 
		FROM
			[lst_type] WITH (NOLOCK)
		WHERE
			[id] = '0000'
		ORDER BY
			[refid]

	END
	ELSE
	BEGIN

		SELECT 
			[listtext] 
		FROM
			[lst_type] WITH (NOLOCK)
		WHERE
			[id] = @prm_division
		ORDER BY
			[refid]

	END

END
GO
/****** Object:  StoredProcedure [dbo].[usp_location_address__find_by_location_id]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[usp_location_address__find_by_location_id]
	@prm_location_id	INT
AS
BEGIN

	SELECT * FROM [dbo].[tbl_location_address] WITH (NOLOCK) WHERE [location_id] = @prm_location_id

END
GO
/****** Object:  StoredProcedure [dbo].[usp_source__get_all]    Script Date: 2018-01-31 2:07:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[usp_source__get_all]
	@prm_division	NVARCHAR(20)
AS
BEGIN

	SELECT * FROM [dbo].[lst_source] WITH (NOLOCK) WHERE [id] = @prm_division AND ISNULL([listtext], '') <> '' ORDER BY [listtext]			

END
GO
USE [master]
GO
ALTER DATABASE [MobileDB] SET  READ_WRITE 
GO

