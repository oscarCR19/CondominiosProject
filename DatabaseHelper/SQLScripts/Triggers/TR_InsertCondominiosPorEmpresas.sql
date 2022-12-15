CREATE TRIGGER TR_InsertCondominiosPorEmpresas
ON Condominios FOR INSERT
AS
SET NOCOUNT ON
DECLARE @id_con int,@id_Empre int
SELECT @id_con = id_con,@id_Empre=id_Empre FROM inserted
INSERT INTO CondiminiosPorEmpresas values(@id_con,@id_Empre)
GO