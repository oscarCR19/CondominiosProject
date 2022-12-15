USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spGetUltimateIdPerson]

AS
	BEGIN
		SELECT 
			TOP 1 P.id_Person+1 as id_Person
		FROM	[dbo].[Personas] P
		ORDER BY P.id_Person DESC
END