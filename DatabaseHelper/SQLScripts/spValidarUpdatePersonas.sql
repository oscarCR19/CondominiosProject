USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spValidarUpdatePersonas]
	@cedula VARCHAR(15),
	@correo VARCHAR(50),
	@telefono VARCHAR(15),
	@idPerson INT

AS
	BEGIN
		SELECT 
			*
		FROM [dbo].[Personas] pp
		WHERE pp.id_Person != @idPerson AND(pp.ced = @cedula
		OR pp.correo = @correo OR PP.telef=@telefono)
END
	exec [spValidarUpdatePersonas] '206950784','oscarmora2006@gmail.com','206950784',1
	--En este sp le estoy diciendo a la db, deme los registros que coincidan de personas que coincidan con cedula, correo o telefono pero que no sean del id del usuario que voy a actualizar