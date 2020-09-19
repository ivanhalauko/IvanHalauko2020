CREATE PROCEDURE [dbo].[UpdateExamForGroup]
	@Id INT,
	@IDExamTerm INT,
	@IDSubjects INT,
	@IDGroupe INT,
	@DateGroupeExam date

AS
	UPDATE ExamForGroup
	SET IDExamTerm=@IDExamTerm,	IDSubjects=@IDSubjects, IDGroupe=@IDGroupe, 	DateGroupeExam=@DateGroupeExam
    WHERE Id=@Id
	SELECT* FROM ExamForGroup WHERE Id=@Id
GO
