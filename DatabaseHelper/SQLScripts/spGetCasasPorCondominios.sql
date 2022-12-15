USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spGetCasasPorCondominios]
@idCond INT
AS
	BEGIN
		SELECT * FROM [dbo].[CasasPorCondominios]
		WHERE id_Con=@idCond
	END