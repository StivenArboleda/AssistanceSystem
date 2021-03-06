USE [master]
GO
/****** Object:  Database [SistemaAsistencia]    Script Date: 03/01/2022 14:36:09 ******/
CREATE DATABASE [SistemaAsistencia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaAsistencia', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SistemaAsistencia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaAsistencia_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SistemaAsistencia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SistemaAsistencia] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaAsistencia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaAsistencia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaAsistencia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaAsistencia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SistemaAsistencia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaAsistencia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaAsistencia] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaAsistencia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaAsistencia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaAsistencia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaAsistencia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaAsistencia] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SistemaAsistencia] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SistemaAsistencia] SET QUERY_STORE = OFF
GO
USE [SistemaAsistencia]
GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 03/01/2022 14:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[Id_cargo] [int] IDENTITY(1,1) NOT NULL,
	[Cargo] [varchar](max) NULL,
	[SueldoPorHora] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[Id_cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 03/01/2022 14:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personal](
	[Id_personal] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NULL,
	[Identificacion] [varchar](max) NULL,
	[Pais] [varchar](max) NULL,
	[Id_cargo] [int] NULL,
	[SueldoPorHora] [numeric](18, 2) NULL,
	[Estado] [varchar](max) NULL,
	[codigo] [varchar](max) NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[Id_personal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Personal]  WITH CHECK ADD  CONSTRAINT [FK_Personal_Cargo] FOREIGN KEY([Id_cargo])
REFERENCES [dbo].[Cargo] ([Id_cargo])
GO
ALTER TABLE [dbo].[Personal] CHECK CONSTRAINT [FK_Personal_Cargo]
GO
/****** Object:  StoredProcedure [dbo].[editarPersonal]    Script Date: 03/01/2022 14:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editarPersonal]
@Id_personal int,
@Nombre as varchar(max),
@Identificacion as varchar(max),
@Pais as varchar(max),
@Id_cargo int,
@Sueldo_por_hora numeric(18,2)
as
if Exists(Select Identificacion from Personal where Identificacion=@Identificacion and Id_personal <>@Id_personal)
Raiserror('Ya existe un registro con esta Identificacion', 16,1)
else
Update Personal set
Nombre=@Nombre, Identificacion=@Identificacion, Pais=@Pais, Id_cargo=@Id_cargo, SueldoPorHora=@Sueldo_por_hora
where Id_personal=@Id_personal
GO
/****** Object:  StoredProcedure [dbo].[InsertarPersonal]    Script Date: 03/01/2022 14:36:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[InsertarPersonal]
@Nombre varchar(max),
@Identificacion varchar(max),
@Pais varchar(max),
@Id_cargo int,
@SueldoPorHora numeric(18,2)
as
declare @Estado varchar(max)
declare @codigo varchar(max)
declare @Id_personal int
set @Estado = 'ACTIVO'
set @codigo='-'
if exists(select Identificacion from Personal where Identificacion=@Identificacion)
Raiserror('Ya existe un registro con esta identificacion', 16,1)
else
Insert into Personal
values(@Nombre ,
@Identificacion ,
@Pais ,
@Id_cargo ,
@SueldoPorHora ,
@Estado ,
@codigo)
Select @Id_personal=SCOPE_IDENTITY()
Update Personal set codigo = @Id_personal
GO
USE [master]
GO
ALTER DATABASE [SistemaAsistencia] SET  READ_WRITE 
GO
