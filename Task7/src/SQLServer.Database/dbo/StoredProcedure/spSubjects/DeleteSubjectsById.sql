CREATE PROCEDURE [dbo].[DeleteSubjectsById]
	@Id INT
AS
	DELETE FROM Subjects WHERE Id=@Id 
GO
