USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spGetCondominios]
AS
	BEGIN
		SELECT 
			*
		FROM [dbo].[Condominios]
	END