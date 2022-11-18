USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spCrearCondominios]
	@id_Empre Int,
	@nombre Varchar(30),
	@direccion Varchar(100),
	@tel Varchar(15),
	@logo Varchar(100)
AS
	BEGIN
		INSERT INTO Condominios(
			id_Empre,
			nombre,
			direccion,
			tel,
			logo)

		VALUES(
			@id_Empre,
			@nombre,
			@direccion,
			@tel,
			@logo)
	END
	GO