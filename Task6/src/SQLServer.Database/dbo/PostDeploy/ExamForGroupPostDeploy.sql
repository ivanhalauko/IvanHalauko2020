CREATE PROCEDURE ExamForGroupPostDeploy
AS
INSERT INTO ExamForGroup (IDExamTerm, IDExam, IDGroupe,DateGroupeExam) VALUES(1, 3, 1, '10.4.2015')
INSERT INTO ExamForGroup (IDExamTerm, IDExam, IDGroupe,DateGroupeExam) VALUES(2, 2, 2, '2015.10.5')
INSERT INTO ExamForGroup (IDExamTerm, IDExam, IDGroupe,DateGroupeExam) VALUES(3, 1, 3, '2015.10.2')
GO
