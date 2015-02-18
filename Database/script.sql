USE [master]
GO
/****** Object:  Database [LoomManagement]    Script Date: 02/09/2015 18:53:25 ******/
CREATE DATABASE [LoomManagement] ON  PRIMARY 
( NAME = N'LoomManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\LoomManagement.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LoomManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\LoomManagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LoomManagement] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LoomManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LoomManagement] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [LoomManagement] SET ANSI_NULLS OFF
GO
ALTER DATABASE [LoomManagement] SET ANSI_PADDING OFF
GO
ALTER DATABASE [LoomManagement] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [LoomManagement] SET ARITHABORT OFF
GO
ALTER DATABASE [LoomManagement] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [LoomManagement] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [LoomManagement] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [LoomManagement] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [LoomManagement] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [LoomManagement] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [LoomManagement] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [LoomManagement] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [LoomManagement] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [LoomManagement] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [LoomManagement] SET  DISABLE_BROKER
GO
ALTER DATABASE [LoomManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [LoomManagement] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [LoomManagement] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [LoomManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [LoomManagement] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [LoomManagement] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [LoomManagement] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [LoomManagement] SET  READ_WRITE
GO
ALTER DATABASE [LoomManagement] SET RECOVERY FULL
GO
ALTER DATABASE [LoomManagement] SET  MULTI_USER
GO
ALTER DATABASE [LoomManagement] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [LoomManagement] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'LoomManagement', N'ON'
GO
USE [LoomManagement]
GO
/****** Object:  Table [dbo].[WithdrownReturnMST]    Script Date: 02/09/2015 18:53:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WithdrownReturnMST](
	[WithdrownReturnId] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[EmployeeId] [int] NULL,
	[ReturnType] [int] NULL,
	[SalaryID] [int] NULL,
	[Amount] [float] NULL,
	[Remark] [varchar](100) NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_WithdrownReturnMST] PRIMARY KEY CLUSTERED 
(
	[WithdrownReturnId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblYarnQualityMST]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblYarnQualityMST](
	[YarnQualityId] [int] IDENTITY(1,1) NOT NULL,
	[YarnQualityName] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblYarnMST] PRIMARY KEY CLUSTERED 
(
	[YarnQualityId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCompany]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCompany](
	[CompanyId] [int] NOT NULL,
	[CompanyName] [varchar](100) NULL,
	[ComapnyCode] [varchar](10) NULL,
	[OwnerName] [varchar](50) NULL,
	[StartDate] [date] NULL,
	[Address] [varchar](500) NULL,
	[ContactPersonName] [varchar](50) NULL,
	[CreationDate] [datetime] NULL,
	[InvestmentAmount] [float] NULL,
	[PANNo] [varchar](50) NULL,
	[CSTNo] [varchar](50) NULL,
	[ECCNo] [varchar](50) NULL,
	[SMSNO] [varchar](15) NULL,
	[IsActive] [bit] NULL,
	[CB] [int] NULL,
	[CD] [datetime] NULL,
	[UB] [int] NULL,
	[UD] [datetime] NULL,
 CONSTRAINT [PK_tblCompany] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBrokersMST]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBrokersMST](
	[BrokerId] [int] IDENTITY(1,1) NOT NULL,
	[BrokerName] [varchar](50) NULL,
	[BrokerFirmName] [varchar](500) NULL,
	[Address] [varchar](500) NULL,
	[ContactNo] [varchar](50) NULL,
	[MobileNo] [varchar](50) NULL,
	[DealingIn] [varchar](500) NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblBrokersMST] PRIMARY KEY CLUSTERED 
(
	[BrokerId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblYarnPurchase]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblYarnPurchase](
	[PurchaseId] [int] NOT NULL,
	[SRNo] [int] NULL,
	[CompanyId] [int] NULL,
	[PartyId] [int] NOT NULL,
	[BrokerId] [int] NULL,
	[YearId] [int] NULL,
	[PurchaseDate] [date] NULL,
	[ChallanNo] [varchar](100) NULL,
	[LRNo] [varchar](50) NULL,
	[RecieveAt] [varchar](50) NULL,
	[Grade] [varchar](50) NULL,
	[EmployeeId] [int] NULL,
 CONSTRAINT [PK_tblYarnPurchase] PRIMARY KEY CLUSTERED 
(
	[PurchaseId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblYarnPackageType]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblYarnPackageType](
	[YarnPackageTypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [nchar](10) NULL,
 CONSTRAINT [PK_tblPackageType] PRIMARY KEY CLUSTERED 
(
	[YarnPackageTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblWorkingYear]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblWorkingYear](
	[YearId] [int] IDENTITY(1,1) NOT NULL,
	[YearName] [varchar](50) NULL,
 CONSTRAINT [PK_tblWorkingYear] PRIMARY KEY CLUSTERED 
(
	[YearId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblWithdrownMST]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblWithdrownMST](
	[WithdrownId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NULL,
	[Remarks] [varchar](100) NULL,
	[WithdrownAmount] [float] NULL,
	[WithdrownDate] [datetime] NULL,
	[ReturnDate] [datetime] NULL,
	[ISStatus] [bit] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblBorrowMST] PRIMARY KEY CLUSTERED 
(
	[WithdrownId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBoilerProcess]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBoilerProcess](
	[BolierProcessId] [int] IDENTITY(1,1) NOT NULL,
	[MachineId] [int] NULL,
	[EmployeeId] [int] NULL,
	[Shift] [varchar](50) NULL,
	[StartDateTime] [datetime] NULL,
	[EndDateTime] [datetime] NULL,
	[Tempreture] [float] NULL,
	[IsActive] [bit] NULL,
	[UpdateBy] [int] NULL,
	[CreateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
	[CreationDateTIme] [datetime] NULL,
 CONSTRAINT [PK_tblBoilerProcess\] PRIMARY KEY CLUSTERED 
(
	[BolierProcessId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBeemProcess]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBeemProcess](
	[BemProcessId] [int] NOT NULL,
	[MachineId] [int] NULL,
	[EmployeeId] [int] NULL,
	[Shift] [varchar](50) NULL,
	[StartDateTime] [datetime] NULL,
	[EndDateTime] [datetime] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblBeemProcess] PRIMARY KEY CLUSTERED 
(
	[BemProcessId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBeamMST]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBeamMST](
	[BeemID] [int] NULL,
	[CompnayCode] [int] NULL,
	[WrapperPartyName] [int] NULL,
	[JobberPartyName] [int] NULL,
	[BeemDate] [date] NULL,
	[YarnQuality] [int] NULL,
	[GrayQuality] [int] NULL,
	[TarNo] [int] NULL,
	[Meters] [float] NULL,
	[Taka] [int] NULL,
	[Weight] [float] NULL,
	[ProductionMeters] [float] NULL,
	[ProductionTaka] [int] NULL,
	[PipeWight] [float] NULL,
	[LoadingDate] [date] NULL,
	[MinStragy] [float] NULL,
	[MachinNo] [int] NULL,
	[Remarks] [varchar](100) NULL,
	[BhidanStatus] [bit] NULL,
	[BhidanDate] [date] NULL,
	[PasaraiName] [int] NULL,
	[count] [float] NULL,
	[IssuneDate] [date] NULL,
	[TakaMeter] [bit] NULL,
	[Rate] [float] NULL,
	[Amount] [float] NULL,
	[MeterConsumption] [float] NULL,
	[RPM] [float] NULL,
	[Pick] [float] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBankMST]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBankMST](
	[BankId] [int] IDENTITY(1,1) NOT NULL,
	[BankName] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblBankMST] PRIMARY KEY CLUSTERED 
(
	[BankId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPartysMST]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPartysMST](
	[PartyId] [int] IDENTITY(1,1) NOT NULL,
	[ComapnyCode] [int] NULL,
	[PartyName] [varchar](50) NULL,
	[ContactPersonName] [varchar](15) NULL,
	[OfficeAddress] [varchar](200) NULL,
	[ShippingAddress] [varchar](200) NULL,
	[City] [varchar](50) NULL,
	[State] [varchar](50) NULL,
	[MobileNo] [varchar](15) NULL,
	[PhoneNo] [varchar](15) NULL,
	[SMSNo] [varchar](15) NULL,
	[ReferencePersonName] [varchar](100) NULL,
	[ReferencePersonMobileNo] [varchar](15) NULL,
	[EmailID] [varchar](100) NULL,
	[ExtraDetails] [varchar](500) NULL,
	[TINNo] [varchar](50) NULL,
	[TINDate] [date] NULL,
	[PANNO] [varchar](50) NULL,
	[CSTTINNo] [varchar](50) NULL,
	[CSTDate] [date] NULL,
	[ECCNo] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreateBye] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTIme] [datetime] NULL,
 CONSTRAINT [PK_tblPartysMST] PRIMARY KEY CLUSTERED 
(
	[PartyId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPanultyMST]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPanultyMST](
	[PenultyID] [int] IDENTITY(1,1) NOT NULL,
	[PenultyCode] [varchar](10) NULL,
	[PenultyName] [varchar](200) NULL,
	[Description] [text] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblPanultyMST] PRIMARY KEY CLUSTERED 
(
	[PenultyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblMendingPenulty]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMendingPenulty](
	[MendingPenultyID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NULL,
	[PenultyID] [int] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblMendingPenulty] PRIMARY KEY CLUSTERED 
(
	[MendingPenultyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMendingDetailsProcess]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMendingDetailsProcess](
	[MendingDetailsID] [int] IDENTITY(1,1) NOT NULL,
	[MendingID] [int] NULL,
	[EmployeeId] [int] NULL,
	[StartMeter] [float] NULL,
	[EndMeter] [float] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblMendingDetailsProcess] PRIMARY KEY CLUSTERED 
(
	[MendingDetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMandingProcess]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMandingProcess](
	[MendingID] [int] IDENTITY(1,1) NOT NULL,
	[TakaNo] [int] NULL,
	[EmployeeId] [int] NULL,
	[Grade] [varchar](5) NULL,
	[StartDateTime] [datetime] NULL,
	[EndDateTime] [datetime] NULL,
	[TotalMiter] [float] NULL,
	[TotalNoOfFoults] [int] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblMandingProcess] PRIMARY KEY CLUSTERED 
(
	[MendingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblMachineType]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMachineType](
	[MachineTypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_tblMachineType] PRIMARY KEY CLUSTERED 
(
	[MachineTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblMachine]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMachine](
	[MachineId] [int] NOT NULL,
	[MachineName] [varchar](50) NULL,
	[MachineTypeId] [int] NULL,
	[AboutMachine] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tblMachine] PRIMARY KEY CLUSTERED 
(
	[MachineId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblLoomProcessWork]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblLoomProcessWork](
	[LoomProcessWorkId] [int] IDENTITY(1,1) NOT NULL,
	[LoomProcessId] [int] NULL,
	[EmployeeId] [int] NULL,
	[WorkingDate] [date] NULL,
	[StartTime] [time](7) NULL,
	[EndTime] [time](7) NULL,
	[Shift] [varchar](50) NULL,
	[MTRStart] [float] NULL,
	[MTREnd] [float] NULL,
 CONSTRAINT [PK_tblLoomProcessWork] PRIMARY KEY CLUSTERED 
(
	[LoomProcessWorkId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblLoomProcess]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoomProcess](
	[LoomProcessId] [int] IDENTITY(1,1) NOT NULL,
	[BeemProcessId] [int] NULL,
	[MachineId] [int] NULL,
	[NoofTFORole] [float] NULL,
	[CreatoinDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblLoomProcess] PRIMARY KEY CLUSTERED 
(
	[LoomProcessId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmployeeType]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmployeeType](
	[EmployeeTypeId] [int] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_tblEmployeeType] PRIMARY KEY CLUSTERED 
(
	[EmployeeTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeTypeId] [int] NULL,
	[EmployeeCode] [varchar](50) NULL,
	[JobTitle] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[MiddleName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[RresidentialAddress] [varchar](500) NULL,
	[PermenentAddress] [varchar](500) NULL,
	[MobileNo] [varchar](50) NULL,
	[EmailID] [varchar](100) NULL,
	[DOB] [date] NULL,
	[Gender] [varchar](50) NULL,
	[IDProfe] [varchar](200) NULL,
	[IDProfeNo] [varchar](100) NULL,
	[Photo] [image] NULL,
	[JointDate] [date] NULL,
	[LeaveDate] [date] NULL,
	[SponsorsId] [int] NULL,
	[Shift] [varchar](50) NULL,
	[Salary] [float] NULL,
	[PerDayWorkingHours] [float] NULL,
	[PerHourSalary] [float] NULL,
	[PaymentType] [bit] NULL,
	[BackName] [varchar](100) NULL,
	[BranchName] [varchar](100) NULL,
	[AccountNo] [varchar](30) NULL,
	[RTGSNo] [varchar](20) NULL,
	[IFSCCode] [varchar](20) NULL,
	[OpeningBalance] [float] NULL,
	[IsActive] [bit] NULL,
	[CB] [int] NULL,
	[CD] [datetime] NULL,
	[UB] [int] NULL,
	[UD] [datetime] NULL,
 CONSTRAINT [PK_tblEmployee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCompanyMachine]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCompanyMachine](
	[RowId] [int] NOT NULL,
	[MachineId] [int] NOT NULL,
	[CompanyId] [int] NOT NULL,
 CONSTRAINT [PK_tblPartyMachine] PRIMARY KEY CLUSTERED 
(
	[RowId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBranchMST]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBranchMST](
	[BranchId] [int] IDENTITY(1,1) NOT NULL,
	[BranchName] [varchar](50) NULL,
	[Address] [varchar](1000) NULL,
	[BankId] [int] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblBranchMST] PRIMARY KEY CLUSTERED 
(
	[BranchId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblYarnTypeMST]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblYarnTypeMST](
	[YarnTypeId] [int] NOT NULL,
	[YarnTypeName] [varchar](50) NULL,
	[YarnQualityId] [int] NULL,
	[Description] [varchar](500) NULL,
	[IsActive] [bit] NULL,
	[UpdateBy] [int] NULL,
	[CreateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
	[CreationDateTIme] [datetime] NULL,
 CONSTRAINT [PK_YarnTypeMST] PRIMARY KEY CLUSTERED 
(
	[YarnTypeId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSalaryMST]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSalaryMST](
	[SalaryId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NULL,
	[Date] [datetime] NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[WorkedHours] [float] NULL,
	[TotalPenalty] [float] NULL,
	[Bonus] [float] NULL,
	[WithdrownAmount] [float] NULL,
	[WithdrownID] [int] NULL,
	[NetSalary] [float] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblSalaryMST] PRIMARY KEY CLUSTERED 
(
	[SalaryId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblYarnPurchaseItems]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblYarnPurchaseItems](
	[PurchaseItemId] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseId] [int] NULL,
	[YarnId] [int] NULL,
	[YarnPackageTypeId] [int] NULL,
	[PurchaseDate] [date] NULL,
	[BoxNo] [varchar](50) NULL,
	[GrossWeight] [float] NULL,
	[TareWeight] [float] NULL,
	[NetWeight] [float] NULL,
	[Cheese] [float] NULL,
	[EmployeeId] [int] NULL,
	[YarnQualityId] [int] NULL,
	[YarnTypeId] [int] NULL,
	[IsActive] [bit] NULL,
	[UpdateBy] [int] NULL,
	[CreateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
	[CreationDateTIme] [datetime] NULL,
 CONSTRAINT [PK_tblYarnPurchaseItems] PRIMARY KEY CLUSTERED 
(
	[PurchaseItemId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblAttendanceMST]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAttendanceMST](
	[AttendanceId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[MeterWorked] [float] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblAttendanceMST] PRIMARY KEY CLUSTERED 
(
	[AttendanceId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblWindingWork]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblWindingWork](
	[WindingProcessId] [int] IDENTITY(1,1) NOT NULL,
	[MachineId] [int] NULL,
	[EmployeeId] [int] NULL,
	[PuchaseItemId] [int] NULL,
	[Shift] [varchar](50) NULL,
	[StartDateTime] [datetime] NULL,
	[TotalIssueWights] [float] NULL,
	[WeastedWights] [float] NULL,
	[ProductionWights] [float] NULL,
	[NoOfCopes] [int] NULL,
	[EndDateTime] [datetime] NULL,
	[YarnQualityId] [int] NULL,
	[YarnTypeId] [int] NULL,
	[IsActive] [bit] NULL,
	[UpdateBy] [int] NULL,
	[CreateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
	[CreationDateTIme] [datetime] NULL,
 CONSTRAINT [PK_tblWindingWork] PRIMARY KEY CLUSTERED 
(
	[WindingProcessId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblTFOProcess]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTFOProcess](
	[TFORoleProcessId] [int] IDENTITY(1,1) NOT NULL,
	[WindingProcessId] [int] NULL,
	[PurchaseItemID] [int] NULL,
	[MachineId] [int] NULL,
	[EmployeeId] [int] NULL,
	[Shift] [varchar](50) NULL,
	[StartDateTime] [datetime] NULL,
	[IssueNoOfCopes] [int] NULL,
	[IssueWights] [float] NULL,
	[NoofTFORole] [float] NULL,
	[ProducttionNoOfTFORoles] [int] NULL,
	[ProducttionWights] [float] NULL,
	[QualityName] [varchar](50) NULL,
	[EndDateTime] [datetime] NULL,
	[YarnQualityId] [int] NULL,
	[YarnTypeId] [int] NULL,
	[IsActive] [bit] NULL,
	[UpdateBy] [int] NULL,
	[CreateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
	[CreationDateTIme] [datetime] NULL,
 CONSTRAINT [PK_tblTFOProcess] PRIMARY KEY CLUSTERED 
(
	[TFORoleProcessId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBolierProcessDetails]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBolierProcessDetails](
	[BolierProcessDetailsId] [int] NOT NULL,
	[BolierProcessId] [int] NULL,
	[TFORoleProcessId] [int] NULL,
	[IssueNoOfTFORoles] [int] NULL,
	[IssueWights] [float] NULL,
	[YarnQualityId] [int] NULL,
	[YarnTypeId] [int] NULL,
 CONSTRAINT [PK_BolierProcessDetails] PRIMARY KEY CLUSTERED 
(
	[BolierProcessDetailsId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBemProcessDetails]    Script Date: 02/09/2015 18:53:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBemProcessDetails](
	[BemProcessDetailsId] [int] NOT NULL,
	[BemProcessId] [int] NULL,
	[TFORoleProcessId] [int] NULL,
	[IssueNoOFCopes] [int] NULL,
	[IssueWights] [float] NULL,
	[YarnQualityId] [int] NULL,
	[YarnTypeId] [int] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblBemProcessDetails] PRIMARY KEY CLUSTERED 
(
	[BemProcessDetailsId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_tblEmployee_tblEmployeeType]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblEmployee]  WITH CHECK ADD  CONSTRAINT [FK_tblEmployee_tblEmployeeType] FOREIGN KEY([EmployeeTypeId])
REFERENCES [dbo].[tblEmployeeType] ([EmployeeTypeId])
GO
ALTER TABLE [dbo].[tblEmployee] CHECK CONSTRAINT [FK_tblEmployee_tblEmployeeType]
GO
/****** Object:  ForeignKey [FK_tblCompanyMachine_tblCompany]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblCompanyMachine]  WITH CHECK ADD  CONSTRAINT [FK_tblCompanyMachine_tblCompany] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[tblCompany] ([CompanyId])
GO
ALTER TABLE [dbo].[tblCompanyMachine] CHECK CONSTRAINT [FK_tblCompanyMachine_tblCompany]
GO
/****** Object:  ForeignKey [FK_tblCompanyMachine_tblMachine]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblCompanyMachine]  WITH CHECK ADD  CONSTRAINT [FK_tblCompanyMachine_tblMachine] FOREIGN KEY([MachineId])
REFERENCES [dbo].[tblMachine] ([MachineId])
GO
ALTER TABLE [dbo].[tblCompanyMachine] CHECK CONSTRAINT [FK_tblCompanyMachine_tblMachine]
GO
/****** Object:  ForeignKey [FK_tblBranchMST_tblBankMST]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblBranchMST]  WITH CHECK ADD  CONSTRAINT [FK_tblBranchMST_tblBankMST] FOREIGN KEY([BankId])
REFERENCES [dbo].[tblBankMST] ([BankId])
GO
ALTER TABLE [dbo].[tblBranchMST] CHECK CONSTRAINT [FK_tblBranchMST_tblBankMST]
GO
/****** Object:  ForeignKey [FK_tblYarnTypeMST_tblYarnQualityMST]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblYarnTypeMST]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnTypeMST_tblYarnQualityMST] FOREIGN KEY([YarnQualityId])
REFERENCES [dbo].[tblYarnQualityMST] ([YarnQualityId])
GO
ALTER TABLE [dbo].[tblYarnTypeMST] CHECK CONSTRAINT [FK_tblYarnTypeMST_tblYarnQualityMST]
GO
/****** Object:  ForeignKey [FK_tblSalaryMST_tblEmployee]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblSalaryMST]  WITH CHECK ADD  CONSTRAINT [FK_tblSalaryMST_tblEmployee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[tblEmployee] ([EmployeeId])
GO
ALTER TABLE [dbo].[tblSalaryMST] CHECK CONSTRAINT [FK_tblSalaryMST_tblEmployee]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnMST]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnMST] FOREIGN KEY([YarnId])
REFERENCES [dbo].[tblYarnQualityMST] ([YarnQualityId])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnMST]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnPackageType]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnPackageType] FOREIGN KEY([YarnPackageTypeId])
REFERENCES [dbo].[tblYarnPackageType] ([YarnPackageTypeId])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnPackageType]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnPurchase]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnPurchase] FOREIGN KEY([PurchaseId])
REFERENCES [dbo].[tblYarnPurchase] ([PurchaseId])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnPurchase]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnQualityMST]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnQualityMST] FOREIGN KEY([YarnQualityId])
REFERENCES [dbo].[tblYarnQualityMST] ([YarnQualityId])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnQualityMST]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnTypeMST]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnTypeMST] FOREIGN KEY([YarnTypeId])
REFERENCES [dbo].[tblYarnTypeMST] ([YarnTypeId])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnTypeMST]
GO
/****** Object:  ForeignKey [FK_tblAttendanceMST_tblEmployee]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblAttendanceMST]  WITH CHECK ADD  CONSTRAINT [FK_tblAttendanceMST_tblEmployee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[tblEmployee] ([EmployeeId])
GO
ALTER TABLE [dbo].[tblAttendanceMST] CHECK CONSTRAINT [FK_tblAttendanceMST_tblEmployee]
GO
/****** Object:  ForeignKey [FK_tblWindingWork_tblYarnPurchaseItems]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblWindingWork]  WITH CHECK ADD  CONSTRAINT [FK_tblWindingWork_tblYarnPurchaseItems] FOREIGN KEY([PuchaseItemId])
REFERENCES [dbo].[tblYarnPurchaseItems] ([PurchaseItemId])
GO
ALTER TABLE [dbo].[tblWindingWork] CHECK CONSTRAINT [FK_tblWindingWork_tblYarnPurchaseItems]
GO
/****** Object:  ForeignKey [FK_tblTFOProcess_tblWindingWork]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblTFOProcess]  WITH CHECK ADD  CONSTRAINT [FK_tblTFOProcess_tblWindingWork] FOREIGN KEY([WindingProcessId])
REFERENCES [dbo].[tblWindingWork] ([WindingProcessId])
GO
ALTER TABLE [dbo].[tblTFOProcess] CHECK CONSTRAINT [FK_tblTFOProcess_tblWindingWork]
GO
/****** Object:  ForeignKey [FK_tblBolierProcessDetails_tblBoilerProcess]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblBolierProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBolierProcessDetails_tblBoilerProcess] FOREIGN KEY([BolierProcessId])
REFERENCES [dbo].[tblBoilerProcess] ([BolierProcessId])
GO
ALTER TABLE [dbo].[tblBolierProcessDetails] CHECK CONSTRAINT [FK_tblBolierProcessDetails_tblBoilerProcess]
GO
/****** Object:  ForeignKey [FK_tblBolierProcessDetails_tblTFOProcess]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblBolierProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBolierProcessDetails_tblTFOProcess] FOREIGN KEY([TFORoleProcessId])
REFERENCES [dbo].[tblTFOProcess] ([TFORoleProcessId])
GO
ALTER TABLE [dbo].[tblBolierProcessDetails] CHECK CONSTRAINT [FK_tblBolierProcessDetails_tblTFOProcess]
GO
/****** Object:  ForeignKey [FK_tblBemProcessDetails_tblBeemProcess]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblBemProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBemProcessDetails_tblBeemProcess] FOREIGN KEY([BemProcessId])
REFERENCES [dbo].[tblBeemProcess] ([BemProcessId])
GO
ALTER TABLE [dbo].[tblBemProcessDetails] CHECK CONSTRAINT [FK_tblBemProcessDetails_tblBeemProcess]
GO
/****** Object:  ForeignKey [FK_tblBemProcessDetails_tblBoilerProcess]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblBemProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBemProcessDetails_tblBoilerProcess] FOREIGN KEY([BemProcessId])
REFERENCES [dbo].[tblBoilerProcess] ([BolierProcessId])
GO
ALTER TABLE [dbo].[tblBemProcessDetails] CHECK CONSTRAINT [FK_tblBemProcessDetails_tblBoilerProcess]
GO
/****** Object:  ForeignKey [FK_tblBemProcessDetails_tblTFOProcess]    Script Date: 02/09/2015 18:53:28 ******/
ALTER TABLE [dbo].[tblBemProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBemProcessDetails_tblTFOProcess] FOREIGN KEY([TFORoleProcessId])
REFERENCES [dbo].[tblTFOProcess] ([TFORoleProcessId])
GO
ALTER TABLE [dbo].[tblBemProcessDetails] CHECK CONSTRAINT [FK_tblBemProcessDetails_tblTFOProcess]
GO
