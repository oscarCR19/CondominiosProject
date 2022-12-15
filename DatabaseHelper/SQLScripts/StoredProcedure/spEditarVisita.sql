USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spEditarVisita]
	@id_Vis Int,
	@nombre Varchar(30),
	@apellido1 Varchar(30),
	@apellido2 Varchar(30),
	@id_Mol Int,
	@id_Veh Int,
	@placa Varchar(30),
	@col_Vehic Varchar(30),
	@cita datetime,
	@ruta_QR Varchar(100),
	@cod_QR Varchar(4),
	@fechInicioQR datetime,
	@fechaExperQR datetime

AS
	BEGIN
		UPDATE [dbo].[VisitasPorCondominios]
		SET 
			nombre = @nombre,
			apellido1 = @apellido1,
			apellido2 = @apellido2,
			id_Mol = @id_Mol,
			id_Veh = @id_Veh,
			placa = @placa,
			col_Vehic = @col_Vehic,
			cita = @cita,
			ruta_QR = @ruta_QR,
			cod_QR = @cod_QR,
			fechInicioQR = @fechInicioQR,
			fechaExperQR = @fechaExperQR
		WHERE id_Vis = @id_Vis
	END
	GO