USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spEditarCondominios]
	@id_Con Int,
	@nombre Varchar(30),
	@direccion Varchar(100),
	@tel Varchar(15),
	@logo Varchar(100)

AS
	BEGIN
		UPDATE [dbo].[Condominios] 
		SET 
			nombre = @nombre,
			direccion = @direccion,
			tel = @tel,
			logo = @logo
		WHERE id_Con = @id_Con
	END
	GO