USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spEditarUsuario]
	@id_Person Int,
	@id_Rol Int,
	@ced Varchar(15),
	@nombre Varchar(30),
	@apellido Varchar(30),
	@telef Varchar(15),
	@correo Varchar(50),
	@usuario Varchar(40),
	@contra Varchar(40)

AS
	BEGIN
		UPDATE [dbo].[Personas]
		SET 
			ced = @ced,
			nombre = @nombre,
			apellido = @apellido,
			telef = @telef,
			correo = @correo,
			usuario = @usuario,
			contra = @contra
		WHERE id_Person = @id_Person
	END
	GO