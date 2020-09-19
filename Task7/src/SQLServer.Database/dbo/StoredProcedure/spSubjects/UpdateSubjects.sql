CREATE PROCEDURE [dbo].[UpdateSubjects]
	@Id INT,
	@SubjectsName nvarchar(50)
AS
	UPDATE Subjects
	SET SubjectsName=@SubjectsName
    WHERE Id=@Id
	SELECT* FROM Subjects WHERE Id=@Id
GO
