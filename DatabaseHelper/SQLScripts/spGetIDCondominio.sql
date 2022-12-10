USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spGetIdCondominio]
@id_Con BIGINT
AS
	BEGIN
		SELECT 
			*
		FROM [dbo].[Condominios] WHERE id_Con=@id_Con
	END
