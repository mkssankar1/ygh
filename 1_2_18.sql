USE [master]
GO
/****** Object:  Database [v1_group]    Script Date: 01/02/2018 20:11:37 ******/
CREATE DATABASE [v1_group] ON  PRIMARY 
( NAME = N'v1_group', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\v1_group.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'v1_group_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\v1_group_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [v1_group] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [v1_group].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [v1_group] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [v1_group] SET ANSI_NULLS OFF
GO
ALTER DATABASE [v1_group] SET ANSI_PADDING OFF
GO
ALTER DATABASE [v1_group] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [v1_group] SET ARITHABORT OFF
GO
ALTER DATABASE [v1_group] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [v1_group] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [v1_group] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [v1_group] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [v1_group] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [v1_group] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [v1_group] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [v1_group] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [v1_group] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [v1_group] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [v1_group] SET  DISABLE_BROKER
GO
ALTER DATABASE [v1_group] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [v1_group] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [v1_group] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [v1_group] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [v1_group] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [v1_group] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [v1_group] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [v1_group] SET  READ_WRITE
GO
ALTER DATABASE [v1_group] SET RECOVERY SIMPLE
GO
ALTER DATABASE [v1_group] SET  MULTI_USER
GO
ALTER DATABASE [v1_group] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [v1_group] SET DB_CHAINING OFF
GO
USE [v1_group]
GO
/****** Object:  User [dev_plan]    Script Date: 01/02/2018 20:11:38 ******/
CREATE USER [dev_plan] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[tblUserInvite]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblUserInvite](
	[UserInvID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[PhoneNumber] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Status] [int] NULL,
	[Notes] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTransCode]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTransCode](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TransCode] [varchar](12) NULL,
	[BankActive] [bit] NULL,
	[TicketActive] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblStates]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblStates](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [varchar](250) NOT NULL,
	[ShortName] [varchar](50) NOT NULL,
	[Active] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblScheme]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblScheme](
	[SchemaID] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[Rate] [decimal](8, 2) NULL,
	[Period] [varchar](50) NULL,
	[SchDesc] [varchar](250) NULL,
	[Active] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblRequestWithdrawal]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblRequestWithdrawal](
	[RequestCustId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[GroupId] [int] NULL,
	[AccountId] [int] NULL,
	[TransactionId] [varchar](20) NULL,
	[Subject] [varchar](200) NULL,
	[Reason] [varchar](500) NULL,
	[RejectMsg] [varchar](500) NULL,
	[RejecterId] [int] NULL,
	[Amount] [numeric](18, 2) NULL,
	[Status] [int] NULL,
	[RequestDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[AdminDate] [datetime] NULL,
	[FarmDate] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblRequestComment]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRequestComment](
	[RequestCommentId] [int] IDENTITY(1,1) NOT NULL,
	[RequestCustId] [int] NULL,
	[Comments] [text] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_tblRequestComment] PRIMARY KEY CLUSTERED 
(
	[RequestCommentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhoneType]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPhoneType](
	[PhoneTypeID] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](100) NULL,
	[ShortName] [varchar](50) NULL,
	[Active] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblImage]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblImage](
	[ImageId] [int] IDENTITY(1,1) NOT NULL,
	[CommonID] [int] NULL,
	[ImagePath] [varchar](150) NULL,
	[Ext] [varchar](50) NULL,
	[Type] [smallint] NULL,
	[CreatedDate] [date] NULL,
	[CreatedBy] [int] NULL,
	[Active] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblGroupSchemePayment]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblGroupSchemePayment](
	[GroupSchemePaymentID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NULL,
	[SchemaID] [int] NULL,
	[BatchID] [int] NULL,
	[Remark] [varchar](200) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [bigint] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ApprovalDate] [datetime] NULL,
	[ApprovalByUser] [bigint] NULL,
	[Status] [smallint] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblGroupMemberInvite]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblGroupMemberInvite](
	[GroupMemberInvID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NULL,
	[CustomerId] [int] NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[PhoneNumber] [varchar](20) NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Status] [int] NULL,
	[Notes] [text] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblGroupMember]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGroupMember](
	[GroupMemberID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NULL,
	[CustomerID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Status] [int] NULL,
	[Notes] [text] NULL,
	[Admin] [bit] NULL,
	[Refferal] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGroupDrawn]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGroupDrawn](
	[GroupDrawnId] [int] NOT NULL,
	[GroupId] [int] NULL,
	[AccountId] [int] NULL,
	[DrawnDate] [date] NULL,
	[PaymentDate] [date] NULL,
	[PaymentLastDate] [date] NULL,
	[Status] [smallint] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGroupDetails]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblGroupDetails](
	[GroupID] [int] IDENTITY(1,1) NOT NULL,
	[GroupName] [varchar](50) NOT NULL,
	[GroupShotName] [varchar](50) NULL,
	[Desc] [varchar](200) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [bigint] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[ApprovalDate] [datetime] NULL,
	[ApprovalByUser] [bigint] NULL,
	[Status] [smallint] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblGroupComment]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGroupComment](
	[GroupCommentId] [int] IDENTITY(1,1) NOT NULL,
	[GroupActId] [int] NULL,
	[Comments] [text] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_tblGroupComment] PRIMARY KEY CLUSTERED 
(
	[GroupCommentId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGroupBatch]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblGroupBatch](
	[BatchID] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NULL,
	[BatchName] [varchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[EndDate] [datetime] NULL,
	[EndByUser] [bigint] NULL,
	[DrawnChangeInterest] [decimal](18, 2) NULL,
	[DrawnChangeOption] [bit] NOT NULL,
	[Bi_MonthDate1] [int] NULL,
	[Bi_MonthDate2] [int] NULL,
	[MonthDate] [int] NULL,
	[Status] [smallint] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblGroupActivity]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblGroupActivity](
	[GroupActId] [int] IDENTITY(1,1) NOT NULL,
	[GroupID] [int] NULL,
	[CustomerID] [int] NULL,
	[ImagePath] [varchar](100) NULL,
	[VideoPath] [varchar](100) NULL,
	[Contents] [varchar](max) NULL,
	[Active] [bit] NULL,
	[CreatedDate] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCustomerPhone]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCustomerPhone](
	[CustomerPhoneID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[PhoneTypeID] [int] NULL,
	[PhoneNo] [varchar](25) NULL,
	[Ext] [varchar](10) NULL,
	[Active] [bit] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCustomerDesignation]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCustomerDesignation](
	[CustomerDesignId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[Designation] [varchar](75) NULL,
	[CompanyName] [varchar](150) NULL,
	[Duration] [varchar](50) NULL,
	[Status] [smallint] NULL,
	[Type] [smallint] NULL,
 CONSTRAINT [PK_tblDesignation] PRIMARY KEY CLUSTERED 
(
	[CustomerDesignId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCustomerBankAccount]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCustomerBankAccount](
	[CustomerBankId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[AccountName] [varchar](100) NULL,
	[BankName] [varchar](100) NULL,
	[BranchName] [varchar](100) NULL,
	[AccountNo] [varchar](25) NULL,
	[AccountType] [smallint] NULL,
	[Place] [varchar](100) NULL,
	[IFSC] [varchar](25) NULL,
	[MICR] [varchar](25) NULL,
	[Priority] [smallint] NULL,
	[Status] [smallint] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedBy] [bigint] NULL,
	[ModifiedBy] [bigint] NULL,
 CONSTRAINT [PK_tblCustomerBankAccount] PRIMARY KEY CLUSTERED 
(
	[CustomerBankId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](70) NOT NULL,
	[LastName] [varchar](70) NULL,
	[Prefix] [varchar](20) NULL,
	[DOB] [date] NULL,
	[Email] [varchar](100) NULL,
	[AlterEmail] [varchar](100) NULL,
	[MaritalStatus] [smallint] NULL,
	[Gender] [smallint] NULL,
	[UserName] [varchar](80) NULL,
	[Password] [varchar](100) NULL,
	[Status] [smallint] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [int] NULL,
	[Type] [int] NOT NULL,
	[Qualification] [varchar](100) NULL,
	[PassGuid] [varchar](50) NULL,
	[ActiveGuid] [varchar](50) NULL,
	[FirstLogin] [bit] NULL,
	[ReferralID] [int] NULL,
	[SaltKey] [int] NULL,
	[Lock] [smallint] NULL,
	[LastLogin] [datetime] NULL,
 CONSTRAINT [PK_tblCustomer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblAddresses]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblAddresses](
	[AddressID] [int] IDENTITY(1,1) NOT NULL,
	[BuildingNumber] [nvarchar](10) NULL,
	[CountryName] [varchar](50) NOT NULL,
	[StateID] [int] NULL,
	[City] [varchar](100) NULL,
	[Address1] [nvarchar](100) NOT NULL,
	[Address2] [nvarchar](255) NULL,
	[POBox] [nvarchar](7) NULL,
	[Active] [bit] NOT NULL,
	[District] [varchar](200) NULL,
	[Taluk] [varchar](200) NULL,
	[Type] [smallint] NULL,
	[CustomerID] [int] NULL,
	[CreatedUser] [int] NULL,
	[CreatedDate] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblAccountTransaction]    Script Date: 01/02/2018 20:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblAccountTransaction](
	[AccountActivityID] [bigint] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NULL,
	[TransactionId] [varchar](50) NULL,
	[Remark] [varchar](200) NULL,
	[Amount] [numeric](18, 2) NULL,
	[RefNo] [varchar](50) NULL,
	[PaymentDate] [datetime] NULL,
	[PaymentReceivedDate] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[Status] [smallint] NULL,
	[PaymentMode] [smallint] NULL,
	[OwnerApporved] [smallint] NULL,
	[FarmApporve] [smallint] NULL,
	[process] [smallint] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[ufnGetCustomerName]    Script Date: 01/02/2018 20:11:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date, ,>
-- Description:	<Description, ,>
-- =============================================
CREATE FUNCTION [dbo].[ufnGetCustomerName](@CustomerID int)
RETURNS varchar(200) 
AS
BEGIN
	DECLARE @ret varchar(100);
    SELECT @ret = FirstName 
    FROM tblCustomer
    WHERE CustomerID = @CustomerID;
   
    RETURN @ret;
	

END
GO
/****** Object:  StoredProcedure [dbo].[spUserLogin]    Script Date: 01/02/2018 20:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*********************************************************  
DESCRIPTION:   
--- 
  
HISTORY:  
31-12-2017 Siva  Created   
*********************************************************/  
  
CREATE PROCEDURE [dbo].[spUserLogin]  
 @UserName       VARCHAR(50)  = NULL, 
 @Password       VARCHAR(50)  = NULL  
  
AS  
BEGIN   
  
SET NOCOUNT ON;  
If exists(select 1 from tblCustomer where UserName = @UserName and Password =@Password and Status=1 and Lock is null and FirstLogin=0)
	BEGIN
	    SELECT 1 as LOGINSTATUS
	    select * from tblCustomer where UserName = @UserName and Password =@Password;
		UPDATE tblCustomer SET LastLogin=GETUTCDATE() where UserName = @UserName and Password =@Password
		
	End
	ELSE If exists(select 1 from tblCustomer where UserName = @UserName and Password =@Password and FirstLogin=1)
	BEGIN
		SELECT 9 as LOGINSTATUS
	END
	ELSE If exists(select 1 from tblCustomer where UserName = @UserName and Password =@Password and Lock is not null)
	BEGIN
		SELECT 8 as LOGINSTATUS 
	END
	ELSE
	BEGIN
		select status as LOGINSTATUS from tblCustomer where UserName = @UserName and Password =@Password
	End
   
END
GO
/****** Object:  StoredProcedure [dbo].[spUserInsert]    Script Date: 01/02/2018 20:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*********************************************************  
DESCRIPTION:   
This procedure creates the user Registration with only basic details  
  
HISTORY:  
28-08-2015 Siva  Created   
*********************************************************/  
  
Create PROCEDURE [dbo].[spUserInsert]  
 @Status           INT    = NULL,  
 @FirstName          VARCHAR(100) = NULL,  
 @LastName          VARCHAR(100) = NULL,  
 @Prefix                 INT    = NULL,  
 @DOB           DATE   = NULL,  
 @Email           VARCHAR(100) = NULL,  
 @AlterEmail          VARCHAR(100) = NULL,  
 @MaritalStatus         INT    = NULL,  
 @Gender           INT    = NULL,  
 @UserName          VARCHAR(100) = NULL,  
 @Password          VARCHAR(100) = NULL,  
 @CreatedBy          INT    = NULL,  
 @ActiveGuid       VARCHAR(50)  = NULL, 
 @SaltKey			INT = 1,
 @RETURN_VALUE         INT  OUTPUT    
  
AS  
BEGIN   
  
SET NOCOUNT ON;  
Declare @Id Int;  
 /*********************************  
 Step 1:   Insert new menber with registration details  
 ********************************/  
 INSERT INTO [dbo].[tblCustomer] (  
  [FirstName],  
  [LastName],  
  [Prefix],  
  [DOB],  
  [Email],  
  [AlterEmail],  
  [MaritalStatus],  
  [Gender],  
  [UserName],  
  [Password],  
  [Status],  
  [CreatedDate],  
  [CreatedBy],  
  [ModifiedDate],  
  [ModifiedBy],  
  [ActiveGuid],
  [SaltKey]   
  ) VALUES (  
  @FirstName,  
  @LastName,  
  @Prefix,  
  @DOB,  
  @Email,  
  @AlterEmail,  
  @MaritalStatus,  
  @Gender,  
  @UserName,  
  @Password,  
  @Status,  
  GETUTCDATE(),  
  @CreatedBy,  
  GETUTCDATE(),  
  @CreatedBy,  
  @ActiveGuid,
  @SaltKey)  
    
 /*********************************  
 Step 2:   Get new ID from tblCust table  
 ********************************/  
 SELECT @RETURN_VALUE =@@IDENTITY   
   
END
GO
/****** Object:  StoredProcedure [dbo].[spGroupInsert]    Script Date: 01/02/2018 20:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*********************************************************  
DESCRIPTION:   
This procedure creates the user Registration with only basic details  
  
HISTORY:  
02-01-2018 Siva  Created   
*********************************************************/  
  
CREATE PROCEDURE [dbo].[spGroupInsert]  
 @GroupName          VARCHAR(100) = NULL,  
 @GroupShotName          VARCHAR(100) = NULL,  
 @Desc                  VARCHAR(500)    = NULL,  
 @CreatedBy          INT    = NULL,  
 @RETURN_VALUE         INT  OUTPUT    
AS  
BEGIN   
  
SET NOCOUNT ON;  
 /*********************************  
 Step 1:   Insert new group with registration details  
 ********************************/  
 INSERT INTO [dbo].[tblGroupDetails] (  
  [GroupName],  
  [GroupShotName],  
  [Desc],  
  [CreatedDate],  
  [CreatedBy]  
  ) VALUES (  
  @GroupName,  
  @GroupShotName,  
  @Desc,  
  GETUTCDATE(),  
  @CreatedBy)  
    
 /*********************************  
 Step 2:   Get new ID from  table  
 ********************************/  
 Set @RETURN_VALUE =@@IDENTITY   
 
 Insert into [dbo].[tblGroupMember](GroupID,CustomerID,CreatedDate,CreatedBy,Admin) 
							 values(@RETURN_VALUE,@CreatedBy,GETUTCDATE(),@CreatedBy,1)
   select @RETURN_VALUE;
END
GO
/****** Object:  StoredProcedure [dbo].[spGroupCheck]    Script Date: 01/02/2018 20:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*********************************************************  
DESCRIPTION:   
This procedure creates the user Registration with only basic details  
  
HISTORY:  
02-01-2018 Siva  Created   
*********************************************************/  
  
create PROCEDURE [dbo].[spGroupCheck]  
 @GroupName          VARCHAR(100) = NULL,  
 @RETURN_VALUE         INT  OUTPUT    
AS  
BEGIN   
  
SET NOCOUNT ON;  
 if exists(select 1 from tblGroupDetails where GroupName=@GroupName)
	 Set @RETURN_VALUE =1   
 Else 
 select @RETURN_VALUE=2;
END
GO
/****** Object:  StoredProcedure [dbo].[spCheckActivation]    Script Date: 01/02/2018 20:11:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*********************************************************  
DESCRIPTION:   
--- 
  
HISTORY:  
31-12-2017 Siva  Created   
*********************************************************/  
  
CREATE PROCEDURE [dbo].[spCheckActivation]  
 @ActiveGuid       VARCHAR(50)  = NULL, 
 @RETURN_VALUE         INT  OUTPUT    
  
AS  
BEGIN   
  
SET NOCOUNT ON;  
If exists(select 1 from tblCustomer where ActiveGuid = @ActiveGuid and FirstLogin =1)
	BEGIN
		UPDATE tblCustomer SET FIRSTLOGIN=0,Status=1 WHERE ActiveGuid = @ActiveGuid
		SELECT @RETURN_VALUE =1 
	End
	ELSE If exists(select 1 from tblCustomer where ActiveGuid = @ActiveGuid)
	BEGIN
		SELECT @RETURN_VALUE =2 
	END
	ELSE
	BEGIN
		SELECT @RETURN_VALUE =0 
	End
   
END
GO
/****** Object:  View [dbo].[GroupAct]    Script Date: 01/02/2018 20:11:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[GroupAct] AS
SELECT TGA.Active,TGA.Contents,TGA.GroupActId,TGA.GroupID,TGA.CustomerID,TGA.ImagePath,TGA.VideoPath
,CONVERT(VARCHAR(19),TGA.CreatedDate) AS CreatedDate,TGA.CreatedDate as CreatedDt,TC.FirstName,TC.LastName,REPLACE(TI.ImagePath, '../', '/') AS UserImagePath,(SELECT COUNT(*) FROM tblGroupComment WHERE GroupActId=TGA.GroupActId) as CouComment
FROM tblGroupActivity AS TGA INNER JOIN  tblCustomer AS TC ON TGA.CustomerID = TC.CustomerID
LEFT Join tblImage AS TI ON TI.CommonID=Tc.CustomerID and TI.Type=1 and TI.Active=1 where TGA.Active=1
GO
/****** Object:  Default [DF_tblGroupMember_Status]    Script Date: 01/02/2018 20:11:40 ******/
ALTER TABLE [dbo].[tblGroupMember] ADD  CONSTRAINT [DF_tblGroupMember_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_tblGroupDetails_Status]    Script Date: 01/02/2018 20:11:40 ******/
ALTER TABLE [dbo].[tblGroupDetails] ADD  CONSTRAINT [DF_tblGroupDetails_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_tblCustomerPhone_Active]    Script Date: 01/02/2018 20:11:40 ******/
ALTER TABLE [dbo].[tblCustomerPhone] ADD  CONSTRAINT [DF_tblCustomerPhone_Active]  DEFAULT ((1)) FOR [Active]
GO
/****** Object:  Default [DF_tblCustomerDesignation_Status]    Script Date: 01/02/2018 20:11:40 ******/
ALTER TABLE [dbo].[tblCustomerDesignation] ADD  CONSTRAINT [DF_tblCustomerDesignation_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_tblCustomer_Status]    Script Date: 01/02/2018 20:11:40 ******/
ALTER TABLE [dbo].[tblCustomer] ADD  CONSTRAINT [DF_tblCustomer_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  Default [DF_tblCustomer_Type]    Script Date: 01/02/2018 20:11:40 ******/
ALTER TABLE [dbo].[tblCustomer] ADD  CONSTRAINT [DF_tblCustomer_Type]  DEFAULT ((1)) FOR [Type]
GO
/****** Object:  Default [DF_tblCustomer_FristLogin]    Script Date: 01/02/2018 20:11:40 ******/
ALTER TABLE [dbo].[tblCustomer] ADD  CONSTRAINT [DF_tblCustomer_FristLogin]  DEFAULT ((1)) FOR [FirstLogin]
GO
/****** Object:  Default [DF_tblAddresses_CountryName]    Script Date: 01/02/2018 20:11:40 ******/
ALTER TABLE [dbo].[tblAddresses] ADD  CONSTRAINT [DF_tblAddresses_CountryName]  DEFAULT ('India') FOR [CountryName]
GO
/****** Object:  Default [DF_tblAddresses_Active]    Script Date: 01/02/2018 20:11:40 ******/
ALTER TABLE [dbo].[tblAddresses] ADD  CONSTRAINT [DF_tblAddresses_Active]  DEFAULT ((1)) FOR [Active]
GO
/****** Object:  Default [DF_tblAccountTransaction_Status]    Script Date: 01/02/2018 20:11:40 ******/
ALTER TABLE [dbo].[tblAccountTransaction] ADD  CONSTRAINT [DF_tblAccountTransaction_Status]  DEFAULT ((0)) FOR [Status]
GO
/****** Object:  Default [DF_tblAccountTransaction_AdminApporved]    Script Date: 01/02/2018 20:11:40 ******/
ALTER TABLE [dbo].[tblAccountTransaction] ADD  CONSTRAINT [DF_tblAccountTransaction_AdminApporved]  DEFAULT ((0)) FOR [OwnerApporved]
GO
/****** Object:  Default [DF_tblAccountTransaction_FarmApporve]    Script Date: 01/02/2018 20:11:40 ******/
ALTER TABLE [dbo].[tblAccountTransaction] ADD  CONSTRAINT [DF_tblAccountTransaction_FarmApporve]  DEFAULT ((0)) FOR [FarmApporve]
GO
