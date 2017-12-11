CREATE TABLE [dbo].[StudentSubject]
(
[UserName] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Subject] [nvarchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Marks] [int] NULL,
[CourseId] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Credit] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Term] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
