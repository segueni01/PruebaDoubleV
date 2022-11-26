CREATE OR ALTER PROCEDURE [DoubleV].[PersonasList]
AS
BEGIN

	SELECT 
		Identificador, 
		Nombre, 
		Apellidos,
		NumeroIdentificacion,
		Email, 
		TipoIdentificacion, 
		FechaCreacion, 
		IdentificacionCompleta, 
		NombreCompleto
	FROM DoubleV.Personas

END