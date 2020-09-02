CREATE PROCEDURE [dbo].[ShowExamTerms]
	@Id INT
AS
	SELECT * FROM dbo.ExamTerms WHERE Id=@Id
GO

