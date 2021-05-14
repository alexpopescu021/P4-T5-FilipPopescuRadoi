USE [master]
GO
/****** Object:  Database [BankingDb]    Script Date: 14-May-21 12:19:31 PM ******/
CREATE DATABASE [BankingDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BankingDb', FILENAME = N'C:\Users\alexp\BankingDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BankingDb_log', FILENAME = N'C:\Users\alexp\BankingDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BankingDb] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BankingDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BankingDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BankingDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BankingDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BankingDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BankingDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [BankingDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BankingDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BankingDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BankingDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BankingDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BankingDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BankingDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BankingDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BankingDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BankingDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BankingDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BankingDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BankingDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BankingDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BankingDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BankingDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [BankingDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BankingDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BankingDb] SET  MULTI_USER 
GO
ALTER DATABASE [BankingDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BankingDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BankingDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BankingDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BankingDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BankingDb] SET QUERY_STORE = OFF
GO
USE [BankingDb]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [BankingDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 14-May-21 12:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BankAccountMetaDatas]    Script Date: 14-May-21 12:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankAccountMetaDatas](
	[Id] [uniqueidentifier] NOT NULL,
	[Color] [int] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[BankAccountId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_BankAccountMetaDatas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BankAccounts]    Script Date: 14-May-21 12:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BankAccounts](
	[Id] [uniqueidentifier] NOT NULL,
	[IBAN] [nvarchar](max) NULL,
	[Balance] [decimal](18, 4) NOT NULL,
	[Currency] [nvarchar](max) NULL,
	[LastTransactionDate] [datetime2](7) NOT NULL,
	[CustomerId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_BankAccounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CardMetaData]    Script Date: 14-May-21 12:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CardMetaData](
	[Id] [uniqueidentifier] NOT NULL,
	[Color] [int] NOT NULL,
	[CardId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_CardMetaData] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cards]    Script Date: 14-May-21 12:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cards](
	[Id] [uniqueidentifier] NOT NULL,
	[SerialNumber] [nvarchar](max) NULL,
	[CVV] [int] NOT NULL,
	[CreateDate] [datetime2](7) NOT NULL,
	[ExpDate] [datetime2](7) NOT NULL,
	[OwnerName] [nvarchar](max) NULL,
	[BankAccountId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Cards] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CardTransactions]    Script Date: 14-May-21 12:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CardTransactions](
	[Id] [uniqueidentifier] NOT NULL,
	[TransactionId] [uniqueidentifier] NULL,
	[TransactionType] [int] NOT NULL,
	[CardId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_CardTransactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactDetails]    Script Date: 14-May-21 12:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactDetails](
	[Id] [uniqueidentifier] NOT NULL,
	[Address] [nvarchar](max) NULL,
	[City] [nvarchar](max) NULL,
	[Country] [nvarchar](max) NULL,
	[PhoneNo] [nvarchar](max) NULL,
	[AlternatePhoneNo] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
 CONSTRAINT [PK_ContactDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 14-May-21 12:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[SocialId] [nvarchar](max) NULL,
	[ContactDetailsId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loans]    Script Date: 14-May-21 12:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loans](
	[Id] [uniqueidentifier] NOT NULL,
	[Value] [real] NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NOT NULL,
	[LunarFee] [real] NOT NULL,
	[CustomerId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Loans] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requests]    Script Date: 14-May-21 12:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requests](
	[Id] [uniqueidentifier] NOT NULL,
	[Type] [nvarchar](max) NULL,
	[SendDate] [datetime2](7) NOT NULL,
	[CustomerId] [uniqueidentifier] NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Requests] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 14-May-21 12:19:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[Id] [uniqueidentifier] NOT NULL,
	[ExternalIBAN] [nvarchar](max) NULL,
	[ExternalName] [nvarchar](max) NULL,
	[Amount] [decimal](18, 4) NOT NULL,
	[Time] [datetime2](7) NOT NULL,
	[Details] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[BankAccountId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_BankAccounts_CustomerId]    Script Date: 14-May-21 12:19:31 PM ******/
CREATE NONCLUSTERED INDEX [IX_BankAccounts_CustomerId] ON [dbo].[BankAccounts]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cards_BankAccountId]    Script Date: 14-May-21 12:19:31 PM ******/
CREATE NONCLUSTERED INDEX [IX_Cards_BankAccountId] ON [dbo].[Cards]
(
	[BankAccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CardTransactions_CardId]    Script Date: 14-May-21 12:19:31 PM ******/
CREATE NONCLUSTERED INDEX [IX_CardTransactions_CardId] ON [dbo].[CardTransactions]
(
	[CardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CardTransactions_TransactionId]    Script Date: 14-May-21 12:19:31 PM ******/
CREATE NONCLUSTERED INDEX [IX_CardTransactions_TransactionId] ON [dbo].[CardTransactions]
(
	[TransactionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Customers_ContactDetailsId]    Script Date: 14-May-21 12:19:31 PM ******/
CREATE NONCLUSTERED INDEX [IX_Customers_ContactDetailsId] ON [dbo].[Customers]
(
	[ContactDetailsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Loans_CustomerId]    Script Date: 14-May-21 12:19:31 PM ******/
CREATE NONCLUSTERED INDEX [IX_Loans_CustomerId] ON [dbo].[Loans]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Requests_CustomerId]    Script Date: 14-May-21 12:19:31 PM ******/
CREATE NONCLUSTERED INDEX [IX_Requests_CustomerId] ON [dbo].[Requests]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Transactions_BankAccountId]    Script Date: 14-May-21 12:19:31 PM ******/
CREATE NONCLUSTERED INDEX [IX_Transactions_BankAccountId] ON [dbo].[Transactions]
(
	[BankAccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Requests] ADD  DEFAULT ((0)) FOR [Status]
GO
ALTER TABLE [dbo].[BankAccounts]  WITH CHECK ADD  CONSTRAINT [FK_BankAccounts_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[BankAccounts] CHECK CONSTRAINT [FK_BankAccounts_Customers_CustomerId]
GO
ALTER TABLE [dbo].[Cards]  WITH CHECK ADD  CONSTRAINT [FK_Cards_BankAccounts_BankAccountId] FOREIGN KEY([BankAccountId])
REFERENCES [dbo].[BankAccounts] ([Id])
GO
ALTER TABLE [dbo].[Cards] CHECK CONSTRAINT [FK_Cards_BankAccounts_BankAccountId]
GO
ALTER TABLE [dbo].[CardTransactions]  WITH CHECK ADD  CONSTRAINT [FK_CardTransactions_Cards_CardId] FOREIGN KEY([CardId])
REFERENCES [dbo].[Cards] ([Id])
GO
ALTER TABLE [dbo].[CardTransactions] CHECK CONSTRAINT [FK_CardTransactions_Cards_CardId]
GO
ALTER TABLE [dbo].[CardTransactions]  WITH CHECK ADD  CONSTRAINT [FK_CardTransactions_Transactions_TransactionId] FOREIGN KEY([TransactionId])
REFERENCES [dbo].[Transactions] ([Id])
GO
ALTER TABLE [dbo].[CardTransactions] CHECK CONSTRAINT [FK_CardTransactions_Transactions_TransactionId]
GO
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_Customers_ContactDetails_ContactDetailsId] FOREIGN KEY([ContactDetailsId])
REFERENCES [dbo].[ContactDetails] ([Id])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_ContactDetails_ContactDetailsId]
GO
ALTER TABLE [dbo].[Loans]  WITH CHECK ADD  CONSTRAINT [FK_Loans_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Loans] CHECK CONSTRAINT [FK_Loans_Customers_CustomerId]
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK_Requests_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK_Requests_Customers_CustomerId]
GO
ALTER TABLE [dbo].[Transactions]  WITH CHECK ADD  CONSTRAINT [FK_Transactions_BankAccounts_BankAccountId] FOREIGN KEY([BankAccountId])
REFERENCES [dbo].[BankAccounts] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Transactions] CHECK CONSTRAINT [FK_Transactions_BankAccounts_BankAccountId]
GO
USE [master]
GO
ALTER DATABASE [BankingDb] SET  READ_WRITE 
GO
