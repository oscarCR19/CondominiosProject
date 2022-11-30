USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spValidarEmpresas]
	@correo VARCHAR(50),
	@contra VARCHAR(50)
AS
	BEGIN
		SELECT 
			*
		FROM [dbo].[Empresas] e
		WHERE (e.correo = @correo
		AND e.contra = @contra)
	END