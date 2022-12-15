USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spDeleteCasa]
	@idCas INT
	
AS
	BEGIN
		Delete FROM [dbo].[CasasPorCondominios]
		WHERE id_Cas=@idCas;
			
	END
GO