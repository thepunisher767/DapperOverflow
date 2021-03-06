USE [master]
GO
/****** Object:  Database [DapperOverflow]    Script Date: 9/15/2020 1:42:39 PM ******/
CREATE DATABASE [DapperOverflow]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DapperOverflow', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DapperOverflow.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DapperOverflow_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DapperOverflow_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DapperOverflow] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DapperOverflow].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DapperOverflow] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DapperOverflow] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DapperOverflow] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DapperOverflow] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DapperOverflow] SET ARITHABORT OFF 
GO
ALTER DATABASE [DapperOverflow] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DapperOverflow] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DapperOverflow] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DapperOverflow] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DapperOverflow] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DapperOverflow] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DapperOverflow] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DapperOverflow] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DapperOverflow] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DapperOverflow] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DapperOverflow] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DapperOverflow] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DapperOverflow] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DapperOverflow] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DapperOverflow] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DapperOverflow] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DapperOverflow] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DapperOverflow] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DapperOverflow] SET  MULTI_USER 
GO
ALTER DATABASE [DapperOverflow] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DapperOverflow] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DapperOverflow] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DapperOverflow] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DapperOverflow] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DapperOverflow] SET QUERY_STORE = OFF
GO
USE [DapperOverflow]
GO
/****** Object:  Table [dbo].[Answer]    Script Date: 9/15/2020 1:42:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Answer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](16) NOT NULL,
	[Detail] [nvarchar](4000) NOT NULL,
	[QuestionID] [int] NOT NULL,
	[Posted] [date] NOT NULL,
	[Upvotes] [int] NULL,
 CONSTRAINT [PK_Answer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 9/15/2020 1:42:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](16) NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
	[Detail] [nvarchar](4000) NOT NULL,
	[Posted] [date] NOT NULL,
	[Category] [nvarchar](20) NOT NULL,
	[Tags] [nvarchar](50) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([id], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (5, N'test', N'test', N'test                ', CAST(N'2020-09-15' AS Date), N'test', N'test', 0)
INSERT [dbo].[Question] ([id], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (6, N'test2', N'test2', N'test2                ', CAST(N'2020-09-15' AS Date), N'test', N'test', 0)
INSERT [dbo].[Question] ([id], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (7, N'test3', N'test3', N'test3                ', CAST(N'2020-09-15' AS Date), N'test', N'test', 0)
INSERT [dbo].[Question] ([id], [Username], [Title], [Detail], [Posted], [Category], [Tags], [Status]) VALUES (8, N'test4', N'test4', N'test4                ', CAST(N'2020-09-15' AS Date), N'test', N'test', 0)
SET IDENTITY_INSERT [dbo].[Question] OFF
GO
USE [master]
GO
ALTER DATABASE [DapperOverflow] SET  READ_WRITE 
GO
