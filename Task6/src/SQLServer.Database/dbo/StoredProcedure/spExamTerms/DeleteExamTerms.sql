CREATE PROCEDURE [dbo].[DeleteExamTerms]
	@Id INT
AS
	DELETE FROM dbo.ExamTerms WHERE Id=@Id
GO
