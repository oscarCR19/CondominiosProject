USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spObtenerUsuario]
	@usuario VARCHAR(50),
	@contra VARCHAR(50)
AS
	BEGIN
		SELECT 
			*
		FROM [dbo].[Personas] pp
		INNER JOIN [dbo].[Roles] r
			ON pp.id_Rol = r.id_Rol
		WHERE pp.usuario = @usuario
		AND pp.contra = @contra

	END