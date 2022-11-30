USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spValidarPersonas]
	@usuario VARCHAR(50),
	@contra VARCHAR(50)

AS
	BEGIN
		SELECT 
			*
		FROM [dbo].[Personas] pp
		WHERE pp.usuario = @usuario
		AND pp.contra = @contra

	END