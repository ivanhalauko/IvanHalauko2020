CREATE PROCEDURE [dbo].[SpecialtiesPostDeploy]
AS
if not exists(SELECT*FROM dbo.Specialties WHERE NameOfSpecialty='Metallurgy' and InfoOfSpecialty='Casting of metals')
	BEGIN
		INSERT INTO Specialties (NameOfSpecialty,InfoOfSpecialty) VALUES ('Metallurgy','Casting of metals')
		INSERT INTO Specialties (NameOfSpecialty,InfoOfSpecialty) VALUES ('Industrial electronics','Design and service of electronics')
		INSERT INTO Specialties (NameOfSpecialty,InfoOfSpecialty) VALUES ('Hydroulics and pneumatics','Design and service of hydraulic drive')		
	END
GO
