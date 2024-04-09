USE [EFM]
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 10/04/2024 00:13:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Funcionario](
	[Id] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[Nome] [nvarchar](500) NULL,
	[Sexo] [nvarchar](50) NULL,
	[Cargo] [nvarchar](50) NULL,
	[Seccao] [nvarchar](500) NULL,
	[NumeroFuncionario] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Funcionario] ON 
GO
INSERT [dbo].[Funcionario] ([Id], [Nome], [Sexo], [Cargo], [Seccao], [NumeroFuncionario]) VALUES (N'de6320b2-b7b1-41c3-845a-13ee902bd407', N'Dario Prazeres', N'Masculino', N'Developer', N'Desevolvimento', 1)
GO
INSERT [dbo].[Funcionario] ([Id], [Nome], [Sexo], [Cargo], [Seccao], [NumeroFuncionario]) VALUES (N'b17199ec-aa17-49c1-b4ea-d9a66e8c8537', N'Andelson Prazeres', N'Masculino', N'Contailista', N'Contabilidade', 2)
GO
SET IDENTITY_INSERT [dbo].[Funcionario] OFF
GO
ALTER TABLE [dbo].[Funcionario] ADD  CONSTRAINT [DF_Funcionario_Id]  DEFAULT (newid()) FOR [Id]
GO
