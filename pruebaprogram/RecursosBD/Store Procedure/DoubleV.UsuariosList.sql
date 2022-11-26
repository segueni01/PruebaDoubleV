CREATE OR ALTER PROCEDURE [DoubleV].[UsuariosList]
AS
BEGIN

	SELECT 
		Identificador, 
		Usuario, 
		Pass,
		FechaCreacion
	FROM DoubleV.Usuarios

END