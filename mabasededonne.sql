USE [master]
GO
/****** Object:  Database [agence]    Script Date: 11/07/2020 14:50:44 ******/
CREATE DATABASE [agence]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'agence', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\agence.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'agence_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\agence_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [agence] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [agence].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [agence] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [agence] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [agence] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [agence] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [agence] SET ARITHABORT OFF 
GO
ALTER DATABASE [agence] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [agence] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [agence] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [agence] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [agence] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [agence] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [agence] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [agence] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [agence] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [agence] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [agence] SET  DISABLE_BROKER 
GO
ALTER DATABASE [agence] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [agence] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [agence] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [agence] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [agence] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [agence] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [agence] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [agence] SET RECOVERY FULL 
GO
ALTER DATABASE [agence] SET  MULTI_USER 
GO
ALTER DATABASE [agence] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [agence] SET DB_CHAINING OFF 
GO
ALTER DATABASE [agence] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [agence] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'agence', N'ON'
GO
USE [agence]
GO
/****** Object:  Table [dbo].[client]    Script Date: 11/07/2020 14:50:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[client](
	[id_client] [int] NOT NULL,
	[nom_client] [varchar](50) NULL,
	[ville_client] [varchar](50) NULL,
	[adresse_client] [varchar](50) NULL,
	[email_client] [varchar](50) NULL,
	[tel_client] [int] NULL,
 CONSTRAINT [PK_client] PRIMARY KEY CLUSTERED 
(
	[id_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[colis]    Script Date: 11/07/2020 14:50:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[colis](
	[id_colis] [int] NULL,
	[nom_colis] [varchar](50) NULL,
	[quantite] [int] NULL,
	[prix] [decimal](18, 0) NULL,
	[id_expediteur] [int] NULL,
	[nom_destinataire] [varchar](50) NULL,
	[ville_destinataire] [varchar](50) NULL,
	[frais_de_transport] [decimal](18, 0) NULL,
	[date] [varchar](50) NULL,
	[statut] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[connecter]    Script Date: 11/07/2020 14:50:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[connecter](
	[id_employer] [int] NULL,
	[login] [varchar](50) NULL,
	[password] [varchar](50) NULL,
	[role] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[employer]    Script Date: 11/07/2020 14:50:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[employer](
	[id_employer] [int] NOT NULL,
	[nom_employer] [varchar](50) NULL,
	[prenom_employer] [varchar](50) NULL,
	[email_employer] [varchar](50) NULL,
	[poste_employer] [varchar](50) NULL,
	[salaire] [float] NULL,
	[date] [varchar](50) NULL,
 CONSTRAINT [PK_employer] PRIMARY KEY CLUSTERED 
(
	[id_employer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tourner]    Script Date: 11/07/2020 14:50:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tourner](
	[id_tourner] [int] NOT NULL,
	[ville_tourner] [varchar](50) NULL,
	[id_chauffeur] [int] NULL,
	[nom_chauffeur] [varchar](50) NULL,
	[date] [varchar](50) NULL,
 CONSTRAINT [PK_tourner] PRIMARY KEY CLUSTERED 
(
	[id_tourner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [agence] SET  READ_WRITE 
GO
