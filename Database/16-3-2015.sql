USE [master]
GO
/****** Object:  Database [LoomsManagement]    Script Date: 03/16/2015 19:13:38 ******/
CREATE DATABASE [LoomsManagement] ON  PRIMARY 
( NAME = N'LoomManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\LoomManagement.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LoomManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\LoomManagement_log.ldf' , SIZE = 7616KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  Table [dbo].[WithdrownReturnMST]    Script Date: 03/16/2015 19:13:39 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  Table [dbo].[tblYarnQualityMST]    Script Date: 03/16/2015 19:13:39 ******/
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
	[IsDelete] [bit] NULL,
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
SET IDENTITY_INSERT [dbo].[tblYarnQualityMST] ON
INSERT [dbo].[tblYarnQualityMST] ([YarnQualityID], [YarnQualityName], [Description], [IsDelete], [IsActive], [CreateBy], [CreationDateTime], [UpdateBy], [UpdationDateTime]) VALUES (1, N'Polyeeester', N'ABC', 0, 1, 1, NULL, NULL, NULL)
INSERT [dbo].[tblYarnQualityMST] ([YarnQualityID], [YarnQualityName], [Description], [IsDelete], [IsActive], [CreateBy], [CreationDateTime], [UpdateBy], [UpdationDateTime]) VALUES (2, N'AB', N'xxx', 1, 1, 1, CAST(0x0000A45B015FDCF4 AS DateTime), 1, CAST(0x0000A45B016003A8 AS DateTime))
INSERT [dbo].[tblYarnQualityMST] ([YarnQualityID], [YarnQualityName], [Description], [IsDelete], [IsActive], [CreateBy], [CreationDateTime], [UpdateBy], [UpdationDateTime]) VALUES (3, N'Polyeeester', N'aaaa', 1, 1, 1, CAST(0x0000A45C00E500D9 AS DateTime), NULL, NULL)
INSERT [dbo].[tblYarnQualityMST] ([YarnQualityID], [YarnQualityName], [Description], [IsDelete], [IsActive], [CreateBy], [CreationDateTime], [UpdateBy], [UpdationDateTime]) VALUES (4, N'ABC', N'123
', 0, 1, 1, CAST(0x0000A45C01357BEF AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblYarnQualityMST] OFF
/****** Object:  Table [dbo].[tblYarnPackageType]    Script Date: 03/16/2015 19:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblYarnPackageType](
	[YarnPackageTypeID] [bigint] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NULL,
	[IsDelete] [bit] NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDateTime] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblPackageType] PRIMARY KEY CLUSTERED 
(
	[YarnPackageTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblYarnPurchase]    Script Date: 03/16/2015 19:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblYarnPurchase](
	[PurchaseID] [bigint] IDENTITY(1,1) NOT NULL,
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
	[IsDelete] [bit] NULL,
	[IsDelete	bit	Checked] [nchar](10) NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDateTime] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpDatedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblYarnPurchase] PRIMARY KEY CLUSTERED 
(
	[PurchaseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblWithdrownMST]    Script Date: 03/16/2015 19:13:39 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  Table [dbo].[tblWorkingYear]    Script Date: 03/16/2015 19:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblWorkingYear](
	[YearID] [int] IDENTITY(1,1) NOT NULL,
	[YearName] [varchar](50) NULL,
	[IsDelete] [bit] NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDateTime] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblWorkingYear] PRIMARY KEY CLUSTERED 
(
	[YearID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblProfeListMst]    Script Date: 03/16/2015 19:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProfeListMst](
	[ProfeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
 CONSTRAINT [PK_tblProfeListMst] PRIMARY KEY CLUSTERED 
(
	[ProfeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblProfeListMst] ON
INSERT [dbo].[tblProfeListMst] ([ProfeID], [Name]) VALUES (1, N'ABC')
INSERT [dbo].[tblProfeListMst] ([ProfeID], [Name]) VALUES (2, N'xyz')
SET IDENTITY_INSERT [dbo].[tblProfeListMst] OFF
/****** Object:  Table [dbo].[tblProductQualityMST]    Script Date: 03/16/2015 19:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblProductQualityMST](
	[ProductQualityID] [bigint] IDENTITY(1,1) NOT NULL,
	[ProductQualityName] [varchar](50) NULL,
	[WARPDenierAfterTPM] [float] NULL,
	[WARPNumberOfFilaments] [int] NULL,
	[WARPYarnQualityID] [int] NULL,
	[WARPYarnTypeID] [int] NULL,
	[WARPDirectionOfTwistS] [varchar](50) NULL,
	[WARPDirectionOfTwistZ] [varchar](50) NULL,
	[WARPTwistPerMeterS] [int] NULL,
	[WARPTwistPerMeterZ] [int] NULL,
	[WEFTDenierAfterTPM] [float] NULL,
	[WEFTNumberOfFilaments1] [int] NULL,
	[WEFTYarnQualityID] [int] NULL,
	[WEFTYarnTypeID] [int] NULL,
	[WEFTDirectionOfTwistS] [varchar](50) NULL,
	[WEFTDirectionOfTwistZ] [varchar](50) NULL,
	[WEFTTwistPerMeterS] [int] NULL,
	[WEFTTwistPerMeterZ] [int] NULL,
	[ApproxTotalEndsWithBorder] [int] NULL,
	[ReedOnLoom] [float] NULL,
	[PickOnLoom] [float] NULL,
	[Border] [float] NULL,
	[HeatSetting] [varchar](50) NULL,
	[WeightOfFabricWARP] [float] NULL,
	[WeightOfFabricWEFT] [float] NULL,
	[TotalWeight] [float] NULL,
	[IsDelete] [bit] NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDateTime] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblProductQualityMaster] PRIMARY KEY CLUSTERED 
(
	[ProductQualityID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblPartysMST]    Script Date: 03/16/2015 19:13:39 ******/
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
	[IsDelete] [bit] NULL,
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
SET IDENTITY_INSERT [dbo].[tblPartysMST] ON
INSERT [dbo].[tblPartysMST] ([PartyID], [CompanyCode], [PartyName], [ContactPersonName], [OfficeAddress], [ShippingAddress], [City], [State], [MobileNo], [PhoneNo], [SMSNo], [ReferencePersonName], [ReferencePersonMobileNo], [EmailID], [ExtraDetails], [TINNo], [TINDate], [PANNO], [CSTTINNo], [CSTDate], [ECCNo], [IsDelete], [IsActive], [CreateBye], [CreationDateTime], [UpdateBy], [UpdationDateTIme]) VALUES (1, 26, N'Nilesh', N'Sunny', N'Ranajit', N'Ranajit', N'Surat', N'Gujarat', N'8866824547', N'8866824547', NULL, N'Mayur', N'8866303520', N'joliyanilesh@gmail.com', N'Good
', N'123', CAST(0xB7390B00 AS Date), N'123', N'123', NULL, N'123', 0, 1, 1, CAST(0x0000A45C00DCBD87 AS DateTime), NULL, NULL)
INSERT [dbo].[tblPartysMST] ([PartyID], [CompanyCode], [PartyName], [ContactPersonName], [OfficeAddress], [ShippingAddress], [City], [State], [MobileNo], [PhoneNo], [SMSNo], [ReferencePersonName], [ReferencePersonMobileNo], [EmailID], [ExtraDetails], [TINNo], [TINDate], [PANNO], [CSTTINNo], [CSTDate], [ECCNo], [IsDelete], [IsActive], [CreateBye], [CreationDateTime], [UpdateBy], [UpdationDateTIme]) VALUES (2, 26, N'Nilesh', N'jjk', N'jk', N'jk', N'jkj', N'jk', N'jk', N'jk', NULL, N'kl', N'klh', N'jk', N'kj', N'jk', CAST(0xB7390B00 AS Date), N'kjbk', N'kj', NULL, N'jh', 0, 1, 1, CAST(0x0000A45C00DDEE25 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblPartysMST] OFF
/****** Object:  Table [dbo].[tblPenaltyMST]    Script Date: 03/16/2015 19:13:39 ******/
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
	[IsDelete] [bit] NULL,
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
SET IDENTITY_INSERT [dbo].[tblPenaltyMST] ON
INSERT [dbo].[tblPenaltyMST] ([PenaltyID], [PenaltyCode], [PenaltyName], [Description], [IsDelete], [IsActive], [CreateBy], [CreationDateTime], [UpdateBy], [UpdationDateTime]) VALUES (1, N'123', N'ABC', N'ds
', 0, 1, 1, CAST(0x0000A45D00FA002E AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblPenaltyMST] OFF
/****** Object:  Table [dbo].[tblLoomProcessWork]    Script Date: 03/16/2015 19:13:39 ******/
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
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK_tblLoomProcessWork] PRIMARY KEY CLUSTERED 
(
	[LoomProcessWorkID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblMendingDetailsProcess]    Script Date: 03/16/2015 19:13:39 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  Table [dbo].[tblMendingPenulty]    Script Date: 03/16/2015 19:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMendingPenulty](
	[MendingPenultyID] [bigint] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [bigint] NULL,
	[PenultyID] [bigint] NULL,
	[IsDelete] [bit] NULL,
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
/****** Object:  Table [dbo].[tblLoomProcess]    Script Date: 03/16/2015 19:13:39 ******/
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
	[IsDelete] [bit] NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDateTime] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblLoomProcess] PRIMARY KEY CLUSTERED 
(
	[LoomProcessID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmployeeTypeMST]    Script Date: 03/16/2015 19:13:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmployeeTypeMST](
	[EmployeeTypeID] [bigint] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[IsDelete] [bit] NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDateTime] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblEmployeeType] PRIMARY KEY CLUSTERED 
(
	[EmployeeTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblEmployeeTypeMST] ON
INSERT [dbo].[tblEmployeeTypeMST] ([EmployeeTypeID], [TypeName], [Description], [IsDelete], [IsActive], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (1, N'Manager', N'Manager', 0, 1, 1, CAST(0x0000A4580131AC26 AS DateTime), NULL, NULL)
INSERT [dbo].[tblEmployeeTypeMST] ([EmployeeTypeID], [TypeName], [Description], [IsDelete], [IsActive], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (2, N'Employee', N'Employee', 0, 1, 1, CAST(0x0000A45801426044 AS DateTime), 1, CAST(0x0000A458014295C1 AS DateTime))
INSERT [dbo].[tblEmployeeTypeMST] ([EmployeeTypeID], [TypeName], [Description], [IsDelete], [IsActive], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (3, N'abc', N'abc', 1, 1, 1, CAST(0x0000A4580142A983 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblEmployeeTypeMST] OFF
/****** Object:  StoredProcedure [dbo].[tblEmployeeType_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblEmployeeType_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblEmployeeType_UPDATE]
@EmployeeTypeID		bigint ,
@TypeName		varchar(50),
@Description		varchar(500),
@IsActive bit,
@UpdatedBy int,
@UpdatedDateTime datetime


AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblEmployeeType
SET
	TypeName=@TypeName,
	[Description]=@Description,
	

UpdatedBy=@UpdatedBy,
UpdatedDateTime=@UpdatedDateTime
WHERE 
	EmployeeTypeID=@EmployeeTypeID
GO
/****** Object:  StoredProcedure [dbo].[tblEmployeeType_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblEmployeeType_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblEmployeeType_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	EmployeeTypeID,
	TypeName,
	[Description],
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblEmployeeType
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblEmployeeType_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblEmployeeType_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblEmployeeType_INSERT]
@TypeName		varchar(50),
@Description		varchar(500),
@IsActive bit,
@CreatedBy int,
@CreatedDateTime datetime


AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblEmployeeType
		(
		TypeName,
		[Description],
		IsActive,
		CreatedBy,
		CreatedDateTime
		)
VALUES 
		(
		@TypeName,
		@Description,
		@IsActive,
		@CreatedBy,
		@CreatedDateTime
		)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblEmployeeType_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblEmployeeType_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblEmployeeType_DELETE]
@EmployeeTypeID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update 	tblEmployeeType
set IsActive=0

WHERE 
	EmployeeTypeID=@EmployeeTypeID
GO
/****** Object:  StoredProcedure [dbo].[tblEmployeeType_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblEmployeeType_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblEmployeeType_BY_ID_LOAD]
@EmployeeTypeID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	EmployeeTypeID,
	TypeName,
	[Description],
	
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblEmployeeType
WHERE 
	EmployeeTypeID=@EmployeeTypeID and IsActive =1
GO
/****** Object:  Table [dbo].[tblCompany]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCompany](
	[CompanyID] [bigint] IDENTITY(1,1) NOT NULL,
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
	[IsDelete] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDateTime] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblCompany] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblCompany] ON
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (23, N'mayur', N'aj', N'mayur', CAST(0xB0390B00 AS Date), N'sdfsdf

', N'afs', NULL, 55455, N'sdfs', N'sdfs', N'sdfs', N'23330', 1, 1, 1, CAST(0x0000A45600F16EE6 AS DateTime), 1, CAST(0x0000A45600F18A0B AS DateTime))
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (24, N'mayur', N'fd', N'f', CAST(0x00000000 AS Date), N'
sfdsfdsfsfsfsfsfs
fdfdfd

', N'dfd', NULL, 434, N'sfds', N'fd', N'd', N'3434', 1, 1, 1, CAST(0x0000A45600F17973 AS DateTime), 1, CAST(0x0000A45600F4F1AC AS DateTime))
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (25, N'12', N'123', N'232', CAST(0xA9390B00 AS Date), N'2
', N'2', NULL, 2, N'2', N'2', N'2', N'2', 1, 1, 1, CAST(0x0000A45600F4AD7E AS DateTime), 1, CAST(0x0000A45800AF83C0 AS DateTime))
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (26, N'f', N'f', N'f', CAST(0x00000000 AS Date), N'f

', N'f', NULL, 45, N'ff', N'f', N'f', N'211', 1, 1, 1, CAST(0x0000A45600F4BE2A AS DateTime), NULL, NULL)
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (27, N'q', N'q', N'q', CAST(0xB0390B00 AS Date), N'2
', N'2', NULL, 12, N'2', N'2', N'2', N'2', 1, 1, 1, CAST(0x0000A45601206A04 AS DateTime), NULL, NULL)
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (28, N'2', N'2', N'2', CAST(0xAA390B00 AS Date), N'2
', N'32', NULL, 2, N'2', N'2', N'2', N'2', 1, 1, 1, CAST(0x0000A45601207A07 AS DateTime), NULL, NULL)
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (29, N'45', N'45', N'45', CAST(0xAC390B00 AS Date), N'
4544
', N'45', NULL, 5, N'545', N'4545', N'4', N'45', 1, 1, 1, CAST(0x0000A456016DA6C4 AS DateTime), NULL, NULL)
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (30, N'1', N'3', N'4', CAST(0xAD390B00 AS Date), N'5
', N'5', NULL, 5, N'5', N'5', N'5', N'5', 1, 1, 1, CAST(0x0000A456017F0E7A AS DateTime), 1, CAST(0x0000A45800AF7FD8 AS DateTime))
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (31, N'5', N'5', N'5', CAST(0xAD390B00 AS Date), N'5
', N'5', NULL, 5, N'5', N'5', N'5', N'5', 1, 1, 1, CAST(0x0000A456017F1541 AS DateTime), NULL, NULL)
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (32, N'55', N'5', N'5', CAST(0xAD390B00 AS Date), N'5
', N'5', NULL, 5, N'5', N'5', N'5', N'5', 1, 1, 1, CAST(0x0000A45700B6ED72 AS DateTime), NULL, NULL)
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (33, N'3', N'32', N'3', CAST(0xAA390B00 AS Date), N'3
', N'3', NULL, 3, N'3', N'32', N'32', N'32', 1, 1, 1, CAST(0x0000A45700B6F84D AS DateTime), NULL, NULL)
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (34, N'4', N'232', N'2', CAST(0xAA390B00 AS Date), N'2

', N'3', NULL, 3, N'545', N'2', N'2', N'2', 1, 1, 1, CAST(0x0000A45700B704DC AS DateTime), 1, CAST(0x0000A458010D523C AS DateTime))
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (35, N'56', N'3', N'33', CAST(0xAB390B00 AS Date), N'33
', N'3', NULL, 3, N'3', N'3', N'3', N'3', 1, 1, 1, CAST(0x0000A45700BE91ED AS DateTime), NULL, NULL)
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (36, N'122', N'131', N'1', CAST(0xAA390B00 AS Date), N'2

', N'2', NULL, 2, N'2', N'2', N'2', N'2', 1, 1, 1, CAST(0x0000A45700C141B0 AS DateTime), NULL, NULL)
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (37, N'2323', N'323', N'323', CAST(0xAA390B00 AS Date), N'


21212112
', N'23', NULL, 1, N'1232', N'32', N'23', N'23', 1, 1, 1, CAST(0x0000A45800AF4FAE AS DateTime), NULL, NULL)
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (38, N'a', N'a', N'a', CAST(0xD2390B00 AS Date), N'a
a

', N'a', NULL, 3, N'aa', N'aa', N'aa', N'4', 1, 1, 1, CAST(0x0000A458010D8E38 AS DateTime), NULL, NULL)
INSERT [dbo].[tblCompany] ([CompanyID], [CompanyName], [ComapnyCode], [OwnerName], [StartDate], [Address], [ContactPersonName], [CreationDate], [InvestmentAmount], [PANNo], [CSTNo], [ECCNo], [SMSNO], [IsActive], [IsDelete], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (39, N'ABC', N'1', N'1', CAST(0x7C390B00 AS Date), N'1
', N'1', NULL, 1, N'1', N'1', N'1', N'1', 1, 0, 1, CAST(0x0000A45C00E53E80 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblCompany] OFF
/****** Object:  StoredProcedure [dbo].[tblCompanyMachine_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblCompanyMachine_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblCompanyMachine_UPDATE]
@RowId		bigint,
@MachineId		bigint,
@CompanyId		bigint

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblCompanyMachine
SET
	RowId=@RowId,
	MachineId=@MachineId,
	CompanyId=@CompanyId
WHERE 
	RowId=@RowId
GO
/****** Object:  StoredProcedure [dbo].[tblCompanyMachine_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblCompanyMachine_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblCompanyMachine_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	RowId,
	MachineId,
	CompanyId
FROM 
	tblCompanyMachine
GO
/****** Object:  StoredProcedure [dbo].[tblCompanyMachine_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblCompanyMachine_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblCompanyMachine_INSERT]
@RowId		bigint,
@MachineId		bigint,
@CompanyId		bigint

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblCompanyMachine
		(
		RowId,
		MachineId,
		CompanyId)
VALUES 
		(
		@RowId,
		@MachineId,
		@CompanyId)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblCompanyMachine_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblCompanyMachine_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblCompanyMachine_DELETE]
@RowId		bigint

AS

/*
	Delete records against the give criteria.
*/

DELETE 

FROM 
	tblCompanyMachine

WHERE 
	RowId=@RowId
GO
/****** Object:  StoredProcedure [dbo].[tblCompanyMachine_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblCompanyMachine_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblCompanyMachine_BY_ID_LOAD]
@RowId		bigint

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	RowId,
	MachineId,
	CompanyId
FROM 
	tblCompanyMachine
WHERE 
	RowId=@RowId
GO
/****** Object:  Table [dbo].[tblMandingProcess]    Script Date: 03/16/2015 19:13:42 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  Table [dbo].[tblMachineTypeMST]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMachineTypeMST](
	[MachineTypeID] [bigint] IDENTITY(1,1) NOT NULL,
	[TypeName] [varchar](50) NULL,
	[Description] [varchar](500) NULL,
	[IsDelete] [bit] NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDateTime] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblMachineType] PRIMARY KEY CLUSTERED 
(
	[MachineTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblMachineTypeMST] ON
INSERT [dbo].[tblMachineTypeMST] ([MachineTypeID], [TypeName], [Description], [IsDelete], [IsActive], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (1, N'Water Jet', N'Good Production', 0, 1, 1, CAST(0x0000A45C012D2B5A AS DateTime), NULL, NULL)
INSERT [dbo].[tblMachineTypeMST] ([MachineTypeID], [TypeName], [Description], [IsDelete], [IsActive], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (2, N'Loom', N'Good
', 1, 1, 1, CAST(0x0000A45C012E54DC AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblMachineTypeMST] OFF
/****** Object:  StoredProcedure [dbo].[tblMachineType_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMachineType_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMachineType_UPDATE]
@MachineTypeID		bigint ,
@TypeName		varchar(50),
@Description		varchar(500),
@IsActive bit,
@UpdatedBy	int,
@UpdatedDateTime datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblMachineType
SET
	TypeName=@TypeName,
	[Description]=@Description,
	IsActive=@IsActive,
	UpdatedBy=@UpdatedBy,
	UpdatedDateTime=@UpdatedDateTime
	
WHERE 
	MachineTypeID=@MachineTypeID
GO
/****** Object:  StoredProcedure [dbo].[tblMachineType_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMachineType_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMachineType_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	MachineTypeID,
	TypeName,
	[Description],
	IsActive,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblMachineType
	where IsActive =1
GO
/****** Object:  StoredProcedure [dbo].[tblMachineType_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMachineType_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMachineType_INSERT]
@TypeName		varchar(50),
@Description		varchar(500),
@IsActive bit,
@CreatedBy int,
@CreatedDateTime datetime


AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblMachineType
		(
		TypeName,
		[Description],
		IsActive,
		CreatedBy,
		CreatedDateTime
		)
VALUES 
		(
		@TypeName,
		@Description,
		@IsActive,
		@CreatedBy,
		@CreatedDateTime
		)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblMachineType_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMachineType_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMachineType_DELETE]
@MachineTypeID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblMachineType
set IsActive =0

WHERE 
	MachineTypeID=@MachineTypeID
GO
/****** Object:  StoredProcedure [dbo].[tblMachineType_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMachineType_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMachineType_BY_ID_LOAD]
@MachineTypeID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	MachineTypeID,
	TypeName,
	[Description],
	IsActive,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblMachineType
WHERE 
	MachineTypeID=@MachineTypeID and IsActive =1
GO
/****** Object:  Table [dbo].[tblMachineMST]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblMachineMST](
	[MachineID] [bigint] IDENTITY(1,1) NOT NULL,
	[MachineName] [varchar](50) NULL,
	[MachineTypeID] [bigint] NULL,
	[AboutMachine] [varchar](50) NULL,
	[IsDelete] [bit] NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDateTime] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDateTime] [datetime] NULL,
 CONSTRAINT [PK_tblMachine] PRIMARY KEY CLUSTERED 
(
	[MachineID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tblMachineMST] ON
INSERT [dbo].[tblMachineMST] ([MachineID], [MachineName], [MachineTypeID], [AboutMachine], [IsDelete], [IsActive], [CreatedBy], [CreatedDateTime], [UpdatedBy], [UpdatedDateTime]) VALUES (1, N'ABC', 1, N'Good
', 0, 1, 1, CAST(0x0000A45C012EC0A6 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblMachineMST] OFF
/****** Object:  StoredProcedure [dbo].[tblMachine_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMachine_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMachine_UPDATE]
@MachineID		bigint,
@MachineName		varchar(50),
@MachineTypeID		bigint,
@AboutMachine		varchar(50),
@IsActive		bit,
@UpdatedBy int,
@UpdatedDateTime datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblMachine
SET
	MachineID=@MachineID,
	MachineName=@MachineName,
	MachineTypeID=@MachineTypeID,
	AboutMachine=@AboutMachine,
	IsActive=@IsActive,
	UpdatedBy=@UpdatedBy,
	UpdatedDateTime=@UpdatedDateTime
WHERE 
	MachineID=@MachineID
GO
/****** Object:  StoredProcedure [dbo].[tblMachine_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMachine_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMachine_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	MachineID,
	MachineName,
	MachineTypeID,
	AboutMachine,
	IsActive,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblMachine
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblMachine_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMachine_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMachine_INSERT]
@MachineID		bigint,
@MachineName		varchar(50),
@MachineTypeID		bigint,
@AboutMachine		varchar(50),
@IsActive		bit,
@CreatedBy int,
@CreatedDateTime datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblMachine
		(
		MachineID,
		MachineName,
		MachineTypeID,
		AboutMachine,
		IsActive,
		CreatedBy,
		CreatedDateTime
		)
VALUES 
		(
		@MachineID,
		@MachineName,
		@MachineTypeID,
		@AboutMachine,
		@IsActive,
		@CreatedBy,
		@CreatedDateTime
		)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblMachine_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMachine_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMachine_DELETE]
@MachineID		bigint

AS

/*
	Delete records against the give criteria.
*/

Update tblMachine
set IsActive=0

WHERE 
	MachineID=@MachineID
GO
/****** Object:  StoredProcedure [dbo].[tblMachine_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMachine_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMachine_BY_ID_LOAD]
@MachineID		bigint

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	MachineID,
	MachineName,
	MachineTypeID,
	AboutMachine,
	IsActive,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblMachine
WHERE 
	MachineID=@MachineID and IsActive=1
GO
/****** Object:  Table [dbo].[tblBrokersMST]    Script Date: 03/16/2015 19:13:42 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  Table [dbo].[tblBoilerProcess]    Script Date: 03/16/2015 19:13:42 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  Table [dbo].[tblBeemProcess]    Script Date: 03/16/2015 19:13:42 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  Table [dbo].[tblBankMST]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblBankMST](
	[BankID] [bigint] IDENTITY(1,1) NOT NULL,
	[BankName] [varchar](50) NULL,
	[IsDelete] [bit] NULL,
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
SET IDENTITY_INSERT [dbo].[tblBankMST] ON
INSERT [dbo].[tblBankMST] ([BankID], [BankName], [IsDelete], [IsActive], [CreateBy], [CreationDateTime], [UpdateBy], [UpdationDateTime]) VALUES (1, N'SBI', 0, 1, 1, CAST(0x0000A45C013248C8 AS DateTime), 1, CAST(0x0000A45C01332B44 AS DateTime))
INSERT [dbo].[tblBankMST] ([BankID], [BankName], [IsDelete], [IsActive], [CreateBy], [CreationDateTime], [UpdateBy], [UpdationDateTime]) VALUES (2, N'HDFC', 0, 1, 1, CAST(0x0000A45C0132555C AS DateTime), NULL, NULL)
INSERT [dbo].[tblBankMST] ([BankID], [BankName], [IsDelete], [IsActive], [CreateBy], [CreationDateTime], [UpdateBy], [UpdationDateTime]) VALUES (3, N'ICICI', 1, 1, 1, CAST(0x0000A45C01326375 AS DateTime), NULL, NULL)
INSERT [dbo].[tblBankMST] ([BankID], [BankName], [IsDelete], [IsActive], [CreateBy], [CreationDateTime], [UpdateBy], [UpdationDateTime]) VALUES (4, N'BOI', 0, 1, 1, CAST(0x0000A45C01326B89 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblBankMST] OFF
/****** Object:  Table [dbo].[tblBeamMST]    Script Date: 03/16/2015 19:13:42 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  StoredProcedure [dbo].[tblBankMST_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBankMST_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBankMST_UPDATE]
@BankID		bigint ,
@BankName		varchar(50),
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblBankMST
SET
	BankName=@BankName,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	BankID=@BankID
GO
/****** Object:  StoredProcedure [dbo].[tblBankMST_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBankMST_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBankMST_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	BankID,
	BankName,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblBankMST where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblBankMST_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBankMST_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBankMST_INSERT]
@BankName		varchar(50),
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblBankMST
		(
		BankName,
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@BankName,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblBankMST_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBankMST_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBankMST_DELETE]
@BankID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblBankMST
set IsActive=0

WHERE 
	BankID=@BankID
GO
/****** Object:  StoredProcedure [dbo].[tblBankMST_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBankMST_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBankMST_BY_ID_LOAD]
@BankID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	BankID,
	BankName,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblBankMST
WHERE 
	BankID=@BankID and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblBeamMST_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBeamMST_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBeamMST_UPDATE]
@BeemID		bigint ,
@CompnayID		bigint,
@WrapperPartyName		int,
@JobberPartyName		int,
@BeemDate		date,
@YarnQuality		int,
@GrayQuality		int,
@TarNo		int,
@Meters		float,
@Taka		int,
@Weight		float,
@ProductionMeters		float,
@ProductionTaka		int,
@PipeWeight		float,
@LoadingDate		date,
@MinStragy		float,
@MachinNo		int,
@Remarks		varchar(100),
@BhidanStatus		bit,
@BhidanDate		date,
@PasaraiName		int,
@Count		float,
@IssuDate		date,
@TakaMeter		bit,
@Rate		float,
@Amount		float,
@MeterConsumption		float,
@RPM		float,
@Pick		float,
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblBeamMST
SET
	CompnayID=@CompnayID,
	WrapperPartyName=@WrapperPartyName,
	JobberPartyName=@JobberPartyName,
	BeemDate=@BeemDate,
	YarnQuality=@YarnQuality,
	GrayQuality=@GrayQuality,
	TarNo=@TarNo,
	Meters=@Meters,
	Taka=@Taka,
	Weight=@Weight,
	ProductionMeters=@ProductionMeters,
	ProductionTaka=@ProductionTaka,
	PipeWeight=@PipeWeight,
	LoadingDate=@LoadingDate,
	MinStragy=@MinStragy,
	MachinNo=@MachinNo,
	Remarks=@Remarks,
	BhidanStatus=@BhidanStatus,
	BhidanDate=@BhidanDate,
	PasaraiName=@PasaraiName,
	[Count]=@Count,
	IssuDate=@IssuDate,
	TakaMeter=@TakaMeter,
	Rate=@Rate,
	Amount=@Amount,
	MeterConsumption=@MeterConsumption,
	RPM=@RPM,
	Pick=@Pick,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	BeemID=@BeemID
GO
/****** Object:  StoredProcedure [dbo].[tblBeamMST_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBeamMST_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBeamMST_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	BeemID,
	CompnayID,
	WrapperPartyName,
	JobberPartyName,
	BeemDate,
	YarnQuality,
	GrayQuality,
	TarNo,
	Meters,
	Taka,
	[Weight],
	ProductionMeters,
	ProductionTaka,
	PipeWeight,
	LoadingDate,
	MinStragy,
	MachinNo,
	Remarks,
	BhidanStatus,
	BhidanDate,
	PasaraiName,
	[Count],
	IssuDate,
	TakaMeter,
	Rate,
	Amount,
	MeterConsumption,
	RPM,
	Pick,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblBeamMST
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblBeamMST_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBeamMST_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBeamMST_INSERT]
@CompnayID		bigint,
@WrapperPartyName		int,
@JobberPartyName		int,
@BeemDate		date,
@YarnQuality		int,
@GrayQuality		int,
@TarNo		int,
@Meters		float,
@Taka		int,
@Weight		float,
@ProductionMeters		float,
@ProductionTaka		int,
@PipeWeight		float,
@LoadingDate		date,
@MinStragy		float,
@MachinNo		int,
@Remarks		varchar(100),
@BhidanStatus		bit,
@BhidanDate		date,
@PasaraiName		int,
@Count		float,
@IssuDate		date,
@TakaMeter		bit,
@Rate		float,
@Amount		float,
@MeterConsumption		float,
@RPM		float,
@Pick		float,
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblBeamMST
		(
		CompnayID,
		WrapperPartyName,
		JobberPartyName,
		BeemDate,
		YarnQuality,
		GrayQuality,
		TarNo,
		Meters,
		Taka,
		[Weight],
		ProductionMeters,
		ProductionTaka,
		PipeWeight,
		LoadingDate,
		MinStragy,
		MachinNo,
		Remarks,
		BhidanStatus,
		BhidanDate,
		PasaraiName,
		[Count],
		IssuDate,
		TakaMeter,
		Rate,
		Amount,
		MeterConsumption,
		RPM,
		Pick,
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@CompnayID,
		@WrapperPartyName,
		@JobberPartyName,
		@BeemDate,
		@YarnQuality,
		@GrayQuality,
		@TarNo,
		@Meters,
		@Taka,
		@Weight,
		@ProductionMeters,
		@ProductionTaka,
		@PipeWeight,
		@LoadingDate,
		@MinStragy,
		@MachinNo,
		@Remarks,
		@BhidanStatus,
		@BhidanDate,
		@PasaraiName,
		@Count,
		@IssuDate,
		@TakaMeter,
		@Rate,
		@Amount,
		@MeterConsumption,
		@RPM,
		@Pick,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblBeamMST_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBeamMST_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBeamMST_DELETE]
@BeemID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblBeamMST
set IsActive=0

WHERE 
	BeemID=@BeemID
GO
/****** Object:  StoredProcedure [dbo].[tblBeamMST_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBeamMST_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBeamMST_BY_ID_LOAD]
@BeemID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	BeemID,
	CompnayID,
	WrapperPartyName,
	JobberPartyName,
	BeemDate,
	YarnQuality,
	GrayQuality,
	TarNo,
	Meters,
	Taka,
	[Weight],
	ProductionMeters,
	ProductionTaka,
	PipeWeight,
	LoadingDate,
	MinStragy,
	MachinNo,
	Remarks,
	BhidanStatus,
	BhidanDate,
	PasaraiName,
	[Count],
	IssuDate,
	TakaMeter,
	Rate,
	Amount,
	MeterConsumption,
	RPM,
	Pick,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblBeamMST
WHERE 
	BeemID=@BeemID and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblBeemProcess_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBeemProcess_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBeemProcess_UPDATE]
@BeemProcessID		bigint ,
@MachineID		bigint,
@EmployeeID		bigint,
@Shift		varchar(50),
@StartDateTime		datetime,
@EndDateTime		datetime,
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblBeemProcess
SET
	MachineID=@MachineID,
	EmployeeID=@EmployeeID,
	Shift=@Shift,
	StartDateTime=@StartDateTime,
	EndDateTime=@EndDateTime,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	BeemProcessID=@BeemProcessID
GO
/****** Object:  StoredProcedure [dbo].[tblBeemProcess_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBeemProcess_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBeemProcess_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	BeemProcessID,
	MachineID,
	EmployeeID,
	Shift,
	StartDateTime,
	EndDateTime,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblBeemProcess 
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblBeemProcess_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBeemProcess_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBeemProcess_INSERT]
@MachineID		bigint,
@EmployeeID		bigint,
@Shift		varchar(50),
@StartDateTime		datetime,
@EndDateTime		datetime,
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblBeemProcess
		(
		MachineID,
		EmployeeID,
		Shift,
		StartDateTime,
		EndDateTime,
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@MachineID,
		@EmployeeID,
		@Shift,
		@StartDateTime,
		@EndDateTime,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblBeemProcess_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBeemProcess_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBeemProcess_DELETE]
@BeemProcessID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update 	tblBeemProcess
set IsActive=0

WHERE 
	BeemProcessID=@BeemProcessID
GO
/****** Object:  StoredProcedure [dbo].[tblBeemProcess_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBeemProcess_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBeemProcess_BY_ID_LOAD]
@BeemProcessID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	BeemProcessID,
	MachineID,
	EmployeeID,
	Shift,
	StartDateTime,
	EndDateTime,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblBeemProcess
WHERE 
	BeemProcessID=@BeemProcessID and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblBoilerProcess_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBoilerProcess_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBoilerProcess_UPDATE]
@BolierProcessID		bigint ,
@MachineID		bigint,
@EmployeeID		bigint,
@Shift		varchar(50),
@StartDateTime		datetime,
@EndDateTime		datetime,
@Tempreture		float,
@IsActive		bit,
@UpdateBy		int,

@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblBoilerProcess
SET
	MachineID=@MachineID,
	EmployeeID=@EmployeeID,
	Shift=@Shift,
	StartDateTime=@StartDateTime,
	EndDateTime=@EndDateTime,
	Tempreture=@Tempreture,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	
	UpdationDateTime=@UpdationDateTime
WHERE 
	BolierProcessID=@BolierProcessID
GO
/****** Object:  StoredProcedure [dbo].[tblBoilerProcess_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBoilerProcess_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBoilerProcess_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	BolierProcessID,
	MachineID,
	EmployeeID,
	Shift,
	StartDateTime,
	EndDateTime,
	Tempreture,
	IsActive,
	UpdateBy,
	CreateBy,
	UpdationDateTime,
	CreationDateTIme
FROM 
	tblBoilerProcess
where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblBoilerProcess_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBoilerProcess_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBoilerProcess_INSERT]
@MachineID		bigint,
@EmployeeID		bigint,
@Shift		varchar(50),
@StartDateTime		datetime,
@EndDateTime		datetime,
@Tempreture		float,
@IsActive		bit,

@CreateBy		int,

@CreationDateTIme		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblBoilerProcess
		(
		MachineID,
		EmployeeID,
		Shift,
		StartDateTime,
		EndDateTime,
		Tempreture,
		IsActive,
		
		CreateBy,
		
		CreationDateTIme)
VALUES 
		(
		@MachineID,
		@EmployeeID,
		@Shift,
		@StartDateTime,
		@EndDateTime,
		@Tempreture,
		@IsActive,
		
		@CreateBy,
		
		@CreationDateTIme)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblBoilerProcess_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBoilerProcess_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBoilerProcess_DELETE]
@BolierProcessID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblBoilerProcess
set IsActive =0

WHERE 
	BolierProcessID=@BolierProcessID
GO
/****** Object:  StoredProcedure [dbo].[tblBoilerProcess_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBoilerProcess_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBoilerProcess_BY_ID_LOAD]
@BolierProcessID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	BolierProcessID,
	MachineID,
	EmployeeID,
	Shift,
	StartDateTime,
	EndDateTime,
	Tempreture,
	IsActive,
	UpdateBy,
	CreateBy,
	UpdationDateTime,
	CreationDateTIme
FROM 
	tblBoilerProcess
WHERE 
	BolierProcessID=@BolierProcessID and IsActive=1
GO
/****** Object:  Table [dbo].[tblBranchMST]    Script Date: 03/16/2015 19:13:42 ******/
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
	[IsDelete] [bit] NULL,
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
SET IDENTITY_INSERT [dbo].[tblBranchMST] ON
INSERT [dbo].[tblBranchMST] ([BranchID], [BranchName], [Address], [BankID], [IsDelete], [IsActive], [CreateBy], [CreationDateTime], [UpdateBy], [UpdationDateTime]) VALUES (1, N'Podar', N'Podar Arcade Dangar Wada Varachha Road Surat
', 1, 0, 1, 1, CAST(0x0000A45C01352072 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblBranchMST] OFF
/****** Object:  StoredProcedure [dbo].[tblLoomProcessWork_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblLoomProcessWork_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblLoomProcessWork_UPDATE]
@LoomProcessWorkID		bigint ,
@LoomProcessID		bigint,
@EmployeeID		bigint,
@WorkingDate		date,
@StartTime		time,
@EndTime		time,
@Shift		varchar(50),
@MTRStart		float,
@MTREnd		float

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblLoomProcessWork
SET
	LoomProcessID=@LoomProcessID,
	EmployeeID=@EmployeeID,
	WorkingDate=@WorkingDate,
	StartTime=@StartTime,
	EndTime=@EndTime,
	Shift=@Shift,
	MTRStart=@MTRStart,
	MTREnd=@MTREnd
WHERE 
	LoomProcessWorkID=@LoomProcessWorkID
GO
/****** Object:  StoredProcedure [dbo].[tblLoomProcessWork_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblLoomProcessWork_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblLoomProcessWork_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	LoomProcessWorkID,
	LoomProcessID,
	EmployeeID,
	WorkingDate,
	StartTime,
	EndTime,
	Shift,
	MTRStart,
	MTREnd
FROM 
	tblLoomProcessWork
GO
/****** Object:  StoredProcedure [dbo].[tblLoomProcessWork_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblLoomProcessWork_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblLoomProcessWork_INSERT]
@LoomProcessID		bigint,
@EmployeeID		bigint,
@WorkingDate		date,
@StartTime		time,
@EndTime		time,
@Shift		varchar(50),
@MTRStart		float,
@MTREnd		float

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblLoomProcessWork
		(
		LoomProcessID,
		EmployeeID,
		WorkingDate,
		StartTime,
		EndTime,
		Shift,
		MTRStart,
		MTREnd)
VALUES 
		(
		@LoomProcessID,
		@EmployeeID,
		@WorkingDate,
		@StartTime,
		@EndTime,
		@Shift,
		@MTRStart,
		@MTREnd)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblLoomProcessWork_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblLoomProcessWork_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblLoomProcessWork_DELETE]
@LoomProcessWorkID		bigint 

AS

/*
	Delete records against the give criteria.
*/

DELETE 

FROM 
	tblLoomProcessWork

WHERE 
	LoomProcessWorkID=@LoomProcessWorkID
GO
/****** Object:  StoredProcedure [dbo].[tblLoomProcessWork_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblLoomProcessWork_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblLoomProcessWork_BY_ID_LOAD]
@LoomProcessWorkID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	LoomProcessWorkID,
	LoomProcessID,
	EmployeeID,
	WorkingDate,
	StartTime,
	EndTime,
	Shift,
	MTRStart,
	MTREnd
FROM 
	tblLoomProcessWork
WHERE 
	LoomProcessWorkID=@LoomProcessWorkID
GO
/****** Object:  StoredProcedure [dbo].[tblCompany_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tblCompany_UPDATE]
@CompanyID		bigint,
@CompanyName		varchar(100),
@ComapnyCode		varchar(10),
@OwnerName		varchar(50),
@StartDate		date,
@Address		varchar(500),
@ContactPersonName		varchar(50),
@InvestmentAmount		float,
@PANNo		varchar(50),
@CSTNo		varchar(50),
@ECCNo		varchar(50),
@SMSNO		varchar(15),
@IsActive		bit,
@UpdatedBy		int,
@UpdatedDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblCompany
SET
	
	CompanyName=@CompanyName,
	ComapnyCode=@ComapnyCode,
	OwnerName=@OwnerName,
	StartDate=@StartDate,
	[Address]=@Address,
	ContactPersonName=@ContactPersonName,
	InvestmentAmount=@InvestmentAmount,
	PANNo=@PANNo,
	CSTNo=@CSTNo,
	ECCNo=@ECCNo,
	SMSNO=@SMSNO,
	IsActive=@IsActive,
	
	UpdatedBy=@UpdatedBy,
	UpdatedDateTime=@UpdatedDateTime
WHERE 
	CompanyID=@CompanyID
GO
/****** Object:  StoredProcedure [dbo].[tblCompany_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblCompany_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblCompany_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	CompanyID,
	CompanyName,
	ComapnyCode,
	OwnerName,
	StartDate,
	[Address],
	ContactPersonName,
	CreationDate,
	InvestmentAmount,
	PANNo,
	CSTNo,
	ECCNo,
	SMSNO,
	IsActive,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblCompany where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblCompany_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblCompany_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblCompany_INSERT]
@CompanyID		bigint,
@CompanyName		varchar(100),
@ComapnyCode		varchar(10),
@OwnerName		varchar(50),
@StartDate		date,
@Address		varchar(500),
@ContactPersonName		varchar(50),
@CreationDate		datetime,
@InvestmentAmount		float,
@PANNo		varchar(50),
@CSTNo		varchar(50),
@ECCNo		varchar(50),
@SMSNO		varchar(15),
@IsActive		bit,
@CreatedBy		int,
@CreatedDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblCompany
		(
		CompanyID,
		CompanyName,
		ComapnyCode,
		OwnerName,
		StartDate,
		[Address],
		ContactPersonName,
		CreationDate,
		InvestmentAmount,
		PANNo,
		CSTNo,
		ECCNo,
		SMSNO,
		IsActive,
		CreatedBy,
		CreatedDateTime
		)
VALUES 
		(
		@CompanyID,
		@CompanyName,
		@ComapnyCode,
		@OwnerName,
		@StartDate,
		@Address,
		@ContactPersonName,
		@CreationDate,
		@InvestmentAmount,
		@PANNo,
		@CSTNo,
		@ECCNo,
		@SMSNO,
		@IsActive,
		@CreatedBy,
		@CreatedDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblCompany_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblCompany_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblCompany_DELETE]
@CompanyID		bigint

AS

/*
	Delete records against the give criteria.
*/

Update 
	tblCompany
	set IsActive=0
	

WHERE 
	CompanyID=@CompanyID
GO
/****** Object:  StoredProcedure [dbo].[tblCompany_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblCompany_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblCompany_BY_ID_LOAD]
@CompanyID		bigint

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	CompanyID,
	CompanyName,
	ComapnyCode,
	OwnerName,
	StartDate,
	[Address],
	ContactPersonName,
	CreationDate,
	InvestmentAmount,
	PANNo,
	CSTNo,
	ECCNo,
	SMSNO,
	IsActive,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblCompany 
	
WHERE 
	CompanyID=@CompanyID and IsActive = 1
GO
/****** Object:  StoredProcedure [dbo].[tblBrokersMST_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBrokersMST_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBrokersMST_UPDATE]
@BrokerID		bigint ,
@BrokerName		varchar(50),
@BrokerFirmName		varchar(500),
@Address		varchar(500),
@ContactNo		varchar(50),
@MobileNo		varchar(50),
@DealingIn		varchar(500),
@IsActive		bit,

@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblBrokersMST
SET
	BrokerName=@BrokerName,
	BrokerFirmName=@BrokerFirmName,
	Address=@Address,
	ContactNo=@ContactNo,
	MobileNo=@MobileNo,
	DealingIn=@DealingIn,
	IsActive=@IsActive,
	
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	BrokerID=@BrokerID
GO
/****** Object:  StoredProcedure [dbo].[tblBrokersMST_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBrokersMST_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBrokersMST_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	BrokerID,
	BrokerName,
	BrokerFirmName,
	[Address],
	ContactNo,
	MobileNo,
	DealingIn,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblBrokersMST
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblBrokersMST_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBrokersMST_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBrokersMST_INSERT]
@BrokerName		varchar(50),
@BrokerFirmName		varchar(500),
@Address		varchar(500),
@ContactNo		varchar(50),
@MobileNo		varchar(50),
@DealingIn		varchar(500),
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblBrokersMST
		(
		BrokerName,
		BrokerFirmName,
		Address,
		ContactNo,
		MobileNo,
		DealingIn,
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@BrokerName,
		@BrokerFirmName,
		@Address,
		@ContactNo,
		@MobileNo,
		@DealingIn,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblBrokersMST_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBrokersMST_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBrokersMST_DELETE]
@BrokerID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblBrokersMST
set IsActive=0

WHERE 
	BrokerID=@BrokerID
GO
/****** Object:  StoredProcedure [dbo].[tblBrokersMST_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBrokersMST_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBrokersMST_BY_ID_LOAD]
@BrokerID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	BrokerID,
	BrokerName,
	BrokerFirmName,
	[Address],
	ContactNo,
	MobileNo,
	DealingIn,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblBrokersMST
WHERE 
	BrokerID=@BrokerID and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblMendingDetailsProcess_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMendingDetailsProcess_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMendingDetailsProcess_UPDATE]
@MendingDetailsID		bigint ,
@MendingID		bigint,
@EmployeeID		bigint,
@StartMeter		float,
@EndMeter		float,
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblMendingDetailsProcess
SET
	MendingID=@MendingID,
	EmployeeID=@EmployeeID,
	StartMeter=@StartMeter,
	EndMeter=@EndMeter,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	MendingDetailsID=@MendingDetailsID
GO
/****** Object:  StoredProcedure [dbo].[tblMendingDetailsProcess_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMendingDetailsProcess_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMendingDetailsProcess_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	MendingDetailsID,
	MendingID,
	EmployeeID,
	StartMeter,
	EndMeter,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblMendingDetailsProcess
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblMendingDetailsProcess_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMendingDetailsProcess_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMendingDetailsProcess_INSERT]
@MendingID		bigint,
@EmployeeID		bigint,
@StartMeter		float,
@EndMeter		float,
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblMendingDetailsProcess
		(
		MendingID,
		EmployeeID,
		StartMeter,
		EndMeter,
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@MendingID,
		@EmployeeID,
		@StartMeter,
		@EndMeter,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblMendingDetailsProcess_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMendingDetailsProcess_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMendingDetailsProcess_DELETE]
@MendingDetailsID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblMendingDetailsProcess
set IsActive=0

WHERE 
	MendingDetailsID=@MendingDetailsID
GO
/****** Object:  StoredProcedure [dbo].[tblMendingDetailsProcess_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMendingDetailsProcess_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMendingDetailsProcess_BY_ID_LOAD]
@MendingDetailsID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	MendingDetailsID,
	MendingID,
	EmployeeID,
	StartMeter,
	EndMeter,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblMendingDetailsProcess
WHERE 
	MendingDetailsID=@MendingDetailsID and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblMandingProcess_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMandingProcess_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMandingProcess_UPDATE]
@MendingID		bigint ,
@TakaNo		int,
@EmployeeID		bigint,
@Grade		varchar(5),
@StartDateTime		datetime,
@EndDateTime		datetime,
@TotalMeter		float,
@TotalNoOfFaults		int,
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblMandingProcess
SET
	TakaNo=@TakaNo,
	EmployeeID=@EmployeeID,
	Grade=@Grade,
	StartDateTime=@StartDateTime,
	EndDateTime=@EndDateTime,
	TotalMeter=@TotalMeter,
	TotalNoOfFaults=@TotalNoOfFaults,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	MendingID=@MendingID
GO
/****** Object:  StoredProcedure [dbo].[tblMandingProcess_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMandingProcess_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMandingProcess_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	MendingID,
	TakaNo,
	EmployeeID,
	Grade,
	StartDateTime,
	EndDateTime,
	TotalMeter,
	TotalNoOfFaults,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblMandingProcess
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblMandingProcess_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMandingProcess_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMandingProcess_INSERT]
@TakaNo		int,
@EmployeeID		bigint,
@Grade		varchar(5),
@StartDateTime		datetime,
@EndDateTime		datetime,
@TotalMeter		float,
@TotalNoOfFaults		int,
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblMandingProcess
		(
		TakaNo,
		EmployeeID,
		Grade,
		StartDateTime,
		EndDateTime,
		TotalMeter,
		TotalNoOfFaults,
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@TakaNo,
		@EmployeeID,
		@Grade,
		@StartDateTime,
		@EndDateTime,
		@TotalMeter,
		@TotalNoOfFaults,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblMandingProcess_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMandingProcess_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMandingProcess_DELETE]
@MendingID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblMandingProcess
set IsActive =0

WHERE 
	MendingID=@MendingID
GO
/****** Object:  StoredProcedure [dbo].[tblMandingProcess_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMandingProcess_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMandingProcess_BY_ID_LOAD]
@MendingID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	MendingID,
	TakaNo,
	EmployeeID,
	Grade,
	StartDateTime,
	EndDateTime,
	TotalMeter,
	TotalNoOfFaults,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblMandingProcess
WHERE 
	MendingID=@MendingID  and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblLoomProcess_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblLoomProcess_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblLoomProcess_UPDATE]
@LoomProcessID		bigint ,
@BeemProcessID		bigint,
@MachineID		bigint,
@NoofTFORole		float,
@CreatoinDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblLoomProcess
SET
	BeemProcessID=@BeemProcessID,
	MachineID=@MachineID,
	NoofTFORole=@NoofTFORole,
	CreatoinDateTime=@CreatoinDateTime
WHERE 
	LoomProcessID=@LoomProcessID
GO
/****** Object:  StoredProcedure [dbo].[tblLoomProcess_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblLoomProcess_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblLoomProcess_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	LoomProcessID,
	BeemProcessID,
	MachineID,
	NoofTFORole,
	CreatoinDateTime
FROM 
	tblLoomProcess
GO
/****** Object:  StoredProcedure [dbo].[tblLoomProcess_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblLoomProcess_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblLoomProcess_INSERT]
@BeemProcessID		bigint,
@MachineID		bigint,
@NoofTFORole		float,
@CreatoinDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblLoomProcess
		(
		BeemProcessID,
		MachineID,
		NoofTFORole,
		CreatoinDateTime)
VALUES 
		(
		@BeemProcessID,
		@MachineID,
		@NoofTFORole,
		@CreatoinDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblLoomProcess_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblLoomProcess_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblLoomProcess_DELETE]
@LoomProcessID		bigint 

AS

/*
	Delete records against the give criteria.
*/

DELETE 

FROM 
	tblLoomProcess

WHERE 
	LoomProcessID=@LoomProcessID
GO
/****** Object:  StoredProcedure [dbo].[tblLoomProcess_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblLoomProcess_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblLoomProcess_BY_ID_LOAD]
@LoomProcessID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	LoomProcessID,
	BeemProcessID,
	MachineID,
	NoofTFORole,
	CreatoinDateTime
FROM 
	tblLoomProcess
WHERE 
	LoomProcessID=@LoomProcessID
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[EmployeeID] [bigint] IDENTITY(1,1) NOT NULL,
	[CompanyID] [bigint] NULL,
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
	[IsDelete] [bit] NULL,
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
SET IDENTITY_INSERT [dbo].[tblEmployee] ON
INSERT [dbo].[tblEmployee] ([EmployeeID], [CompanyID], [EmployeeTypeID], [EmployeeCode], [JobTitle], [FirstName], [MiddleName], [LastName], [ResidentialAddress], [PermanentAddress], [MobileNo], [EmailID], [DOB], [Gender], [IDProfe], [IDProfeNo], [Photo], [JoinDate], [LeaveDate], [SponsorsID], [Shift], [Salary], [PerDayWorkingHours], [PerHourSalary], [PaymentType], [BankName], [BranchName], [AccountNo], [RTGSNo], [IFSCCode], [OpeningBalance], [IsDelete], [IsActive], [CreatedBY], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES (1, 1, 1, N'121', N'abc', N'Nilesh', N'R', N'Joliya', N'Ranjitnagar', N'Ranjitnagar', N'8866824547', N'joliyanilesh@gmail.com', CAST(0x23140B00 AS Date), N'Male', N'1', N'1', NULL, CAST(0x62360B00 AS Date), CAST(0x3B390B00 AS Date), 1, N'm', 10000, 8, 500, 1, N'SBI', N'Podar', N'123', N'1', N'1', 10000, 0, 1, 1, NULL, NULL, NULL)
INSERT [dbo].[tblEmployee] ([EmployeeID], [CompanyID], [EmployeeTypeID], [EmployeeCode], [JobTitle], [FirstName], [MiddleName], [LastName], [ResidentialAddress], [PermanentAddress], [MobileNo], [EmailID], [DOB], [Gender], [IDProfe], [IDProfeNo], [Photo], [JoinDate], [LeaveDate], [SponsorsID], [Shift], [Salary], [PerDayWorkingHours], [PerHourSalary], [PaymentType], [BankName], [BranchName], [AccountNo], [RTGSNo], [IFSCCode], [OpeningBalance], [IsDelete], [IsActive], [CreatedBY], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES (2, 1, 1, N'1', N'sdd', N'mayur', N'sorathiya', N'sorathiya', N'Yogichok', N'Yogichok', N'8866303520', N'mmm', CAST(0xD9140B00 AS Date), N'male', N'1', N'1', NULL, CAST(0x61360B00 AS Date), NULL, 1, N'm', 10000, 4, 500, 0, N'ICICI', N'', N'12345566', N'1', N'1', 12, 1, 1, 1, CAST(0x0000A45D0134887E AS DateTime), NULL, NULL)
INSERT [dbo].[tblEmployee] ([EmployeeID], [CompanyID], [EmployeeTypeID], [EmployeeCode], [JobTitle], [FirstName], [MiddleName], [LastName], [ResidentialAddress], [PermanentAddress], [MobileNo], [EmailID], [DOB], [Gender], [IDProfe], [IDProfeNo], [Photo], [JoinDate], [LeaveDate], [SponsorsID], [Shift], [Salary], [PerDayWorkingHours], [PerHourSalary], [PaymentType], [BankName], [BranchName], [AccountNo], [RTGSNo], [IFSCCode], [OpeningBalance], [IsDelete], [IsActive], [CreatedBY], [CreatedDate], [UpdatedBy], [UpdatedDate]) VALUES (3, 39, 1, N'2', N'www', N'suny', N'sondagar', N'sondagar', N'faefaf', N'faefaf', N'45454545', N'fasf', CAST(0xB4140B00 AS Date), N'male', N'1', N'3', NULL, CAST(0xF3340B00 AS Date), NULL, 1, N'm', 12000, 8, 500, 0, N'BOI', N'', N'sdfs', N'sdf', N'dsfsd', 20000, 0, 1, 1, CAST(0x0000A45D01393550 AS DateTime), NULL, NULL)
SET IDENTITY_INSERT [dbo].[tblEmployee] OFF
/****** Object:  Table [dbo].[tblCompanyMachineMST]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCompanyMachineMST](
	[RowId] [bigint] IDENTITY(1,1) NOT NULL,
	[MachineId] [bigint] NOT NULL,
	[CompanyId] [bigint] NOT NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK_tblPartyMachine] PRIMARY KEY CLUSTERED 
(
	[RowId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[tblPartysMST_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblPartysMST_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblPartysMST_UPDATE]
@PartyID		bigint ,
@CompanyCode		int,
@PartyName		varchar(50),
@ContactPersonName		varchar(15),
@OfficeAddress		varchar(200),
@ShippingAddress		varchar(200),
@City		varchar(50),
@State		varchar(50),
@MobileNo		varchar(15),
@PhoneNo		varchar(15),
@SMSNo		varchar(15),
@ReferencePersonName		varchar(100),
@ReferencePersonMobileNo		varchar(15),
@EmailID		varchar(100),
@ExtraDetails		varchar(500),
@TINNo		varchar(50),
@TINDate		date,
@PANNO		varchar(50),
@CSTTINNo		varchar(50),
@CSTDate		date,
@ECCNo		varchar(50),
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTIme		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblPartysMST
SET
	CompanyCode=@CompanyCode,
	PartyName=@PartyName,
	ContactPersonName=@ContactPersonName,
	OfficeAddress=@OfficeAddress,
	ShippingAddress=@ShippingAddress,
	City=@City,
	State=@State,
	MobileNo=@MobileNo,
	PhoneNo=@PhoneNo,
	SMSNo=@SMSNo,
	ReferencePersonName=@ReferencePersonName,
	ReferencePersonMobileNo=@ReferencePersonMobileNo,
	EmailID=@EmailID,
	ExtraDetails=@ExtraDetails,
	TINNo=@TINNo,
	TINDate=@TINDate,
	PANNO=@PANNO,
	CSTTINNo=@CSTTINNo,
	CSTDate=@CSTDate,
	ECCNo=@ECCNo,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	UpdationDateTIme=@UpdationDateTIme
WHERE 
	PartyID=@PartyID
GO
/****** Object:  StoredProcedure [dbo].[tblPartysMST_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblPartysMST_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblPartysMST_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	PartyID,
	CompanyCode,
	PartyName,
	ContactPersonName,
	OfficeAddress,
	ShippingAddress,
	City,
	[State],
	MobileNo,
	PhoneNo,
	SMSNo,
	ReferencePersonName,
	ReferencePersonMobileNo,
	EmailID,
	ExtraDetails,
	TINNo,
	TINDate,
	PANNO,
	CSTTINNo,
	CSTDate,
	ECCNo,
	IsActive,
	CreateBye,
	CreationDateTime,
	UpdateBy,
	UpdationDateTIme
FROM 
	tblPartysMST
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblPartysMST_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblPartysMST_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblPartysMST_INSERT]
@CompanyCode		int,
@PartyName		varchar(50),
@ContactPersonName		varchar(15),
@OfficeAddress		varchar(200),
@ShippingAddress		varchar(200),
@City		varchar(50),
@State		varchar(50),
@MobileNo		varchar(15),
@PhoneNo		varchar(15),
@SMSNo		varchar(15),
@ReferencePersonName		varchar(100),
@ReferencePersonMobileNo		varchar(15),
@EmailID		varchar(100),
@ExtraDetails		varchar(500),
@TINNo		varchar(50),
@TINDate		date,
@PANNO		varchar(50),
@CSTTINNo		varchar(50),
@CSTDate		date,
@ECCNo		varchar(50),
@IsActive		bit,
@CreateBye		int,
@CreationDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblPartysMST
		(
		CompanyCode,
		PartyName,
		ContactPersonName,
		OfficeAddress,
		ShippingAddress,
		City,
		[State],
		MobileNo,
		PhoneNo,
		SMSNo,
		ReferencePersonName,
		ReferencePersonMobileNo,
		EmailID,
		ExtraDetails,
		TINNo,
		TINDate,
		PANNO,
		CSTTINNo,
		CSTDate,
		ECCNo,
		IsActive,
		CreateBye,
		CreationDateTime)
VALUES 
		(
		@CompanyCode,
		@PartyName,
		@ContactPersonName,
		@OfficeAddress,
		@ShippingAddress,
		@City,
		@State,
		@MobileNo,
		@PhoneNo,
		@SMSNo,
		@ReferencePersonName,
		@ReferencePersonMobileNo,
		@EmailID,
		@ExtraDetails,
		@TINNo,
		@TINDate,
		@PANNO,
		@CSTTINNo,
		@CSTDate,
		@ECCNo,
		@IsActive,
		@CreateBye,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblPartysMST_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblPartysMST_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblPartysMST_DELETE]
@PartyID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblPartysMST
set IsActive=0
WHERE 
	PartyID=@PartyID
GO
/****** Object:  StoredProcedure [dbo].[tblPartysMST_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblPartysMST_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblPartysMST_BY_ID_LOAD]
@PartyID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	PartyID,
	CompanyCode,
	PartyName,
	ContactPersonName,
	OfficeAddress,
	ShippingAddress,
	City,
	[State],
	MobileNo,
	PhoneNo,
	SMSNo,
	ReferencePersonName,
	ReferencePersonMobileNo,
	EmailID,
	ExtraDetails,
	TINNo,
	TINDate,
	PANNO,
	CSTTINNo,
	CSTDate,
	ECCNo,
	IsActive,
	CreateBye,
	CreationDateTime,
	UpdateBy,
	UpdationDateTIme
FROM 
	tblPartysMST
WHERE 
	PartyID=@PartyID 
	and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblMendingPenulty_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMendingPenulty_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMendingPenulty_UPDATE]
@MendingPenultyID		bigint ,
@EmployeeID		bigint,
@PenultyID		bigint,
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblMendingPenulty
SET
	EmployeeID=@EmployeeID,
	PenultyID=@PenultyID,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	MendingPenultyID=@MendingPenultyID
GO
/****** Object:  StoredProcedure [dbo].[tblMendingPenulty_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMendingPenulty_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMendingPenulty_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	MendingPenultyID,
	EmployeeID,
	PenultyID,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblMendingPenulty
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblMendingPenulty_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMendingPenulty_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMendingPenulty_INSERT]
@EmployeeID		bigint,
@PenultyID		bigint,
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime
AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblMendingPenulty
		(
		EmployeeID,
		PenultyID,
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@EmployeeID,
		@PenultyID,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblMendingPenulty_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMendingPenulty_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMendingPenulty_DELETE]
@MendingPenultyID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update 	tblMendingPenulty
set IsActive=0

WHERE 
	MendingPenultyID=@MendingPenultyID
GO
/****** Object:  StoredProcedure [dbo].[tblMendingPenulty_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblMendingPenulty_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblMendingPenulty_BY_ID_LOAD]
@MendingPenultyID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	MendingPenultyID,
	EmployeeID,
	PenultyID,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblMendingPenulty
WHERE 
	MendingPenultyID=@MendingPenultyID 
	and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblPenaltyMST_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblPenaltyMST_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblPenaltyMST_UPDATE]
@PenaltyID		bigint ,
@PenaltyCode		varchar(10),
@PenaltyName		varchar(200),
@Description		text,
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblPenaltyMST
SET
	PenaltyCode=@PenaltyCode,
	PenaltyName=@PenaltyName,
	[Description]=@Description,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	PenaltyID=@PenaltyID
GO
/****** Object:  StoredProcedure [dbo].[tblPenaltyMST_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblPenaltyMST_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblPenaltyMST_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	PenaltyID,
	PenaltyCode,
	PenaltyName,
	[Description],
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblPenaltyMST
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblPenaltyMST_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblPenaltyMST_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblPenaltyMST_INSERT]
@PenaltyCode		varchar(10),
@PenaltyName		varchar(200),
@Description		text,
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblPenaltyMST
		(
		PenaltyCode,
		PenaltyName,
		[Description],
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@PenaltyCode,
		@PenaltyName,
		@Description,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblPenaltyMST_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblPenaltyMST_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblPenaltyMST_DELETE]
@PenaltyID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblPenaltyMST
set IsActive=0

WHERE 
	PenaltyID=@PenaltyID
GO
/****** Object:  StoredProcedure [dbo].[tblPenaltyMST_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblPenaltyMST_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblPenaltyMST_BY_ID_LOAD]
@PenaltyID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	PenaltyID,
	PenaltyCode,
	PenaltyName,
	[Description],
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblPenaltyMST
WHERE 
	PenaltyID=@PenaltyID 
	and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblWithdrownMST_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWithdrownMST_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWithdrownMST_UPDATE]
@WithdrownID		bigint ,
@EmployeeID		bigint,
@Remarks		varchar(100),
@WithdrownAmount		float,
@WithdrownDate		datetime,
@ReturnDate		datetime,
@ISStatus		bit,
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblWithdrownMST
SET
	EmployeeID=@EmployeeID,
	Remarks=@Remarks,
	WithdrownAmount=@WithdrownAmount,
	WithdrownDate=@WithdrownDate,
	ReturnDate=@ReturnDate,
	ISStatus=@ISStatus,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	WithdrownID=@WithdrownID
GO
/****** Object:  StoredProcedure [dbo].[tblWithdrownMST_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWithdrownMST_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWithdrownMST_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	WithdrownID,
	EmployeeID,
	Remarks,
	WithdrownAmount,
	WithdrownDate,
	ReturnDate,
	ISStatus,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblWithdrownMST
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblWithdrownMST_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWithdrownMST_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWithdrownMST_INSERT]
@EmployeeID		bigint,
@Remarks		varchar(100),
@WithdrownAmount		float,
@WithdrownDate		datetime,
@ReturnDate		datetime,
@ISStatus		bit,
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblWithdrownMST
		(
		EmployeeID,
		Remarks,
		WithdrownAmount,
		WithdrownDate,
		ReturnDate,
		ISStatus,
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@EmployeeID,
		@Remarks,
		@WithdrownAmount,
		@WithdrownDate,
		@ReturnDate,
		@ISStatus,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblWithdrownMST_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWithdrownMST_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWithdrownMST_DELETE]
@WithdrownID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblWithdrownMST
set IsActive=0

WHERE 
	WithdrownID=@WithdrownID
GO
/****** Object:  StoredProcedure [dbo].[tblWithdrownMST_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWithdrownMST_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWithdrownMST_BY_ID_LOAD]
@WithdrownID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	WithdrownID,
	EmployeeID,
	Remarks,
	WithdrownAmount,
	WithdrownDate,
	ReturnDate,
	ISStatus,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblWithdrownMST
WHERE 
	WithdrownID=@WithdrownID 
	and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPackageType_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPackageType_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPackageType_UPDATE]
@YarnPackageTypeID		bigint ,
@TypeName		varchar(50),
@IsActive bit,
@UpdatedBy int,
@UpdatedDateTime datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblYarnPackageType
SET
	TypeName=@TypeName,
	IsActive=@IsActive,
	UpdatedBy=@UpdatedBy,
	UpdatedDateTime=@UpdatedDateTime
	
	
WHERE 
	YarnPackageTypeID=@YarnPackageTypeID
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPackageType_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPackageType_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPackageType_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	YarnPackageTypeID,
	TypeName,
	IsActive,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblYarnPackageType
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPackageType_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPackageType_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPackageType_INSERT]
@TypeName		varchar(50),
@IsActive bit,
@CreatedBy int,
@CreatedDateTime datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblYarnPackageType
		(
		TypeName,
		IsActive,
		CreatedBy,
		CreatedDateTime
		
		)
VALUES 
		(
		@TypeName,
		@IsActive,
		@CreatedBy,
		@CreatedDateTime
		
		)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPackageType_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPackageType_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPackageType_DELETE]
@YarnPackageTypeID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblYarnPackageType
set IsActive =0

WHERE 
	YarnPackageTypeID=@YarnPackageTypeID
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPackageType_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPackageType_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPackageType_BY_ID_LOAD]
@YarnPackageTypeID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	YarnPackageTypeID,
	TypeName,
	IsActive,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblYarnPackageType
WHERE 
	YarnPackageTypeID=@YarnPackageTypeID  
	and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblWorkingYear_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWorkingYear_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWorkingYear_UPDATE]
@YearID		int ,
@YearName		varchar(50),
@IsActive bit,
@CreatedBy	int,
@CreatedDateTime datetime,
@UpdatedBy int,
@UpdatedDateTime datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblWorkingYear
SET
	YearName=@YearName,
	IsActive=@IsActive,
	CreatedBy=@CreatedBy,
	UpdatedBy=@UpdatedBy,
	UpdatedDateTime=@UpdatedDateTime
	
WHERE 
	YearID=@YearID
GO
/****** Object:  StoredProcedure [dbo].[tblWorkingYear_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWorkingYear_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWorkingYear_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	YearID,
	YearName,
	IsActive,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblWorkingYear
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblWorkingYear_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWorkingYear_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWorkingYear_INSERT]
@YearName		varchar(50),
@IsActive bit,
@CreatedBy int,
@CreatedDateTime datetime


AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblWorkingYear
		(
		YearName,
		IsActive,
		CreatedBy,
		CreatedDateTime
		)
VALUES 
		(
		@YearName,
		@IsActive,
		@CreatedBy,
		@CreatedDateTime
		
		)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblWorkingYear_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWorkingYear_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWorkingYear_DELETE]
@YearID		int 

AS

/*
	Delete records against the give criteria.
*/

Update 	tblWorkingYear
set IsActive=0

WHERE 
	YearID=@YearID
GO
/****** Object:  StoredProcedure [dbo].[tblWorkingYear_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWorkingYear_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWorkingYear_BY_ID_LOAD]
@YearID		int 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	YearID,
	YearName,
	IsActive,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblWorkingYear
WHERE 
	YearID=@YearID 
	and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPurchase_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tblYarnPurchase_UPDATE]
@PurchaseID		bigint,
@SRNo		int,
@CompanyID		bigint,
@PartyID		bigint,
@BrokerID		bigint,
@YearID		bigint,
@PurchaseDate		date,
@ChallanNo		varchar(100),
@LRNo		varchar(50),
@RecieveAt		varchar(50),
@Grade		varchar(50),
@EmployeeId		int,
@IsActive	bit,
@UpdatedBy int,
@UpdatedDateTime	datetime


AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblYarnPurchase
SET
	
	SRNo=@SRNo,
	CompanyID=@CompanyID,
	PartyID=@PartyID,
	BrokerID=@BrokerID,
	YearID=@YearID,
	PurchaseDate=@PurchaseDate,
	ChallanNo=@ChallanNo,
	LRNo=@LRNo,
	RecieveAt=@RecieveAt,
	Grade=@Grade,
	EmployeeId=@EmployeeId,
	IsActive=@IsActive,
	UpdatedBy=@UpdatedBy,
	UpdatedDateTime=@UpdatedDateTime
	
WHERE 
	PurchaseID=@PurchaseID
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPurchase_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPurchase_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPurchase_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	PurchaseID,
	SRNo,
	CompanyID,
	PartyID,
	BrokerID,
	YearID,
	PurchaseDate,
	ChallanNo,
	LRNo,
	RecieveAt,
	Grade,
	EmployeeId,
	IsActive,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblYarnPurchase
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPurchase_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPurchase_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPurchase_INSERT]
@PurchaseID		bigint,
@SRNo		int,
@CompanyID		bigint,
@PartyID		bigint,
@BrokerID		bigint,
@YearID		bigint,
@PurchaseDate		date,
@ChallanNo		varchar(100),
@LRNo		varchar(50),
@RecieveAt		varchar(50),
@Grade		varchar(50),
@EmployeeId		int,
@IsActive bit,
@CreatedBy	int,
@CreatedDateTime datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblYarnPurchase
		(
		PurchaseID,
		SRNo,
		CompanyID,
		PartyID,
		BrokerID,
		YearID,
		PurchaseDate,
		ChallanNo,
		LRNo,
		RecieveAt,
		Grade,
		EmployeeId,
		IsActive,
		CreatedBy,
		CreatedDateTime
		)
VALUES 
		(
		@PurchaseID,
		@SRNo,
		@CompanyID,
		@PartyID,
		@BrokerID,
		@YearID,
		@PurchaseDate,
		@ChallanNo,
		@LRNo,
		@RecieveAt,
		@Grade,
		@EmployeeId,
		@IsActive ,
@CreatedBy,
@CreatedDateTime )
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPurchase_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPurchase_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPurchase_DELETE]
@PurchaseID		bigint

AS

/*
	Delete records against the give criteria.
*/

Update tblYarnPurchase
set IsActive=0

WHERE 
	PurchaseID=@PurchaseID
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPurchase_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPurchase_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPurchase_BY_ID_LOAD]
@PurchaseID		bigint

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	PurchaseID,
	SRNo,
	CompanyID,
	PartyID,
	BrokerID,
	YearID,
	PurchaseDate,
	ChallanNo,
	LRNo,
	RecieveAt,
	Grade,
	EmployeeId,
	IsActive,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblYarnPurchase
WHERE 
	PurchaseID=@PurchaseID 
	and
	IsActive =1
GO
/****** Object:  StoredProcedure [dbo].[WithdrownReturnMST_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 WithdrownReturnMST_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[WithdrownReturnMST_UPDATE]
@WithdrownReturnID		bigint ,
@Date		date,
@EmployeeID		bigint,
@ReturnType		int,
@SalaryID		bigint,
@Amount		float,
@Remark		varchar(100),
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	WithdrownReturnMST
SET
	Date=@Date,
	EmployeeID=@EmployeeID,
	ReturnType=@ReturnType,
	SalaryID=@SalaryID,
	Amount=@Amount,
	Remark=@Remark,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	WithdrownReturnID=@WithdrownReturnID
GO
/****** Object:  StoredProcedure [dbo].[WithdrownReturnMST_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 WithdrownReturnMST_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[WithdrownReturnMST_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	WithdrownReturnID,
	[Date],
	EmployeeID,
	ReturnType,
	SalaryID,
	Amount,
	Remark,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	WithdrownReturnMST
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[WithdrownReturnMST_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 WithdrownReturnMST_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[WithdrownReturnMST_INSERT]
@Date		date,
@EmployeeID		bigint,
@ReturnType		int,
@SalaryID		bigint,
@Amount		float,
@Remark		varchar(100),
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	WithdrownReturnMST
		(
		[Date],
		EmployeeID,
		ReturnType,
		SalaryID,
		Amount,
		Remark,
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@Date,
		@EmployeeID,
		@ReturnType,
		@SalaryID,
		@Amount,
		@Remark,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[WithdrownReturnMST_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 WithdrownReturnMST_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[WithdrownReturnMST_DELETE]
@WithdrownReturnID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update WithdrownReturnMST
set IsActive=0

WHERE 
	WithdrownReturnID=@WithdrownReturnID
GO
/****** Object:  StoredProcedure [dbo].[WithdrownReturnMST_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 WithdrownReturnMST_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[WithdrownReturnMST_BY_ID_LOAD]
@WithdrownReturnID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	WithdrownReturnID,
	[Date],
	EmployeeID,
	ReturnType,
	SalaryID,
	Amount,
	Remark,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	WithdrownReturnMST
WHERE 
	WithdrownReturnID=@WithdrownReturnID 
	and IsActive=1
GO
/****** Object:  Table [dbo].[tblYarnTypeMST]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblYarnTypeMST](
	[YarnTypeID] [bigint] IDENTITY(1,1) NOT NULL,
	[YarnTypeName] [varchar](50) NULL,
	[YarnQualityID] [bigint] NULL,
	[Denier] [varchar](50) NULL,
	[NumberOfFilaments] [int] NULL,
	[Description] [varchar](500) NULL,
	[IsActive] [bit] NULL,
	[IsDelete] [bit] NULL,
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
SET IDENTITY_INSERT [dbo].[tblYarnTypeMST] ON
INSERT [dbo].[tblYarnTypeMST] ([YarnTypeID], [YarnTypeName], [YarnQualityID], [Denier], [NumberOfFilaments], [Description], [IsActive], [IsDelete], [UpdateBy], [CreateBy], [UpdationDateTime], [CreationDateTIme]) VALUES (1, N'Crape', 1, N'77/80', 5070, N'Good', 1, 0, NULL, 1, NULL, CAST(0x0000A45900F95D38 AS DateTime))
INSERT [dbo].[tblYarnTypeMST] ([YarnTypeID], [YarnTypeName], [YarnQualityID], [Denier], [NumberOfFilaments], [Description], [IsActive], [IsDelete], [UpdateBy], [CreateBy], [UpdationDateTime], [CreationDateTIme]) VALUES (2, N'Semidull', 1, N'23', 1234, N'asd', 1, 0, NULL, 1, NULL, CAST(0x0000A45900FAA252 AS DateTime))
INSERT [dbo].[tblYarnTypeMST] ([YarnTypeID], [YarnTypeName], [YarnQualityID], [Denier], [NumberOfFilaments], [Description], [IsActive], [IsDelete], [UpdateBy], [CreateBy], [UpdationDateTime], [CreationDateTIme]) VALUES (3, N'Abc', 1, N'12', 1234, N'good', 1, 0, NULL, 1, NULL, CAST(0x0000A45B00AD3C6B AS DateTime))
SET IDENTITY_INSERT [dbo].[tblYarnTypeMST] OFF
/****** Object:  StoredProcedure [dbo].[tblYarnQualityMST_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnQualityMST_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnQualityMST_UPDATE]
@YarnQualityID		bigint ,
@YarnQualityName		varchar(50),
@Description		varchar(500),
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblYarnQualityMST
SET
	YarnQualityName=@YarnQualityName,
	Description=@Description,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	YarnQualityID=@YarnQualityID
GO
/****** Object:  StoredProcedure [dbo].[tblYarnQualityMST_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnQualityMST_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnQualityMST_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	YarnQualityID,
	YarnQualityName,
	[Description],
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblYarnQualityMST
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblYarnQualityMST_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnQualityMST_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnQualityMST_INSERT]
@YarnQualityName		varchar(50),
@Description		varchar(500),
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblYarnQualityMST
		(
		YarnQualityName,
		[Description],
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@YarnQualityName,
		@Description,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblYarnQualityMST_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnQualityMST_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnQualityMST_DELETE]
@YarnQualityID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblYarnQualityMST
set IsActive=0

WHERE 
	YarnQualityID=@YarnQualityID
GO
/****** Object:  StoredProcedure [dbo].[tblYarnQualityMST_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnQualityMST_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnQualityMST_BY_ID_LOAD]
@YarnQualityID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	YarnQualityID,
	YarnQualityName,
	[Description],
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblYarnQualityMST
WHERE 
	YarnQualityID=@YarnQualityID
	and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblYarnTypeMST_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[tblYarnTypeMST_UPDATE]
@YarnTypeID		bigint,
@YarnTypeName		varchar(50),
@YarnQualityID		bigint,
@Denier varchar(50),
@NumberOfFilaments int,
@Description		varchar(500),
@IsActive		bit,
@UpdateBy		int,

@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblYarnTypeMST
SET
	
	YarnTypeName=@YarnTypeName,
	YarnQualityID=@YarnQualityID,
	Denier=@Denier,
	NumberOfFilaments=@NumberOfFilaments,
	[Description]=@Description,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	
	UpdationDateTime=@UpdationDateTime
WHERE 
	YarnTypeID=@YarnTypeID
GO
/****** Object:  StoredProcedure [dbo].[tblYarnTypeMST_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnTypeMST_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnTypeMST_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	YarnTypeID,
	YarnTypeName,
	YarnQualityID,
	Denier,
	NumberOfFilaments,
	[Description],
	IsActive,
	UpdateBy,
	CreateBy,
	UpdationDateTime,
	CreationDateTIme
FROM 
	tblYarnTypeMST 	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblYarnTypeMST_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnTypeMST_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnTypeMST_INSERT]
@YarnTypeID		bigint,
@YarnTypeName		varchar(50),
@YarnQualityID		bigint,
@Denier varchar(50),
@NumberOfFilaments int,
@Description		varchar(500),
@IsActive bit,
@CreateBy int,
@CreationDateTIme datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblYarnTypeMST
		(
		YarnTypeID,
		YarnTypeName,
		YarnQualityID,
		Denier,
		NumberOfFilaments,
		[Description],
		IsActive,
		
		CreateBy,
		
		CreationDateTIme)
VALUES 
		(
		@YarnTypeID,
		@YarnTypeName,
		@YarnQualityID,
		@Denier,
		@NumberOfFilaments,
		@Description,
		@IsActive,
		
		@CreateBy,
		
		@CreationDateTIme)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblYarnTypeMST_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnTypeMST_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnTypeMST_DELETE]
@YarnTypeID		bigint

AS

/*
	Delete records against the give criteria.
*/

Update tblYarnTypeMST
set IsActive=0

WHERE 
	YarnTypeID=@YarnTypeID
GO
/****** Object:  StoredProcedure [dbo].[tblYarnTypeMST_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnTypeMST_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnTypeMST_BY_ID_LOAD]
@YarnTypeID		bigint

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	YarnTypeID,
	YarnTypeName,
	YarnQualityID,
	Denier,
	NumberOfFilaments,
	[Description],
	IsActive,
	UpdateBy,
	CreateBy,
	UpdationDateTime,
	CreationDateTIme
FROM 
	tblYarnTypeMST
WHERE 
	YarnTypeID=@YarnTypeID 
	and IsActive=1
GO
/****** Object:  Table [dbo].[tblYarnPurchaseItems]    Script Date: 03/16/2015 19:13:42 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  Table [dbo].[tblSalaryMST]    Script Date: 03/16/2015 19:13:42 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  StoredProcedure [dbo].[tblEmployee_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblEmployee_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblEmployee_UPDATE]
@EmployeeID		bigint ,
@EmployeeTypeID		bigint,
@EmployeeCode		varchar(50),
@JobTitle		varchar(50),
@FirstName		varchar(50),
@MiddleName		varchar(50),
@LastName		varchar(50),
@ResidentialAddress		varchar(500),
@PermanentAddress		varchar(500),
@MobileNo		varchar(50),
@EmailID		varchar(100),
@DOB		date,
@Gender		varchar(50),
@IDProfe		varchar(200),
@IDProfeNo		varchar(100),
@Photo		image,
@JoinDate		date,
@LeaveDate		date,
@SponsorsID		int,
@Shift		varchar(50),
@Salary		float,
@PerDayWorkingHours		float,
@PerHourSalary		float,
@PaymentType		bit,
@BankName		varchar(100),
@BranchName		varchar(100),
@AccountNo		varchar(30),
@RTGSNo		varchar(20),
@IFSCCode		varchar(20),
@OpeningBalance		float,
@IsActive		bit,
@UpdatedBy		int,
@UpdatedDate		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblEmployee
SET
	EmployeeTypeID=@EmployeeTypeID,
	EmployeeCode=@EmployeeCode,
	JobTitle=@JobTitle,
	FirstName=@FirstName,
	MiddleName=@MiddleName,
	LastName=@LastName,
	ResidentialAddress=@ResidentialAddress,
	PermanentAddress=@PermanentAddress,
	MobileNo=@MobileNo,
	EmailID=@EmailID,
	DOB=@DOB,
	Gender=@Gender,
	IDProfe=@IDProfe,
	IDProfeNo=@IDProfeNo,
	Photo=@Photo,
	JoinDate=@JoinDate,
	LeaveDate=@LeaveDate,
	SponsorsID=@SponsorsID,
	Shift=@Shift,
	Salary=@Salary,
	PerDayWorkingHours=@PerDayWorkingHours,
	PerHourSalary=@PerHourSalary,
	PaymentType=@PaymentType,
	BankName=@BankName,
	BranchName=@BranchName,
	AccountNo=@AccountNo,
	RTGSNo=@RTGSNo,
	IFSCCode=@IFSCCode,
	OpeningBalance=@OpeningBalance,
	IsActive=@IsActive,
	UpdatedBy=@UpdatedBy,
	UpdatedDate=@UpdatedDate
WHERE 
	EmployeeID=@EmployeeID
GO
/****** Object:  StoredProcedure [dbo].[tblEmployee_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblEmployee_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblEmployee_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	EmployeeID,
	EmployeeTypeID,
	EmployeeCode,
	JobTitle,
	FirstName,
	MiddleName,
	LastName,
	ResidentialAddress,
	PermanentAddress,
	MobileNo,
	EmailID,
	DOB,
	Gender,
	IDProfe,
	IDProfeNo,
	Photo,
	JoinDate,
	LeaveDate,
	SponsorsID,
	Shift,
	Salary,
	PerDayWorkingHours,
	PerHourSalary,
	PaymentType,
	BankName,
	BranchName,
	AccountNo,
	RTGSNo,
	IFSCCode,
	OpeningBalance,
	IsActive,
	CreatedBY,
	CreatedDate,
	UpdatedBy,
	UpdatedDate
FROM 
	tblEmployee
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblEmployee_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblEmployee_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblEmployee_INSERT]
@EmployeeTypeID		bigint,
@EmployeeCode		varchar(50),
@JobTitle		varchar(50),
@FirstName		varchar(50),
@MiddleName		varchar(50),
@LastName		varchar(50),
@ResidentialAddress		varchar(500),
@PermanentAddress		varchar(500),
@MobileNo		varchar(50),
@EmailID		varchar(100),
@DOB		date,
@Gender		varchar(50),
@IDProfe		varchar(200),
@IDProfeNo		varchar(100),
@Photo		image,
@JoinDate		date,
@LeaveDate		date,
@SponsorsID		int,
@Shift		varchar(50),
@Salary		float,
@PerDayWorkingHours		float,
@PerHourSalary		float,
@PaymentType		bit,
@BankName		varchar(100),
@BranchName		varchar(100),
@AccountNo		varchar(30),
@RTGSNo		varchar(20),
@IFSCCode		varchar(20),
@OpeningBalance		float,
@IsActive		bit,
@CreatedBY		int,
@CreatedDate		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblEmployee
		(
		EmployeeTypeID,
		EmployeeCode,
		JobTitle,
		FirstName,
		MiddleName,
		LastName,
		ResidentialAddress,
		PermanentAddress,
		MobileNo,
		EmailID,
		DOB,
		Gender,
		IDProfe,
		IDProfeNo,
		Photo,
		JoinDate,
		LeaveDate,
		SponsorsID,
		Shift,
		Salary,
		PerDayWorkingHours,
		PerHourSalary,
		PaymentType,
		BankName,
		BranchName,
		AccountNo,
		RTGSNo,
		IFSCCode,
		OpeningBalance,
		IsActive,
		CreatedBY,
		CreatedDate
		)
VALUES 
		(
		@EmployeeTypeID,
		@EmployeeCode,
		@JobTitle,
		@FirstName,
		@MiddleName,
		@LastName,
		@ResidentialAddress,
		@PermanentAddress,
		@MobileNo,
		@EmailID,
		@DOB,
		@Gender,
		@IDProfe,
		@IDProfeNo,
		@Photo,
		@JoinDate,
		@LeaveDate,
		@SponsorsID,
		@Shift,
		@Salary,
		@PerDayWorkingHours,
		@PerHourSalary,
		@PaymentType,
		@BankName,
		@BranchName,
		@AccountNo,
		@RTGSNo,
		@IFSCCode,
		@OpeningBalance,
		@IsActive,
		@CreatedBY,
		@CreatedDate)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblEmployee_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblEmployee_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblEmployee_DELETE]
@EmployeeID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update 	tblEmployee
set IsActive=0

WHERE 
	EmployeeID=@EmployeeID
GO
/****** Object:  StoredProcedure [dbo].[tblEmployee_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblEmployee_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblEmployee_BY_ID_LOAD]
@EmployeeID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	EmployeeID,
	EmployeeTypeID,
	EmployeeCode,
	JobTitle,
	FirstName,
	MiddleName,
	LastName,
	ResidentialAddress,
	PermanentAddress,
	MobileNo,
	EmailID,
	DOB,
	Gender,
	IDProfe,
	IDProfeNo,
	Photo,
	JoinDate,
	LeaveDate,
	SponsorsID,
	Shift,
	Salary,
	PerDayWorkingHours,
	PerHourSalary,
	PaymentType,
	BankName,
	BranchName,
	AccountNo,
	RTGSNo,
	IFSCCode,
	OpeningBalance,
	IsActive,
	CreatedBY,
	CreatedDate,
	UpdatedBy,
	UpdatedDate
FROM 
	tblEmployee
WHERE 
	EmployeeID=@EmployeeID and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblBranchMST_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBranchMST_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBranchMST_UPDATE]
@BranchID		bigint ,
@BranchName		varchar(50),
@Address		varchar(1000),
@BankID		bigint,
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblBranchMST
SET
	BranchName=@BranchName,
	Address=@Address,
	BankID=@BankID,
	IsActive=@IsActive,
	CreateBy=@CreateBy,
	CreationDateTime=@CreationDateTime,
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	BranchID=@BranchID
GO
/****** Object:  StoredProcedure [dbo].[tblBranchMST_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBranchMST_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBranchMST_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	BranchID,
	BranchName,
	[Address],
	BankID,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblBranchMST
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblBranchMST_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBranchMST_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBranchMST_INSERT]
@BranchName		varchar(50),
@Address		varchar(1000),
@BankID		bigint,
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblBranchMST
		(
		BranchName,
		Address,
		BankID,
		IsActive,
		CreateBy,
		CreationDateTime
		)
VALUES 
		(
		@BranchName,
		@Address,
		@BankID,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblBranchMST_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBranchMST_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBranchMST_DELETE]
@BranchID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update 	tblBranchMST
set IsActive =0

WHERE 
	BranchID=@BranchID
GO
/****** Object:  StoredProcedure [dbo].[tblBranchMST_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBranchMST_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBranchMST_BY_ID_LOAD]
@BranchID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	BranchID,
	BranchName,
	[Address],
	BankID,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblBranchMST
WHERE 
	BranchID=@BranchID and IsActive=1
GO
/****** Object:  Table [dbo].[tblAttendanceMST]    Script Date: 03/16/2015 19:13:42 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  StoredProcedure [dbo].[tblAttendanceMST_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblAttendanceMST_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblAttendanceMST_UPDATE]
@AttendanceID		bigint ,
@EmployeeID		bigint,
@StartTime		datetime,
@EndTime		datetime,
@MeterWorked		float,
@IsActive		bit,

@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblAttendanceMST
SET
	EmployeeID=@EmployeeID,
	StartTime=@StartTime,
	EndTime=@EndTime,
	MeterWorked=@MeterWorked,
	IsActive=@IsActive,
	
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	AttendanceID=@AttendanceID
GO
/****** Object:  StoredProcedure [dbo].[tblAttendanceMST_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblAttendanceMST_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblAttendanceMST_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	AttendanceID,
	EmployeeID,
	StartTime,
	EndTime,
	MeterWorked,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblAttendanceMST
	
	Where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblAttendanceMST_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblAttendanceMST_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblAttendanceMST_INSERT]
@EmployeeID		bigint,
@StartTime		datetime,
@EndTime		datetime,
@MeterWorked		float,
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime
AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblAttendanceMST
		(
		EmployeeID,
		StartTime,
		EndTime,
		MeterWorked,
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@EmployeeID,
		@StartTime,
		@EndTime,
		@MeterWorked,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblAttendanceMST_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblAttendanceMST_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblAttendanceMST_DELETE]
@AttendanceID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update 	tblAttendanceMST
set IsActive=0

WHERE 
	AttendanceID=@AttendanceID
GO
/****** Object:  StoredProcedure [dbo].[tblAttendanceMST_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblAttendanceMST_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblAttendanceMST_BY_ID_LOAD]
@AttendanceID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	AttendanceID,
	EmployeeID,
	StartTime,
	EndTime,
	MeterWorked,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblAttendanceMST
WHERE 
	AttendanceID=@AttendanceID and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblSalaryMST_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblSalaryMST_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblSalaryMST_UPDATE]
@SalaryID		int ,
@EmployeeID		bigint,
@Date		datetime,
@StartDate		date,
@EndDate		date,
@WorkedHours		float,
@TotalPenalty		float,
@Bonus		float,
@WithdrownAmount		float,
@WithdrownID		bigint,
@NetSalary		float,
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblSalaryMST
SET
	EmployeeID=@EmployeeID,
	[Date]=@Date,
	StartDate=@StartDate,
	EndDate=@EndDate,
	WorkedHours=@WorkedHours,
	TotalPenalty=@TotalPenalty,
	Bonus=@Bonus,
	WithdrownAmount=@WithdrownAmount,
	WithdrownID=@WithdrownID,
	NetSalary=@NetSalary,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	SalaryID=@SalaryID
GO
/****** Object:  StoredProcedure [dbo].[tblSalaryMST_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblSalaryMST_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblSalaryMST_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	SalaryID,
	EmployeeID,
	[Date],
	StartDate,
	EndDate,
	WorkedHours,
	TotalPenalty,
	Bonus,
	WithdrownAmount,
	WithdrownID,
	NetSalary,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblSalaryMST
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblSalaryMST_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblSalaryMST_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblSalaryMST_INSERT]
@EmployeeID		bigint,
@Date		datetime,
@StartDate		date,
@EndDate		date,
@WorkedHours		float,
@TotalPenalty		float,
@Bonus		float,
@WithdrownAmount		float,
@WithdrownID		bigint,
@NetSalary		float,
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblSalaryMST
		(
		EmployeeID,
		[Date],
		StartDate,
		EndDate,
		WorkedHours,
		TotalPenalty,
		Bonus,
		WithdrownAmount,
		WithdrownID,
		NetSalary,
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@EmployeeID,
		@Date,
		@StartDate,
		@EndDate,
		@WorkedHours,
		@TotalPenalty,
		@Bonus,
		@WithdrownAmount,
		@WithdrownID,
		@NetSalary,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblSalaryMST_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblSalaryMST_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblSalaryMST_DELETE]
@SalaryID		int 

AS

/*
	Delete records against the give criteria.
*/

Update tblSalaryMST
set IsActive=0

WHERE 
	SalaryID=@SalaryID
GO
/****** Object:  StoredProcedure [dbo].[tblSalaryMST_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblSalaryMST_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblSalaryMST_BY_ID_LOAD]
@SalaryID		int 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	SalaryID,
	EmployeeID,
	[Date],
	StartDate,
	EndDate,
	WorkedHours,
	TotalPenalty,
	Bonus,
	WithdrownAmount,
	WithdrownID,
	NetSalary,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblSalaryMST
WHERE 
	SalaryID=@SalaryID 
	and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPurchaseItems_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPurchaseItems_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPurchaseItems_UPDATE]
@PurchaseItemID		bigint ,
@PurchaseID		bigint,
@YarnID		bigint,
@YarnPackageTypeID		bigint,
@PurchaseDate		date,
@BoxNo		varchar(50),
@GrossWeight		float,
@TareWeight		float,
@NetWeight		float,
@Cheese		float,
@EmployeeID		bigint,
@YarnQualityID		bigint,
@YarnTypeID		bigint,
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblYarnPurchaseItems
SET
	PurchaseID=@PurchaseID,
	YarnID=@YarnID,
	YarnPackageTypeID=@YarnPackageTypeID,
	PurchaseDate=@PurchaseDate,
	BoxNo=@BoxNo,
	GrossWeight=@GrossWeight,
	TareWeight=@TareWeight,
	NetWeight=@NetWeight,
	Cheese=@Cheese,
	EmployeeID=@EmployeeID,
	YarnQualityID=@YarnQualityID,
	YarnTypeID=@YarnTypeID,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	
	UpdationDateTime=@UpdationDateTime
WHERE 
	PurchaseItemID=@PurchaseItemID
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPurchaseItems_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPurchaseItems_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPurchaseItems_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	PurchaseItemID,
	PurchaseID,
	YarnID,
	YarnPackageTypeID,
	PurchaseDate,
	BoxNo,
	GrossWeight,
	TareWeight,
	NetWeight,
	Cheese,
	EmployeeID,
	YarnQualityID,
	YarnTypeID,
	IsActive,
	UpdateBy,
	CreateBy,
	UpdationDateTime,
	CreationDateTIme
FROM 
	tblYarnPurchaseItems
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPurchaseItems_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPurchaseItems_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPurchaseItems_INSERT]
@PurchaseID		bigint,
@YarnID		bigint,
@YarnPackageTypeID		bigint,
@PurchaseDate		date,
@BoxNo		varchar(50),
@GrossWeight		float,
@TareWeight		float,
@NetWeight		float,
@Cheese		float,
@EmployeeID		bigint,
@YarnQualityID		bigint,
@YarnTypeID		bigint,
@IsActive		bit,
@CreateBy		int,
@CreationDateTIme datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblYarnPurchaseItems
		(
		PurchaseID,
		YarnID,
		YarnPackageTypeID,
		PurchaseDate,
		BoxNo,
		GrossWeight,
		TareWeight,
		NetWeight,
		Cheese,
		EmployeeID,
		YarnQualityID,
		YarnTypeID,
		IsActive,
		
		CreateBy,
		
		CreationDateTIme)
VALUES 
		(
		@PurchaseID,
		@YarnID,
		@YarnPackageTypeID,
		@PurchaseDate,
		@BoxNo,
		@GrossWeight,
		@TareWeight,
		@NetWeight,
		@Cheese,
		@EmployeeID,
		@YarnQualityID,
		@YarnTypeID,
		@IsActive,
	
		@CreateBy,
		
		@CreationDateTIme)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPurchaseItems_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPurchaseItems_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPurchaseItems_DELETE]
@PurchaseItemID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update 	tblYarnPurchaseItems
set IsActive=0

WHERE 
	PurchaseItemID=@PurchaseItemID
GO
/****** Object:  StoredProcedure [dbo].[tblYarnPurchaseItems_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblYarnPurchaseItems_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblYarnPurchaseItems_BY_ID_LOAD]
@PurchaseItemID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	PurchaseItemID,
	PurchaseID,
	YarnID,
	YarnPackageTypeID,
	PurchaseDate,
	BoxNo,
	GrossWeight,
	TareWeight,
	NetWeight,
	Cheese,
	EmployeeID,
	YarnQualityID,
	YarnTypeID,
	IsActive,
	UpdateBy,
	CreateBy,
	UpdationDateTime,
	CreationDateTIme
FROM 
	tblYarnPurchaseItems
WHERE 
	PurchaseItemID=@PurchaseItemID 
	and IsActive=1
GO
/****** Object:  Table [dbo].[tblWindingWork]    Script Date: 03/16/2015 19:13:42 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  StoredProcedure [dbo].[tblWindingWork_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWindingWork_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWindingWork_UPDATE]
@WindingProcessId		int ,
@MachineId		int,
@EmployeeId		int,
@PuchaseItemId		bigint,
@Shift		varchar(50),
@StartDateTime		datetime,
@TotalIssueWeight		float,
@WastedWeight		float,
@ProductionWeight		float,
@NoOfCopes		int,
@EndDateTime		datetime,
@YarnQualityId		int,
@YarnTypeId		int,
@IsActive		bit,
@UpdateBy		int,

@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblWindingWork
SET
	MachineId=@MachineId,
	EmployeeId=@EmployeeId,
	PuchaseItemId=@PuchaseItemId,
	Shift=@Shift,
	StartDateTime=@StartDateTime,
	TotalIssueWeight=@TotalIssueWeight,
	WastedWeight=@WastedWeight,
	ProductionWeight=@ProductionWeight,
	NoOfCopes=@NoOfCopes,
	EndDateTime=@EndDateTime,
	YarnQualityId=@YarnQualityId,
	YarnTypeId=@YarnTypeId,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	
	UpdationDateTime=@UpdationDateTime
WHERE 
	WindingProcessId=@WindingProcessId
GO
/****** Object:  StoredProcedure [dbo].[tblWindingWork_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWindingWork_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWindingWork_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	WindingProcessId,
	MachineId,
	EmployeeId,
	PuchaseItemId,
	Shift,
	StartDateTime,
	TotalIssueWeight,
	WastedWeight,
	ProductionWeight,
	NoOfCopes,
	EndDateTime,
	YarnQualityId,
	YarnTypeId,
	IsActive,
	UpdateBy,
	CreateBy,
	UpdationDateTime,
	CreationDateTIme
FROM 
	tblWindingWork
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblWindingWork_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWindingWork_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWindingWork_INSERT]
@MachineId		int,
@EmployeeId		int,
@PuchaseItemId		bigint,
@Shift		varchar(50),
@StartDateTime		datetime,
@TotalIssueWeight		float,
@WastedWeight		float,
@ProductionWeight		float,
@NoOfCopes		int,
@EndDateTime		datetime,
@YarnQualityId		int,
@YarnTypeId		int,
@IsActive		bit,

@CreateBy		int,

@CreationDateTIme		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblWindingWork
		(
		MachineId,
		EmployeeId,
		PuchaseItemId,
		Shift,
		StartDateTime,
		TotalIssueWeight,
		WastedWeight,
		ProductionWeight,
		NoOfCopes,
		EndDateTime,
		YarnQualityId,
		YarnTypeId,
		IsActive,
		
		CreateBy,
		
		CreationDateTIme)
VALUES 
		(
		@MachineId,
		@EmployeeId,
		@PuchaseItemId,
		@Shift,
		@StartDateTime,
		@TotalIssueWeight,
		@WastedWeight,
		@ProductionWeight,
		@NoOfCopes,
		@EndDateTime,
		@YarnQualityId,
		@YarnTypeId,
		@IsActive,
	
		@CreateBy,
		
		@CreationDateTIme)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblWindingWork_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWindingWork_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWindingWork_DELETE]
@WindingProcessId		int 

AS

/*
	Delete records against the give criteria.
*/

Update tblWindingWork
set IsActive=0

WHERE 
	WindingProcessId=@WindingProcessId
GO
/****** Object:  StoredProcedure [dbo].[tblWindingWork_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblWindingWork_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblWindingWork_BY_ID_LOAD]
@WindingProcessId		int 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	WindingProcessId,
	MachineId,
	EmployeeId,
	PuchaseItemId,
	Shift,
	StartDateTime,
	TotalIssueWeight,
	WastedWeight,
	ProductionWeight,
	NoOfCopes,
	EndDateTime,
	YarnQualityId,
	YarnTypeId,
	IsActive,
	UpdateBy,
	CreateBy,
	UpdationDateTime,
	CreationDateTIme
FROM 
	tblWindingWork
WHERE 
	WindingProcessId=@WindingProcessId 
	and IsActive=1
GO
/****** Object:  Table [dbo].[tblTFOProcess]    Script Date: 03/16/2015 19:13:42 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  StoredProcedure [dbo].[tblTFOProcess_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblTFOProcess_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblTFOProcess_UPDATE]
@TFORoleProcessId		bigint ,
@WindingProcessId		int,
@PurchaseItemID		int,
@MachineId		int,
@EmployeeId		int,
@Shift		varchar(50),
@StartDateTime		datetime,
@IssueNoOfCopes		int,
@IssueWights		float,
@NoofTFORole		float,
@ProducttionNoOfTFORoles		int,
@ProducttionWights		float,
@QualityName		varchar(50),
@EndDateTime		datetime,
@YarnQualityId		int,
@YarnTypeId		int,
@IsActive		bit,
@UpdationDateTime		datetime,
@CreationDateTIme		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblTFOProcess
SET
	WindingProcessId=@WindingProcessId,
	PurchaseItemID=@PurchaseItemID,
	MachineId=@MachineId,
	EmployeeId=@EmployeeId,
	Shift=@Shift,
	StartDateTime=@StartDateTime,
	IssueNoOfCopes=@IssueNoOfCopes,
	IssueWights=@IssueWights,
	NoofTFORole=@NoofTFORole,
	ProducttionNoOfTFORoles=@ProducttionNoOfTFORoles,
	ProducttionWights=@ProducttionWights,
	QualityName=@QualityName,
	EndDateTime=@EndDateTime,
	YarnQualityId=@YarnQualityId,
	YarnTypeId=@YarnTypeId,
	IsActive=@IsActive,
	UpdationDateTime=@UpdationDateTime,
	CreationDateTIme=@CreationDateTIme
WHERE 
	TFORoleProcessId=@TFORoleProcessId
GO
/****** Object:  StoredProcedure [dbo].[tblTFOProcess_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblTFOProcess_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblTFOProcess_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	TFORoleProcessId,
	WindingProcessId,
	PurchaseItemID,
	MachineId,
	EmployeeId,
	Shift,
	StartDateTime,
	IssueNoOfCopes,
	IssueWights,
	NoofTFORole,
	ProducttionNoOfTFORoles,
	ProducttionWights,
	QualityName,
	EndDateTime,
	YarnQualityId,
	YarnTypeId,
	IsActive,
	UpdateBy,
	CreateBy,
	UpdationDateTime,
	CreationDateTIme
FROM 
	tblTFOProcess
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblTFOProcess_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblTFOProcess_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblTFOProcess_INSERT]
@WindingProcessId		int,
@PurchaseItemID		int,
@MachineId		int,
@EmployeeId		int,
@Shift		varchar(50),
@StartDateTime		datetime,
@IssueNoOfCopes		int,
@IssueWights		float,
@NoofTFORole		float,
@ProducttionNoOfTFORoles		int,
@ProducttionWights		float,
@QualityName		varchar(50),
@EndDateTime		datetime,
@YarnQualityId		int,
@YarnTypeId		int,
@IsActive		bit,
@CreateBy		int,
@CreationDateTIme		datetime

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblTFOProcess
		(
		WindingProcessId,
		PurchaseItemID,
		MachineId,
		EmployeeId,
		Shift,
		StartDateTime,
		IssueNoOfCopes,
		IssueWights,
		NoofTFORole,
		ProducttionNoOfTFORoles,
		ProducttionWights,
		QualityName,
		EndDateTime,
		YarnQualityId,
		YarnTypeId,
		IsActive,
		
		CreateBy,
		
		CreationDateTIme)
VALUES 
		(
		@WindingProcessId,
		@PurchaseItemID,
		@MachineId,
		@EmployeeId,
		@Shift,
		@StartDateTime,
		@IssueNoOfCopes,
		@IssueWights,
		@NoofTFORole,
		@ProducttionNoOfTFORoles,
		@ProducttionWights,
		@QualityName,
		@EndDateTime,
		@YarnQualityId,
		@YarnTypeId,
		@IsActive,
		
		@CreateBy,
		
		@CreationDateTIme)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblTFOProcess_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblTFOProcess_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblTFOProcess_DELETE]
@TFORoleProcessId		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblTFOProcess
set IsActive=0

WHERE 
	TFORoleProcessId=@TFORoleProcessId
GO
/****** Object:  StoredProcedure [dbo].[tblTFOProcess_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblTFOProcess_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblTFOProcess_BY_ID_LOAD]
@TFORoleProcessId		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	TFORoleProcessId,
	WindingProcessId,
	PurchaseItemID,
	MachineId,
	EmployeeId,
	Shift,
	StartDateTime,
	IssueNoOfCopes,
	IssueWights,
	NoofTFORole,
	ProducttionNoOfTFORoles,
	ProducttionWights,
	QualityName,
	EndDateTime,
	YarnQualityId,
	YarnTypeId,
	IsActive,
	UpdateBy,
	CreateBy,
	UpdationDateTime,
	CreationDateTIme
FROM 
	tblTFOProcess
WHERE 
	TFORoleProcessId=@TFORoleProcessId 
	and IsActive=1
GO
/****** Object:  Table [dbo].[tblBolierProcessDetails]    Script Date: 03/16/2015 19:13:42 ******/
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
	[IsDelete] [bit] NULL,
	[CreatedBy] [int] NULL,
	[CreatedDateTime] [datetime] NULL,
	[UpdatedBy] [int] NULL,
	[UpdatedDateTime] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_BolierProcessDetails] PRIMARY KEY CLUSTERED 
(
	[BoilerProcessDetailsID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBemProcessDetails]    Script Date: 03/16/2015 19:13:42 ******/
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
	[IsDelete] [bit] NULL,
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
/****** Object:  StoredProcedure [dbo].[tblBolierProcessDetails_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBolierProcessDetails_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBolierProcessDetails_UPDATE]
@BoilerProcessDetailsID		bigint ,
@BoilerProcessID		bigint,
@TFORoleProcessID		bigint,
@IssueNoOfTFORoles		int,
@IssueWeights		float,
@YarnQualityID		bigint,
@YarnTypeID		bigint

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblBolierProcessDetails
SET
	BoilerProcessID=@BoilerProcessID,
	TFORoleProcessID=@TFORoleProcessID,
	IssueNoOfTFORoles=@IssueNoOfTFORoles,
	IssueWeights=@IssueWeights,
	YarnQualityID=@YarnQualityID,
	YarnTypeID=@YarnTypeID
WHERE 
	BoilerProcessDetailsID=@BoilerProcessDetailsID
GO
/****** Object:  StoredProcedure [dbo].[tblBolierProcessDetails_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBolierProcessDetails_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBolierProcessDetails_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	BoilerProcessDetailsID,
	BoilerProcessID,
	TFORoleProcessID,
	IssueNoOfTFORoles,
	IssueWeights,
	YarnQualityID,
	YarnTypeID,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime,
	IsActive
FROM 
	tblBolierProcessDetails
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblBolierProcessDetails_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBolierProcessDetails_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBolierProcessDetails_INSERT]
@BoilerProcessID		bigint,
@TFORoleProcessID		bigint,
@IssueNoOfTFORoles		int,
@IssueWeights		float,
@YarnQualityID		bigint,
@YarnTypeID		bigint,
@CreatedBy int,
@CreatedDateTime datetime,
@IsActive bit

AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblBolierProcessDetails
		(
		BoilerProcessID,
		TFORoleProcessID,
		IssueNoOfTFORoles,
		IssueWeights,
		YarnQualityID,
		YarnTypeID,
		CreatedBy,
		CreatedDateTime,
		IsActive
		)
VALUES 
		(
		@BoilerProcessID,
		@TFORoleProcessID,
		@IssueNoOfTFORoles,
		@IssueWeights,
		@YarnQualityID,
		@YarnTypeID,
		@CreatedBy,
		@CreatedDateTime,
		@IsActive
		)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblBolierProcessDetails_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBolierProcessDetails_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBolierProcessDetails_DELETE]
@BoilerProcessDetailsID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblBolierProcessDetails
set IsActive=0

WHERE 
	BoilerProcessDetailsID=@BoilerProcessDetailsID
GO
/****** Object:  StoredProcedure [dbo].[tblBolierProcessDetails_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBolierProcessDetails_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBolierProcessDetails_BY_ID_LOAD]
@BoilerProcessDetailsID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	BoilerProcessDetailsID,
	BoilerProcessID,
	TFORoleProcessID,
	IssueNoOfTFORoles,
	IssueWeights,
	YarnQualityID,
	YarnTypeID,
	CreatedBy,
	CreatedDateTime,
	UpdatedBy,
	UpdatedDateTime
FROM 
	tblBolierProcessDetails
WHERE 
	BoilerProcessDetailsID=@BoilerProcessDetailsID and IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblBemProcessDetails_UPDATE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBemProcessDetails_UPDATE
PURPOSE: 		 Update records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBemProcessDetails_UPDATE]
@BemProcessDetailsID		bigint ,
@BemProcessID		bigint,
@TFORoleProcessID		bigint,
@IssueNoOFCopes		int,
@IssueWeights		float,
@YarnQualityID		bigint,
@YarnTypeID		bigint,
@IsActive		bit,
@UpdateBy		int,
@UpdationDateTime		datetime

AS

/*
	it will update reocrds which match the criteria.
*/

UPDATE 
	tblBemProcessDetails
SET
	BemProcessID=@BemProcessID,
	TFORoleProcessID=@TFORoleProcessID,
	IssueNoOFCopes=@IssueNoOFCopes,
	IssueWeights=@IssueWeights,
	YarnQualityID=@YarnQualityID,
	YarnTypeID=@YarnTypeID,
	IsActive=@IsActive,
	UpdateBy=@UpdateBy,
	UpdationDateTime=@UpdationDateTime
WHERE 
	BemProcessDetailsID=@BemProcessDetailsID
GO
/****** Object:  StoredProcedure [dbo].[tblBemProcessDetails_LOAD_ALL]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBemProcessDetails_LOAD_ALL
PURPOSE: 		 Search all records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBemProcessDetails_LOAD_ALL]

AS

/*
	It will select all the records.
*/

SELECT 
	
	BemProcessDetailsID,
	BemProcessID,
	TFORoleProcessID,
	IssueNoOFCopes,
	IssueWeights,
	YarnQualityID,
	YarnTypeID,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblBemProcessDetails
	where IsActive=1
GO
/****** Object:  StoredProcedure [dbo].[tblBemProcessDetails_INSERT]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBemProcessDetails_INSERT
PURPOSE: 		 Insert new records.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBemProcessDetails_INSERT]
@BemProcessID		bigint,
@TFORoleProcessID		bigint,
@IssueNoOFCopes		int,
@IssueWeights		float,
@YarnQualityID		bigint,
@YarnTypeID		bigint,
@IsActive		bit,
@CreateBy		int,
@CreationDateTime		datetime
AS

/*
	It is used to insert new records.
*/

INSERT 
	INTO 
	tblBemProcessDetails
		(
		BemProcessID,
		TFORoleProcessID,
		IssueNoOFCopes,
		IssueWeights,
		YarnQualityID,
		YarnTypeID,
		IsActive,
		CreateBy,
		CreationDateTime)
VALUES 
		(
		@BemProcessID,
		@TFORoleProcessID,
		@IssueNoOFCopes,
		@IssueWeights,
		@YarnQualityID,
		@YarnTypeID,
		@IsActive,
		@CreateBy,
		@CreationDateTime)
select SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[tblBemProcessDetails_DELETE]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBemProcessDetails_DELETE
PURPOSE: 		 Delete records against primary key.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBemProcessDetails_DELETE]
@BemProcessDetailsID		bigint 

AS

/*
	Delete records against the give criteria.
*/

Update tblBemProcessDetails
set IsActive=0

WHERE 
	BemProcessDetailsID=@BemProcessDetailsID
GO
/****** Object:  StoredProcedure [dbo].[tblBemProcessDetails_BY_ID_LOAD]    Script Date: 03/16/2015 19:13:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************************************************************
NAME: 			 tblBemProcessDetails_BY_ID_LOAD
PURPOSE: 		 Search records against the primary key field.
SCREEN NAME: 	 

CREATED 		 ACTION 	 DATE 		 VERSION 	 REMARKS
******************************************************************************************************************************************************
CodeGenrator 		 Created 	 01-03-2015 	 1.0.0.0 		 -
*******************************************************************************************************************************************************/

CREATE PROCEDURE [dbo].[tblBemProcessDetails_BY_ID_LOAD]
@BemProcessDetailsID		bigint 

AS

/*
	It will select records which match the criteria.
*/

SELECT 
	
	BemProcessDetailsID,
	BemProcessID,
	TFORoleProcessID,
	IssueNoOFCopes,
	IssueWeights,
	YarnQualityID,
	YarnTypeID,
	IsActive,
	CreateBy,
	CreationDateTime,
	UpdateBy,
	UpdationDateTime
FROM 
	tblBemProcessDetails
WHERE 
	BemProcessDetailsID=@BemProcessDetailsID and IsActive=1
GO
/****** Object:  ForeignKey [FK_tblBranchMST_tblBankMST]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblBranchMST]  WITH CHECK ADD  CONSTRAINT [FK_tblBranchMST_tblBankMST] FOREIGN KEY([BankID])
REFERENCES [dbo].[tblBankMST] ([BankID])
GO
ALTER TABLE [dbo].[tblBranchMST] CHECK CONSTRAINT [FK_tblBranchMST_tblBankMST]
GO
/****** Object:  ForeignKey [FK_tblEmployee_tblEmployeeType]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblEmployee]  WITH CHECK ADD  CONSTRAINT [FK_tblEmployee_tblEmployeeType] FOREIGN KEY([EmployeeTypeID])
REFERENCES [dbo].[tblEmployeeTypeMST] ([EmployeeTypeID])
GO
ALTER TABLE [dbo].[tblEmployee] CHECK CONSTRAINT [FK_tblEmployee_tblEmployeeType]
GO
/****** Object:  ForeignKey [FK_tblCompanyMachine_tblCompany]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblCompanyMachineMST]  WITH CHECK ADD  CONSTRAINT [FK_tblCompanyMachine_tblCompany] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[tblCompany] ([CompanyID])
GO
ALTER TABLE [dbo].[tblCompanyMachineMST] CHECK CONSTRAINT [FK_tblCompanyMachine_tblCompany]
GO
/****** Object:  ForeignKey [FK_tblCompanyMachine_tblMachine]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblCompanyMachineMST]  WITH CHECK ADD  CONSTRAINT [FK_tblCompanyMachine_tblMachine] FOREIGN KEY([MachineId])
REFERENCES [dbo].[tblMachineMST] ([MachineID])
GO
ALTER TABLE [dbo].[tblCompanyMachineMST] CHECK CONSTRAINT [FK_tblCompanyMachine_tblMachine]
GO
/****** Object:  ForeignKey [FK_tblYarnTypeMST_tblYarnQualityMST]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblYarnTypeMST]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnTypeMST_tblYarnQualityMST] FOREIGN KEY([YarnQualityID])
REFERENCES [dbo].[tblYarnQualityMST] ([YarnQualityID])
GO
ALTER TABLE [dbo].[tblYarnTypeMST] CHECK CONSTRAINT [FK_tblYarnTypeMST_tblYarnQualityMST]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnMST]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnMST] FOREIGN KEY([YarnID])
REFERENCES [dbo].[tblYarnQualityMST] ([YarnQualityID])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnMST]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnPackageType]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnPackageType] FOREIGN KEY([YarnPackageTypeID])
REFERENCES [dbo].[tblYarnPackageType] ([YarnPackageTypeID])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnPackageType]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnPurchase]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnPurchase] FOREIGN KEY([PurchaseID])
REFERENCES [dbo].[tblYarnPurchase] ([PurchaseID])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnPurchase]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnQualityMST]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnQualityMST] FOREIGN KEY([YarnQualityID])
REFERENCES [dbo].[tblYarnQualityMST] ([YarnQualityID])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnQualityMST]
GO
/****** Object:  ForeignKey [FK_tblYarnPurchaseItems_tblYarnTypeMST]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblYarnPurchaseItems]  WITH CHECK ADD  CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnTypeMST] FOREIGN KEY([YarnTypeID])
REFERENCES [dbo].[tblYarnTypeMST] ([YarnTypeID])
GO
ALTER TABLE [dbo].[tblYarnPurchaseItems] CHECK CONSTRAINT [FK_tblYarnPurchaseItems_tblYarnTypeMST]
GO
/****** Object:  ForeignKey [FK_tblSalaryMST_tblEmployee]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblSalaryMST]  WITH CHECK ADD  CONSTRAINT [FK_tblSalaryMST_tblEmployee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmployeeID])
GO
ALTER TABLE [dbo].[tblSalaryMST] CHECK CONSTRAINT [FK_tblSalaryMST_tblEmployee]
GO
/****** Object:  ForeignKey [FK_tblAttendanceMST_tblEmployee]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblAttendanceMST]  WITH CHECK ADD  CONSTRAINT [FK_tblAttendanceMST_tblEmployee] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[tblEmployee] ([EmployeeID])
GO
ALTER TABLE [dbo].[tblAttendanceMST] CHECK CONSTRAINT [FK_tblAttendanceMST_tblEmployee]
GO
/****** Object:  ForeignKey [FK_tblWindingWork_tblYarnPurchaseItems]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblWindingWork]  WITH CHECK ADD  CONSTRAINT [FK_tblWindingWork_tblYarnPurchaseItems] FOREIGN KEY([PuchaseItemId])
REFERENCES [dbo].[tblYarnPurchaseItems] ([PurchaseItemID])
GO
ALTER TABLE [dbo].[tblWindingWork] CHECK CONSTRAINT [FK_tblWindingWork_tblYarnPurchaseItems]
GO
/****** Object:  ForeignKey [FK_tblTFOProcess_tblWindingWork]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblTFOProcess]  WITH CHECK ADD  CONSTRAINT [FK_tblTFOProcess_tblWindingWork] FOREIGN KEY([WindingProcessId])
REFERENCES [dbo].[tblWindingWork] ([WindingProcessId])
GO
ALTER TABLE [dbo].[tblTFOProcess] CHECK CONSTRAINT [FK_tblTFOProcess_tblWindingWork]
GO
/****** Object:  ForeignKey [FK_tblBolierProcessDetails_tblBoilerProcess]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblBolierProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBolierProcessDetails_tblBoilerProcess] FOREIGN KEY([BoilerProcessID])
REFERENCES [dbo].[tblBoilerProcess] ([BolierProcessID])
GO
ALTER TABLE [dbo].[tblBolierProcessDetails] CHECK CONSTRAINT [FK_tblBolierProcessDetails_tblBoilerProcess]
GO
/****** Object:  ForeignKey [FK_tblBolierProcessDetails_tblTFOProcess]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblBolierProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBolierProcessDetails_tblTFOProcess] FOREIGN KEY([TFORoleProcessID])
REFERENCES [dbo].[tblTFOProcess] ([TFORoleProcessId])
GO
ALTER TABLE [dbo].[tblBolierProcessDetails] CHECK CONSTRAINT [FK_tblBolierProcessDetails_tblTFOProcess]
GO
/****** Object:  ForeignKey [FK_tblBemProcessDetails_tblBeemProcess]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblBemProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBemProcessDetails_tblBeemProcess] FOREIGN KEY([BemProcessID])
REFERENCES [dbo].[tblBeemProcess] ([BeemProcessID])
GO
ALTER TABLE [dbo].[tblBemProcessDetails] CHECK CONSTRAINT [FK_tblBemProcessDetails_tblBeemProcess]
GO
/****** Object:  ForeignKey [FK_tblBemProcessDetails_tblBoilerProcess]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblBemProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBemProcessDetails_tblBoilerProcess] FOREIGN KEY([BemProcessID])
REFERENCES [dbo].[tblBoilerProcess] ([BolierProcessID])
GO
ALTER TABLE [dbo].[tblBemProcessDetails] CHECK CONSTRAINT [FK_tblBemProcessDetails_tblBoilerProcess]
GO
/****** Object:  ForeignKey [FK_tblBemProcessDetails_tblTFOProcess]    Script Date: 03/16/2015 19:13:42 ******/
ALTER TABLE [dbo].[tblBemProcessDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblBemProcessDetails_tblTFOProcess] FOREIGN KEY([TFORoleProcessID])
REFERENCES [dbo].[tblTFOProcess] ([TFORoleProcessId])
GO
ALTER TABLE [dbo].[tblBemProcessDetails] CHECK CONSTRAINT [FK_tblBemProcessDetails_tblTFOProcess]
GO
