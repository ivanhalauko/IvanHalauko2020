CREATE PROCEDURE ExamPostDeploy
AS
IF not exists (SELECT * from dbo.Subjects WHERE SubjectsName='Phisics')
begin
INSERT INTO Subjects(SubjectsName) VALUES('Phisics')
INSERT INTO Subjects(SubjectsName) VALUES('Chemist')
INSERT INTO Subjects(SubjectsName) VALUES('Math')
INSERT INTO Subjects(SubjectsName) VALUES('English')
end
GO