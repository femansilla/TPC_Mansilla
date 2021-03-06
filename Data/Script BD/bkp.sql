USE [master]
GO
/****** Object:  Database [MANSILLA_DB]    Script Date: 4/11/2018 22:06:10 ******/
CREATE DATABASE [MANSILLA_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MANSILLA_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.DBDESA\MSSQL\DATA\MANSILLA_DB.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MANSILLA_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.DBDESA\MSSQL\DATA\MANSILLA_DB_log.ldf' , SIZE = 1088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MANSILLA_DB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MANSILLA_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MANSILLA_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MANSILLA_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MANSILLA_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MANSILLA_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MANSILLA_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MANSILLA_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MANSILLA_DB] SET  MULTI_USER 
GO
ALTER DATABASE [MANSILLA_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MANSILLA_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MANSILLA_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MANSILLA_DB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MANSILLA_DB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MANSILLA_DB]
GO
/****** Object:  Table [dbo].[CALLES]    Script Date: 4/11/2018 22:06:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CALLES](
	[CODE] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPCION] [varchar](100) NOT NULL,
	[ALTURA] [int] NOT NULL,
	[CODPOS] [int] NOT NULL,
	[CODEPROV] [int] NOT NULL,
	[STATUS] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[ALTURA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoriaProducto]    Script Date: 4/11/2018 22:06:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriaProducto](
	[productoCode] [int] NOT NULL,
	[categoriaCode] [int] NOT NULL,
	[Status] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[productoCode] ASC,
	[categoriaCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categorias]    Script Date: 4/11/2018 22:06:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categorias](
	[code] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
	[Status] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 4/11/2018 22:06:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NOT NULL,
	[Apellido] [varchar](max) NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[FechaNac] [datetime] NOT NULL,
	[status] [char](1) NOT NULL,
	[CUIT] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClientType]    Script Date: 4/11/2018 22:06:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClientType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compras]    Script Date: 4/11/2018 22:06:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compras](
	[Code] [int] IDENTITY(1,1) NOT NULL,
	[DateCompra] [datetime] NOT NULL,
	[ProveedorCode] [int] NOT NULL,
	[ImporteTotal] [money] NOT NULL,
	[status] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CPA]    Script Date: 4/11/2018 22:06:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CPA](
	[CODE] [int] NOT NULL,
	[PROVCODE] [int] NOT NULL,
	[STATUS] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Direcciones]    Script Date: 4/11/2018 22:06:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direcciones](
	[Code] [int] IDENTITY(1,1) NOT NULL,
	[ProvCode] [int] NULL,
	[LocalidadCode] [int] NULL,
	[CalleCode] [int] NULL,
	[CPACode] [int] NULL,
	[Status] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[CPACode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[LocalidadCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[ProvCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListaDePrecios]    Script Date: 4/11/2018 22:06:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListaDePrecios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOCALIDADES]    Script Date: 4/11/2018 22:06:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOCALIDADES](
	[CODE] [int] IDENTITY(1,1) NOT NULL,
	[CODPOS] [int] NOT NULL,
	[CODEPROV] [int] NOT NULL,
	[DESCRIPCION] [varchar](100) NOT NULL,
	[STATUS] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrecioProducto]    Script Date: 4/11/2018 22:06:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrecioProducto](
	[productoCode] [int] NOT NULL,
	[Precio] [money] NOT NULL,
	[Status] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[productoCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 4/11/2018 22:06:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Code] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
	[status] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 4/11/2018 22:06:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductType](
	[Code] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
	[Status] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NOT NULL,
	[Apellido] [varchar](max) NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[FechaNac] [datetime] NOT NULL,
	[status] [char](1) NOT NULL,
	[CUIT] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProveedorType]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProveedorType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
	[Status] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVINCIAS]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVINCIAS](
	[CODE] [int] IDENTITY(1,1) NOT NULL,
	[DESCRIPCION] [varchar](100) NOT NULL,
	[STATUS] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RelationDireccion]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RelationDireccion](
	[Code] [int] IDENTITY(1,1) NOT NULL,
	[PropietarioCode] [int] NOT NULL,
	[DireccionCode] [int] NOT NULL,
	[Status] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RelationProductosCompra]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RelationProductosCompra](
	[RelationCode] [int] IDENTITY(1,1) NOT NULL,
	[CompraCode] [int] NOT NULL,
	[ProductoCode] [int] NOT NULL,
	[ImporteUnidad] [money] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[status] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[RelationCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RelationProductosProveedor]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RelationProductosProveedor](
	[ProductoCode] [int] NOT NULL,
	[ProveedorCode] [int] NOT NULL,
	[Status] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductoCode] ASC,
	[ProveedorCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RelationProductosVenta]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RelationProductosVenta](
	[RelationCode] [int] IDENTITY(1,1) NOT NULL,
	[VentaCode] [int] NOT NULL,
	[ProductoCode] [int] NOT NULL,
	[ImporteUnidad] [money] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[status] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[RelationCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Representantes]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Representantes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](max) NOT NULL,
	[Apellido] [varchar](max) NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[FechaNac] [datetime] NOT NULL,
	[status] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposClientes]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposClientes](
	[ClienteID] [int] NOT NULL,
	[TypeCode] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposProducto]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposProducto](
	[typeCode] [int] NOT NULL,
	[productoCode] [int] NOT NULL,
	[Status] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[typeCode] ASC,
	[productoCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposProveedor]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposProveedor](
	[ProveedorID] [int] NOT NULL,
	[TypeCode] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TiposUsuarios]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TiposUsuarios](
	[UserCode] [int] NOT NULL,
	[TypeCode] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserCode] ASC,
	[TypeCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
	[Status] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID] [int] NOT NULL,
	[userName] [varchar](max) NOT NULL,
	[userPassword] [varchar](max) NOT NULL,
	[status] [char](1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[Code] [int] IDENTITY(1,1) NOT NULL,
	[DateCompra] [datetime] NOT NULL,
	[ClienteCode] [int] NULL,
	[ImporteTotal] [money] NOT NULL,
	[Estado] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VW_Compras]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[VW_Compras]
as
SELECT  c.Code,
		c.DateCompra,
		c.status as Estado,
		p.CUIT,
		p.Nombre,
		p.Apellido,
		c.ImporteTotal
FROM Compras c
INNER JOIN Proveedores p ON c.ProveedorCode = p.Id 
GO
/****** Object:  View [dbo].[VW_Productos]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[VW_Productos]
as 
	SELECT  p.Code Id
		   ,p.Descripcion
		   ,(select pp.Precio) as Precio
		   ,(select c.Descripcion from Categorias c where c.code = cp.categoriaCode) Categoria
		   ,(select pt.Descripcion from ProductType pt where pt.Code = tp.typeCode) ProductType
	FROM Productos p
	left join PrecioProducto pp on p.Code = pp.productoCode
	left join CategoriaProducto cp on p.Code = cp.productoCode
	left join TiposProducto tp on p.Code = tp.productoCode
	where p.status = 'A' 
GO
/****** Object:  View [dbo].[VW_ProductosCompra]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[VW_ProductosCompra]
as
SELECT r.CompraCode,
	   b.Descripcion,
       r.ImporteUnidad,
	   r.Cantidad
From RelationProductosCompra r
inner join Productos b on r.ProductoCode = b.Code
GO
/****** Object:  View [dbo].[VW_ProductosVenta]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[VW_ProductosVenta]
as
SELECT r.VentaCode, 
	   b.Descripcion,
       r.ImporteUnidad,
	   r.Cantidad
From RelationProductosVenta r
inner join Productos b on r.ProductoCode = b.Code
GO
/****** Object:  View [dbo].[VW_Proveedores]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE view [dbo].[VW_Proveedores]
as 
select  p.ID Code, 
		p.Nombre,
		p.Apellido,
		p.Sexo,
		p.FechaNac,
		p.CUIT
		,(select pt.Id from ProveedorType pt where pt.Id = tp.TypeCode and pt.Status = 'A') TypeCode
		,(select pt.Descripcion from ProveedorType pt where pt.Id = tp.TypeCode and pt.Status = 'A') ProveedorType 
from Proveedores p
left join TiposProveedor tp on tp.ProveedorID = p.Id
where p.status = 'A' 

GO
/****** Object:  View [dbo].[VW_Representative_User]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE view [dbo].[VW_Representative_User]
as 
select  r.ID UserId, 
		r.Nombre,
		r.Apellido,
		r.Sexo,
		r.FechaNac,
		lower(u.userName) userName
		,(select ut.Id from UserType ut where ut.Id = tu.TypeCode and ut.Status = 'A') UserTypeCode
		,(select ut.Descripcion from UserType ut where ut.Id = tu.TypeCode and ut.Status = 'A') UserType 
from Representantes r
Left join Usuarios u on u.ID = r.ID
left join TiposUsuarios tu on tu.UserCode = u.ID
where r.status = 'A' 


--select * from Representantes
--select * from Usuarios
--select * from usertype
--select * from TiposUsuarios
GO
/****** Object:  View [dbo].[VW_Ventas]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[VW_Ventas]
as
SELECT        
	Ventas.Code, 
	Ventas.DateCompra, 
	Ventas.ClienteCode, 
	Ventas.ImporteTotal, 
	Ventas.Estado, 
	Clientes.CUIT,
	Clientes.Nombre, 
	Clientes.Apellido
FROM Ventas
CROSS JOIN Clientes
GO
ALTER TABLE [dbo].[CategoriaProducto] ADD  DEFAULT ('A') FOR [Status]
GO
ALTER TABLE [dbo].[Categorias] ADD  DEFAULT ('A') FOR [Status]
GO
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [df_ConstraintStatus]  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[Compras] ADD  DEFAULT (getdate()) FOR [DateCompra]
GO
ALTER TABLE [dbo].[Compras] ADD  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[Direcciones] ADD  DEFAULT ('A') FOR [Status]
GO
ALTER TABLE [dbo].[PrecioProducto] ADD  DEFAULT ('A') FOR [Status]
GO
ALTER TABLE [dbo].[Productos] ADD  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[ProductType] ADD  DEFAULT ('A') FOR [Status]
GO
ALTER TABLE [dbo].[Proveedores] ADD  CONSTRAINT [ConstraintStatus]  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[ProveedorType] ADD  DEFAULT ('A') FOR [Status]
GO
ALTER TABLE [dbo].[RelationDireccion] ADD  DEFAULT ('A') FOR [Status]
GO
ALTER TABLE [dbo].[RelationProductosCompra] ADD  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[RelationProductosProveedor] ADD  DEFAULT ('A') FOR [Status]
GO
ALTER TABLE [dbo].[RelationProductosVenta] ADD  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[Representantes] ADD  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[TiposProducto] ADD  DEFAULT ('A') FOR [Status]
GO
ALTER TABLE [dbo].[UserType] ADD  DEFAULT ('A') FOR [Status]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [CNT_DEFAULT_PASS]  DEFAULT ('123456') FOR [userPassword]
GO
ALTER TABLE [dbo].[Usuarios] ADD  CONSTRAINT [CNS_DEFAULT_Status]  DEFAULT ('A') FOR [status]
GO
ALTER TABLE [dbo].[Ventas] ADD  DEFAULT (getdate()) FOR [DateCompra]
GO
ALTER TABLE [dbo].[Ventas] ADD  DEFAULT ('A') FOR [Estado]
GO
ALTER TABLE [dbo].[CALLES]  WITH CHECK ADD FOREIGN KEY([CODEPROV])
REFERENCES [dbo].[PROVINCIAS] ([CODE])
GO
ALTER TABLE [dbo].[CALLES]  WITH CHECK ADD FOREIGN KEY([CODPOS])
REFERENCES [dbo].[CPA] ([CODE])
GO
ALTER TABLE [dbo].[CategoriaProducto]  WITH CHECK ADD FOREIGN KEY([categoriaCode])
REFERENCES [dbo].[Categorias] ([code])
GO
ALTER TABLE [dbo].[CategoriaProducto]  WITH CHECK ADD FOREIGN KEY([productoCode])
REFERENCES [dbo].[Productos] ([Code])
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD FOREIGN KEY([ProveedorCode])
REFERENCES [dbo].[Proveedores] ([Id])
GO
ALTER TABLE [dbo].[CPA]  WITH CHECK ADD FOREIGN KEY([PROVCODE])
REFERENCES [dbo].[PROVINCIAS] ([CODE])
GO
ALTER TABLE [dbo].[Direcciones]  WITH CHECK ADD FOREIGN KEY([CalleCode])
REFERENCES [dbo].[CALLES] ([CODE])
GO
ALTER TABLE [dbo].[Direcciones]  WITH CHECK ADD FOREIGN KEY([CPACode])
REFERENCES [dbo].[CPA] ([CODE])
GO
ALTER TABLE [dbo].[Direcciones]  WITH CHECK ADD FOREIGN KEY([LocalidadCode])
REFERENCES [dbo].[LOCALIDADES] ([CODE])
GO
ALTER TABLE [dbo].[Direcciones]  WITH CHECK ADD FOREIGN KEY([ProvCode])
REFERENCES [dbo].[PROVINCIAS] ([CODE])
GO
ALTER TABLE [dbo].[LOCALIDADES]  WITH CHECK ADD FOREIGN KEY([CODEPROV])
REFERENCES [dbo].[PROVINCIAS] ([CODE])
GO
ALTER TABLE [dbo].[LOCALIDADES]  WITH CHECK ADD FOREIGN KEY([CODPOS])
REFERENCES [dbo].[CPA] ([CODE])
GO
ALTER TABLE [dbo].[PrecioProducto]  WITH CHECK ADD FOREIGN KEY([productoCode])
REFERENCES [dbo].[Productos] ([Code])
GO
ALTER TABLE [dbo].[RelationDireccion]  WITH CHECK ADD FOREIGN KEY([DireccionCode])
REFERENCES [dbo].[Direcciones] ([Code])
GO
ALTER TABLE [dbo].[RelationProductosCompra]  WITH CHECK ADD FOREIGN KEY([CompraCode])
REFERENCES [dbo].[Compras] ([Code])
GO
ALTER TABLE [dbo].[RelationProductosCompra]  WITH CHECK ADD FOREIGN KEY([ProductoCode])
REFERENCES [dbo].[Productos] ([Code])
GO
ALTER TABLE [dbo].[RelationProductosProveedor]  WITH CHECK ADD FOREIGN KEY([ProductoCode])
REFERENCES [dbo].[Productos] ([Code])
GO
ALTER TABLE [dbo].[RelationProductosProveedor]  WITH CHECK ADD FOREIGN KEY([ProveedorCode])
REFERENCES [dbo].[Proveedores] ([Id])
GO
ALTER TABLE [dbo].[RelationProductosVenta]  WITH CHECK ADD FOREIGN KEY([ProductoCode])
REFERENCES [dbo].[Productos] ([Code])
GO
ALTER TABLE [dbo].[RelationProductosVenta]  WITH CHECK ADD FOREIGN KEY([VentaCode])
REFERENCES [dbo].[Ventas] ([Code])
GO
ALTER TABLE [dbo].[TiposClientes]  WITH CHECK ADD FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[TiposClientes]  WITH CHECK ADD FOREIGN KEY([TypeCode])
REFERENCES [dbo].[ClientType] ([Id])
GO
ALTER TABLE [dbo].[TiposProducto]  WITH CHECK ADD FOREIGN KEY([productoCode])
REFERENCES [dbo].[Productos] ([Code])
GO
ALTER TABLE [dbo].[TiposProducto]  WITH CHECK ADD FOREIGN KEY([typeCode])
REFERENCES [dbo].[ProductType] ([Code])
GO
ALTER TABLE [dbo].[TiposProveedor]  WITH CHECK ADD FOREIGN KEY([ProveedorID])
REFERENCES [dbo].[Proveedores] ([Id])
GO
ALTER TABLE [dbo].[TiposProveedor]  WITH CHECK ADD FOREIGN KEY([TypeCode])
REFERENCES [dbo].[ProveedorType] ([Id])
GO
ALTER TABLE [dbo].[TiposUsuarios]  WITH CHECK ADD FOREIGN KEY([TypeCode])
REFERENCES [dbo].[UserType] ([Id])
GO
ALTER TABLE [dbo].[TiposUsuarios]  WITH CHECK ADD FOREIGN KEY([UserCode])
REFERENCES [dbo].[Usuarios] ([ID])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[Representantes] ([ID])
GO
ALTER TABLE [dbo].[CALLES]  WITH CHECK ADD CHECK  ((len([ALTURA])>(1)))
GO
ALTER TABLE [dbo].[CALLES]  WITH CHECK ADD CHECK  ((len([DESCRIPCION])>=(5)))
GO
ALTER TABLE [dbo].[CALLES]  WITH CHECK ADD CHECK  ((len([STATUS])=(1)))
GO
ALTER TABLE [dbo].[CategoriaProducto]  WITH CHECK ADD CHECK  (([Status]='A' OR [status]='I'))
GO
ALTER TABLE [dbo].[Compras]  WITH CHECK ADD CHECK  (([status]='A' OR [status]='I'))
GO
ALTER TABLE [dbo].[CPA]  WITH CHECK ADD CHECK  ((len([CODE])<=(4)))
GO
ALTER TABLE [dbo].[CPA]  WITH CHECK ADD CHECK  ((len([PROVCODE])<=(2)))
GO
ALTER TABLE [dbo].[CPA]  WITH CHECK ADD CHECK  ((len([STATUS])=(1)))
GO
ALTER TABLE [dbo].[Direcciones]  WITH CHECK ADD  CONSTRAINT [CHK_Status] CHECK  (([status]='M' OR [status]='F'))
GO
ALTER TABLE [dbo].[Direcciones] CHECK CONSTRAINT [CHK_Status]
GO
ALTER TABLE [dbo].[LOCALIDADES]  WITH CHECK ADD CHECK  ((len([DESCRIPCION])>=(5)))
GO
ALTER TABLE [dbo].[LOCALIDADES]  WITH CHECK ADD CHECK  ((len([STATUS])=(1)))
GO
ALTER TABLE [dbo].[PrecioProducto]  WITH CHECK ADD CHECK  (([precio]>=(0)))
GO
ALTER TABLE [dbo].[PrecioProducto]  WITH CHECK ADD CHECK  (([Status]='A' OR [status]='I'))
GO
ALTER TABLE [dbo].[Productos]  WITH CHECK ADD CHECK  (([status]='A' OR [status]='I'))
GO
ALTER TABLE [dbo].[ProductType]  WITH CHECK ADD CHECK  (([Descripcion]<>''))
GO
ALTER TABLE [dbo].[ProductType]  WITH CHECK ADD CHECK  (([Status]='A' OR [status]='I'))
GO
ALTER TABLE [dbo].[ProveedorType]  WITH CHECK ADD CHECK  (([status]='A' OR [status]='I'))
GO
ALTER TABLE [dbo].[PROVINCIAS]  WITH CHECK ADD CHECK  ((len([DESCRIPCION])>=(5)))
GO
ALTER TABLE [dbo].[PROVINCIAS]  WITH CHECK ADD CHECK  ((len([STATUS])=(1)))
GO
ALTER TABLE [dbo].[RelationDireccion]  WITH CHECK ADD CHECK  (([status]='A' OR [status]='I'))
GO
ALTER TABLE [dbo].[RelationProductosCompra]  WITH CHECK ADD CHECK  (([cantidad]>=(0)))
GO
ALTER TABLE [dbo].[RelationProductosCompra]  WITH CHECK ADD CHECK  (([ImporteUnidad]>=(0)))
GO
ALTER TABLE [dbo].[RelationProductosCompra]  WITH CHECK ADD CHECK  (([status]='A' OR [status]='I'))
GO
ALTER TABLE [dbo].[RelationProductosProveedor]  WITH CHECK ADD CHECK  (([status]='A' OR [status]='I'))
GO
ALTER TABLE [dbo].[RelationProductosVenta]  WITH CHECK ADD CHECK  (([cantidad]>=(0)))
GO
ALTER TABLE [dbo].[RelationProductosVenta]  WITH CHECK ADD CHECK  (([ImporteUnidad]>=(0)))
GO
ALTER TABLE [dbo].[RelationProductosVenta]  WITH CHECK ADD CHECK  (([status]='A' OR [status]='I'))
GO
ALTER TABLE [dbo].[Representantes]  WITH CHECK ADD  CONSTRAINT [CHK_Representative_sex] CHECK  (([sexo]='M' OR [sexo]='F'))
GO
ALTER TABLE [dbo].[Representantes] CHECK CONSTRAINT [CHK_Representative_sex]
GO
ALTER TABLE [dbo].[TiposProducto]  WITH CHECK ADD CHECK  (([Status]='A' OR [status]='I'))
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Direccion]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[SP_Delete_Direccion]
@Code int
AS
BEGIN
	SET NOCOUNT ON;

	update Direcciones
	set  [status] = 'I'
	WHERE Code = @Code
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Direccion_Usuario]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[SP_Delete_Direccion_Usuario]
@UserCode int, @DireccionCode int
AS
BEGIN
	SET NOCOUNT ON;
	update RelationDireccion
	set [status] = 'I'
	where UserCode = @UserCode and DireccionCode = @DireccionCode
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Producto]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Delete_Producto]
 @idProducto int null
AS
BEGIN
	SET NOCOUNT ON;
	update Productos 
	set [STATUS] = 'I'
	where @idProducto = ID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_ProductType]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Delete_ProductType]
@typeCode int
as
begin
	update ProductType set Status = 'I'
	where Code = @typeCode
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Proveedor]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Delete_Proveedor]
@ProveedorCode int
as
begin
Update Proveedores
set Status = 'I'
where Id = @ProveedorCode
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_ProveedorType]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[SP_Delete_ProveedorType]
@typeCode int
as
begin
Update ProveedorType
set Status = 'I'
where Id = @typeCode
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Representative]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE  [dbo].[SP_Delete_Representative]
	 @userCode int
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE REPRESENTANTES
	SET [status] = 'I'
	WHERE ID = @userCode

END

GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_User]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE  [dbo].[SP_Delete_User]
@repCode int
AS
BEGIN
	SET NOCOUNT ON;
	
	update Usuarios
	set [status] = 'I'
	where ID = @repCode
	
END

GO
/****** Object:  StoredProcedure [dbo].[SP_Get_All_CategoriasProducts]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Get_All_CategoriasProducts]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT c.code Code,
		   c.Descripcion
	FROM Categorias c
	WHERE c.status = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_All_Clientes]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Get_All_Clientes]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

		select  c.Id code,
				c.Nombre,
				c.Apellido,
				c.CUIT,
				c.Sexo,
				c.FechaNac,
				(select ct.Descripcion from ClientType ct where ct.Id = tc.TypeCode) ClientType
		from Clientes c
		left join tiposClientes tc on c.Id = tc.ClienteID
		where c.status = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_All_Productos]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_Get_All_Productos] 
AS
BEGIN
	SET NOCOUNT ON;
	SELECT p.*
	FROM VW_Productos p 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_All_ProductsTypes]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Get_All_ProductsTypes]
as
begin
	select Code, Descripcion 
	from ProductType 
	where Status = 'A'
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_All_Proveedores]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Get_All_Proveedores]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

		select  *
		from [VW_Proveedores]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_All_ProveedorTypes]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Get_All_ProveedorTypes]
as
begin
select Id Code, Descripcion 
from ProveedorType
where Status = 'A'
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_All_Provincias]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Get_All_Provincias]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT p.CODE Code,
		   p.DESCRIPCION Descripcion
	FROM PROVINCIAS p
	WHERE p.status = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[sp_get_all_userTypes]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_get_all_userTypes]
	-- Add the parameters for the stored procedure here
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT ut.Id Code,
		   ut.Descripcion
	FROM UserType ut
	WHERE ut.status = 'A'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_All_Usuarios]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Get_All_Usuarios]
as begin
select * from VW_Representative_User
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_Calle]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Get_Calle]
	-- Add the parameters for the stored procedure here
	@ProvCode int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT c.CODE Code,
		   c.DESCRIPCION Descripcion
	FROM CALLES c
	WHERE c.status = 'A' and c.CODEPROV = @ProvCode
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_Catalogo_ByProveedor]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_Get_Catalogo_ByProveedor]
@ProveedorCode int
as
Begin
SET NOCOUNT ON;
	select p.Code as code,p.Descripcion
	from RelationProductosProveedor rpp
	inner join Productos p on p.Code = rpp.ProductoCode
	where rpp.ProveedorCode = @ProveedorCode and rpp.Status = 'A'
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_Cliente_ByID]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Get_Cliente_ByID]
	-- Add the parameters for the stored procedure here
	@ClientCode int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

		select  c.Id code,
				c.Nombre,
				c.Apellido,
				c.CUIT,
				c.Sexo,
				c.FechaNac,
				(select ct.Descripcion from ClientType ct where ct.Id = tc.TypeCode) ClientType
		from Clientes c
		left join tiposClientes tc on c.Id = tc.ClienteID
		where c.status = 'A' and c.Id = @ClientCode
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_Localidad]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Get_Localidad]
	-- Add the parameters for the stored procedure here
	@ProvCode int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT l.CODE Code,
		   l.DESCRIPCION Descripcion
	FROM LOCALIDADES l
	WHERE l.status = 'A' and l.CODEPROV = @ProvCode
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_Producto_byID]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE  [dbo].[SP_Get_Producto_byID]
	@IDPRODUCTO int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT p.*
	FROM VW_Productos p 
	where p.Id = @IDPRODUCTO 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_ProductType]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Get_ProductType]
@typeCode int
as
begin
	select Code, Descripcion 
	from ProductType 
	where Status = 'A' and Code = @typeCode
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_Proveedor_ByID]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_Get_Proveedor_ByID]
	-- Add the parameters for the stored procedure here
	@ProveedorCode int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

		select * from VW_Proveedores p
		where p.Code = @ProveedorCode
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_ProveedorType_ByID]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Get_ProveedorType_ByID]
@typeCode int
as
begin
select Id Code, Descripcion 
from ProveedorType
where Status = 'A'
and Id = @typeCode
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_Usuario_byID]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[SP_Get_Usuario_byID]
	@UserCode int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT *
	FROM VW_Representative_User	u
	where u.UserId = @UserCode
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Direccion]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_Insert_Direccion]

@Prov varchar(MAX),
@Localidad varchar(MAX),
@Calle varchar(MAX),
@CalleAltura int

AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @ProvCode int = (select p.CODE from PROVINCIAS p where p.DESCRIPCION = @Prov) 
	DECLARE @LocalidadCode int = (select l.CODE from LOCALIDADES l where l.DESCRIPCION = @Localidad)
	DECLARE @CalleCode int = (select c.CODE from CALLES c where c.DESCRIPCION = @Localidad and c.ALTURA = @CalleAltura)
	DECLARE @CPACode int = (select cp.CODE from CPA cp where cp.PROVCODE = @ProvCode)

	insert into Direcciones (ProvCode, LocalidadCode, CalleCode, CPACode) 
	output inserted.Code
	values (@ProvCode, @LocalidadCode, @CalleCode, @CPACode)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Direccion_Usuario]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_Insert_Direccion_Usuario]
@UserCode int, @DireccionCode int
AS
BEGIN
	SET NOCOUNT ON;
	insert into RelationDireccion (UserCode, DireccionCode) values (@UserCode, @DireccionCode)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Producto]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE  [dbo].[SP_Insert_Producto]
	@Descripcion varchar(MAX), @CategoriaCode int, @TypeCode int
AS
BEGIN
	SET NOCOUNT ON;
	insert into Productos (Descripcion, CategoriaCode, TypeCode) values (@Descripcion, @CategoriaCode, @TypeCode)
END


--SP_Insert_Producto 'Tu Vieja'
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_ProductType]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Insert_ProductType]
@Descripcion varchar(max)
as
begin
	insert into ProductType (Descripcion) values (@Descripcion)
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Proveedor]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE  [dbo].[SP_Insert_Proveedor]
	 @Nombre varchar(MAX)
	,@Apellido varchar(MAX)
	,@Sexo char(1)
	,@FechaNac date 
	,@Cuit varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	insert into Proveedores (Nombre, Apellido, Sexo, FechaNac, CUIT) 
	output inserted.ID 
	values (@Nombre, @Apellido, @Sexo, @FechaNac, @Cuit)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_ProveedorType]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[SP_Insert_ProveedorType]
	 @Descripcion varchar(MAX)
AS
BEGIN
	SET NOCOUNT ON;
	insert into ProveedorType (Descripcion) 
	output inserted.ID 
	values (@Descripcion)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Representative]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE  [dbo].[SP_Insert_Representative]
	 @Nombre varchar(MAX)
	,@Apellido varchar(MAX)
	,@Sexo char(1)
	,@FechaNac datetime
AS
BEGIN
	SET NOCOUNT ON;
	insert into Representantes (Nombre, Apellido, Sexo, FechaNac) 
	output inserted.ID 
	values (@Nombre, @Apellido, @Sexo, @FechaNac)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_TipoProveedor]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE  [dbo].[SP_Insert_TipoProveedor]
@prvCode int, @prvTypeCode int
AS
BEGIN
	SET NOCOUNT ON;
	insert into TiposProveedor (ProveedorID, TypeCode) values (@prvCode, @prvTypeCode)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_User]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE  [dbo].[SP_Insert_User]
@repCode int, @userTypeCode int
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @userName varchar(MAX) = (SELECT RTRIM(LTRIM(SUBSTRING(NOMBRE, 1, 1)+APELLIDO)) FROM REPRESENTANTES where id = @repCode)
	insert into Usuarios (ID, userName) values (@repCode, @userName)
	insert into TiposUsuarios (UserCode, TypeCode) values (@repCode, @userTypeCode)
END

GO
/****** Object:  StoredProcedure [dbo].[SP_update_Descripcion_Producto]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_update_Descripcion_Producto]
@Descripcion varchar(100) null, @idProducto int null
AS
BEGIN
	SET NOCOUNT ON;
	update Productos 
	set Descripcion = @Descripcion
	where @idProducto = ID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Direccion]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[SP_Update_Direccion]
@Code int,
@Prov varchar(MAX),
@Localidad varchar(MAX),
@Calle varchar(MAX),
@CalleAltura int

AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @ProvCode int = (select p.CODE from PROVINCIAS p where p.DESCRIPCION = @Prov) 
	DECLARE @LocalidadCode int = (select l.CODE from LOCALIDADES l where l.DESCRIPCION = @Localidad)
	DECLARE @CalleCode int = (select c.CODE from CALLES c where c.DESCRIPCION = @Localidad and c.ALTURA = @CalleAltura)
	DECLARE @CPACode int = (select cp.CODE from CPA cp where cp.PROVCODE = @ProvCode)

	update Direcciones
	set  ProvCode = @ProvCode
		,LocalidadCode = @LocalidadCode
		,CalleCode = @CalleCode
		,CPACode = @CPACode
	WHERE Code = @Code
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Direccion_Usuario]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE  [dbo].[SP_Update_Direccion_Usuario]
@UserCode int, @DireccionCode int
AS
BEGIN
	SET NOCOUNT ON;
	Update RelationDireccion
	set DireccionCode = @DireccionCode
	where userCode = @UserCode
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_ProductType]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SP_Update_ProductType]
@typeCode int, @Descripcion varchar(max)
as
begin
	update ProductType set Descripcion = @Descripcion
	where Code = @typeCode
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Proveedor]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE  [dbo].[SP_Update_Proveedor]
	@proveedorCode int
	,@Nombre varchar(MAX)
	,@Apellido varchar(MAX)
	,@Sexo char(1)
	,@FechaNac date 
	,@Cuit varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	update Proveedores set
	Nombre = @Nombre
	,Apellido = @Apellido
	,Sexo = @Sexo
	,FechaNac = @FechaNac
	,CUIT = @Cuit
	where Id = @proveedorCode
END

GO
/****** Object:  StoredProcedure [dbo].[SP_Update_ProveedorType]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SP_Update_ProveedorType]
@typeCode int, @Descripcion varchar(MAX)
as
begin
Update ProveedorType
set Descripcion = @Descripcion 
where Id = @typeCode
end
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Representative]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE  [dbo].[SP_Update_Representative]
	 @userCode int
	,@Nombre varchar(MAX)
	,@Apellido varchar(MAX)
	,@Sexo char(1)
	,@FechaNac datetime
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE REPRESENTANTES
	SET NOMBRE = @Nombre
		,APELLIDO = @Apellido
		,SEXO = @Sexo
		,FECHANAC = @FechaNac
	WHERE ID = @userCode

END

GO
/****** Object:  StoredProcedure [dbo].[SP_Update_TipoProveedor]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO






CREATE PROCEDURE  [dbo].[SP_Update_TipoProveedor]
@prvCode int, @prvTypeCode int
AS
BEGIN
	SET NOCOUNT ON;
	update TiposProveedor 
	set TypeCode = @prvTypeCode
	where ProveedorID = @prvCode
END

GO
/****** Object:  StoredProcedure [dbo].[SP_Update_User]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE  [dbo].[SP_Update_User]
@repCode int, @userTypeCode int
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @userName varchar(MAX) = (SELECT RTRIM(LTRIM(SUBSTRING(NOMBRE, 1, 1)+APELLIDO)) FROM REPRESENTANTES where id = @repCode)
	
	update Usuarios
	set [userName] = @userName
	where ID = @repCode
	
	update TiposUsuarios
	set [TypeCode] = @userTypeCode
	where UserCode = @repCode

END

GO
/****** Object:  StoredProcedure [dbo].[SP_validateUser]    Script Date: 4/11/2018 22:06:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_validateUser]
	@username varchar(50), @password varchar(50)
AS
BEGIN
	SET NOCOUNT ON;
	SELECT 'true' UserExist
	WHERE EXISTS (select * from USUARIOS u where u.userName like @username and u.userPassword like @password)
END
GO
USE [master]
GO
ALTER DATABASE [MANSILLA_DB] SET  READ_WRITE 
GO
