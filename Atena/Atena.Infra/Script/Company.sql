USE [Atena]
GO

/****** Object:  Table [dbo].[TbCompany]    Script Date: 05/07/2023 22:35:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TbCompany](
	[Id] [uniqueidentifier] NOT NULL,
	[CompanyName] [nvarchar](100) NOT NULL,
	[CorporateName] [nvarchar](100) NOT NULL,
	[CNPJ] [nvarchar](20) NOT NULL,
	[Included] [datetime] NOT NULL,
	[Updated] [datetime] NOT NULL,
	[Status] [varchar](2) NOT NULL,
 CONSTRAINT [PK_TbCompany] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO