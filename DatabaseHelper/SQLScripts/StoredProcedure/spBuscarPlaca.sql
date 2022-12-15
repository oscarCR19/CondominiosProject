USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spBuscarPlaca]
@filtro Varchar(100)

AS
	BEGIN
		SELECT * FROM [dbo].[VehiculosPorCondominos] vc WHERE vc.placa LIKE '%' + @filtro + '%'
END
GO
