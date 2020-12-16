CREATE PROCEDURE GroupsPostDeploy
as
IF not exists(select * from dbo.Groups WHERE GroupeName='MT' and IDSpecialties=0)
	BEGIN
		INSERT INTO Groups (GroupeName,IDSpecialties) VALUES('MT',1)
		INSERT INTO Groups (GroupeName,IDSpecialties) VALUES('IE',2)
		INSERT INTO Groups (GroupeName,IDSpecialties) VALUES('HP',3)
		--INSERT INTO Groups (GroupeName,IDSpecialties) VALUES('MF',4)
	END
	GO