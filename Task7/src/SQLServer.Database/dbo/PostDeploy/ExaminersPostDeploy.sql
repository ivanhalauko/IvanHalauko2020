CREATE PROCEDURE [dbo].[ExaminersPostDeploy]
	
AS
IF not exists(select * from dbo.Examiners WHERE Name='Vasiliy' and Surname='Petrovich' and Patronymic='Hrenov')
	BEGIN
		INSERT INTO Examiners (Name,Surname,Patronymic) VALUES('Vasiliy','Petrovich','Hrenov')
		INSERT INTO Examiners (Name,Surname,Patronymic) VALUES('Grigoriy','Nikolayevich','Ivanov')
		INSERT INTO Examiners (Name,Surname,Patronymic) VALUES('Maxim','Leonovich','Jukov')
		INSERT INTO Examiners (Name,Surname,Patronymic) VALUES('Vitaliy','Ivanovich','Zaycev')
	END
	GO
