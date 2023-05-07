USE [NGO]
GO
/****** Object:  Table [dbo].[NGO_Admin]    Script Date: 07-05-2023 10:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGO_Admin](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Mobilenumber] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGO_Donar]    Script Date: 07-05-2023 10:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGO_Donar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[DonatedAmount] [varchar](100) NULL,
	[DonatedDate] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGO_Events]    Script Date: 07-05-2023 10:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGO_Events](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Detail] [varchar](100) NULL,
	[DateTime] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGO_FundRaiser]    Script Date: 07-05-2023 10:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGO_FundRaiser](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[FundRaiserAmount] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGO_Member]    Script Date: 07-05-2023 10:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGO_Member](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[JoinDate] [date] NULL,
	[EndDate] [date] NULL,
	[TypeofUser] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGO_User]    Script Date: 07-05-2023 10:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGO_User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Mobilenumber] [varchar](10) NULL,
	[Address] [varchar](100) NULL,
	[EmailId] [varchar](50) NULL,
	[Birthdate] [date] NULL,
	[Gender] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NGO_Volunteer]    Script Date: 07-05-2023 10:12:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGO_Volunteer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](20) NULL,
	[Mobilenumber] [varchar](10) NULL,
	[Address] [varchar](100) NULL,
	[EmailId] [varchar](50) NULL,
	[Birthdate] [date] NULL,
	[Gender] [varchar](10) NULL
) ON [PRIMARY]
GO
