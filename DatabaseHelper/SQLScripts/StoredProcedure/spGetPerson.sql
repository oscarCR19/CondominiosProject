USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spGetPerson]
@idPerson INT
AS
	BEGIN
		SELECT 
			*
		FROM	[dbo].[Personas] P
		WHERE p.id_Person=@idPerson
	
END