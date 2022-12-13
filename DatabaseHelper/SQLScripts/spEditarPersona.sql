USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spEditarPersona]
	@id_Person Int,
	@id_Rol Int,
	@ced Varchar(15),
	@nombre1 Varchar(30),
	@nombre2 Varchar(30),
	@apellido1 Varchar(30),
	@apellido2 Varchar(30) NULL,
	@telef Varchar(15),
	@correo Varchar(50),
	@contra Varchar(40)

AS
	BEGIN
		UPDATE [dbo].[Personas]
		SET 
			ced = @ced,
			id_Rol=@id_Rol,
			nombre1 = @nombre1,
			nombre2=@nombre2,
			apellido1 = @apellido1,
			apellido2 = @apellido2,
			telef = @telef,
			correo = @correo,
			contra = @contra
		WHERE id_Person = @id_Person
	END
	GO