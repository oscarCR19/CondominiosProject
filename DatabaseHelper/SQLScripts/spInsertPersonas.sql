USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spInsertPersonas]
	@id_Rol Int,
	@ced Varchar(15),
	@nombre Varchar(30),
	@apellido Varchar(30),
	@telef Varchar(15),
	@correo Varchar(50),
	@usuario Varchar(40),
	@contra Varchar(40)

AS

BEGIN
	INSERT INTO [dbo].[Personas] 
	VALUES (@id_Rol, @ced, @nombre, @apellido, @telef, @correo, @usuario, @contra)
END

EXEC spInsertPersonas 2,'117850521','leandro','vargas valverde','62166673','leandro9700@gmail.com','lvargasva','leandro123'
EXEC spInsertPersonas 3,'119340759','Jose Andres','Bogantes','88625329','jose.bogantes2016@gmail.com','jandresb','bE3XiWw='
