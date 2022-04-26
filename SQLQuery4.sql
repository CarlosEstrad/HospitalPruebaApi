USE [hospital]
GO

/****** Object:  Table [dbo].[paciente]    Script Date: 26/04/2022 04:38:00 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[paciente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](15) NOT NULL,
	[Apellido] [varchar](15) NOT NULL,
	[Documento] [int] NOT NULL,
	[Direccion] [varchar](50) NULL,
	[Telefono] [varchar](15) NOT NULL,
	[Correo] [varchar](50) NOT NULL,
	[Edad] [int] NOT NULL,
	[Peso] [float] NULL,
	[Fecha_Nacimiento] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


