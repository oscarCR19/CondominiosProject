USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spInsertCondominios]
	@id_Empre Int,
	@codigo Varchar(30),
	@nombre Varchar(30),
	@direccion Varchar(100),
	@tel Varchar(15),
	@logo Varchar(100)

AS

BEGIN
	INSERT INTO [dbo].[Condominios]
	VALUES(
	@id_Empre,
	@codigo,
	@nombre,
	@direccion,
	@tel,
	@logo)
END

