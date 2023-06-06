USE [master]
GO
/****** Object:  Database [SistemaEstudiantil]    Script Date: 5/6/2023 11:12:53 p. m. ******/
CREATE DATABASE [SistemaEstudiantil]
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
/****** Object:  Table [dbo].[Asignatura]    Script Date: 5/6/2023 11:12:53 p. m. ******/
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
/****** Object:  Table [dbo].[AsignaturaEstudiante]    Script Date: 5/6/2023 11:12:53 p. m. ******/
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
/****** Object:  Table [dbo].[Estudiante]    Script Date: 5/6/2023 11:12:53 p. m. ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 5/6/2023 11:12:53 p. m. ******/
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
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([Id], [Nombre], [Apellidos], [IdUsuario], [Contrasena], [Rol]) VALUES (1, N'Anthony', N'Sanchez', N'asanchez', N'123456', N'Administrador')
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Estudian__0FB9FB4F678E37DE]    Script Date: 5/6/2023 11:12:53 p. m. ******/
ALTER TABLE [dbo].[Estudiante] ADD UNIQUE NONCLUSTERED 
(
	[Matricula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ_Estudiante_Id]    Script Date: 5/6/2023 11:12:53 p. m. ******/
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
