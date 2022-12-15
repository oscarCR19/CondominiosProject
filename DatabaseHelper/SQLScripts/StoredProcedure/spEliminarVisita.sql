USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spEliminarVisita]
	@id_Vis Int

AS
	BEGIN
		DELETE FROM [dbo].[VisitasPorCondominios]
		WHERE id_Vis = @id_Vis
END
GO