USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spGetCondominiosPorEmpresas]
@id INT
AS
	BEGIN
		SELECT C.id_Con,C.id_Empre,C.codigo,C.nombre,C.direccion,C.tel,C.logo FROM Condominios C
	inner join CondiminiosPorEmpresas CE
		inner join Empresas E
			ON E.id_Empre=CE.id_Empre
	ON C.id_Con=CE.id_Con
	                      WHERE e.id_Empre=@id
	END