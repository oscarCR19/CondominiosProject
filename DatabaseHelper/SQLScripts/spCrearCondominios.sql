USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spCrearCondominios]
	@codigo Varchar(30),
	@nombre Varchar(30),
	@direccion Varchar(100),
	@tel Varchar(15),
	@logo Varchar(100)
AS
	BEGIN
		INSERT INTO Condominios(
			codigo,
			nombre,
			direccion,
			tel,
			logo)

		VALUES(
			@codigo,
			@nombre,
			@direccion,
			@tel,
			@logo)
	END
	GO