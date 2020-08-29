CREATE PROCEDURE ExamStudResultsPostDeploy 
AS
INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(1,1,4)
INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(2,2,5)
INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(3,3,6)
INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(4,1,7)
INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(1,2,8)
INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(2,3,9)
INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(3,1,4)
INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(4,2,3)
GO