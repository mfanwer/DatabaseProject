CREATE TABLE [dbo].[ProfData]
(
[ID] [int] NOT NULL IDENTITY(1, 1),
[UserName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Name] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Department] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProfData] ADD CONSTRAINT [PK_ProfData] PRIMARY KEY CLUSTERED  ([UserName]) ON [PRIMARY]
GO
