USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spGetOficialesPorEmpresas]
@id_Empre INT
AS
	BEGIN
		SELECT p.id_Person,p.id_Rol,p.ced,p.nombre1,p.nombre2,p.apellido1,p.apellido2,p.telef,p.correo FROM Personas p
			INNER JOIN OficialesPorEmpresas oe
				ON p.id_Person=oe.id_Person
		WHERE oe.id_Empre=@id_Empre AND p.id_Rol=3
	END
	