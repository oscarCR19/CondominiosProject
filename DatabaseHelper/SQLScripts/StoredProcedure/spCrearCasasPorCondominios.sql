USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spCrearCasasPorCondominios]
	@id_Con Int,
	@habitac Int,
	@parqueos Int,
	@valor Decimal
AS
	BEGIN
		INSERT INTO CasasPorCondominios(
			id_Con,
			habitac,
			parqueos,
			valor)

		VALUES(
			@id_Con,
			@habitac,
			@parqueos,
			@valor)
	END
	GO