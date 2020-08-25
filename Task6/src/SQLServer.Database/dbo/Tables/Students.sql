CREATE TABLE [dbo].[Students]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [Surname] NVARCHAR(50) NULL, 
    [Patronymic] NVARCHAR(50) NULL, 
    [BirthDate] DATE NULL, 
    [IDGroup] INT NULL, 
    CONSTRAINT [FK_Students_Groupe] FOREIGN KEY ([Id]) REFERENCES [Groupe]([Id])
)
