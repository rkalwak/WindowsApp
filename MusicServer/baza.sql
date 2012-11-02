USE [musicserver]
GO
/****** Object:  Table [dbo].[music]    Script Date: 11/02/2012 20:39:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[music](
	[Artist] [nchar](50) NOT NULL,
	[Title] [nchar](50) NOT NULL,
	[Allbum] [nchar](100) NULL,
	[Genre] [nchar](50) NULL,
	[Year] [int] NULL,
	[FileName] [varchar](200) NOT NULL,
	[Duration] [int] NOT NULL,
	[Number] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_music] PRIMARY KEY CLUSTERED 
(
	[Artist] ASC,
	[Title] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
