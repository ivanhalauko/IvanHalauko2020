CREATE PROCEDURE StudentsPostDeploy
AS
INSERT INTO Students (Name, Surname, Patronymic, BirthDate,IDGroupe) VALUES('Vasya','Petrov','Fedotovich','2015.05.06',1)
INSERT INTO Students (Name, Surname, Patronymic, BirthDate,IDGroupe) VALUES('Kolya','Ivanov','Ptrovich','2015.04.10',2)
INSERT INTO Students (Name, Surname, Patronymic, BirthDate,IDGroupe) VALUES('Petya','Gavrilov','Rigogich','2015.01.15',3)
INSERT INTO Students (Name, Surname, Patronymic, BirthDate,IDGroupe) VALUES('Gena','Stepanov','Losevich','2015.08.20',4)
GO