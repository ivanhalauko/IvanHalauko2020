CREATE PROCEDURE [dbo].[ShowSubjectsById]
	@Id INT
AS
	SELECT * FROM dbo.Subjects WHERE Id=@Id
GO
