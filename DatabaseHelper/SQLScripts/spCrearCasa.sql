USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spCrearCasa]
	@idCond INT
	
AS
	BEGIN
		INSERT INTO [dbo].[CasasPorCondominios](id_Con) VALUES(@idCond)
			
	END
GO