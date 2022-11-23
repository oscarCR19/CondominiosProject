USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spCrearEmpresa]
	@id_Rol Int,
	@ced Varchar(15),
	@nombre1 Varchar(30),
	@nombre2 Varchar(30),
	@apellido1 Varchar(30),
	@apellido2 Varchar(30),
	@telef Varchar(15),
	@correo Varchar(50),
	@usuario Varchar(40),
	@contra Varchar(40),

	@nombreEmpresa Varchar(50),
	@direc Varchar(100),
	@tel Varchar(15),
	@correoEmpresa Varchar(50),
	@logo Varchar(100),
	@cedJuridica Varchar(200)

AS
	BEGIN
		INSERT INTO Personas(
			id_Rol,
			ced,
			nombre1,
			nombre2,
			apellido1,
			apellido2,
			telef,
			correo,
			usuario,
			contra)

		VALUES(
			@id_Rol,
			@ced,
			@nombre1,
			@nombre2,
			@apellido1,
			@apellido2,
			@telef,
			@correo,
			@usuario,
			@contra)
	END

	BEGIN
		INSERT INTO Empresas(
			nombre,
			direc,
			tel,
			correo,
			logo,
			cedJuridica)

		VALUES(
			@nombreEmpresa,
			@direc,
			@tel,
			@correoEmpresa,
			@logo,
			@cedJuridica)
	END

	GO