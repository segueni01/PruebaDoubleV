CREATE OR ALTER PROCEDURE [DoubleV].[CheckUsuario]
(
	@User NVARCHAR(250) = NULL,
	@Pass NVARCHAR(250) = NULL
)
AS
BEGIN

	IF NOT EXISTS (SELECT TOP 1 Usuario FROM DoubleV.Usuarios WHERE Usuario = @User and Pass = @Pass)
	BEGIN
		RAISERROR('No existe un usuario con estas credenciales!!!', 16, 1);
	END

END