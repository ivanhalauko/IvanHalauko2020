CREATE PROCEDURE [dbo].[DeleteStudent]
	@Id int
AS
	DELETE FROM Students WHERE Id = @Id
GO
