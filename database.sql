USE [master]
GO
	/****** Object:  Database [dbLivraria]    Script Date: 27/07/2020 21:43:46 ******/
	CREATE DATABASE [dbLivraria] CONTAINMENT = NONE ON PRIMARY (
		NAME = N'bdLivraria',
		FILENAME = N'C:\Users\Public\bdLivraria.mdf',
		SIZE = 8192KB,
		MAXSIZE = UNLIMITED,
		FILEGROWTH = 65536KB
	) LOG ON (
		NAME = N'bdLivraria_log',
		FILENAME = N'C:\Users\Public\bdLivraria_log.ldf',
		SIZE = 8192KB,
		MAXSIZE = 2048GB,
		FILEGROWTH = 65536KB
	)
GO IF (
		1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled')
	) begin EXEC [dbLivraria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO ALTER DATABASE [dbLivraria]
SET ANSI_NULL_DEFAULT OFF
GO ALTER DATABASE [dbLivraria]
SET ANSI_NULLS OFF
GO ALTER DATABASE [dbLivraria]
SET ANSI_PADDING OFF
GO ALTER DATABASE [dbLivraria]
SET ANSI_WARNINGS OFF
GO ALTER DATABASE [dbLivraria]
SET ARITHABORT OFF
GO ALTER DATABASE [dbLivraria]
SET AUTO_CLOSE ON
GO ALTER DATABASE [dbLivraria]
SET AUTO_SHRINK OFF
GO ALTER DATABASE [dbLivraria]
SET AUTO_UPDATE_STATISTICS ON
GO ALTER DATABASE [dbLivraria]
SET CURSOR_CLOSE_ON_COMMIT OFF
GO ALTER DATABASE [dbLivraria]
SET CURSOR_DEFAULT GLOBAL
GO ALTER DATABASE [dbLivraria]
SET CONCAT_NULL_YIELDS_NULL OFF
GO ALTER DATABASE [dbLivraria]
SET NUMERIC_ROUNDABORT OFF
GO ALTER DATABASE [dbLivraria]
SET QUOTED_IDENTIFIER OFF
GO ALTER DATABASE [dbLivraria]
SET RECURSIVE_TRIGGERS OFF
GO ALTER DATABASE [dbLivraria]
SET ENABLE_BROKER
GO ALTER DATABASE [dbLivraria]
SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO ALTER DATABASE [dbLivraria]
SET DATE_CORRELATION_OPTIMIZATION OFF
GO ALTER DATABASE [dbLivraria]
SET TRUSTWORTHY OFF
GO ALTER DATABASE [dbLivraria]
SET ALLOW_SNAPSHOT_ISOLATION OFF
GO ALTER DATABASE [dbLivraria]
SET PARAMETERIZATION SIMPLE
GO ALTER DATABASE [dbLivraria]
SET READ_COMMITTED_SNAPSHOT ON
GO ALTER DATABASE [dbLivraria]
SET HONOR_BROKER_PRIORITY OFF
GO ALTER DATABASE [dbLivraria]
SET RECOVERY SIMPLE
GO ALTER DATABASE [dbLivraria]
SET MULTI_USER
GO ALTER DATABASE [dbLivraria]
SET PAGE_VERIFY CHECKSUM
GO ALTER DATABASE [dbLivraria]
SET DB_CHAINING OFF
GO ALTER DATABASE [dbLivraria]
SET FILESTREAM(NON_TRANSACTED_ACCESS = OFF)
GO ALTER DATABASE [dbLivraria]
SET TARGET_RECOVERY_TIME = 60 SECONDS
GO ALTER DATABASE [dbLivraria]
SET DELAYED_DURABILITY = DISABLED
GO ALTER DATABASE [dbLivraria]
SET QUERY_STORE = OFF
GO USE [dbLivraria]
GO ALTER DATABASE SCOPED CONFIGURATION
SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO ALTER DATABASE SCOPED CONFIGURATION
SET MAXDOP = 0;
GO ALTER DATABASE SCOPED CONFIGURATION
SET PARAMETER_SNIFFING = ON;
GO ALTER DATABASE SCOPED CONFIGURATION
SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO ALTER DATABASE [dbLivraria]
SET READ_WRITE
GO
	/****** Object:  Table [dbo].[Livro]    Script Date: 27/07/2020 21:48:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO CREATE TABLE [dbo].[Livro](
		[Id] [int] IDENTITY(1, 1) NOT NULL,
		[ISBN] [bigint] NOT NULL,
		[Autor] [nvarchar](max) NULL,
		[Titulo] [nvarchar](max) NULL,
		[Preco] [float] NOT NULL,
		[DataPublicacao] [datetime] NOT NULL,
		[Capa] [nvarchar](max) NULL,
		CONSTRAINT [PK_dbo.Livro] PRIMARY KEY CLUSTERED ([Id] ASC) WITH (
			PAD_INDEX = OFF,
			STATISTICS_NORECOMPUTE = OFF,
			IGNORE_DUP_KEY = OFF,
			ALLOW_ROW_LOCKS = ON,
			ALLOW_PAGE_LOCKS = ON
		) ON [PRIMARY]
	) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT INTO [dbo].[Livro] (ISBN, Autor, Titulo, Preco, DataPublicacao, Capa)
values (
		9780195101706,
		'Machado de Assis',
		'Memórias Póstumas de Brás Cuba',
		22.67,
		'2012-07-04',
		'https://m.media-amazon.com/images/I/51rG7b0DjJL.jpg'
	)
INSERT INTO [dbo].[Livro] (ISBN, Autor, Titulo, Preco, DataPublicacao, Capa)
values (
		8573026278,
		'Stephen King',
		'Pesadelos e Paisagens Noturnas - Vol. 1',
		45.91,
		'2012-07-04',
		'https://i.imgur.com/40arP1w.jpeg'
	)