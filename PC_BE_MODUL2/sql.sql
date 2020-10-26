USE [master]
GO

/****** Object:  Database [PC_BE_MODUL2]    Script Date: 10/21/2020 1:05:20 PM ******/
DROP DATABASE [PC_BE_MODUL2]
GO

/****** Object:  Database [PC_BE_MODUL2]    Script Date: 10/21/2020 1:05:20 PM ******/
CREATE DATABASE [PC_BE_MODUL2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PC_BE_MODUL2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PC_BE_MODUL2.mdf' , SIZE = 139264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PC_BE_MODUL2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PC_BE_MODUL2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PC_BE_MODUL2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [PC_BE_MODUL2] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET ARITHABORT OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [PC_BE_MODUL2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [PC_BE_MODUL2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET  DISABLE_BROKER 
GO

ALTER DATABASE [PC_BE_MODUL2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [PC_BE_MODUL2] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET RECOVERY FULL 
GO

ALTER DATABASE [PC_BE_MODUL2] SET  MULTI_USER 
GO

ALTER DATABASE [PC_BE_MODUL2] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [PC_BE_MODUL2] SET DB_CHAINING OFF 
GO

ALTER DATABASE [PC_BE_MODUL2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [PC_BE_MODUL2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [PC_BE_MODUL2] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [PC_BE_MODUL2] SET QUERY_STORE = OFF
GO

ALTER DATABASE [PC_BE_MODUL2] SET  READ_WRITE 
GO

