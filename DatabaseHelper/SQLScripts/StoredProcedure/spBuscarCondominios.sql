USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spBuscarCondominios]
@filtro Varchar(100)

AS
	BEGIN
		SELECT * FROM [dbo].[Condominios] c WHERE c.nombre LIKE '%' + @filtro + '%'
END
GO

EXEC spBuscarCondominios 'leandro'