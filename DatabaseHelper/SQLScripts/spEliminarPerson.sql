USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spEliminarPerson]
	@id_Person INT,
	@id_Rol INT

AS
	
	if (@id_Rol=2)
	BEGIN
		DELETE FROM CasasPorCondominos
		WHERE id_Person = @id_Person;
		DELETE FROM Personas
		WHERE id_Person = @id_Person;
	END;
		
	
	if(@id_Rol=3)
	BEGIN
		DELETE FROM OficialesPorEmpresas
		WHERE id_Person = @id_Person;
		DELETE FROM Personas
		WHERE id_Person = @id_Person;
	END;
GO
