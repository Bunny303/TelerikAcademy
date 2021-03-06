USE [master]
GO
/****** Object:  Database [SupermarketDataBase]    Script Date: 13.1.2014 г. 16:33:31 ч. ******/
CREATE DATABASE [SupermarketDataBase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SupermarketDataBase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SupermarketDataBase.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SupermarketDataBase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\SupermarketDataBase_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SupermarketDataBase] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SupermarketDataBase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SupermarketDataBase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET ARITHABORT OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SupermarketDataBase] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SupermarketDataBase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SupermarketDataBase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SupermarketDataBase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SupermarketDataBase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SupermarketDataBase] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [SupermarketDataBase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SupermarketDataBase] SET  MULTI_USER 
GO
ALTER DATABASE [SupermarketDataBase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SupermarketDataBase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SupermarketDataBase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SupermarketDataBase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [SupermarketDataBase]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 13.1.2014 г. 16:33:31 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Measures]    Script Date: 13.1.2014 г. 16:33:31 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Measures](
	[MeasureID] [int] IDENTITY(1,1) NOT NULL,
	[MeasureName] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Measures] PRIMARY KEY CLUSTERED 
(
	[MeasureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 13.1.2014 г. 16:33:31 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[VendorID] [int] NULL,
	[MeasureID] [int] NULL,
	[ProductName] [nvarchar](max) NOT NULL,
	[BasePrice] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SaleReports]    Script Date: 13.1.2014 г. 16:33:31 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SaleReports](
	[SaleReportID] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
	[Sum] [decimal](18, 2) NOT NULL,
	[SupermarketName] [nvarchar](max) NULL,
	[ReportDate] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.SaleReports] PRIMARY KEY CLUSTERED 
(
	[SaleReportID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vendors]    Script Date: 13.1.2014 г. 16:33:31 ч. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendors](
	[VendorID] [int] IDENTITY(1,1) NOT NULL,
	[VendorName] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Vendors] PRIMARY KEY CLUSTERED 
(
	[VendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Index [IX_MeasureID]    Script Date: 13.1.2014 г. 16:33:31 ч. ******/
CREATE NONCLUSTERED INDEX [IX_MeasureID] ON [dbo].[Products]
(
	[MeasureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_VendorID]    Script Date: 13.1.2014 г. 16:33:31 ч. ******/
CREATE NONCLUSTERED INDEX [IX_VendorID] ON [dbo].[Products]
(
	[VendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ProductID]    Script Date: 13.1.2014 г. 16:33:31 ч. ******/
CREATE NONCLUSTERED INDEX [IX_ProductID] ON [dbo].[SaleReports]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Products_dbo.Measures_MeasureID] FOREIGN KEY([MeasureID])
REFERENCES [dbo].[Measures] ([MeasureID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_dbo.Products_dbo.Measures_MeasureID]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Products_dbo.Vendors_VendorID] FOREIGN KEY([VendorID])
REFERENCES [dbo].[Vendors] ([VendorID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_dbo.Products_dbo.Vendors_VendorID]
GO
ALTER TABLE [dbo].[SaleReports]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SaleReports_dbo.Products_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SaleReports] CHECK CONSTRAINT [FK_dbo.SaleReports_dbo.Products_ProductID]
GO
USE [master]
GO
ALTER DATABASE [SupermarketDataBase] SET  READ_WRITE 
GO
