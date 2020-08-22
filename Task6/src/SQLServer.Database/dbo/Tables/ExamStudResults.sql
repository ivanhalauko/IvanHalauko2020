CREATE TABLE [dbo].[ExamStudResults]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IDStudent] INT NOT NULL, 
    [IDExamForGroupe] INT NOT NULL, 
    [Rating] INT NULL, 
    CONSTRAINT [FK_ExamStudResults_Students] FOREIGN KEY ([IDStudent]) REFERENCES [Students]([Id]), 
    CONSTRAINT [FK_ExamStudResults_Groupe] FOREIGN KEY ([IDExamForGroupe]) REFERENCES [Groupe]([Id]) 
)
