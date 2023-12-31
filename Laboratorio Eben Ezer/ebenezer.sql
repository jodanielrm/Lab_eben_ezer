USE [master]
GO
/****** Object:  Database [LabEbenEzer]    Script Date: 18/08/2022 13:28:03 ******/
CREATE DATABASE [LabEbenEzer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LabEbenEzer', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.VIERNES\MSSQL\DATA\LabEbenEzer.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LabEbenEzer_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.VIERNES\MSSQL\DATA\LabEbenEzer_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LabEbenEzer] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LabEbenEzer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LabEbenEzer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LabEbenEzer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LabEbenEzer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LabEbenEzer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LabEbenEzer] SET ARITHABORT OFF 
GO
ALTER DATABASE [LabEbenEzer] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LabEbenEzer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LabEbenEzer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LabEbenEzer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LabEbenEzer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LabEbenEzer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LabEbenEzer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LabEbenEzer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LabEbenEzer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LabEbenEzer] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LabEbenEzer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LabEbenEzer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LabEbenEzer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LabEbenEzer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LabEbenEzer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LabEbenEzer] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LabEbenEzer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LabEbenEzer] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LabEbenEzer] SET  MULTI_USER 
GO
ALTER DATABASE [LabEbenEzer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LabEbenEzer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LabEbenEzer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LabEbenEzer] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LabEbenEzer] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LabEbenEzer] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [LabEbenEzer] SET QUERY_STORE = OFF
GO
USE [LabEbenEzer]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id_Cli] [int] NOT NULL,
	[Nom_Cli] [varchar](60) NULL,
	[Edad_Cli] [int] NULL,
	[Gen_Cli] [bit] NULL,
	[Tel_Cli] [int] NULL,
	[Dir_Cli] [varchar](500) NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id_Cli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Ver_Clientes]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Ver_Clientes]
AS
SELECT     Id_Cli AS Codigo, Nom_Cli AS Cliente, Edad_Cli AS Edad, iif(Gen_Cli = 'false', 'Masculino', 'Femenino') AS Genero, Tel_Cli as Telefono
FROM        dbo.Cliente
GO
/****** Object:  Table [dbo].[Inmunologia]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inmunologia](
	[Id_ResultadoI] [int] NOT NULL,
	[Fch_ResultadoI] [date] NULL,
	[Id_Cli] [int] NULL,
	[Id_Medico] [int] NULL,
	[IgG] [bit] NULL,
	[IgM] [bit] NULL,
	[Id_Tipo] [int] NULL,
 CONSTRAINT [PK_Inmunologia] PRIMARY KEY CLUSTERED 
(
	[Id_ResultadoI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medico]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medico](
	[Id_Medico] [int] NOT NULL,
	[Nom_Medico] [varchar](50) NULL,
	[Clini_Medico] [varchar](100) NULL,
	[Tel_Medico] [int] NULL,
 CONSTRAINT [PK_Medico] PRIMARY KEY CLUSTERED 
(
	[Id_Medico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Examen]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Examen](
	[Id_Tipo] [int] NOT NULL,
	[Nom_Exam] [varchar](70) NULL,
 CONSTRAINT [PK_Tipo_Examen] PRIMARY KEY CLUSTERED 
(
	[Id_Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Ver_Inmunologia]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Ver_Inmunologia]
AS
select i.Id_ResultadoI as Codigo, i.Fch_ResultadoI as Fecha, i.Id_Cli, c.Nom_Cli as Cliente,
		i.Id_Medico, m.Nom_Medico as Medico, i.Id_Tipo, t.Nom_Exam as Examen,  iif(i.IgG  = 'true','Positivo','Negativo') as IgG, iif(i.IgM  = 'true','Positivo','Negativo')  as IgM from Inmunologia i
		inner  join Cliente c on i.Id_Cli = c.Id_Cli
		inner join Medico m on i.Id_Medico = m.Id_Medico
		inner join Tipo_Examen t on i.Id_Tipo = t.Id_Tipo
GO
/****** Object:  View [dbo].[Ver_Medico]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Ver_Medico]
AS
SELECT     Id_Medico AS Codigo, Nom_Medico AS Medico, Clini_Medico AS Clinica, Tel_Medico AS Telefono
FROM        dbo.Medico
GO
/****** Object:  Table [dbo].[QGeneral]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QGeneral](
	[Id_ResultadoQG] [int] NOT NULL,
	[Fch_ResultadoQG] [date] NULL,
	[Id_Cli] [int] NULL,
	[Id_Medico] [int] NULL,
	[Id_Tipo] [int] NULL,
	[AU] [varchar](20) NULL,
	[CT] [varchar](20) NULL,
	[CHdl] [varchar](20) NULL,
	[CLdl] [varchar](20) NULL,
	[Creatinina] [varchar](20) NULL,
	[Glucosa] [varchar](20) NULL,
	[Urea] [varchar](20) NULL,
	[Trigliceridos] [varchar](20) NULL,
	[SGOT] [varchar](20) NULL,
	[SGPT] [varchar](20) NULL,
	[Nota] [varchar](max) NULL,
 CONSTRAINT [PK_QGeneral] PRIMARY KEY CLUSTERED 
(
	[Id_ResultadoQG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[Ver_Q_General]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Ver_Q_General]
AS
SELECT g.Id_ResultadoQG AS Codigo, g.Fch_ResultadoQG AS Fecha, g.Id_Cli, c.Nom_Cli AS Cliente, g.Id_Medico, m.Nom_Medico AS Medico, g.Id_Tipo, t.Nom_Exam AS Examen, g.AU AS Acido_Urico, g.CT AS Colesterol_Total, g.CHdl AS Hdl, 
                  g.CLdl AS Ldl, g.Creatinina, g.Glucosa, g.Urea, g.Trigliceridos, g.SGOT, g.SGPT, g.Nota
FROM     dbo.QGeneral AS g INNER JOIN
                  dbo.Cliente AS c ON g.Id_Cli = c.Id_Cli INNER JOIN
                  dbo.Medico AS m ON g.Id_Medico = m.Id_Medico INNER JOIN
                  dbo.Tipo_Examen AS t ON g.Id_Tipo = t.Id_Tipo
GO
/****** Object:  Table [dbo].[Citologia]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Citologia](
	[Id_ResultadoC] [int] NOT NULL,
	[Fch_ResultadoC] [date] NULL,
	[Id_Cli] [int] NULL,
	[Id_Medico] [int] NULL,
	[Id_Tipo] [int] NULL,
	[FchToma] [date] NULL,
	[FchRecibido] [date] NULL,
	[FchInforme] [date] NULL,
	[CFAdecuada] [varchar](20) NULL,
	[CFInadecuada] [varchar](20) NULL,
	[CFEndocervicales] [varchar](20) NULL,
	[Diagnostico] [varchar](100) NULL,
	[RI] [varchar](20) NULL,
	[Flora] [varchar](20) NULL,
	[Otros] [varchar](20) NULL,
	[Comentario] [varchar](max) NULL,
	[Observacion] [varchar](max) NULL,
	[sugerencia] [varchar](100) NULL,
 CONSTRAINT [PK_Citologia] PRIMARY KEY CLUSTERED 
(
	[Id_ResultadoC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[Ver_Citologia]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Ver_Citologia]
AS
SELECT ci.Id_ResultadoC AS Codigo, ci.Fch_ResultadoC AS Fecha, ci.Id_Cli, c.Nom_Cli AS Cliente, ci.Id_Medico, m.Nom_Medico AS Medico, ci.Id_Tipo, t.Nom_Exam AS Examen, ci.FchToma AS Fecha_Toma, ci.FchRecibido AS Fecha_Recibido, 
                  ci.FchInforme AS Fecha_Informe, ci.CFAdecuada AS Adecuada, ci.CFInadecuada AS Inadecuada, ci.CFEndocervicales AS Endocervicales, ci.Diagnostico, ci.RI, ci.Flora, ci.Otros, ci.Comentario, ci.Observacion, 
                  ci.sugerencia AS Sugerencia
FROM     dbo.Citologia AS ci INNER JOIN
                  dbo.Cliente AS c ON ci.Id_Cli = c.Id_Cli INNER JOIN
                  dbo.Medico AS m ON ci.Id_Medico = m.Id_Medico INNER JOIN
                  dbo.Tipo_Examen AS t ON ci.Id_Tipo = t.Id_Tipo
GO
/****** Object:  Table [dbo].[Serologia]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Serologia](
	[Id_ResultadoS] [int] NOT NULL,
	[Fch_ResultadoS] [date] NULL,
	[Id_Cli] [int] NULL,
	[Id_Medico] [int] NULL,
	[Id_Tipo] [int] NULL,
	[ASO] [varchar](20) NULL,
	[RPR] [varchar](20) NULL,
	[FR] [varchar](20) NULL,
	[PCR] [varchar](20) NULL,
	[VIH] [varchar](20) NULL,
	[HPS] [varchar](20) NULL,
 CONSTRAINT [PK_Serologia] PRIMARY KEY CLUSTERED 
(
	[Id_ResultadoS] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Ver_Serologia]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Ver_Serologia]
AS
SELECT s.Id_ResultadoS AS Codigo, s.Fch_ResultadoS AS Fecha, s.Id_Cli, c.Nom_Cli AS Cliente, s.Id_Medico, m.Nom_Medico AS Medico, s.Id_Tipo, t.Nom_Exam AS Examen, s.ASO AS Antiestreptolisinas, s.RPR, s.FR AS Factor_AR_Reumatoide, 
                  s.PCR AS Proteina_C_Reactiva, s.VIH AS AC_VIH, s.HPS AS Helicobacter_Pylori_en_Sangre
FROM     dbo.Serologia AS s INNER JOIN
                  dbo.Cliente AS c ON s.Id_Cli = c.Id_Cli INNER JOIN
                  dbo.Medico AS m ON s.Id_Medico = m.Id_Medico INNER JOIN
                  dbo.Tipo_Examen AS t ON s.Id_Tipo = t.Id_Tipo
GO
/****** Object:  Table [dbo].[Orina]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orina](
	[Id_ResultadoO] [int] NOT NULL,
	[Fch_ResultadoO] [date] NULL,
	[Id_Cli] [int] NULL,
	[Id_Medico] [int] NULL,
	[Id_Tipo] [int] NULL,
	[Aspecto] [varchar](20) NULL,
	[Color] [varchar](20) NULL,
	[Olor] [varchar](20) NULL,
	[Sedimento] [varchar](20) NULL,
	[Densidad] [varchar](20) NULL,
	[Glucosa] [varchar](20) NULL,
	[Bilirrubina] [varchar](20) NULL,
	[Cetonas] [varchar](20) NULL,
	[Ph] [varchar](20) NULL,
	[SO] [varchar](20) NULL,
	[Proteinas] [varchar](20) NULL,
	[Urobilinogeno] [varchar](20) NULL,
	[Nitritos] [varchar](20) NULL,
	[Leucocitos] [varchar](20) NULL,
	[CE] [varchar](20) NULL,
	[Eritrocitos] [varchar](20) NULL,
	[LeucocitosM] [varchar](20) NULL,
	[Bacterias] [varchar](20) NULL,
	[Mocus] [varchar](20) NULL,
	[Cristales] [varchar](20) NULL,
	[Cilindros] [varchar](20) NULL,
	[Comentario] [varchar](max) NULL,
 CONSTRAINT [PK_Orina] PRIMARY KEY CLUSTERED 
(
	[Id_ResultadoO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[Ver_Orina]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Ver_Orina]
AS
SELECT o.Id_ResultadoO AS Codigo, o.Fch_ResultadoO AS Fecha, o.Id_Cli, c.Nom_Cli AS Cliente, o.Id_Medico, m.Nom_Medico AS Medico, o.Id_Tipo, t.Nom_Exam AS Examen, o.Aspecto, o.Color, o.Olor, o.Sedimento, o.Densidad, o.Glucosa, 
                  o.Bilirrubina, o.Cetonas, o.Ph AS PH, o.SO AS Sangre_Oculta, o.Proteinas, o.Urobilinogeno, o.Nitritos, o.Leucocitos, o.CE AS C_Epiteliales, o.Eritrocitos, o.LeucocitosM AS LeucositosM, o.Bacterias, o.Mocus, o.Cristales, o.Cilindros, 
                  o.Comentario
FROM     dbo.Orina AS o INNER JOIN
                  dbo.Cliente AS c ON o.Id_Cli = c.Id_Cli INNER JOIN
                  dbo.Medico AS m ON o.Id_Medico = m.Id_Medico INNER JOIN
                  dbo.Tipo_Examen AS t ON o.Id_Tipo = t.Id_Tipo
GO
/****** Object:  Table [dbo].[Parasitologia]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parasitologia](
	[Id_ResultadoP] [int] NOT NULL,
	[Fch_ResultadoP] [date] NULL,
	[Id_Cli] [int] NULL,
	[Id_Medico] [int] NULL,
	[Id_Tipo] [int] NULL,
	[Color] [varchar](20) NULL,
	[Consistencia] [varchar](20) NULL,
	[Moco] [varchar](20) NULL,
	[SM] [varchar](20) NULL,
	[Trofozoitos] [varchar](20) NULL,
	[Quistes] [varchar](20) NULL,
	[Huevos] [varchar](20) NULL,
	[Larvas] [varchar](20) NULL,
	[Leucocitos] [varchar](20) NULL,
	[Eritrocitos] [varchar](20) NULL,
	[Otros] [varchar](20) NULL,
	[Nota] [varchar](max) NULL,
 CONSTRAINT [PK_Parasitologia] PRIMARY KEY CLUSTERED 
(
	[Id_ResultadoP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[Ver_Parasitologia]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Ver_Parasitologia]
AS
SELECT p.Id_ResultadoP AS Codigo, p.Fch_ResultadoP AS Fecha, p.Id_Cli, c.Nom_Cli AS Cliente, p.Id_Medico, m.Nom_Medico AS Medico, p.Id_Tipo, t.Nom_Exam AS Examen, p.Color, p.Consistencia, p.Moco, p.SM AS Sangre_Macro, p.Trofozoitos, 
                  p.Quistes, p.Huevos, p.Larvas, p.Leucocitos, p.Eritrocitos, p.Otros, p.Nota
FROM     dbo.Parasitologia AS p INNER JOIN
                  dbo.Cliente AS c ON p.Id_Cli = c.Id_Cli INNER JOIN
                  dbo.Medico AS m ON p.Id_Medico = m.Id_Medico INNER JOIN
                  dbo.Tipo_Examen AS t ON p.Id_Tipo = t.Id_Tipo
GO
/****** Object:  Table [dbo].[Diversos]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diversos](
	[Id_ResultadoD] [int] NOT NULL,
	[Fch_ResultadoD] [date] NULL,
	[Id_Cli] [int] NULL,
	[Id_Medico] [int] NULL,
	[Id_Tipo] [int] NULL,
	[ES] [varchar](120) NULL,
	[Resultado] [varchar](500) NULL,
 CONSTRAINT [PK_Diversos] PRIMARY KEY CLUSTERED 
(
	[Id_ResultadoD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Ver_Diversos]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Ver_Diversos]
AS
SELECT d.Id_ResultadoD AS Codigo, d.Fch_ResultadoD AS Fecha, d.Id_Cli, c.Nom_Cli AS Cliente, d.Id_Medico, m.Nom_Medico AS Medico, d.Id_Tipo, t.Nom_Exam AS Examen, d.ES AS Examen_Solicitado, d.Resultado
FROM     dbo.Diversos AS d INNER JOIN
                  dbo.Cliente AS c ON d.Id_Cli = c.Id_Cli INNER JOIN
                  dbo.Medico AS m ON d.Id_Medico = m.Id_Medico INNER JOIN
                  dbo.Tipo_Examen AS t ON d.Id_Tipo = t.Id_Tipo
GO
/****** Object:  Table [dbo].[Hemograma]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hemograma](
	[Id_ResultadoH] [int] NOT NULL,
	[Fch_ResultadoH] [date] NULL,
	[Id_Cli] [int] NULL,
	[Id_Medico] [int] NULL,
	[Id_Tipo] [int] NULL,
	[Wbc] [varchar](30) NULL,
	[Linfocitos] [varchar](30) NULL,
	[Granulocitos] [varchar](30) NULL,
	[Monocitos] [varchar](30) NULL,
	[Hemoglobina] [varchar](30) NULL,
	[Rbc] [varchar](30) NULL,
	[Hematocrito] [varchar](30) NULL,
	[Mcv] [varchar](30) NULL,
	[Mch] [varchar](30) NULL,
	[Mchc] [varchar](30) NULL,
	[Plaquetas] [varchar](30) NULL,
	[Comentario] [varchar](500) NULL,
 CONSTRAINT [PK_Hemograma] PRIMARY KEY CLUSTERED 
(
	[Id_ResultadoH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Ver_Hemograma]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Ver_Hemograma]
AS
SELECT        h.Id_ResultadoH AS Codigo, h.Fch_ResultadoH AS Fecha, h.Id_Cli, c.Nom_Cli AS Cliente, h.Id_Medico, m.Nom_Medico AS Medico, h.Id_Tipo, t.Nom_Exam AS Examen, h.Wbc, h.Linfocitos, h.Granulocitos AS Granulitos, 
                         h.Monocitos, h.Hemoglobina, h.Rbc, h.Hematocrito AS Hematrocito, h.Mcv, h.Mch, h.Mchc, h.Plaquetas
FROM            dbo.Hemograma AS h INNER JOIN
                         dbo.Cliente AS c ON h.Id_Cli = c.Id_Cli INNER JOIN
                         dbo.Medico AS m ON h.Id_Medico = m.Id_Medico INNER JOIN
                         dbo.Tipo_Examen AS t ON h.Id_Tipo = t.Id_Tipo
GO
INSERT [dbo].[Citologia] ([Id_ResultadoC], [Fch_ResultadoC], [Id_Cli], [Id_Medico], [Id_Tipo], [FchToma], [FchRecibido], [FchInforme], [CFAdecuada], [CFInadecuada], [CFEndocervicales], [Diagnostico], [RI], [Flora], [Otros], [Comentario], [Observacion], [sugerencia]) VALUES (1, CAST(N'2022-07-28' AS Date), 2, 1, 7, CAST(N'2022-07-19' AS Date), CAST(N'2022-07-21' AS Date), CAST(N'2022-07-23' AS Date), N'a', N'b', N'v', N'Leer Comentarios', N'Moderada', N'Gardnerella V', N'Trichomonas V', N'mmmmm', N'nnnnn', N'SE SUGIERE NUEVA VALORACIÓN A CRITERIO DEL MEDICO')
INSERT [dbo].[Citologia] ([Id_ResultadoC], [Fch_ResultadoC], [Id_Cli], [Id_Medico], [Id_Tipo], [FchToma], [FchRecibido], [FchInforme], [CFAdecuada], [CFInadecuada], [CFEndocervicales], [Diagnostico], [RI], [Flora], [Otros], [Comentario], [Observacion], [sugerencia]) VALUES (2, CAST(N'2022-07-30' AS Date), 1, 1, 7, CAST(N'2022-08-01' AS Date), CAST(N'2022-08-04' AS Date), CAST(N'2022-08-06' AS Date), N'NO UTIL', N'NO UTIL', N'UTIL', N'Leer Comentarios', N'Moderada', N'Gardnerella V', N'Trichomonas V', N'Mas mensajes largos que serviran para ver que tan largo puede quedar el mensaje, puede ser larguisimo o corto dependiendo que pueden decir del paciente', N'Este es otro mensaje largo que se deja al criterio de la persona porque es necesario ver que tanto puede alcanzar la extension del mensaje para guardarlo en el sistema', N'SE SUGIERE NUEVA VALORACIÓN A CRITERIO DEL MEDICO')
INSERT [dbo].[Citologia] ([Id_ResultadoC], [Fch_ResultadoC], [Id_Cli], [Id_Medico], [Id_Tipo], [FchToma], [FchRecibido], [FchInforme], [CFAdecuada], [CFInadecuada], [CFEndocervicales], [Diagnostico], [RI], [Flora], [Otros], [Comentario], [Observacion], [sugerencia]) VALUES (3, CAST(N'2022-08-05' AS Date), 2, 1, 7, CAST(N'2022-07-13' AS Date), CAST(N'2022-07-13' AS Date), CAST(N'2022-07-13' AS Date), N'', N'', N'', N'Leer Comentarios', N'Leve', N'Cocoide', N'Candida A.', N'', N'', N'SE SUGIERE NUEVA VALORACIÓN A CRITERIO DEL MEDICO')
GO
INSERT [dbo].[Cliente] ([Id_Cli], [Nom_Cli], [Edad_Cli], [Gen_Cli], [Tel_Cli], [Dir_Cli]) VALUES (1, N'Carlos Adan Cruz', 29, 0, 88236963, N'Danli, El Paraiso, Honduras')
INSERT [dbo].[Cliente] ([Id_Cli], [Nom_Cli], [Edad_Cli], [Gen_Cli], [Tel_Cli], [Dir_Cli]) VALUES (2, N'Luisa Sosa', 25, 1, 33423456, N'Colonia Los Arcos, Danli, El Paraiso')
INSERT [dbo].[Cliente] ([Id_Cli], [Nom_Cli], [Edad_Cli], [Gen_Cli], [Tel_Cli], [Dir_Cli]) VALUES (3, N'Marissa Gamero', 30, 1, 98936163, N'Bo La Reforma Danli El Paraiso, una cuadra arriba del triangulo.')
GO
INSERT [dbo].[Diversos] ([Id_ResultadoD], [Fch_ResultadoD], [Id_Cli], [Id_Medico], [Id_Tipo], [ES], [Resultado]) VALUES (1, CAST(N'2022-07-29' AS Date), 2, 1, 11, N'Helicobacter en Sangre', N'Positivo')
GO
INSERT [dbo].[Hemograma] ([Id_ResultadoH], [Fch_ResultadoH], [Id_Cli], [Id_Medico], [Id_Tipo], [Wbc], [Linfocitos], [Granulocitos], [Monocitos], [Hemoglobina], [Rbc], [Hematocrito], [Mcv], [Mch], [Mchc], [Plaquetas], [Comentario]) VALUES (5, CAST(N'2022-08-18' AS Date), 1, 2, 12, N'5 %', N'20 %', N'50 %', N'5 %', N'12 g/dl', N'4 10*/1', N'40 %', N'90 fl', N'30 pg', N'32 g/dl', N'200 10*/1', N'Nada que comentar')
GO
INSERT [dbo].[Inmunologia] ([Id_ResultadoI], [Fch_ResultadoI], [Id_Cli], [Id_Medico], [IgG], [IgM], [Id_Tipo]) VALUES (1, CAST(N'2022-07-28' AS Date), 3, 1, 1, 1, 2)
INSERT [dbo].[Inmunologia] ([Id_ResultadoI], [Fch_ResultadoI], [Id_Cli], [Id_Medico], [IgG], [IgM], [Id_Tipo]) VALUES (2, CAST(N'2022-07-30' AS Date), 1, 1, 0, 0, 6)
INSERT [dbo].[Inmunologia] ([Id_ResultadoI], [Fch_ResultadoI], [Id_Cli], [Id_Medico], [IgG], [IgM], [Id_Tipo]) VALUES (3, CAST(N'2022-07-30' AS Date), 1, 1, 0, 0, 6)
INSERT [dbo].[Inmunologia] ([Id_ResultadoI], [Fch_ResultadoI], [Id_Cli], [Id_Medico], [IgG], [IgM], [Id_Tipo]) VALUES (4, CAST(N'2022-07-30' AS Date), 1, 1, 0, 0, 5)
INSERT [dbo].[Inmunologia] ([Id_ResultadoI], [Fch_ResultadoI], [Id_Cli], [Id_Medico], [IgG], [IgM], [Id_Tipo]) VALUES (5, CAST(N'2022-07-30' AS Date), 3, 1, 1, 1, 6)
INSERT [dbo].[Inmunologia] ([Id_ResultadoI], [Fch_ResultadoI], [Id_Cli], [Id_Medico], [IgG], [IgM], [Id_Tipo]) VALUES (6, CAST(N'2022-08-05' AS Date), 3, 1, 0, 0, 6)
GO
INSERT [dbo].[Medico] ([Id_Medico], [Nom_Medico], [Clini_Medico], [Tel_Medico]) VALUES (0, NULL, NULL, NULL)
INSERT [dbo].[Medico] ([Id_Medico], [Nom_Medico], [Clini_Medico], [Tel_Medico]) VALUES (1, N'Cadan Crz', N'La Reforma', 88236963)
INSERT [dbo].[Medico] ([Id_Medico], [Nom_Medico], [Clini_Medico], [Tel_Medico]) VALUES (2, N'Adan Nuñez', N'Danli', 22356874)
GO
INSERT [dbo].[Orina] ([Id_ResultadoO], [Fch_ResultadoO], [Id_Cli], [Id_Medico], [Id_Tipo], [Aspecto], [Color], [Olor], [Sedimento], [Densidad], [Glucosa], [Bilirrubina], [Cetonas], [Ph], [SO], [Proteinas], [Urobilinogeno], [Nitritos], [Leucocitos], [CE], [Eritrocitos], [LeucocitosM], [Bacterias], [Mocus], [Cristales], [Cilindros], [Comentario]) VALUES (1, CAST(N'2022-07-29' AS Date), 2, 1, 9, N'TRANSPARENTE', N'AMARILLO OBSCURO', N'SUIGENERIS', N'ABUNDANTE', N'aaa', N'bbb', N'ccc', N'ddd', N'eee', N'fff', N'ggg', N'hhh', N'iii', N'jjj', N'111', N'222', N'333', N'ABUNDANTES', N'MODERADO', N'444', N'5555', N'asdasdsdfgfdsgdfsg')
GO
INSERT [dbo].[Parasitologia] ([Id_ResultadoP], [Fch_ResultadoP], [Id_Cli], [Id_Medico], [Id_Tipo], [Color], [Consistencia], [Moco], [SM], [Trofozoitos], [Quistes], [Huevos], [Larvas], [Leucocitos], [Eritrocitos], [Otros], [Nota]) VALUES (1, CAST(N'2022-07-29' AS Date), 2, 1, 10, N'LIGERO TURBIO', N'AMARILLO OBSCURO', N'SUIGENERIS', N'MODERADO', N'aaa', N'bbb', N'ccc', N'ABUNDANTES', N'MODERADO', N'dddd', N'aasdfasfdasdfasdf', N'zxcvzxcvzxvczxcv')
GO
INSERT [dbo].[QGeneral] ([Id_ResultadoQG], [Fch_ResultadoQG], [Id_Cli], [Id_Medico], [Id_Tipo], [AU], [CT], [CHdl], [CLdl], [Creatinina], [Glucosa], [Urea], [Trigliceridos], [SGOT], [SGPT], [Nota]) VALUES (1, CAST(N'2022-07-28' AS Date), 1, 1, 1, N'5 mg/dl', N'250 mg/dl', N'50 mg/dl', N'150 mg/dl', N'1 mg/dl', N'100 mg/dl', N'20 mg/dl', N'200 mg/dl', N'20 U/L', N'20 U/L', N'aaabbb')
INSERT [dbo].[QGeneral] ([Id_ResultadoQG], [Fch_ResultadoQG], [Id_Cli], [Id_Medico], [Id_Tipo], [AU], [CT], [CHdl], [CLdl], [Creatinina], [Glucosa], [Urea], [Trigliceridos], [SGOT], [SGPT], [Nota]) VALUES (2, CAST(N'2022-07-28' AS Date), 2, 1, 1, N'3 mg/dl', N'250 mg/dl', N'55 mg/dl', N'200 mg/dl', N'1 mg/dl', N'100 mg/dl', N'25 mg/dl', N'200 mg/dl', N'20 U/L', N'10 U/L', N'zzzzz')
INSERT [dbo].[QGeneral] ([Id_ResultadoQG], [Fch_ResultadoQG], [Id_Cli], [Id_Medico], [Id_Tipo], [AU], [CT], [CHdl], [CLdl], [Creatinina], [Glucosa], [Urea], [Trigliceridos], [SGOT], [SGPT], [Nota]) VALUES (3, CAST(N'2022-07-30' AS Date), 1, 1, 1, N'4.0 mg/dl', N'300 mg/dl', N'50 mg/dl', N'150 mg/dl', N'1.0 mg/dl', N'90 mg/dl', N'40 mg/dl', N'200 mg/dl', N'4 U/L', N'20 U/L', N'mmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmm')
INSERT [dbo].[QGeneral] ([Id_ResultadoQG], [Fch_ResultadoQG], [Id_Cli], [Id_Medico], [Id_Tipo], [AU], [CT], [CHdl], [CLdl], [Creatinina], [Glucosa], [Urea], [Trigliceridos], [SGOT], [SGPT], [Nota]) VALUES (4, CAST(N'2022-07-30' AS Date), 3, 1, 1, N'5 mg/dl', N'500 mg/dl', N'55 mg/dl', N'200 mg/dl', N'1.0 mg/dl', N'100 mg/dl', N'20 mg/dl', N'200 mg/dl', N'20 U/L', N'30 U/L', N'Mensaje predeterminado para ver el tamaño del mensaje que se puede mostrar en este espacio, abc, 1234, mensaje completo para una extension amplia.')
INSERT [dbo].[QGeneral] ([Id_ResultadoQG], [Fch_ResultadoQG], [Id_Cli], [Id_Medico], [Id_Tipo], [AU], [CT], [CHdl], [CLdl], [Creatinina], [Glucosa], [Urea], [Trigliceridos], [SGOT], [SGPT], [Nota]) VALUES (5, CAST(N'2022-08-18' AS Date), 3, 0, 1, N'1 mg/dl', N'150 mg/dl', N'40 mg/dl', N'100 mg/dl', N'1.0 mg/dl', N'60 mg/dl', N'10 mg/dl', N'200 mg/dl', N'45 U/L', N'35 U/L', N'Mensaaaaaaajeeeeee')
GO
INSERT [dbo].[Serologia] ([Id_ResultadoS], [Fch_ResultadoS], [Id_Cli], [Id_Medico], [Id_Tipo], [ASO], [RPR], [FR], [PCR], [VIH], [HPS]) VALUES (1, CAST(N'2022-07-29' AS Date), 1, 1, 8, N'500', N'200', N'456', N'500', N'280', N'100')
INSERT [dbo].[Serologia] ([Id_ResultadoS], [Fch_ResultadoS], [Id_Cli], [Id_Medico], [Id_Tipo], [ASO], [RPR], [FR], [PCR], [VIH], [HPS]) VALUES (2, CAST(N'2022-08-18' AS Date), 2, 0, 8, N'255', N'400', N'152', N'345', N'0', N'124')
GO
INSERT [dbo].[Tipo_Examen] ([Id_Tipo], [Nom_Exam]) VALUES (1, N'QUIMICO GENERAL')
INSERT [dbo].[Tipo_Examen] ([Id_Tipo], [Nom_Exam]) VALUES (2, N'AC. CHAGAS')
INSERT [dbo].[Tipo_Examen] ([Id_Tipo], [Nom_Exam]) VALUES (3, N'AC. HEPATITIS ''A''')
INSERT [dbo].[Tipo_Examen] ([Id_Tipo], [Nom_Exam]) VALUES (4, N'AC. HEPATITIS ''B''')
INSERT [dbo].[Tipo_Examen] ([Id_Tipo], [Nom_Exam]) VALUES (5, N'AC. HEPATITIS ''C''')
INSERT [dbo].[Tipo_Examen] ([Id_Tipo], [Nom_Exam]) VALUES (6, N'TOXOPLASMOSIS')
INSERT [dbo].[Tipo_Examen] ([Id_Tipo], [Nom_Exam]) VALUES (7, N'INFORME DE CITOLOGIA CERVICO UTERINO')
INSERT [dbo].[Tipo_Examen] ([Id_Tipo], [Nom_Exam]) VALUES (8, N'SEROLOGIA')
INSERT [dbo].[Tipo_Examen] ([Id_Tipo], [Nom_Exam]) VALUES (9, N'ORINA')
INSERT [dbo].[Tipo_Examen] ([Id_Tipo], [Nom_Exam]) VALUES (10, N'PARASITOLOGIA')
INSERT [dbo].[Tipo_Examen] ([Id_Tipo], [Nom_Exam]) VALUES (11, N'DIVERSOS')
INSERT [dbo].[Tipo_Examen] ([Id_Tipo], [Nom_Exam]) VALUES (12, N'HEMOGRAMA')
GO
ALTER TABLE [dbo].[Citologia]  WITH CHECK ADD  CONSTRAINT [FK_Citologia_Cliente] FOREIGN KEY([Id_Cli])
REFERENCES [dbo].[Cliente] ([Id_Cli])
GO
ALTER TABLE [dbo].[Citologia] CHECK CONSTRAINT [FK_Citologia_Cliente]
GO
ALTER TABLE [dbo].[Citologia]  WITH CHECK ADD  CONSTRAINT [FK_Citologia_Medico] FOREIGN KEY([Id_Medico])
REFERENCES [dbo].[Medico] ([Id_Medico])
GO
ALTER TABLE [dbo].[Citologia] CHECK CONSTRAINT [FK_Citologia_Medico]
GO
ALTER TABLE [dbo].[Citologia]  WITH CHECK ADD  CONSTRAINT [FK_Citologia_Tipo_Examen] FOREIGN KEY([Id_Tipo])
REFERENCES [dbo].[Tipo_Examen] ([Id_Tipo])
GO
ALTER TABLE [dbo].[Citologia] CHECK CONSTRAINT [FK_Citologia_Tipo_Examen]
GO
ALTER TABLE [dbo].[Diversos]  WITH CHECK ADD  CONSTRAINT [FK_Diversos_Cliente] FOREIGN KEY([Id_Cli])
REFERENCES [dbo].[Cliente] ([Id_Cli])
GO
ALTER TABLE [dbo].[Diversos] CHECK CONSTRAINT [FK_Diversos_Cliente]
GO
ALTER TABLE [dbo].[Diversos]  WITH CHECK ADD  CONSTRAINT [FK_Diversos_Medico] FOREIGN KEY([Id_Medico])
REFERENCES [dbo].[Medico] ([Id_Medico])
GO
ALTER TABLE [dbo].[Diversos] CHECK CONSTRAINT [FK_Diversos_Medico]
GO
ALTER TABLE [dbo].[Diversos]  WITH CHECK ADD  CONSTRAINT [FK_Diversos_Tipo_Examen] FOREIGN KEY([Id_Tipo])
REFERENCES [dbo].[Tipo_Examen] ([Id_Tipo])
GO
ALTER TABLE [dbo].[Diversos] CHECK CONSTRAINT [FK_Diversos_Tipo_Examen]
GO
ALTER TABLE [dbo].[Hemograma]  WITH CHECK ADD  CONSTRAINT [FK_Hemograma_Cliente] FOREIGN KEY([Id_Cli])
REFERENCES [dbo].[Cliente] ([Id_Cli])
GO
ALTER TABLE [dbo].[Hemograma] CHECK CONSTRAINT [FK_Hemograma_Cliente]
GO
ALTER TABLE [dbo].[Hemograma]  WITH CHECK ADD  CONSTRAINT [FK_Hemograma_Medico] FOREIGN KEY([Id_Medico])
REFERENCES [dbo].[Medico] ([Id_Medico])
GO
ALTER TABLE [dbo].[Hemograma] CHECK CONSTRAINT [FK_Hemograma_Medico]
GO
ALTER TABLE [dbo].[Hemograma]  WITH CHECK ADD  CONSTRAINT [FK_Hemograma_Tipo_Examen] FOREIGN KEY([Id_Tipo])
REFERENCES [dbo].[Tipo_Examen] ([Id_Tipo])
GO
ALTER TABLE [dbo].[Hemograma] CHECK CONSTRAINT [FK_Hemograma_Tipo_Examen]
GO
ALTER TABLE [dbo].[Inmunologia]  WITH CHECK ADD  CONSTRAINT [FK_Inmunologia_Cliente] FOREIGN KEY([Id_Cli])
REFERENCES [dbo].[Cliente] ([Id_Cli])
GO
ALTER TABLE [dbo].[Inmunologia] CHECK CONSTRAINT [FK_Inmunologia_Cliente]
GO
ALTER TABLE [dbo].[Inmunologia]  WITH CHECK ADD  CONSTRAINT [FK_Inmunologia_Medico] FOREIGN KEY([Id_Medico])
REFERENCES [dbo].[Medico] ([Id_Medico])
GO
ALTER TABLE [dbo].[Inmunologia] CHECK CONSTRAINT [FK_Inmunologia_Medico]
GO
ALTER TABLE [dbo].[Inmunologia]  WITH CHECK ADD  CONSTRAINT [FK_Inmunologia_Tipo_Examen] FOREIGN KEY([Id_Tipo])
REFERENCES [dbo].[Tipo_Examen] ([Id_Tipo])
GO
ALTER TABLE [dbo].[Inmunologia] CHECK CONSTRAINT [FK_Inmunologia_Tipo_Examen]
GO
ALTER TABLE [dbo].[Orina]  WITH CHECK ADD  CONSTRAINT [FK_Orina_Cliente] FOREIGN KEY([Id_Cli])
REFERENCES [dbo].[Cliente] ([Id_Cli])
GO
ALTER TABLE [dbo].[Orina] CHECK CONSTRAINT [FK_Orina_Cliente]
GO
ALTER TABLE [dbo].[Orina]  WITH CHECK ADD  CONSTRAINT [FK_Orina_Medico] FOREIGN KEY([Id_Medico])
REFERENCES [dbo].[Medico] ([Id_Medico])
GO
ALTER TABLE [dbo].[Orina] CHECK CONSTRAINT [FK_Orina_Medico]
GO
ALTER TABLE [dbo].[Orina]  WITH CHECK ADD  CONSTRAINT [FK_Orina_Tipo_Examen] FOREIGN KEY([Id_Tipo])
REFERENCES [dbo].[Tipo_Examen] ([Id_Tipo])
GO
ALTER TABLE [dbo].[Orina] CHECK CONSTRAINT [FK_Orina_Tipo_Examen]
GO
ALTER TABLE [dbo].[Parasitologia]  WITH CHECK ADD  CONSTRAINT [FK_Parasitologia_Cliente] FOREIGN KEY([Id_Cli])
REFERENCES [dbo].[Cliente] ([Id_Cli])
GO
ALTER TABLE [dbo].[Parasitologia] CHECK CONSTRAINT [FK_Parasitologia_Cliente]
GO
ALTER TABLE [dbo].[Parasitologia]  WITH CHECK ADD  CONSTRAINT [FK_Parasitologia_Medico] FOREIGN KEY([Id_Medico])
REFERENCES [dbo].[Medico] ([Id_Medico])
GO
ALTER TABLE [dbo].[Parasitologia] CHECK CONSTRAINT [FK_Parasitologia_Medico]
GO
ALTER TABLE [dbo].[Parasitologia]  WITH CHECK ADD  CONSTRAINT [FK_Parasitologia_Tipo_Examen] FOREIGN KEY([Id_Tipo])
REFERENCES [dbo].[Tipo_Examen] ([Id_Tipo])
GO
ALTER TABLE [dbo].[Parasitologia] CHECK CONSTRAINT [FK_Parasitologia_Tipo_Examen]
GO
ALTER TABLE [dbo].[QGeneral]  WITH CHECK ADD  CONSTRAINT [FK_QGeneral_Cliente] FOREIGN KEY([Id_Cli])
REFERENCES [dbo].[Cliente] ([Id_Cli])
GO
ALTER TABLE [dbo].[QGeneral] CHECK CONSTRAINT [FK_QGeneral_Cliente]
GO
ALTER TABLE [dbo].[QGeneral]  WITH CHECK ADD  CONSTRAINT [FK_QGeneral_Medico] FOREIGN KEY([Id_Medico])
REFERENCES [dbo].[Medico] ([Id_Medico])
GO
ALTER TABLE [dbo].[QGeneral] CHECK CONSTRAINT [FK_QGeneral_Medico]
GO
ALTER TABLE [dbo].[QGeneral]  WITH CHECK ADD  CONSTRAINT [FK_QGeneral_Tipo_Examen] FOREIGN KEY([Id_Tipo])
REFERENCES [dbo].[Tipo_Examen] ([Id_Tipo])
GO
ALTER TABLE [dbo].[QGeneral] CHECK CONSTRAINT [FK_QGeneral_Tipo_Examen]
GO
ALTER TABLE [dbo].[Serologia]  WITH CHECK ADD  CONSTRAINT [FK_Serologia_Cliente] FOREIGN KEY([Id_Cli])
REFERENCES [dbo].[Cliente] ([Id_Cli])
GO
ALTER TABLE [dbo].[Serologia] CHECK CONSTRAINT [FK_Serologia_Cliente]
GO
ALTER TABLE [dbo].[Serologia]  WITH CHECK ADD  CONSTRAINT [FK_Serologia_Medico] FOREIGN KEY([Id_Medico])
REFERENCES [dbo].[Medico] ([Id_Medico])
GO
ALTER TABLE [dbo].[Serologia] CHECK CONSTRAINT [FK_Serologia_Medico]
GO
ALTER TABLE [dbo].[Serologia]  WITH CHECK ADD  CONSTRAINT [FK_Serologia_Tipo_Examen] FOREIGN KEY([Id_Tipo])
REFERENCES [dbo].[Tipo_Examen] ([Id_Tipo])
GO
ALTER TABLE [dbo].[Serologia] CHECK CONSTRAINT [FK_Serologia_Tipo_Examen]
GO
/****** Object:  StoredProcedure [dbo].[BusquedaExamen]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BusquedaExamen]
	-- Add the parameters for the stored procedure here
	
	@tipo int
AS
BEGIN
	
	if @tipo = 1
		select * from Ver_Q_General
	else if @tipo in (2,3,4,5,6)
		select * from Ver_Inmunologia where Id_Tipo = @tipo
	else if @tipo =7
		select * from Ver_Citologia
	else if @tipo =8
		select * from Ver_Serologia
	else if @tipo =9
		select * from Ver_Orina
	else if @tipo =10
		select * from Ver_Parasitologia
	else if @tipo =11
		select * from Ver_Diversos
	else if @tipo =12
		select * from Ver_Hemograma
END
GO
/****** Object:  StoredProcedure [dbo].[VerCitologia]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VerCitologia]
	-- Add the parameters for the stored procedure here
	@id int
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select ci.Id_ResultadoC as Id, ci.Fch_ResultadoC as Fecha, c.Nom_Cli as Cliente, iif(c.Gen_Cli  = 'true','Femenino','Masculino') as Genero,
	c.Edad_Cli as Edad, c.Dir_Cli as Direccion, m.Nom_Medico, te.Nom_Exam, 
	ci.FchToma as FechaToma, FchRecibido as FechaRecibo, FchInforme as FechaInforme,
	ci.CFAdecuada as Adecuada, ci.CFInadecuada as Inadecuada, ci.CFEndocervicales as Endocervicales,
	ci.Diagnostico as Negativo, ci.RI as ReaccionInflamatoria, ci.Flora as Flora, ci.Otros as Otros, 
	ci.Comentario as Comentario, ci.Observacion as Observacion, ci.sugerencia as Sugerencia
	from Citologia ci  inner join Cliente c on ci.Id_Cli = c.Id_Cli
	inner join Medico m on ci.Id_Medico = m.Id_Medico
	inner join Tipo_Examen te on te.Id_Tipo = ci.Id_Tipo
	where ci.Id_ResultadoC = @id
END
GO
/****** Object:  StoredProcedure [dbo].[VerDiversos]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[VerDiversos]
	-- Add the parameters for the stored procedure here
	@id int
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select d.Id_Resultadod as Id, d.Fch_Resultadod as Fecha, c.Nom_Cli as Cliente, iif(c.Gen_Cli  = 'true','Femenino','Masculino') as Genero,
	c.Edad_Cli as Edad, m.Nom_Medico, te.Nom_Exam, 
	d.ES as ExamenSolicitado, d.Resultado as Resultado
	from Diversos d inner join Cliente c on d.Id_Cli = c.Id_Cli
	inner join Medico m on d.Id_Medico = m.Id_Medico
	inner join Tipo_Examen te on te.Id_Tipo = d.Id_Tipo
	where d.Id_Resultadod = @id
END
GO
/****** Object:  StoredProcedure [dbo].[VerHemograma]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VerHemograma]
	-- Add the parameters for the stored procedure here
	@id int
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select h.Id_Resultadoh as Id, h.Fch_Resultadoh as Fecha, c.Nom_Cli as Cliente, iif(c.Gen_Cli  = 'true','Femenino','Masculino') as Genero,
	c.Edad_Cli as Edad, m.Nom_Medico,h.Wbc, h.Linfocitos, h.Granulocitos AS Granulitos, 
                         h.Monocitos, h.Hemoglobina, h.Rbc, h.Hematocrito AS Hematrocito, h.Mcv, h.Mch, h.Mchc, h.Plaquetas, h.Comentario
FROM            dbo.Hemograma AS h INNER JOIN
                         dbo.Cliente AS c ON h.Id_Cli = c.Id_Cli INNER JOIN
                         dbo.Medico AS m ON h.Id_Medico = m.Id_Medico INNER JOIN
                         dbo.Tipo_Examen AS t ON h.Id_Tipo = t.Id_Tipo
						 where h.Id_Resultadoh = @id
END
GO
/****** Object:  StoredProcedure [dbo].[VerInmunologia]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VerInmunologia]
	-- Add the parameters for the stored procedure here
	@id int
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select i.Id_ResultadoI as Id, i.Fch_ResultadoI as Fecha, c.Nom_Cli as Cliente, iif(c.Gen_Cli  = 'true','Femenino','Masculino') as Genero,
	c.Edad_Cli as Edad, m.Nom_Medico, te.Nom_Exam, iif(i.IgG  = 'true','Positivo','Negativo') as IgG, iif(i.IgM  = 'true','Positivo','Negativo')  as IgM
	from Inmunologia i  inner join Cliente c on i.Id_Cli = c.Id_Cli
	inner join Medico m on i.Id_Medico = m.Id_Medico
	inner join Tipo_Examen te on te.Id_Tipo = i.Id_Tipo
	where i.Id_ResultadoI = @id
END
GO
/****** Object:  StoredProcedure [dbo].[VerOrina]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[VerOrina]
	-- Add the parameters for the stored procedure here
	@id int
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select o.Id_Resultadoo as Id, o.Fch_Resultadoo as Fecha, c.Nom_Cli as Cliente, iif(c.Gen_Cli  = 'true','Femenino','Masculino') as Genero,
	c.Edad_Cli as Edad, m.Nom_Medico, te.Nom_Exam, 
	o.Aspecto as Aspecto, o.Color as Color, o.Olor as Olor, o.Sedimento as Sedimento,
	o.Densidad as Densidad, o.Glucosa as Glucosa, o.Bilirrubina as Bilirrubina, o.Cetonas as Cetonas,
	o.Ph as PH, o.SO as SangreOculta, o.Proteinas as Proteinas, o.Urobilinogeno as Urobilinogeno,
	o.Nitritos as Nitritos, o.Leucocitos as Leucocitos, o.CE as CEpiteliales, o.Eritrocitos as Eritrocitos,
	o.LeucocitosM as LeucocitosM, o.Bacterias as Bacterias, o.Mocus as Mocus, o.Cristales as Cristales,
	o.Cilindros as Cilindros, o.Comentario as Comentario
	from Orina o  inner join Cliente c on o.Id_Cli = c.Id_Cli
	inner join Medico m on o.Id_Medico = m.Id_Medico
	inner join Tipo_Examen te on te.Id_Tipo = o.Id_Tipo
	where o.Id_ResultadoO = @id
END
GO
/****** Object:  StoredProcedure [dbo].[VerParasitologia]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[VerParasitologia]
	-- Add the parameters for the stored procedure here
	@id int
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select p.Id_Resultadop as Id, p.Fch_Resultadop as Fecha, c.Nom_Cli as Cliente, iif(c.Gen_Cli  = 'true','Femenino','Masculino') as Genero,
	c.Edad_Cli as Edad, m.Nom_Medico, te.Nom_Exam, 
	p.Color as Color, p.Consistencia as Consistencia, p.Moco as Moco, p.SM as SangreMacro,
	p.Trofozoitos as Trofozoitos, p.Quistes as Quistes, p.Huevos as Huevos, 
	p.Larvas as Larvas, p.Leucocitos as Leucocitos, p.Eritrocitos as Eritrocitos, p.Otros as Otros,
	p.Nota as Nota
	from Parasitologia p  inner join Cliente c on p.Id_Cli = c.Id_Cli
	inner join Medico m on p.Id_Medico = m.Id_Medico
	inner join Tipo_Examen te on te.Id_Tipo = p.Id_Tipo
	where p.Id_Resultadop = @id
END
GO
/****** Object:  StoredProcedure [dbo].[VerQuimicaGeneral]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VerQuimicaGeneral]
	-- Add the parameters for the stored procedure here
	@id int
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select qg.Id_ResultadoQG as Id, Fch_ResultadoQG as Fecha, c.Nom_Cli as Cliente, iif(c.Gen_Cli  = 'true','Femenino','Masculino') as Genero,
	c.Edad_Cli as Edad, m.Nom_Medico, qg.AU as AcidoUrico, qg.CT as ColesterolTotal,
	qg.CHdl as ColesterolHDL, qg.CLdl as ColesterolLDL, qg.Creatinina as Creatinina, 
	qg.Glucosa as Glucosa, qg.Urea as Urea, qg.Trigliceridos as Trigliceridos, qg.SGOT as SGOT,
	qg.SGPT as SGPT, qg.Nota as Nota
	from QGeneral qg inner join Cliente c on qg.Id_Cli = c.Id_Cli
	inner join Medico m on qg.Id_Medico = m.Id_Medico
	inner join Tipo_Examen te on te.Id_Tipo = qg.Id_Tipo
	where qg.Id_ResultadoQG = @id
END
GO
/****** Object:  StoredProcedure [dbo].[VerSerologia]    Script Date: 18/08/2022 13:28:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VerSerologia]
	-- Add the parameters for the stored procedure here
	@id int
	AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	select s.Id_ResultadoS as Id, s.Fch_ResultadoS as Fecha, c.Nom_Cli as Cliente, iif(c.Gen_Cli  = 'true','Femenino','Masculino') as Genero,
	c.Edad_Cli as Edad, m.Nom_Medico, te.Nom_Exam, 
	s.ASO as Antiestreptolisinas, s.RPR as RPR, s.FR as FactorReumatoide, s.PCR as PCR,
	s.VIH as VIH, s.HPS as Helicobacter
	from Serologia s  inner join Cliente c on s.Id_Cli = c.Id_Cli
	inner join Medico m on s.Id_Medico = m.Id_Medico
	inner join Tipo_Examen te on te.Id_Tipo = s.Id_Tipo
	where s.Id_ResultadoS = @id
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ci"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 257
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 7
               Left = 305
               Bottom = 170
               Right = 499
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "m"
            Begin Extent = 
               Top = 7
               Left = 547
               Bottom = 170
               Right = 741
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t"
            Begin Extent = 
               Top = 7
               Left = 789
               Bottom = 126
               Right = 983
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Citologia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Citologia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Clientes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Clientes'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "d"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 7
               Left = 296
               Bottom = 170
               Right = 490
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "m"
            Begin Extent = 
               Top = 7
               Left = 538
               Bottom = 170
               Right = 732
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t"
            Begin Extent = 
               Top = 7
               Left = 780
               Bottom = 126
               Right = 974
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Diversos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Diversos'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "h"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 6
               Left = 250
               Bottom = 136
               Right = 420
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "m"
            Begin Extent = 
               Top = 6
               Left = 458
               Bottom = 136
               Right = 628
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t"
            Begin Extent = 
               Top = 6
               Left = 666
               Bottom = 102
               Right = 836
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Hemograma'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Hemograma'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Inmunologia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Inmunologia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Medico"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Medico'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Medico'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "o"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 7
               Left = 296
               Bottom = 170
               Right = 490
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "m"
            Begin Extent = 
               Top = 7
               Left = 538
               Bottom = 170
               Right = 732
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t"
            Begin Extent = 
               Top = 7
               Left = 780
               Bottom = 126
               Right = 974
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Orina'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Orina'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "p"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 245
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 7
               Left = 293
               Bottom = 170
               Right = 487
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "m"
            Begin Extent = 
               Top = 7
               Left = 535
               Bottom = 170
               Right = 729
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t"
            Begin Extent = 
               Top = 7
               Left = 777
               Bottom = 126
               Right = 971
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   En' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Parasitologia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'd
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Parasitologia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Parasitologia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "g"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 258
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 7
               Left = 306
               Bottom = 232
               Right = 500
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "m"
            Begin Extent = 
               Top = 7
               Left = 548
               Bottom = 170
               Right = 742
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t"
            Begin Extent = 
               Top = 7
               Left = 790
               Bottom = 126
               Right = 984
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 20
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Q_General'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Q_General'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Q_General'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "s"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 245
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "c"
            Begin Extent = 
               Top = 7
               Left = 293
               Bottom = 170
               Right = 487
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "m"
            Begin Extent = 
               Top = 7
               Left = 535
               Bottom = 170
               Right = 729
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "t"
            Begin Extent = 
               Top = 7
               Left = 777
               Bottom = 126
               Right = 971
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Serologia'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Ver_Serologia'
GO
USE [master]
GO
ALTER DATABASE [LabEbenEzer] SET  READ_WRITE 
GO
