﻿CREATE PROCEDURE ExamStudResultsPostDeploy 
AS
IF not exists (select * from dbo.ExamStudResults where IDStudent=1 
and IDExamForGroupe=1 and Rating=4)
	begin
		INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(1,1,4)
		INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(2,2,5)
		INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(3,3,6)
		INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(4,4,7)
		INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(1,1,8)
		INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(2,2,9)
		INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(3,3,4)
		INSERT ExamStudResults (IDStudent,IDExamForGroupe,Rating) VALUES(4,4,3)
	end
	GO