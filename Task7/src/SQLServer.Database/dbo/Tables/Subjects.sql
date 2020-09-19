﻿CREATE TABLE [dbo].[Subjects]
(
	[Id] INT IDENTITY(1,1)   PRIMARY KEY, 
    [SubjectsName] NVARCHAR(50) NOT NULL, 
    [IsAssessment] NVARCHAR(50) NOT NULL, 
    [IDExaminers] INT NOT NULL, 
    CONSTRAINT [FK_Subjects_ToExaminers] FOREIGN KEY ([IDExaminers]) REFERENCES [Examiners]([Id])
)
