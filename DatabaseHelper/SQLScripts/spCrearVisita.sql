USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spCrearVisita]
	@id_Cas Int,
	@nombre Varchar(30),
	@apellido Varchar(30),
	@id_Mol Int,
	@id_Veh Int, 
	@placa Varchar(15),
	@col_Vehic Varchar(20),
	@cita datetime,
	@ruta_QR Varchar(100),
	@cod_QR Int
AS
	BEGIN
		INSERT INTO VisitasPorCondominios
			(id_Cas,
			nombre,
			apellido,
			id_Mol,
			id_Veh, 
			placa,
			col_Vehic,
			cita,
			ruta_QR,
			cod_QR)

		VALUES(
			@id_Cas,
			@nombre,
			@apellido,
			@id_Mol,
			@id_Veh, 
			@placa,
			@col_Vehic,
			@cita,
			@ruta_QR,
			@cod_QR)
	END
	GO