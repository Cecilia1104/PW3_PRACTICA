USE [Prueba]
GO
/****** Object:  Table [dbo].[Seleccion]    Script Date: 10/24/2013 00:39:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seleccion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Seleccion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tecnico]    Script Date: 10/24/2013 00:39:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tecnico](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NULL,
	[idseleccion] [int] NOT NULL,
 CONSTRAINT [PK_Tecnico] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jugador]    Script Date: 10/24/2013 00:39:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jugador](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NULL,
	[apellido] [nvarchar](50) NULL,
	[idseleccion] [int] NOT NULL,
	[edad] [int] NULL,
 CONSTRAINT [PK_Jugador] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK__Jugador__idselec__0CBAE877]    Script Date: 10/24/2013 00:39:45 ******/
ALTER TABLE [dbo].[Jugador]  WITH CHECK ADD  CONSTRAINT [FK__Jugador__idselec__0CBAE877] FOREIGN KEY([idseleccion])
REFERENCES [dbo].[Seleccion] ([id])
GO
ALTER TABLE [dbo].[Jugador] CHECK CONSTRAINT [FK__Jugador__idselec__0CBAE877]
GO
/****** Object:  ForeignKey [FK__Tecnico__idselec__0F975522]    Script Date: 10/24/2013 00:39:45 ******/
ALTER TABLE [dbo].[Tecnico]  WITH CHECK ADD  CONSTRAINT [FK__Tecnico__idselec__0F975522] FOREIGN KEY([idseleccion])
REFERENCES [dbo].[Seleccion] ([id])
GO
ALTER TABLE [dbo].[Tecnico] CHECK CONSTRAINT [FK__Tecnico__idselec__0F975522]
GO
