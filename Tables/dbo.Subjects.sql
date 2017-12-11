CREATE TABLE [dbo].[Subjects]
(
[Department] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Subject] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[CourseId] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Credit] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[term] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
