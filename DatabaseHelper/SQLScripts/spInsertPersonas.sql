USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spInsertPersonas]
	@id_Rol Int,
	@id_Cond Int,
	@id_Empre Int,
	@ced Varchar(15),
	@nombre1 Varchar(30),
	@nombre2 Varchar(30),
	@apellido1 Varchar(30),
	@apellido2 Varchar(30),
	@telef Varchar(15),
	@correo Varchar(50),
	@usuario Varchar(40),
	@contra Varchar(40),
	@id_ultPerson Int,
	@id_Cas INT
	


AS

	if(@id_Rol=2)
		BEGIN
			INSERT INTO [dbo].[Personas] 
			VALUES (@id_Rol, @ced, @nombre1, @nombre2, @apellido1, @apellido2, @telef, @correo, @usuario, @contra);
			INSERT INTO [dbo].[CasasPorCondominos] VALUES (@id_Cond,@id_ultPerson,@id_Cas);
		END

	if(@id_Rol=3)
	BEGIN
			INSERT INTO [dbo].[Personas] 
			VALUES (@id_Rol, @ced, @nombre1, @nombre2, @apellido1, @apellido2, @telef, @correo, @usuario, @contra);
			INSERT INTO [dbo].[OficialesPorEmpresas] VALUES (@id_ultPerson,@id_Empre);
		END
GO
