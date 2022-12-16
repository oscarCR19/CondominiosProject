USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spGetVisitasPorPersonas]
@usuario Varchar(50)
AS
	BEGIN
		select v.nombre,v.apellido1,v.cita,v.cod_QR,v.placa,ruta_QR,v.col_Vehic from VisitasPorCondominios v
			inner join CasasPorCondominos cc
					inner join Personas p
				on cc.id_Person=p.id_Person
			on v.id_Cas=cc.id_Cas 
	where p.usuario=@usuario
	END
GO
