USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spEliminarPerson]
	@id_Person Int

AS
	BEGIN
		DELETE FROM Personas
		WHERE id_Person = @id_Person
END
GO
