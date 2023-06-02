USE [master]
GO
/****** Object:  Database [SistemaEstudiantil]    Script Date: 01/06/2023 08:13:43 p. m. ******/
CREATE DATABASE [SistemaEstudiantil]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaEstudiantil1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SistemaEstudiantil1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaEstudiantil1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SistemaEstudiantil1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SistemaEstudiantil] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaEstudiantil].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaEstudiantil] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SistemaEstudiantil] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaEstudiantil] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaEstudiantil] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SistemaEstudiantil] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaEstudiantil] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaEstudiantil] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaEstudiantil] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaEstudiantil] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaEstudiantil] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaEstudiantil] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaEstudiantil] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SistemaEstudiantil] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SistemaEstudiantil] SET QUERY_STORE = ON
GO
ALTER DATABASE [SistemaEstudiantil] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [SistemaEstudiantil]
GO
/****** Object:  Table [dbo].[Asignatura]    Script Date: 01/06/2023 08:13:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignatura](
	[IdAsignatura] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
 CONSTRAINT [PK_IdAsignatura] PRIMARY KEY CLUSTERED 
(
	[IdAsignatura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AsignaturaEstudiante]    Script Date: 01/06/2023 08:13:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsignaturaEstudiante](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEstudiante] [int] NULL,
	[IdAsignatura] [int] NOT NULL,
	[Calificacion] [decimal](2, 2) NOT NULL,
 CONSTRAINT [PK_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 01/06/2023 08:13:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Matricula] [varchar](15) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Apellidos] [varchar](30) NOT NULL,
	[Edad] [int] NOT NULL,
	[Sexo] [varchar](1) NOT NULL,
	[FechaNacimiento] [date] NOT NULL,
	[Curso] [varchar](25) NOT NULL,
	[CantidadMateria] [int] NOT NULL,
	[UsuarioId] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Matricula] PRIMARY KEY CLUSTERED 
(
	[Matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 01/06/2023 08:13:43 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](30) NOT NULL,
	[Apellidos] [varchar](30) NOT NULL,
	[IdUsuario] [varchar](15) NOT NULL,
	[Contrasena] [varchar](64) NOT NULL,
	[Rol] [varchar](30) NOT NULL,
 CONSTRAINT [PK_IdUsuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Asignatura] ON 
GO
INSERT [dbo].[Asignatura] ([IdAsignatura], [Nombre]) VALUES (1, N'Historia')
GO
INSERT [dbo].[Asignatura] ([IdAsignatura], [Nombre]) VALUES (2, N'Quimica')
GO
INSERT [dbo].[Asignatura] ([IdAsignatura], [Nombre]) VALUES (3, N'Fisica')
GO
INSERT [dbo].[Asignatura] ([IdAsignatura], [Nombre]) VALUES (4, N'Matemáticas')
GO
INSERT [dbo].[Asignatura] ([IdAsignatura], [Nombre]) VALUES (5, N'Inglés')
GO
INSERT [dbo].[Asignatura] ([IdAsignatura], [Nombre]) VALUES (6, N'Español')
GO
INSERT [dbo].[Asignatura] ([IdAsignatura], [Nombre]) VALUES (7, N'Geografía')
GO
INSERT [dbo].[Asignatura] ([IdAsignatura], [Nombre]) VALUES (8, N'Biología')
GO
SET IDENTITY_INSERT [dbo].[Asignatura] OFF
GO
SET IDENTITY_INSERT [dbo].[AsignaturaEstudiante] ON 
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (7, 7, 1, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (8, 7, 2, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (9, 7, 3, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (10, 7, 4, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (11, 7, 5, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (12, 7, 6, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (13, 7, 7, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (14, 7, 8, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (16, 1007, 1, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (17, 1007, 2, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (18, 1007, 3, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (19, 1007, 4, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (20, 1007, 5, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (21, 1007, 6, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (22, 1007, 7, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (23, 1007, 8, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (24, 1007, 1, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (25, 1007, 2, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (26, 1007, 3, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (27, 1007, 4, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (28, 1007, 5, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (29, 1007, 6, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (30, 1007, 7, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (31, 1007, 8, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (38, 1006, 1, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (39, 1006, 2, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (40, 1006, 3, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (41, 1006, 4, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (42, 1006, 5, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (43, 1006, 6, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (44, 1006, 7, CAST(0.00 AS Decimal(2, 2)))
GO
INSERT [dbo].[AsignaturaEstudiante] ([Id], [IdEstudiante], [IdAsignatura], [Calificacion]) VALUES (45, 1006, 8, CAST(0.00 AS Decimal(2, 2)))
GO
SET IDENTITY_INSERT [dbo].[AsignaturaEstudiante] OFF
GO
SET IDENTITY_INSERT [dbo].[Estudiante] ON 
GO
INSERT [dbo].[Estudiante] ([Id], [Matricula], [Nombre], [Apellidos], [Edad], [Sexo], [FechaNacimiento], [Curso], [CantidadMateria], [UsuarioId]) VALUES (1007, N'1147897', N'Robert', N'mota', 25, N'M', CAST(N'1997-06-03' AS Date), N'Infotep', 8, N'elcoyote14')
GO
INSERT [dbo].[Estudiante] ([Id], [Matricula], [Nombre], [Apellidos], [Edad], [Sexo], [FechaNacimiento], [Curso], [CantidadMateria], [UsuarioId]) VALUES (7, N'1234778', N'Ranencio', N'Clausito', 125, N'M', CAST(N'1990-12-25' AS Date), N'Marco Polo', 1, N'santaclaus05')
GO
INSERT [dbo].[Estudiante] ([Id], [Matricula], [Nombre], [Apellidos], [Edad], [Sexo], [FechaNacimiento], [Curso], [CantidadMateria], [UsuarioId]) VALUES (1006, N'4567894', N'vaca', N'muerta', 23, N'M', CAST(N'1999-08-14' AS Date), N'La Granjita', 5, N'heheboy14')
GO
SET IDENTITY_INSERT [dbo].[Estudiante] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([Id], [Nombre], [Apellidos], [IdUsuario], [Contrasena], [Rol]) VALUES (1002, N'Robert', N'Mota', N'elcoyote14', N'123456', N'Administrador')
GO
INSERT [dbo].[Usuario] ([Id], [Nombre], [Apellidos], [IdUsuario], [Contrasena], [Rol]) VALUES (1, N'Responsable', N'El Irresponsable', N'heheboy14', N'hola123', N'El irresponsable')
GO
INSERT [dbo].[Usuario] ([Id], [Nombre], [Apellidos], [IdUsuario], [Contrasena], [Rol]) VALUES (2, N'Santa', N'Claus', N'santaclaus05', N'123456', N'Administrador')
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Estudian__0FB9FB4FD5A0C42E]    Script Date: 01/06/2023 08:13:43 p. m. ******/
ALTER TABLE [dbo].[Estudiante] ADD UNIQUE NONCLUSTERED 
(
	[Matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Estudiante_Id]    Script Date: 01/06/2023 08:13:43 p. m. ******/
ALTER TABLE [dbo].[Estudiante] ADD  CONSTRAINT [UQ_Estudiante_Id] UNIQUE NONCLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AsignaturaEstudiante]  WITH CHECK ADD  CONSTRAINT [FK_IdAsignatura] FOREIGN KEY([IdAsignatura])
REFERENCES [dbo].[Asignatura] ([IdAsignatura])
GO
ALTER TABLE [dbo].[AsignaturaEstudiante] CHECK CONSTRAINT [FK_IdAsignatura]
GO
ALTER TABLE [dbo].[AsignaturaEstudiante]  WITH CHECK ADD  CONSTRAINT [FK_IdEstudiante] FOREIGN KEY([IdEstudiante])
REFERENCES [dbo].[Estudiante] ([Id])
GO
ALTER TABLE [dbo].[AsignaturaEstudiante] CHECK CONSTRAINT [FK_IdEstudiante]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioId] FOREIGN KEY([UsuarioId])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_UsuarioId]
GO
USE [master]
GO
ALTER DATABASE [SistemaEstudiantil] SET  READ_WRITE 
GO
