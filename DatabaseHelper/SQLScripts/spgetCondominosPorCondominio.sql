USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spGetCondominosPorCondominio]
@id_Cond INT
AS
	BEGIN
		SELECT p.id_Person,p.id_Rol,p.ced,p.nombre1,p.nombre2,p.apellido1,p.apellido2,p.telef,p.correo FROM Personas p
			INNER JOIN CasasPorCondominos cc
				ON p.id_Person=cc.id_Person
		WHERE cc.id_Con=@id_Cond
	END

	exec spGetCondominosPorCondominio 1