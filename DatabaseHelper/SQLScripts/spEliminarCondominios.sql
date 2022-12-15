USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spEliminarCondominios]
	@id_Con Int

AS
	BEGIN
		DELETE FROM Condominios
		WHERE id_Con = @id_Con;
	END

	BEGIN
		DELETE FROM [dbo].[CondiminiosPorEmpresas]
		WHERE id_Con = @id_Con;
	END
GO