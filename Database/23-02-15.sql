USE [master]
GO
/****** Object:  Database [LoomsManagement]    Script Date: 02/23/2015 18:09:09 ******/
CREATE DATABASE [LoomsManagement] ON  PRIMARY 
( NAME = N'LoomManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\LoomManagement.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LoomManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\LoomManagement_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LoomsManagement] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LoomsManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LoomsManagement] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [LoomsManagement] SET ANSI_NULLS OFF
GO
ALTER DATABASE [LoomsManagement] SET ANSI_PADDING OFF
GO
ALTER DATABASE [LoomsManagement] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [LoomsManagement] SET ARITHABORT OFF
GO
ALTER DATABASE [LoomsManagement] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [LoomsManagement] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [LoomsManagement] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [LoomsManagement] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [LoomsManagement] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [LoomsManagement] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [LoomsManagement] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [LoomsManagement] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [LoomsManagement] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [LoomsManagement] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [LoomsManagement] SET  DISABLE_BROKER
GO
ALTER DATABASE [LoomsManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [LoomsManagement] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [LoomsManagement] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [LoomsManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [LoomsManagement] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [LoomsManagement] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [LoomsManagement] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [LoomsManagement] SET  READ_WRITE
GO
ALTER DATABASE [LoomsManagement] SET RECOVERY FULL
GO
ALTER DATABASE [LoomsManagement] SET  MULTI_USER
GO
ALTER DATABASE [LoomsManagement] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [LoomsManagement] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'LoomsManagement', N'ON'
GO
USE [LoomsManagement]
GO
/****** Object:  Table [dbo].[WithdrownReturnMST]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WithdrownReturnMST](
	[WithdrownReturnID] [bigint] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[EmployeeID] [bigint] NULL,
	[ReturnType] [int] NULL,
	[SalaryID] [bigint] NULL,
	[Amount] [float] NULL,
	[Remark] [varchar](100) NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_WithdrownReturnMST] PRIMARY KEY CLUSTERED 
(
	[WithdrownReturnID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblYarnQualityMST]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblYarnQualityMST](
	[YarnQualityID] [bigint] IDENTITY(1,1) NOT NULL,
	[YarnQualityName] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblYarnMST] PRIMARY KEY CLUSTERED 
(
	[YarnQualityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCompany]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCompany](
	[CompanyID] [bigint] NOT NULL,
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
	[CompanyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBrokersMST]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBrokersMST](
	[BrokerID] [bigint] IDENTITY(1,1) NOT NULL,
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
	[BrokerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblYarnPurchase]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblYarnPurchase](
	[PurchaseID] [bigint] NOT NULL,
	[SRNo] [int] NULL,
	[CompanyID] [bigint] NULL,
	[PartyID] [bigint] NOT NULL,
	[BrokerID] [bigint] NULL,
	[YearID] [bigint] NULL,
	[PurchaseDate] [date] NULL,
	[ChallanNo] [varchar](100) NULL,
	[LRNo] [varchar](50) NULL,
	[RecieveAt] [varchar](50) NULL,
	[Grade] [varchar](50) NULL,
	[EmployeeId] [int] NULL,
 CONSTRAINT [PK_tblYarnPurchase] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblYarnPackageType]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblYarnPackageType](
	[YarnPackageTypeID] [bigint] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NULL,
 CONSTRAINT [PK_tblPackageType] PRIMARY KEY CLUSTERED 
(
	[YarnPackageTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblWorkingYear]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblWorkingYear](
	[YearID] [int] IDENTITY(1,1) NOT NULL,
	[YearName] [varchar](50) NULL,
 CONSTRAINT [PK_tblWorkingYear] PRIMARY KEY CLUSTERED 
(
	[YearID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblWithdrownMST]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblWithdrownMST](
	[WithdrownID] [bigint] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [bigint] NULL,
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
	[WithdrownID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBoilerProcess]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBoilerProcess](
	[BolierProcessID] [bigint] IDENTITY(1,1) NOT NULL,
	[MachineID] [bigint] NULL,
	[EmployeeID] [bigint] NULL,
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
	[BolierProcessID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBeemProcess]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBeemProcess](
	[BeemProcessID] [bigint] IDENTITY(1,1) NOT NULL,
	[MachineID] [bigint] NULL,
	[EmployeeID] [bigint] NULL,
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
	[BeemProcessID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBeamMST]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBeamMST](
	[BeemID] [bigint] IDENTITY(1,1) NOT NULL,
	[CompnayID] [bigint] NULL,
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
	[PipeWeight] [float] NULL,
	[LoadingDate] [date] NULL,
	[MinStragy] [float] NULL,
	[MachinNo] [int] NULL,
	[Remarks] [varchar](100) NULL,
	[BhidanStatus] [bit] NULL,
	[BhidanDate] [date] NULL,
	[PasaraiName] [int] NULL,
	[Count] [float] NULL,
	[IssuDate] [date] NULL,
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
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblBeamMST] PRIMARY KEY CLUSTERED 
(
	[BeemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblBankMST]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBankMST](
	[BankID] [bigint] IDENTITY(1,1) NOT NULL,
	[BankName] [varchar](50) NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblBankMST] PRIMARY KEY CLUSTERED 
(
	[BankID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPenaltyMST]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPenaltyMST](
	[PenaltyID] [bigint] IDENTITY(1,1) NOT NULL,
	[PenaltyCode] [varchar](10) NULL,
	[PenaltyName] [varchar](200) NULL,
	[Description] [text] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblPanultyMST] PRIMARY KEY CLUSTERED 
(
	[PenaltyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPartysMST]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblPartysMST](
	[PartyID] [bigint] IDENTITY(1,1) NOT NULL,
	[CompanyCode] [int] NULL,
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
	[PartyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblMendingPenulty]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMendingPenulty](
	[MendingPenultyID] [bigint] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [bigint] NULL,
	[PenultyID] [bigint] NULL,
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
/****** Object:  Table [dbo].[tblMendingDetailsProcess]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMendingDetailsProcess](
	[MendingDetailsID] [bigint] IDENTITY(1,1) NOT NULL,
	[MendingID] [bigint] NULL,
	[EmployeeID] [bigint] NULL,
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
/****** Object:  Table [dbo].[tblMandingProcess]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMandingProcess](
	[MendingID] [bigint] IDENTITY(1,1) NOT NULL,
	[TakaNo] [int] NULL,
	[EmployeeID] [bigint] NULL,
	[Grade] [varchar](5) NULL,
	[StartDateTime] [datetime] NULL,
	[EndDateTime] [datetime] NULL,
	[TotalMeter] [float] NULL,
	[TotalNoOfFaults] [int] NULL,
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
/****** Object:  Table [dbo].[tblMachineType]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMachineType](
	[MachineTypeID] [bigint] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_tblMachineType] PRIMARY KEY CLUSTERED 
(
	[MachineTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblMachine]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMachine](
	[MachineID] [bigint] NOT NULL,
	[MachineName] [varchar](50) NULL,
	[MachineTypeID] [bigint] NULL,
	[AboutMachine] [varchar](50) NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_tblMachine] PRIMARY KEY CLUSTERED 
(
	[MachineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblLoomProcessWork]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblLoomProcessWork](
	[LoomProcessWorkID] [bigint] IDENTITY(1,1) NOT NULL,
	[LoomProcessID] [bigint] NULL,
	[EmployeeID] [bigint] NULL,
	[WorkingDate] [date] NULL,
	[StartTime] [time](7) NULL,
	[EndTime] [time](7) NULL,
	[Shift] [varchar](50) NULL,
	[MTRStart] [float] NULL,
	[MTREnd] [float] NULL,
 CONSTRAINT [PK_tblLoomProcessWork] PRIMARY KEY CLUSTERED 
(
	[LoomProcessWorkID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblLoomProcess]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoomProcess](
	[LoomProcessID] [bigint] IDENTITY(1,1) NOT NULL,
	[BeemProcessID] [bigint] NULL,
	[MachineID] [bigint] NULL,
	[NoofTFORole] [float] NULL,
	[CreatoinDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblLoomProcess] PRIMARY KEY CLUSTERED 
(
	[LoomProcessID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmployeeType]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmployeeType](
	[EmployeeTypeID] [bigint] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [PK_tblEmployeeType] PRIMARY KEY CLUSTERED 
(
	[EmployeeTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[EmployeeID] [bigint] IDENTITY(1,1) NOT NULL,
	[EmployeeTypeID] [bigint] NULL,
	[EmployeeCode] [varchar](50) NULL,
	[JobTitle] [varchar](50) NULL,
	[FirstName] [varchar](50) NULL,
	[MiddleName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[ResidentialAddress] [varchar](500) NULL,
	[PermanentAddress] [varchar](500) NULL,
	[MobileNo] [varchar](50) NULL,
	[EmailID] [varchar](100) NULL,
	[DOB] [date] NULL,
	[Gender] [varchar](50) NULL,
	[IDProfe] [varchar](200) NULL,
	[IDProfeNo] [varchar](100) NULL,
	[Photo] [image] NULL,
	[JoinDate] [date] NULL,
	[LeaveDate] [date] NULL,
	[SponsorsID] [int] NULL,
	[Shift] [varchar](50) NULL,
	[Salary] [float] NULL,
	[PerDayWorkingHours] [float] NULL,
	[PerHourSalary] [float] NULL,
	[PaymentType] [bit] NULL,
	[BankName] [varchar](100) NULL,
	[BranchName] [varchar](100) NULL,
	[AccountNo] [varchar](30) NULL,
	[RTGSNo] [varchar](20) NULL,
	[IFSCCode] [varchar](20) NULL,
	[OpeningBalance] [float] NULL,
	[IsActive] [bit] NULL,
	[CreatedBY] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_tblEmployee] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCompanyMachine]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCompanyMachine](
	[RowId] [bigint] NOT NULL,
	[MachineId] [bigint] NOT NULL,
	[CompanyId] [bigint] NOT NULL,
 CONSTRAINT [PK_tblPartyMachine] PRIMARY KEY CLUSTERED 
(
	[RowId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBranchMST]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBranchMST](
	[BranchID] [bigint] IDENTITY(1,1) NOT NULL,
	[BranchName] [varchar](50) NULL,
	[Address] [varchar](1000) NULL,
	[BankID] [bigint] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblBranchMST] PRIMARY KEY CLUSTERED 
(
	[BranchID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblYarnTypeMST]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblYarnTypeMST](
	[YarnTypeID] [bigint] NOT NULL,
	[YarnTypeName] [varchar](50) NULL,
	[YarnQualityID] [bigint] NULL,
	[Description] [varchar](500) NULL,
	[IsActive] [bit] NULL,
	[UpdateBy] [int] NULL,
	[CreateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
	[CreationDateTIme] [datetime] NULL,
 CONSTRAINT [PK_YarnTypeMST] PRIMARY KEY CLUSTERED 
(
	[YarnTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSalaryMST]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSalaryMST](
	[SalaryID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [bigint] NULL,
	[Date] [datetime] NULL,
	[StartDate] [date] NULL,
	[EndDate] [date] NULL,
	[WorkedHours] [float] NULL,
	[TotalPenalty] [float] NULL,
	[Bonus] [float] NULL,
	[WithdrownAmount] [float] NULL,
	[WithdrownID] [bigint] NULL,
	[NetSalary] [float] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblSalaryMST] PRIMARY KEY CLUSTERED 
(
	[SalaryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblYarnPurchaseItems]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblYarnPurchaseItems](
	[PurchaseItemID] [bigint] IDENTITY(1,1) NOT NULL,
	[PurchaseID] [bigint] NULL,
	[YarnID] [bigint] NULL,
	[YarnPackageTypeID] [bigint] NULL,
	[PurchaseDate] [date] NULL,
	[BoxNo] [varchar](50) NULL,
	[GrossWeight] [float] NULL,
	[TareWeight] [float] NULL,
	[NetWeight] [float] NULL,
	[Cheese] [float] NULL,
	[EmployeeID] [bigint] NULL,
	[YarnQualityID] [bigint] NULL,
	[YarnTypeID] [bigint] NULL,
	[IsActive] [bit] NULL,
	[UpdateBy] [int] NULL,
	[CreateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
	[CreationDateTIme] [datetime] NULL,
 CONSTRAINT [PK_tblYarnPurchaseItems] PRIMARY KEY CLUSTERED 
(
	[PurchaseItemID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblAttendanceMST]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAttendanceMST](
	[AttendanceID] [bigint] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [bigint] NULL,
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
	[AttendanceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblWindingWork]    Script Date: 02/23/2015 18:09:12 ******/
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
	[PuchaseItemId] [bigint] NULL,
	[Shift] [varchar](50) NULL,
	[StartDateTime] [datetime] NULL,
	[TotalIssueWeight] [float] NULL,
	[WastedWeight] [float] NULL,
	[ProductionWeight] [float] NULL,
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
/****** Object:  Table [dbo].[tblTFOProcess]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTFOProcess](
	[TFORoleProcessId] [bigint] IDENTITY(1,1) NOT NULL,
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
/****** Object:  Table [dbo].[tblBolierProcessDetails]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBolierProcessDetails](
	[BoilerProcessDetailsID] [bigint] IDENTITY(1,1) NOT NULL,
	[BoilerProcessID] [bigint] NULL,
	[TFORoleProcessID] [bigint] NULL,
	[IssueNoOfTFORoles] [int] NULL,
	[IssueWeights] [float] NULL,
	[YarnQualityID] [bigint] NULL,
	[YarnTypeID] [bigint] NULL,
 CONSTRAINT [PK_BolierProcessDetails] PRIMARY KEY CLUSTERED 
(
	[BoilerProcessDetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBemProcessDetails]    Script Date: 02/23/2015 18:09:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBemProcessDetails](
	[BemProcessDetailsID] [bigint] IDENTITY(1,1) NOT NULL,
	[BemProcessID] [bigint] NULL,
	[TFORoleProcessID] [bigint] NULL,
	[IssueNoOFCopes] [int] NULL,
	[IssueWeights] [float] NULL,
	[YarnQualityID] [bigint] NULL,
	[YarnTypeID] [bigint] NULL,
	[IsActive] [bit] NULL,
	[CreateBy] [int] NULL,
	[CreationDateTime] [datetime] NULL,
	[UpdateBy] [int] NULL,
	[UpdationDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblBemProcessDetails] PRIMARY KEY CLUSTERED 
(
	[BemProcessDetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_tblEmployee_tblEmployeeType]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblEmployee]  WITH CHECK ADD  CONSTRAINT [FK_tblEmployee_tblEmployeeType] FOREIGN KEY([EmployeeTypeID])
REFERENCES [dbo].[tblEmployeeType] ([EmployeeTypeID])
GO
ALTER TABLE [dbo].[tblEmployee] CHECK CONSTRAINT [FK_tblEmployee_tblEmployeeType]
GO
/****** Object:  ForeignKey [FK_tblCompanyMachine_tblCompany]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblCompanyMachine]  WITH CHECK ADD  CONSTRAINT [FK_tblCompanyMachine_tblCompany] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[tblCompany] ([CompanyID])
GO
ALTER TABLE [dbo].[tblCompanyMachine] CHECK CONSTRAINT [FK_tblCompanyMachine_tblCompany]
GO
/****** Object:  ForeignKey [FK_tblCompanyMachine_tblMachine]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblCompanyMachine]  WITH CHECK ADD  CONSTRAINT [FK_tblCompanyMachine_tblMachine] FOREIGN KEY([MachineId])
REFERENCES [dbo].[tblMachine] ([MachineID])
GO
ALTER TABLE [dbo].[tblCompanyMachine] CHECK CONSTRAINT [FK_tblCompanyMachine_tblMachine]
GO
/****** Object:  ForeignKey [FK_tblBranchMST_tblBankMST]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblBranchMST]  WITH CHECK ADD  CONSTRAINT [FK_tblBranchMST_tblBankMST] FOREIGN KEY([BankID])
REFERENCES [dbo].[tblBankMST] ([BankID])
GO
ALTER TABLE [dbo].[tblBranchMST] CHECK CONSTRAINT [FK_tblBranchMST_tblBankMST]
GO
/****** Object:  ForeignKey [FK_tblYarnTypeMST_tblYarnQualityMST]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblYarnTypeMST]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnTypeMST_tblYarnQualityMST] FOREIGN KEY([YarnQualityID])
REFERENCES [dbo].[tblYarnQualityMST] ([YarnQualityID])
GO
ALTER TABLE [dbo].[tblYarnTypeMST] CHECK CONSTRAINT [FK_tblYarnTypeMST_tblYarnQualityMST]
GO
/****** Object:  ForeignKey [FK_tblSalaryMST_tblEmployee]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblSalaryMST]  WITH CHECK ADD  CONSTRAINT [FK_tblSalaryMST_tblEmployee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmployeeID])
GO
ALTER TABLE [dbo].[tblSalaryMST] CHECK CONSTRAINT [FK_tblSalaryMST_tblEmployee]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnMST]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnMST] FOREIGN KEY([YarnID])
REFERENCES [dbo].[tblYarnQualityMST] ([YarnQualityID])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnMST]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnPackageType]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnPackageType] FOREIGN KEY([YarnPackageTypeID])
REFERENCES [dbo].[tblYarnPackageType] ([YarnPackageTypeID])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnPackageType]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnPurchase]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnPurchase] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[tblYarnPurchase] ([PurchaseID])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnPurchase]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnQualityMST]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnQualityMST] FOREIGN KEY([YarnQualityID])
REFERENCES [dbo].[tblYarnQualityMST] ([YarnQualityID])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnQualityMST]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnTypeMST]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnTypeMST] FOREIGN KEY([YarnTypeID])
REFERENCES [dbo].[tblYarnTypeMST] ([YarnTypeID])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnTypeMST]
GO
/****** Object:  ForeignKey [FK_tblAttendanceMST_tblEmployee]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblAttendanceMST]  WITH CHECK ADD  CONSTRAINT [FK_tblAttendanceMST_tblEmployee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmployeeID])
GO
ALTER TABLE [dbo].[tblAttendanceMST] CHECK CONSTRAINT [FK_tblAttendanceMST_tblEmployee]
GO
/****** Object:  ForeignKey [FK_tblWindingWork_tblYarnPurchaseItems]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblWindingWork]  WITH CHECK ADD  CONSTRAINT [FK_tblWindingWork_tblYarnPurchaseItems] FOREIGN KEY([PuchaseItemId])
REFERENCES [dbo].[tblYarnPurchaseItems] ([PurchaseItemID])
GO
ALTER TABLE [dbo].[tblWindingWork] CHECK CONSTRAINT [FK_tblWindingWork_tblYarnPurchaseItems]
GO
/****** Object:  ForeignKey [FK_tblTFOProcess_tblWindingWork]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblTFOProcess]  WITH CHECK ADD  CONSTRAINT [FK_tblTFOProcess_tblWindingWork] FOREIGN KEY([WindingProcessId])
REFERENCES [dbo].[tblWindingWork] ([WindingProcessId])
GO
ALTER TABLE [dbo].[tblTFOProcess] CHECK CONSTRAINT [FK_tblTFOProcess_tblWindingWork]
GO
/****** Object:  ForeignKey [FK_tblBolierProcessDetails_tblBoilerProcess]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblBolierProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBolierProcessDetails_tblBoilerProcess] FOREIGN KEY([BoilerProcessID])
REFERENCES [dbo].[tblBoilerProcess] ([BolierProcessID])
GO
ALTER TABLE [dbo].[tblBolierProcessDetails] CHECK CONSTRAINT [FK_tblBolierProcessDetails_tblBoilerProcess]
GO
/****** Object:  ForeignKey [FK_tblBolierProcessDetails_tblTFOProcess]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblBolierProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBolierProcessDetails_tblTFOProcess] FOREIGN KEY([TFORoleProcessID])
REFERENCES [dbo].[tblTFOProcess] ([TFORoleProcessId])
GO
ALTER TABLE [dbo].[tblBolierProcessDetails] CHECK CONSTRAINT [FK_tblBolierProcessDetails_tblTFOProcess]
GO
/****** Object:  ForeignKey [FK_tblBemProcessDetails_tblBeemProcess]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblBemProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBemProcessDetails_tblBeemProcess] FOREIGN KEY([BemProcessID])
REFERENCES [dbo].[tblBeemProcess] ([BeemProcessID])
GO
ALTER TABLE [dbo].[tblBemProcessDetails] CHECK CONSTRAINT [FK_tblBemProcessDetails_tblBeemProcess]
GO
/****** Object:  ForeignKey [FK_tblBemProcessDetails_tblBoilerProcess]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblBemProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBemProcessDetails_tblBoilerProcess] FOREIGN KEY([BemProcessID])
REFERENCES [dbo].[tblBoilerProcess] ([BolierProcessID])
GO
ALTER TABLE [dbo].[tblBemProcessDetails] CHECK CONSTRAINT [FK_tblBemProcessDetails_tblBoilerProcess]
GO
/****** Object:  ForeignKey [FK_tblBemProcessDetails_tblTFOProcess]    Script Date: 02/23/2015 18:09:12 ******/
ALTER TABLE [dbo].[tblBemProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBemProcessDetails_tblTFOProcess] FOREIGN KEY([TFORoleProcessID])
REFERENCES [dbo].[tblTFOProcess] ([TFORoleProcessId])
GO
ALTER TABLE [dbo].[tblBemProcessDetails] CHECK CONSTRAINT [FK_tblBemProcessDetails_tblTFOProcess]
GO
