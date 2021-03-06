USE [master]
GO
/****** Object:  Database [No hay 2 sin 3]    Script Date: 7/8/2022 9:53:11 AM ******/
CREATE DATABASE [No hay 2 sin 3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'No hay 2 sin 3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\No hay 2 sin 3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'No hay 2 sin 3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\No hay 2 sin 3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [No hay 2 sin 3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [No hay 2 sin 3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [No hay 2 sin 3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET ARITHABORT OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [No hay 2 sin 3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [No hay 2 sin 3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [No hay 2 sin 3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [No hay 2 sin 3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [No hay 2 sin 3] SET  MULTI_USER 
GO
ALTER DATABASE [No hay 2 sin 3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [No hay 2 sin 3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [No hay 2 sin 3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [No hay 2 sin 3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [No hay 2 sin 3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [No hay 2 sin 3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [No hay 2 sin 3] SET QUERY_STORE = OFF
GO
USE [No hay 2 sin 3]
GO
/****** Object:  User [slave]    Script Date: 7/8/2022 9:53:11 AM ******/
CREATE USER [slave] FOR LOGIN [slave] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [esclavo]    Script Date: 7/8/2022 9:53:11 AM ******/
CREATE USER [esclavo] FOR LOGIN [esclavo] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [slave]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [slave]
GO
ALTER ROLE [db_datareader] ADD MEMBER [slave]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [slave]
GO
ALTER ROLE [db_owner] ADD MEMBER [esclavo]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [esclavo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [esclavo]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [esclavo]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [bigint] IDENTITY(1,1) NOT NULL,
	[nombreCliente] [varchar](50) NULL,
	[domicilioCliente] [varchar](50) NULL,
	[telefonoCliente] [varchar](50) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Delivery]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delivery](
	[idDelivery] [bigint] IDENTITY(1,1) NOT NULL,
	[precioDelivery] [decimal](4, 2) NULL,
 CONSTRAINT [PK_Delivery] PRIMARY KEY CLUSTERED 
(
	[idDelivery] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallePedido]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallePedido](
	[idDetallePedido] [bigint] NOT NULL,
	[idPedido] [bigint] NOT NULL,
	[idProducto] [bigint] NULL,
	[cantidadProductoDetallePedido] [bigint] NULL,
	[observacionDetallePedido] [varchar](50) NULL,
	[nombreProducto] [varchar](40) NULL,
	[precioProducto] [decimal](16, 2) NULL,
 CONSTRAINT [PK_DetallePedido] PRIMARY KEY CLUSTERED 
(
	[idDetallePedido] ASC,
	[idPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoPedido]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoPedido](
	[idEstadoPedido] [bigint] IDENTITY(1,1) NOT NULL,
	[nombreEstado] [varchar](15) NOT NULL,
 CONSTRAINT [PK_EstadoPedido] PRIMARY KEY CLUSTERED 
(
	[idEstadoPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[idPedido] [bigint] IDENTITY(1,1) NOT NULL,
	[idCliente] [bigint] NULL,
	[montoTotalPedido] [decimal](16, 2) NULL,
	[fechaPedido] [datetime] NULL,
	[horaPedido] [nchar](5) NULL,
	[observacionPedido] [varchar](50) NULL,
	[domicilioEntregaPedido] [varchar](50) NULL,
	[idEstadoPedido] [bigint] NULL,
	[montoAbono] [decimal](16, 2) NULL,
	[tiempoDemora] [bigint] NULL,
	[descuento] [decimal](18, 2) NULL,
	[nombreClienteMostrador] [varchar](50) NULL,
 CONSTRAINT [PK_Pedido] PRIMARY KEY CLUSTERED 
(
	[idPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[idPerfil] [bigint] IDENTITY(1,1) NOT NULL,
	[nombrePerfil] [varchar](50) NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[idPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [bigint] IDENTITY(1,1) NOT NULL,
	[nombreProducto] [varchar](50) NOT NULL,
	[observacionProducto] [varchar](50) NOT NULL,
	[precioX1] [decimal](8, 2) NULL,
	[precioX2] [decimal](8, 2) NULL,
	[precioX3] [decimal](8, 2) NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Security]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Security](
	[psw] [varchar](50) NULL,
	[idPassword] [int] NOT NULL,
	[fchRegistro] [varchar](10) NULL,
	[fchValidoDesde] [varchar](10) NULL,
	[fchValidoHasta] [varchar](10) NULL,
 CONSTRAINT [PK_Security] PRIMARY KEY CLUSTERED 
(
	[idPassword] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[idSucursal] [bigint] IDENTITY(1,1) NOT NULL,
	[direccion] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[localidad] [varchar](50) NULL,
	[activa] [bit] NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[idSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [bigint] IDENTITY(1,1) NOT NULL,
	[nombreUsuario] [varchar](50) NULL,
	[contraseña] [varchar](50) NULL,
	[idPerfil] [bigint] NULL,
	[idSucursal] [bigint] NULL,
	[activo] [bit] NULL,
	[nombre] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[domicilio] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([idCliente], [nombreCliente], [domicilioCliente], [telefonoCliente]) VALUES (1, N'Mostrador', N'Mostrador', N'0')
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Delivery] ON 

INSERT [dbo].[Delivery] ([idDelivery], [precioDelivery]) VALUES (1, CAST(10.00 AS Decimal(4, 2)))
SET IDENTITY_INSERT [dbo].[Delivery] OFF
GO
INSERT [dbo].[DetallePedido] ([idDetallePedido], [idPedido], [idProducto], [cantidadProductoDetallePedido], [observacionDetallePedido], [nombreProducto], [precioProducto]) VALUES (1, 42, 4, 1, N'', N'ALGO 1', CAST(1.00 AS Decimal(16, 2)))
GO
SET IDENTITY_INSERT [dbo].[Pedido] ON 

INSERT [dbo].[Pedido] ([idPedido], [idCliente], [montoTotalPedido], [fechaPedido], [horaPedido], [observacionPedido], [domicilioEntregaPedido], [idEstadoPedido], [montoAbono], [tiempoDemora], [descuento], [nombreClienteMostrador]) VALUES (42, 1, CAST(1.00 AS Decimal(16, 2)), CAST(N'2022-06-27T00:00:00.000' AS DateTime), N'23:06', N'', N'Mostrador', NULL, CAST(1000.00 AS Decimal(16, 2)), 1, CAST(0.00 AS Decimal(18, 2)), N'fer')
SET IDENTITY_INSERT [dbo].[Pedido] OFF
GO
SET IDENTITY_INSERT [dbo].[Perfil] ON 

INSERT [dbo].[Perfil] ([idPerfil], [nombrePerfil]) VALUES (1, N'Total')
INSERT [dbo].[Perfil] ([idPerfil], [nombrePerfil]) VALUES (2, N'Propietario')
INSERT [dbo].[Perfil] ([idPerfil], [nombrePerfil]) VALUES (3, N'Administrador')
INSERT [dbo].[Perfil] ([idPerfil], [nombrePerfil]) VALUES (4, N'Empleado')
SET IDENTITY_INSERT [dbo].[Perfil] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([idProducto], [nombreProducto], [observacionProducto], [precioX1], [precioX2], [precioX3]) VALUES (4, N'ALGO 1', N'', CAST(1.00 AS Decimal(8, 2)), CAST(2.00 AS Decimal(8, 2)), CAST(3.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
INSERT [dbo].[Security] ([psw], [idPassword], [fchRegistro], [fchValidoDesde], [fchValidoHasta]) VALUES (N'2J7A0V5I8E5R', 1, N'6/14/2022', N'6/14/2022', N'12/7/2035')
GO
SET IDENTITY_INSERT [dbo].[Sucursal] ON 

INSERT [dbo].[Sucursal] ([idSucursal], [direccion], [telefono], [localidad], [activa]) VALUES (1, N'pueyrredon', N'1', N'Córdoba', 1)
INSERT [dbo].[Sucursal] ([idSucursal], [direccion], [telefono], [localidad], [activa]) VALUES (2, N'gral paz', N'1', N'Córdoba', 1)
INSERT [dbo].[Sucursal] ([idSucursal], [direccion], [telefono], [localidad], [activa]) VALUES (3, N'd.quiros', N'222', N'Córdoba', 1)
INSERT [dbo].[Sucursal] ([idSucursal], [direccion], [telefono], [localidad], [activa]) VALUES (4, N'sta isabel', N'1', N'Córdoba', 1)
INSERT [dbo].[Sucursal] ([idSucursal], [direccion], [telefono], [localidad], [activa]) VALUES (5, N'mta1017', N'123', N'cba', 1)
INSERT [dbo].[Sucursal] ([idSucursal], [direccion], [telefono], [localidad], [activa]) VALUES (6, N'bv sj 123', N'333', N'cba', 1)
INSERT [dbo].[Sucursal] ([idSucursal], [direccion], [telefono], [localidad], [activa]) VALUES (9, N'pueyrredon', N'1', N'Córdoba', 0)
SET IDENTITY_INSERT [dbo].[Sucursal] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([idUsuario], [nombreUsuario], [contraseña], [idPerfil], [idSucursal], [activo], [nombre], [telefono], [domicilio]) VALUES (1, N'mati', N'1', 2, 1, 1, N'mati', N'1', N'1')
INSERT [dbo].[Usuario] ([idUsuario], [nombreUsuario], [contraseña], [idPerfil], [idSucursal], [activo], [nombre], [telefono], [domicilio]) VALUES (2, N'matigp', N'1', 3, 2, 1, N'mati gp', N'1', N'1')
INSERT [dbo].[Usuario] ([idUsuario], [nombreUsuario], [contraseña], [idPerfil], [idSucursal], [activo], [nombre], [telefono], [domicilio]) VALUES (3, N'fran', N'1', 3, 4, 1, N'fran', N'1', N'1')
INSERT [dbo].[Usuario] ([idUsuario], [nombreUsuario], [contraseña], [idPerfil], [idSucursal], [activo], [nombre], [telefono], [domicilio]) VALUES (4, N'cesar', N'1', 3, 1, 1, N'cesar', N'1', N'1')
INSERT [dbo].[Usuario] ([idUsuario], [nombreUsuario], [contraseña], [idPerfil], [idSucursal], [activo], [nombre], [telefono], [domicilio]) VALUES (5, N'pepe', N'1', 4, 1, 1, N'pepe', N'1', N'1')
INSERT [dbo].[Usuario] ([idUsuario], [nombreUsuario], [contraseña], [idPerfil], [idSucursal], [activo], [nombre], [telefono], [domicilio]) VALUES (6, N'cacho', N'1', 4, 2, 1, N'cacho', N'1', N'1')
INSERT [dbo].[Usuario] ([idUsuario], [nombreUsuario], [contraseña], [idPerfil], [idSucursal], [activo], [nombre], [telefono], [domicilio]) VALUES (7, N'javi', N'1', 1, 1, 1, N'javi', N'1', N'1')
INSERT [dbo].[Usuario] ([idUsuario], [nombreUsuario], [contraseña], [idPerfil], [idSucursal], [activo], [nombre], [telefono], [domicilio]) VALUES (8, N'marcos', N'1', 1, 1, 1, N'marcos', N'1', N'1')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[Pedido] ADD  DEFAULT ('') FOR [nombreClienteMostrador]
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedido_Pedido] FOREIGN KEY([idPedido])
REFERENCES [dbo].[Pedido] ([idPedido])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_DetallePedido_Pedido]
GO
ALTER TABLE [dbo].[DetallePedido]  WITH CHECK ADD  CONSTRAINT [FK_DetallePedido_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[DetallePedido] CHECK CONSTRAINT [FK_DetallePedido_Producto]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_Cliente]
GO
ALTER TABLE [dbo].[Pedido]  WITH CHECK ADD  CONSTRAINT [FK_Pedido_EstadoPedido] FOREIGN KEY([idEstadoPedido])
REFERENCES [dbo].[EstadoPedido] ([idEstadoPedido])
GO
ALTER TABLE [dbo].[Pedido] CHECK CONSTRAINT [FK_Pedido_EstadoPedido]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Perfil] FOREIGN KEY([idPerfil])
REFERENCES [dbo].[Perfil] ([idPerfil])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Perfil]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Sucursal] FOREIGN KEY([idSucursal])
REFERENCES [dbo].[Sucursal] ([idSucursal])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Sucursal]
GO
/****** Object:  StoredProcedure [dbo].[Perfil_getAll]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Perfil_getAll]
AS
BEGIN
	select nombrePerfil, idPerfil
	from Perfil
	order by nombrePerfil
END

GO
/****** Object:  StoredProcedure [dbo].[Sucursal_AddNew]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sucursal_AddNew]
	@direccion varchar(50),
	@telefono varchar(50),
	@localidad varchar(50)
AS
BEGIN
	insert into Sucursal (direccion, telefono, localidad, activa) 
		values (@direccion, @telefono, @localidad, 'True')
END

GO
/****** Object:  StoredProcedure [dbo].[Sucursal_buscar]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sucursal_buscar]
	@direccion varchar(50),
	@activa int
AS
BEGIN
	select idSucursal, direccion, telefono, localidad
	from Sucursal
	where activa = @activa
	and direccion like '%' +@direccion + '%'
	order by idSucursal asc
END

GO
/****** Object:  StoredProcedure [dbo].[Sucursal_Delete]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sucursal_Delete]
	@idSucursal bigint,
	@activar bigint
AS
BEGIN
	update Sucursal
	set activa = @activar
	where idSucursal = @idSucursal
END

GO
/****** Object:  StoredProcedure [dbo].[Sucursal_getAll]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sucursal_getAll]
AS
BEGIN
	select idSucursal, direccion, telefono, localidad
	from Sucursal
	where activa = 1
	order by idSucursal asc
END

GO
/****** Object:  StoredProcedure [dbo].[Sucursal_update]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sucursal_update]
	@idSucursal bigint,
	@direccion varchar(50),
	@telefono varchar(50),
	@localidad varchar(50),
	@activa bit
AS
BEGIN
	update Sucursal
	set direccion = @direccion, 
		telefono = @telefono,
		localidad = @localidad,
		activa = @activa
	where idSucursal = @idSucursal
END

GO
/****** Object:  StoredProcedure [dbo].[Usuario_AddNew]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_AddNew]
	@nombreUsuario varchar(50),
	@contraseña varchar(50),
	@idPerfil bigint,
	@idSucursal bigint,
	@nombre varchar(50),
	@telefono varchar(50),
	@domicilio varchar(50)
AS
BEGIN
	insert into Usuario(nombreUsuario, contraseña, idPerfil, idSucursal, nombre, telefono, domicilio, activo) 
		values (@nombreUsuario, @contraseña, @idPerfil, @idSucursal, @nombre, @telefono, @domicilio, 1)
END

GO
/****** Object:  StoredProcedure [dbo].[Usuario_delete]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_delete]
	@idUsuario bigint,
	@activo bigint
AS
BEGIN
	update Usuario
	set activo = @activo
	where idUsuario = @idUsuario
END

GO
/****** Object:  StoredProcedure [dbo].[Usuario_getAll]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_getAll]	
	@activo int,
	@nombre varchar(50)
AS
BEGIN
	select usr.idUsuario, usr.nombre, usr.nombreUsuario, per.nombrePerfil, suc.direccion as direccionSucursal, usr.idPerfil, usr.contraseña, usr.idSucursal, 
		usr.telefono, usr.domicilio		
	from Usuario usr, sucursal suc, perfil per
	where activo = @activo
	and nombre like '%' + @nombre + '%'
	and usr.idSucursal = suc.idSucursal
	and usr.idPerfil = per.idPerfil	
	order by idUsuario, idSucursal asc
END

GO
/****** Object:  StoredProcedure [dbo].[Usuario_getAll_bySucursal]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_getAll_bySucursal]
	@idSucursal bigint,
	@nombre varchar(50)
AS
BEGIN
	select usr.idUsuario, usr.nombre, usr.nombreUsuario, per.nombrePerfil, suc.direccion as direccionSucursal, usr.idPerfil, usr.contraseña, usr.idSucursal, 
		usr.telefono, usr.domicilio		
	from Usuario usr, sucursal suc, perfil per
	where activo = 1
	and usr.idSucursal = suc.idSucursal
	and usr.idPerfil = per.idPerfil
	and usr.idSucursal = @idSucursal
	and nombre like '%' + @nombre + '%'
	order by idUsuario, idSucursal asc
END

GO
/****** Object:  StoredProcedure [dbo].[Usuario_getAll_inactivos]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_getAll_inactivos]
	@idSucursal bigint,
	@nombre varchar(50)
AS
BEGIN
	select usr.idUsuario, usr.nombre, usr.nombreUsuario, per.nombrePerfil, suc.direccion as direccionSucursal, usr.idPerfil, usr.contraseña, usr.idSucursal, 
		usr.telefono, usr.domicilio
	from Usuario usr, sucursal suc, perfil per
	where activo = 0
	and usr.idSucursal = @idSucursal
	and usr.idSucursal = suc.idSucursal
	and usr.idPerfil = per.idPerfil
	and usr.nombre like '%' + @nombre + '%'
	order by usr.idUsuario, usr.idSucursal asc
END

GO
/****** Object:  StoredProcedure [dbo].[Usuario_getAll_inactvo_bySucursal]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Usuario_getAll_inactvo_bySucursal]
	@idSucursal bigint,
	@nombre varchar(50)
AS
BEGIN
	select usr.idUsuario, usr.nombre, usr.nombreUsuario, per.nombrePerfil, suc.direccion as direccionSucursal, usr.idPerfil, usr.contraseña, usr.idSucursal, 
		usr.telefono, usr.domicilio		
	from Usuario usr, sucursal suc, perfil per
	where activo = 0
	and usr.idSucursal = suc.idSucursal
	and usr.idPerfil = per.idPerfil
	and usr.idSucursal = @idSucursal
	and nombre like '%' + @nombre + '%'
	order by idUsuario, idSucursal asc
END

GO
/****** Object:  StoredProcedure [dbo].[Usuario_getOne]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Usuario_getOne]
	@idUsuario bigint
AS
BEGIN
	select usr.nombreUsuario, usr.contraseña, usr.idPerfil, per.nombrePerfil, usr.idSucursal, suc.direccion as dirSuc, usr.activo, usr.nombre, usr.telefono
	from Usuario usr, Perfil per, Sucursal suc
	where usr.idPerfil = per.idPerfil
	and usr.idSucursal = suc.idSucursal
	and usr.idUsuario = @idUsuario
END

GO
/****** Object:  StoredProcedure [dbo].[Usuario_getValidacion]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Usuario_getValidacion]
	@nombreUsuario varchar(50),
	@contraseña varchar(50)
AS
BEGIN
	select usr.idPerfil, per.nombrePerfil, usr.idSucursal
	from Usuario usr, Perfil per
	where usr.idPerfil = per.idPerfil
	and usr.nombreUsuario = @nombreUsuario
	and usr.contraseña = @contraseña
END

GO
/****** Object:  StoredProcedure [dbo].[Usuario_Update]    Script Date: 7/8/2022 9:53:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Usuario_Update]
	@idUsuario bigint,
	@nombreUsuario varchar(50),
	@contraseña varchar(50),
	@idPerfil varchar(50),
	@idSucursal varchar(50),
	@activo bit,
	@nombre varchar(50),
	@telefono varchar(50),
	@domicilio varchar(50)
AS
BEGIN
	update Usuario
	set nombreUsuario = @nombreUsuario,
		contraseña = @contraseña,
		idPerfil = @idPerfil,
		idSucursal = @idSucursal,
		activo = @activo,
		nombre = @nombre, 
		domicilio = @domicilio,
		telefono = @telefono
	where idUsuario = @idUsuario
END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 = SI / 0= NO (dada de baja)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sucursal', @level2type=N'COLUMN',@level2name=N'activa'
GO
USE [master]
GO
ALTER DATABASE [No hay 2 sin 3] SET  READ_WRITE 
GO
