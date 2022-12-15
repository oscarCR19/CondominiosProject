USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spEliminarPerson]
	@id_Person Int

AS
	BEGIN
	DELETE CasasPorCondominos WHERE	 
			id_Person=@id_Person;
	DELETE Personas WHERE
	id_Person=@id_Person;
	
		
END
GO

