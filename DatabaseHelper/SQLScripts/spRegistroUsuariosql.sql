USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spRegistrarUsuario]
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
		INSERT INTO Personas(
			id_Rol,
			ced,
			nombre,
			apellido,
			telef,
			correo,
			usuario,
			contra)

		VALUES(
			@id_Rol,
			@ced,
			@nombre,
			@apellido,
			@telef,
			@correo,
			@usuario,
			@contra)
	END
	GO