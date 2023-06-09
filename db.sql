USE [EmployeeManagement]
GO
ALTER TABLE [dbo].[Person] DROP CONSTRAINT [DF_Person_GrossSales]
GO
ALTER TABLE [dbo].[Person] DROP CONSTRAINT [DF_Person_ComissionRate]
GO
ALTER TABLE [dbo].[Person] DROP CONSTRAINT [DF_Person_Hours]
GO
ALTER TABLE [dbo].[Person] DROP CONSTRAINT [DF_Person_Salary]
GO
ALTER TABLE [dbo].[Person] DROP CONSTRAINT [DF_Person_Wage]
GO
ALTER TABLE [dbo].[Benefits] DROP CONSTRAINT [DF_Benefits_Commission]
GO
ALTER TABLE [dbo].[Benefits] DROP CONSTRAINT [DF_Benefits_Education]
GO
ALTER TABLE [dbo].[Benefits] DROP CONSTRAINT [DF_Benefits_Benefits]
GO
ALTER TABLE [dbo].[Benefits] DROP CONSTRAINT [DF_Benefits_Overtime]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 14/02/2020 17:19:10 ******/
DROP TABLE [dbo].[Person]
GO
/****** Object:  Table [dbo].[EmployeeType]    Script Date: 14/02/2020 17:19:10 ******/
DROP TABLE [dbo].[EmployeeType]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 14/02/2020 17:19:10 ******/
DROP TABLE [dbo].[Course]
GO
/****** Object:  Table [dbo].[Benefits]    Script Date: 14/02/2020 17:19:10 ******/
DROP TABLE [dbo].[Benefits]
GO
/****** Object:  User [macs]    Script Date: 14/02/2020 17:19:10 ******/
DROP USER [macs]
GO
USE [master]
GO
/****** Object:  Database [EmployeeManagement]    Script Date: 14/02/2020 17:19:10 ******/
DROP DATABASE [EmployeeManagement]
GO
/****** Object:  Database [EmployeeManagement]    Script Date: 14/02/2020 17:19:10 ******/
CREATE DATABASE [EmployeeManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeManagement', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER17\MSSQL\DATA\EmployeeManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EmployeeManagement_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER17\MSSQL\DATA\EmployeeManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EmployeeManagement] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmployeeManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EmployeeManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EmployeeManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmployeeManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EmployeeManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EmployeeManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EmployeeManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EmployeeManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EmployeeManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EmployeeManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EmployeeManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EmployeeManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EmployeeManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EmployeeManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EmployeeManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [EmployeeManagement] SET  MULTI_USER 
GO
ALTER DATABASE [EmployeeManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmployeeManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EmployeeManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EmployeeManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EmployeeManagement] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EmployeeManagement', N'ON'
GO
ALTER DATABASE [EmployeeManagement] SET QUERY_STORE = OFF
GO
USE [EmployeeManagement]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
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
USE [EmployeeManagement]
GO
/****** Object:  User [macs]    Script Date: 14/02/2020 17:19:11 ******/
CREATE USER [macs] FOR LOGIN [macs] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Benefits]    Script Date: 14/02/2020 17:19:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Benefits](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Overtime] [bit] NOT NULL,
	[Benefits] [bit] NOT NULL,
	[Education] [bit] NOT NULL,
	[Commission] [bit] NOT NULL,
 CONSTRAINT [PK_Benefits] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 14/02/2020 17:19:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [nvarchar](200) NULL,
	[Description] [nvarchar](200) NULL,
	[Credits] [nvarchar](50) NULL,
	[Approved] [bit] NULL,
	[ApprovedDate] [date] NULL,
	[PersonId] [int] NULL,
	[ID] [nchar](10) NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeType]    Script Date: 14/02/2020 17:19:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 14/02/2020 17:19:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](200) NULL,
	[LastName] [nvarchar](200) NULL,
	[Street] [nvarchar](200) NULL,
	[City] [nvarchar](200) NULL,
	[State] [nvarchar](200) NULL,
	[Zip] [int] NULL,
	[Phone] [nchar](10) NULL,
	[Wage] [decimal](18, 0) NULL,
	[Salary] [decimal](18, 0) NULL,
	[Hours] [decimal](18, 0) NULL,
	[ComissionRate] [decimal](18, 0) NULL,
	[GrossSales] [decimal](18, 0) NULL,
	[IdType] [int] NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Course] ON 

INSERT [dbo].[Course] ([CourseId], [CourseName], [Description], [Credits], [Approved], [ApprovedDate], [PersonId], [ID]) VALUES (1, N'2', N'2', N'1', 1, CAST(N'2020-02-13' AS Date), 1, NULL)
INSERT [dbo].[Course] ([CourseId], [CourseName], [Description], [Credits], [Approved], [ApprovedDate], [PersonId], [ID]) VALUES (2, N'tyu', N'uytu', N'3', 0, CAST(N'2020-02-14' AS Date), 3, NULL)
INSERT [dbo].[Course] ([CourseId], [CourseName], [Description], [Credits], [Approved], [ApprovedDate], [PersonId], [ID]) VALUES (3, N'2', N'5', N'1', 1, CAST(N'2020-02-15' AS Date), 1, NULL)
INSERT [dbo].[Course] ([CourseId], [CourseName], [Description], [Credits], [Approved], [ApprovedDate], [PersonId], [ID]) VALUES (4, N'21', N'121', N'3', 1, CAST(N'2020-02-22' AS Date), 0, N'1         ')
INSERT [dbo].[Course] ([CourseId], [CourseName], [Description], [Credits], [Approved], [ApprovedDate], [PersonId], [ID]) VALUES (5, N'2', N'2', N'1', 1, CAST(N'2020-02-14' AS Date), 1, N'1         ')
INSERT [dbo].[Course] ([CourseId], [CourseName], [Description], [Credits], [Approved], [ApprovedDate], [PersonId], [ID]) VALUES (6, N'a', N'a', N'1', 0, CAST(N'2020-02-14' AS Date), 1, N'6         ')
INSERT [dbo].[Course] ([CourseId], [CourseName], [Description], [Credits], [Approved], [ApprovedDate], [PersonId], [ID]) VALUES (7, N'3', N'3', N'10', 1, CAST(N'2020-02-15' AS Date), 9, N'3         ')
SET IDENTITY_INSERT [dbo].[Course] OFF
SET IDENTITY_INSERT [dbo].[EmployeeType] ON 

INSERT [dbo].[EmployeeType] ([Id], [Name]) VALUES (1, N'CONTRACT')
INSERT [dbo].[EmployeeType] ([Id], [Name]) VALUES (2, N'HOURLY')
INSERT [dbo].[EmployeeType] ([Id], [Name]) VALUES (3, N'SALARY')
INSERT [dbo].[EmployeeType] ([Id], [Name]) VALUES (4, N'SALES')
SET IDENTITY_INSERT [dbo].[EmployeeType] OFF
SET IDENTITY_INSERT [dbo].[Person] ON 

INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (1, N'ewqe', N'fsdf', N'32133', N'123', N'AZ', 12, NULL, CAST(5 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 0)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (2, N'11co', N'adsf', N'fdaf', N'fdasf', N'AZ', 123, N'321321    ', CAST(4 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (3, N'33ho', N'gfsdg', N'3213', N'fdsg', N'NE', 45, N'555       ', CAST(87 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(6 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (4, N'gfdsg', N'gfsdgg', N'gfdsg', N'gfsdg', N'CO', 46, N'12        ', CAST(0 AS Decimal(18, 0)), CAST(7 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 3)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (5, N'gfg', N'gfdsg', N'fdsg', N'gdfsg', N'AZ', 12, N'123       ', CAST(0 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 3)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (6, N'eqwe', N'ewqe', N'wqe', N'ewqe', N'AZ', 12, N'123       ', CAST(0 AS Decimal(18, 0)), CAST(34 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 3)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (7, N'qwe', N'qwe', N'123', N'eqwe', N'CA', 123, N'123       ', CAST(0 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 3)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (8, N'qq', N'ww', N'123213', N'ee', N'CA', 55, N'245       ', CAST(0 AS Decimal(18, 0)), CAST(4000 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 3)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (9, N'1', N'1', N'1', N'1', N'AZ', 1, N'1         ', CAST(1 AS Decimal(18, 0)), CAST(3 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (10, N'2313', N'213', N'3213', N'3213', N'AR', 1, N'1         ', CAST(0 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 3)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (11, N'1', N'1', N'1', N'1', N'AR', 1, N'1         ', CAST(1 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 2)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (12, N'1', N'1', N'1', N'1', N'AZ', 1, N'1         ', CAST(0 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 3)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (13, N'rwer', N'4234', N'4324', N'234', N'AR', 6, N'6         ', CAST(0 AS Decimal(18, 0)), CAST(6 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 3)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (14, N'rr', N'rr', N'r', N'r', N'AR', 1, N'1         ', CAST(1 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 1)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (15, N'aa', N'aa', N'aa', N'aa', N'AZ', 1, N'1         ', CAST(0 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 3)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (16, N'rr', N'rr', N'r', N'rr', N'CA', 9, N'9         ', CAST(0 AS Decimal(18, 0)), CAST(9 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 3)
INSERT [dbo].[Person] ([Id], [FirstName], [LastName], [Street], [City], [State], [Zip], [Phone], [Wage], [Salary], [Hours], [ComissionRate], [GrossSales], [IdType]) VALUES (17, N'iiiii', N'llll', N'yrty', N'wqe', N'AR', 1, N'1         ', CAST(0 AS Decimal(18, 0)), CAST(1 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), CAST(0 AS Decimal(18, 0)), 3)
SET IDENTITY_INSERT [dbo].[Person] OFF
ALTER TABLE [dbo].[Benefits] ADD  CONSTRAINT [DF_Benefits_Overtime]  DEFAULT ((0)) FOR [Overtime]
GO
ALTER TABLE [dbo].[Benefits] ADD  CONSTRAINT [DF_Benefits_Benefits]  DEFAULT ((0)) FOR [Benefits]
GO
ALTER TABLE [dbo].[Benefits] ADD  CONSTRAINT [DF_Benefits_Education]  DEFAULT ((0)) FOR [Education]
GO
ALTER TABLE [dbo].[Benefits] ADD  CONSTRAINT [DF_Benefits_Commission]  DEFAULT ((0)) FOR [Commission]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_Wage]  DEFAULT ((0)) FOR [Wage]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_Salary]  DEFAULT ((0)) FOR [Salary]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_Hours]  DEFAULT ((0)) FOR [Hours]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_ComissionRate]  DEFAULT ((0)) FOR [ComissionRate]
GO
ALTER TABLE [dbo].[Person] ADD  CONSTRAINT [DF_Person_GrossSales]  DEFAULT ((0)) FOR [GrossSales]
GO
USE [master]
GO
ALTER DATABASE [EmployeeManagement] SET  READ_WRITE 
GO
