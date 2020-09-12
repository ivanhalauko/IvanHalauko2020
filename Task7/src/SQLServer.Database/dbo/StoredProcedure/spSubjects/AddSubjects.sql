CREATE PROCEDURE [dbo].[AddSubjects]
	@SubjectsName nvarchar(50)
AS
	INSERT INTO Subjects(SubjectsName)
	VALUES (@SubjectsName)

	SELECT SCOPE_IDENTITY()
GO