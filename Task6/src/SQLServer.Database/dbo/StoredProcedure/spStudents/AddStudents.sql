CREATE PROCEDURE [dbo].[AddStudents]
	@Name nvarchar(50),
	@Surname nvarchar(50),
	@Patronymic nvarchar(50),
	@BirthDate date,
	@IDGroup int
AS
	INSERT INTO Students(Name, Surname, Patronymic, BirthDate, IDGroup)
    VALUES (@Name, @Surname, @Patronymic, @BirthDate, @IDGroup)
	SELECT SCOPE_IDENTITY()
GO
