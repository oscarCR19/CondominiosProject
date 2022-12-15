CREATE TRIGGER TR_DeleteCondominiosPorEmpresas
ON CondiminiosPorEmpresas FOR DELETE
AS
SET NOCOUNT ON
DECLARE @id_con int,@id_Empre int
SELECT @id_con = id_con,@id_Empre=id_Empre FROM deleted
DELETE FROM Condominios WHERE id_Con=@id_con
GO