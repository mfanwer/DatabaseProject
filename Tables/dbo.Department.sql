CREATE TABLE [dbo].[Department]
(
[DepartmentName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Department] ADD CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED  ([DepartmentName]) ON [PRIMARY]
GO
