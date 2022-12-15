USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spCrearCondominios]
	@id_Empre INT,
	@nombre Varchar(30),
	@direccion Varchar(100),
	@tel Varchar(15),
	@logo Varchar(100)
AS
	BEGIN
		INSERT INTO [dbo].[Condominios](
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
			@logo);		
	END;
GO