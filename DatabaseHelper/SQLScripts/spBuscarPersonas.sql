USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spBuscarPersonas]
@filtro Varchar(100)

AS
	BEGIN
		SELECT * FROM [dbo].[Personas] p WHERE p.nombre1 LIKE '%' + @filtro + '%'
END
GO

EXEC spBuscarPersonas 'leandro'