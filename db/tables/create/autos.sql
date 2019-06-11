USE [transportes]
GO

/****** Object:  Table [dbo].[autos]    Script Date: 21/05/2019 09:45:00 a. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[autos](
	[folio] [nvarchar](50) NOT NULL,
	[marca] [nvarchar](50) NOT NULL,
	[modelo] [nvarchar](50) NOT NULL,
	[color] [nvarchar](50) NOT NULL,
	[tipo_transmicion] [int] NOT NULL,
	[descripcion] [ntext] NULL,
 CONSTRAINT [PK_autos] PRIMARY KEY CLUSTERED 
(
	[folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[autos]  WITH CHECK ADD  CONSTRAINT [FK_autos_transmisiones] FOREIGN KEY([tipo_transmicion])
REFERENCES [dbo].[transmisiones] ([IdTransmision])
GO

ALTER TABLE [dbo].[autos] CHECK CONSTRAINT [FK_autos_transmisiones]
GO


