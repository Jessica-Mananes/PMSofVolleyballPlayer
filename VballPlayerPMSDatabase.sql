USE [master]
GO
/****** Object:  Database [VballPlayerPMSDatabase]    Script Date: 28/06/2025 9:36:56 pm ******/
CREATE DATABASE [VballPlayerPMSDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'p', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\p.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'p_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\p_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VballPlayerPMSDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET QUERY_STORE = ON
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [VballPlayerPMSDatabase]
GO
/****** Object:  Table [dbo].[Players]    Script Date: 28/06/2025 9:36:57 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Players](
	[Name] [nchar](100) NOT NULL,
	[Age] [int] NOT NULL,
	[Position] [nchar](100) NOT NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'Leica Erica                                                                                         ', 23, N'Spiker                                                                                              ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'Leica Erica Laica                                                                                   ', 28, N'Spiker                                                                                              ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'aguas                                                          Ivy  Aguas                           ', 25, N'Libero                                                                                              ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'Mananes, Jessica                                                                                    ', 19, N'Spiker                                                                                              ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'Carmelita                                                                                           ', 31, N'Middle Hitter                                                                                       ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'JESS                                                                                                ', 17, N'Libero                                                                                              ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'Cedrick                                                                                             ', 15, N'Spiker                                                                                              ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'Jessabel                                                                                            ', 24, N'Blocker                                                                                             ')
INSERT [dbo].[Players] ([Name], [Age], [Position]) VALUES (N'sicajess                                                                                            ', 16, N'Blocker                                                                                             ')
GO
USE [master]
GO
ALTER DATABASE [VballPlayerPMSDatabase] SET  READ_WRITE 
GO
