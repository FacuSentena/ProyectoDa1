USE [master]
GO
/****** Object:  Database [DemoDB]    Script Date: 17/06/2021 12:49:15 ******/
CREATE DATABASE [DemoDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DemoDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DemoDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DemoDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DemoDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DemoDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DemoDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DemoDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DemoDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DemoDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DemoDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DemoDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [DemoDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DemoDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DemoDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DemoDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DemoDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DemoDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DemoDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DemoDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DemoDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DemoDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DemoDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DemoDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DemoDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DemoDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DemoDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DemoDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DemoDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DemoDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DemoDB] SET  MULTI_USER 
GO
ALTER DATABASE [DemoDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DemoDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DemoDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DemoDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DemoDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DemoDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DemoDB] SET QUERY_STORE = OFF
GO
USE [DemoDB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 17/06/2021 12:49:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntidadCategorias]    Script Date: 17/06/2021 12:49:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntidadCategorias](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[EntidadUsuario_Id] [int] NULL,
 CONSTRAINT [PK_dbo.EntidadCategorias] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntidadContrasenaMaestras]    Script Date: 17/06/2021 12:49:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntidadContrasenaMaestras](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Clave] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.EntidadContrasenaMaestras] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntidadContrasenas]    Script Date: 17/06/2021 12:49:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntidadContrasenas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Clave] [nvarchar](max) NULL,
	[GrupoDeFortaleza] [nvarchar](max) NULL,
	[UltimaModificacion] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.EntidadContrasenas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntidadFiltracionEntidadParUsuarioContrasenas]    Script Date: 17/06/2021 12:49:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntidadFiltracionEntidadParUsuarioContrasenas](
	[EntidadFiltracion_Id] [int] NOT NULL,
	[EntidadParUsuarioContrasena_Id] [int] NOT NULL,
 CONSTRAINT [PK_dbo.EntidadFiltracionEntidadParUsuarioContrasenas] PRIMARY KEY CLUSTERED 
(
	[EntidadFiltracion_Id] ASC,
	[EntidadParUsuarioContrasena_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntidadFiltracions]    Script Date: 17/06/2021 12:49:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntidadFiltracions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
 CONSTRAINT [PK_dbo.EntidadFiltracions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntidadParUsuarioContrasenas]    Script Date: 17/06/2021 12:49:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntidadParUsuarioContrasenas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NombreDeUsuario] [nvarchar](max) NULL,
	[Sitio] [nvarchar](max) NULL,
	[Nota] [nvarchar](max) NULL,
	[EstaBorrada] [bit] NOT NULL,
	[FueModificada] [bit] NOT NULL,
	[Categoria_Id] [int] NULL,
	[Contrasena_Id] [int] NULL,
 CONSTRAINT [PK_dbo.EntidadParUsuarioContrasenas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntidadTarjetaDeCreditoEntidadFiltracions]    Script Date: 17/06/2021 12:49:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntidadTarjetaDeCreditoEntidadFiltracions](
	[EntidadTarjetaDeCredito_Id] [int] NOT NULL,
	[EntidadFiltracion_Id] [int] NOT NULL,
 CONSTRAINT [PK_dbo.EntidadTarjetaDeCreditoEntidadFiltracions] PRIMARY KEY CLUSTERED 
(
	[EntidadTarjetaDeCredito_Id] ASC,
	[EntidadFiltracion_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntidadTarjetaDeCreditoes]    Script Date: 17/06/2021 12:49:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntidadTarjetaDeCreditoes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NULL,
	[Nota] [nvarchar](max) NULL,
	[CodigoDeSeguridad] [nvarchar](max) NULL,
	[FechaVencimiento] [nvarchar](max) NULL,
	[Tipo] [nvarchar](max) NULL,
	[Nombre] [nvarchar](max) NULL,
	[EstaBorrada] [bit] NOT NULL,
	[Categoria_Id] [int] NULL,
 CONSTRAINT [PK_dbo.EntidadTarjetaDeCreditoes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntidadUsuarios]    Script Date: 17/06/2021 12:49:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntidadUsuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ConstrasenaMaestra_Id] [int] NULL,
 CONSTRAINT [PK_dbo.EntidadUsuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_EntidadUsuario_Id]    Script Date: 17/06/2021 12:49:15 ******/
CREATE NONCLUSTERED INDEX [IX_EntidadUsuario_Id] ON [dbo].[EntidadCategorias]
(
	[EntidadUsuario_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EntidadFiltracion_Id]    Script Date: 17/06/2021 12:49:15 ******/
CREATE NONCLUSTERED INDEX [IX_EntidadFiltracion_Id] ON [dbo].[EntidadFiltracionEntidadParUsuarioContrasenas]
(
	[EntidadFiltracion_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EntidadParUsuarioContrasena_Id]    Script Date: 17/06/2021 12:49:15 ******/
CREATE NONCLUSTERED INDEX [IX_EntidadParUsuarioContrasena_Id] ON [dbo].[EntidadFiltracionEntidadParUsuarioContrasenas]
(
	[EntidadParUsuarioContrasena_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Categoria_Id]    Script Date: 17/06/2021 12:49:15 ******/
CREATE NONCLUSTERED INDEX [IX_Categoria_Id] ON [dbo].[EntidadParUsuarioContrasenas]
(
	[Categoria_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Contrasena_Id]    Script Date: 17/06/2021 12:49:15 ******/
CREATE NONCLUSTERED INDEX [IX_Contrasena_Id] ON [dbo].[EntidadParUsuarioContrasenas]
(
	[Contrasena_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EntidadFiltracion_Id]    Script Date: 17/06/2021 12:49:15 ******/
CREATE NONCLUSTERED INDEX [IX_EntidadFiltracion_Id] ON [dbo].[EntidadTarjetaDeCreditoEntidadFiltracions]
(
	[EntidadFiltracion_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EntidadTarjetaDeCredito_Id]    Script Date: 17/06/2021 12:49:15 ******/
CREATE NONCLUSTERED INDEX [IX_EntidadTarjetaDeCredito_Id] ON [dbo].[EntidadTarjetaDeCreditoEntidadFiltracions]
(
	[EntidadTarjetaDeCredito_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Categoria_Id]    Script Date: 17/06/2021 12:49:15 ******/
CREATE NONCLUSTERED INDEX [IX_Categoria_Id] ON [dbo].[EntidadTarjetaDeCreditoes]
(
	[Categoria_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ConstrasenaMaestra_Id]    Script Date: 17/06/2021 12:49:15 ******/
CREATE NONCLUSTERED INDEX [IX_ConstrasenaMaestra_Id] ON [dbo].[EntidadUsuarios]
(
	[ConstrasenaMaestra_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EntidadCategorias]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EntidadCategorias_dbo.EntidadUsuarios_EntidadUsuario_Id] FOREIGN KEY([EntidadUsuario_Id])
REFERENCES [dbo].[EntidadUsuarios] ([Id])
GO
ALTER TABLE [dbo].[EntidadCategorias] CHECK CONSTRAINT [FK_dbo.EntidadCategorias_dbo.EntidadUsuarios_EntidadUsuario_Id]
GO
ALTER TABLE [dbo].[EntidadFiltracionEntidadParUsuarioContrasenas]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EntidadFiltracionEntidadParUsuarioContrasenas_dbo.EntidadFiltracions_EntidadFiltracion_Id] FOREIGN KEY([EntidadFiltracion_Id])
REFERENCES [dbo].[EntidadFiltracions] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EntidadFiltracionEntidadParUsuarioContrasenas] CHECK CONSTRAINT [FK_dbo.EntidadFiltracionEntidadParUsuarioContrasenas_dbo.EntidadFiltracions_EntidadFiltracion_Id]
GO
ALTER TABLE [dbo].[EntidadFiltracionEntidadParUsuarioContrasenas]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EntidadFiltracionEntidadParUsuarioContrasenas_dbo.EntidadParUsuarioContrasenas_EntidadParUsuarioContrasena_Id] FOREIGN KEY([EntidadParUsuarioContrasena_Id])
REFERENCES [dbo].[EntidadParUsuarioContrasenas] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EntidadFiltracionEntidadParUsuarioContrasenas] CHECK CONSTRAINT [FK_dbo.EntidadFiltracionEntidadParUsuarioContrasenas_dbo.EntidadParUsuarioContrasenas_EntidadParUsuarioContrasena_Id]
GO
ALTER TABLE [dbo].[EntidadParUsuarioContrasenas]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EntidadParUsuarioContrasenas_dbo.EntidadCategorias_Categoria_Id] FOREIGN KEY([Categoria_Id])
REFERENCES [dbo].[EntidadCategorias] ([Id])
GO
ALTER TABLE [dbo].[EntidadParUsuarioContrasenas] CHECK CONSTRAINT [FK_dbo.EntidadParUsuarioContrasenas_dbo.EntidadCategorias_Categoria_Id]
GO
ALTER TABLE [dbo].[EntidadParUsuarioContrasenas]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EntidadParUsuarioContrasenas_dbo.EntidadContrasenas_Contrasena_Id] FOREIGN KEY([Contrasena_Id])
REFERENCES [dbo].[EntidadContrasenas] ([Id])
GO
ALTER TABLE [dbo].[EntidadParUsuarioContrasenas] CHECK CONSTRAINT [FK_dbo.EntidadParUsuarioContrasenas_dbo.EntidadContrasenas_Contrasena_Id]
GO
ALTER TABLE [dbo].[EntidadTarjetaDeCreditoEntidadFiltracions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EntidadTarjetaDeCreditoEntidadFiltracions_dbo.EntidadFiltracions_EntidadFiltracion_Id] FOREIGN KEY([EntidadFiltracion_Id])
REFERENCES [dbo].[EntidadFiltracions] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EntidadTarjetaDeCreditoEntidadFiltracions] CHECK CONSTRAINT [FK_dbo.EntidadTarjetaDeCreditoEntidadFiltracions_dbo.EntidadFiltracions_EntidadFiltracion_Id]
GO
ALTER TABLE [dbo].[EntidadTarjetaDeCreditoEntidadFiltracions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EntidadTarjetaDeCreditoEntidadFiltracions_dbo.EntidadTarjetaDeCreditoes_EntidadTarjetaDeCredito_Id] FOREIGN KEY([EntidadTarjetaDeCredito_Id])
REFERENCES [dbo].[EntidadTarjetaDeCreditoes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EntidadTarjetaDeCreditoEntidadFiltracions] CHECK CONSTRAINT [FK_dbo.EntidadTarjetaDeCreditoEntidadFiltracions_dbo.EntidadTarjetaDeCreditoes_EntidadTarjetaDeCredito_Id]
GO
ALTER TABLE [dbo].[EntidadTarjetaDeCreditoes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EntidadTarjetaDeCreditoes_dbo.EntidadCategorias_Categoria_Id] FOREIGN KEY([Categoria_Id])
REFERENCES [dbo].[EntidadCategorias] ([Id])
GO
ALTER TABLE [dbo].[EntidadTarjetaDeCreditoes] CHECK CONSTRAINT [FK_dbo.EntidadTarjetaDeCreditoes_dbo.EntidadCategorias_Categoria_Id]
GO
ALTER TABLE [dbo].[EntidadUsuarios]  WITH CHECK ADD  CONSTRAINT [FK_dbo.EntidadUsuarios_dbo.EntidadContrasenaMaestras_ConstrasenaMaestra_Id] FOREIGN KEY([ConstrasenaMaestra_Id])
REFERENCES [dbo].[EntidadContrasenaMaestras] ([Id])
GO
ALTER TABLE [dbo].[EntidadUsuarios] CHECK CONSTRAINT [FK_dbo.EntidadUsuarios_dbo.EntidadContrasenaMaestras_ConstrasenaMaestra_Id]
GO
USE [master]
GO
ALTER DATABASE [DemoDB] SET  READ_WRITE 
GO
