USE [CondominiosProject]
GO

CREATE OR ALTER PROCEDURE [dbo].[spValidarEmpresas]
	@correo VARCHAR(50),
	@contra VARCHAR(50)
AS
	BEGIN
		SELECT 
			*
		FROM [dbo].[Empresas] e
		WHERE (e.correo = @correo
		AND e.contra = @contra)
	END


	insert into dbo.Empresas(nombre,direc,tel,correo,logo,cedJuridica,contra) values ('Primer condominio','Los lagos','71080791','oscarmora2006@gmail.com','','206950784','hola');