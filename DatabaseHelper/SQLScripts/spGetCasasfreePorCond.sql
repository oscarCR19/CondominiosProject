USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spGetCasasfreePorCond]
	@iD_Con INT
	
AS
	BEGIN
		SELECT CC.id_Con,CC.id_Cas FROM [dbo].[CasasPorCondominios] CC
			INNER JOIN [CasasPorCondominos] CCO
			ON CC.id_Cas!=CCO.id_Cas
			WHERE CC.id_Con=@iD_Con
		
			
	END
GO
exec spGetCasasfreePorCond 1