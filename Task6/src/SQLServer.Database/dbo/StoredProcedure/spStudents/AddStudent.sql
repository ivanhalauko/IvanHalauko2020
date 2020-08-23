CREATE PROCEDURE [dbo].[AddStudent]
	@Id int,
	@Name nvarchar(50),
	@Surname nvarchar(50),
	@Patronymic nvarchar(50),
	@BirthDate date,
	@IDGroup int
AS
	INSERT INTO Students( Id, Name, Surname, Patronymic, BirthDate, IDGroup)
    VALUES (@Id, @Name, @Surname, @Patronymic, @BirthDate, @IDGroup)
	SELECT SCOPE_IDENTITY()
GO
