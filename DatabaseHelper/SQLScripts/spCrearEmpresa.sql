USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spCrearEmpresa]
	@nombreEmpresa Varchar(50),
	@direc Varchar(100),
	@tel Varchar(15),
	@correoEmpresa Varchar(50),
	@logo Varchar(100),
	@cedJuridica Varchar(200),
	@contra Varchar(40)

AS
	BEGIN
		INSERT INTO Empresas(
			nombre,
			direc,
			tel,
			correo,
			logo,
			cedJuridica,
			contra)

		VALUES(
			@nombreEmpresa,
			@direc,
			@tel,
			@correoEmpresa,
			@logo,
			@cedJuridica,
			@contra)
	END
	GO