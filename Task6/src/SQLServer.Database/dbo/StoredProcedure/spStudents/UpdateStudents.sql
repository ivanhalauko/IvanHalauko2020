CREATE PROCEDURE [dbo].[UpdateStudents]
	@Id int,
	@Name nvarchar(50),
	@Surname nvarchar(50),
	@Patronymic nvarchar(50),
	@BirthDate date,
	@IDGroup int
AS
	UPDATE Students
	SET Id=@Id, Name=@Name, Surname=@Surname,Patronymic=@Patronymic, BirthDate=@BirthDate, IDGroup=@IDGroup
    WHERE IDGroup=@IDGroup
	SELECT* FROM Students WHERE Id=@Id
GO
