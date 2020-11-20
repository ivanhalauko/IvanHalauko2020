CREATE PROCEDURE SubjectsPostDeploy
AS
IF not exists (SELECT * from dbo.Subjects WHERE SubjectsName='Phisics' and IsAssessment = 'Assesment' and IDExaminers=0)
	begin
		INSERT INTO Subjects(SubjectsName,IsAssessment, IDExaminers) VALUES('Phisics', 'Assesment', 1)
		INSERT INTO Subjects(SubjectsName,IsAssessment, IDExaminers) VALUES('Chemist', 'Test', 2)
		INSERT INTO Subjects(SubjectsName,IsAssessment, IDExaminers) VALUES('Math', 'Assesment', 3)
		INSERT INTO Subjects(SubjectsName,IsAssessment, IDExaminers) VALUES('English', 'Test', 4)
	end
GO