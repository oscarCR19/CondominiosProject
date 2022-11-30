CREATE PROCEDURE [dbo].[spUpdateFotoCondominio]
	@photoPath VARCHAR(50),
	@id_Con INT
AS
	BEGIN
		UPDATE [dbo].[Condominios] SET [logo] = @photoPath 
		WHERE id_Con = @id_Con
	END