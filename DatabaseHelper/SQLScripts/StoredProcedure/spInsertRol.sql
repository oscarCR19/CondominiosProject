USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spInsertRoles]
	@id_Rol Int,
	@descrip Varchar(20)
AS

BEGIN
	INSERT INTO [dbo].[Roles]
	VALUES (@id_Rol, @descrip)
END

EXEC spInsertRoles 1,'Administrador'
EXEC spInsertRoles 2,'Seguridad'
EXEC spInsertRoles 3,'Condomino'