USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spValidarPersonas]
	@cedula VARCHAR(15),
	@correo VARCHAR(50),
	@telefono VARCHAR(15)

AS
	BEGIN
		SELECT 
			*
		FROM [dbo].[Personas] pp
		WHERE pp.ced = @cedula
		OR pp.correo = @correo OR PP.telef=@telefono

	END

