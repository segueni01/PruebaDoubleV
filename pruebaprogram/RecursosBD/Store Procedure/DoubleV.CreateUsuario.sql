
CREATE OR ALTER PROCEDURE [DoubleV].[CreateUsuario](
	@Identificador  UNIQUEIDENTIFIER  = NULL,
	@Usuario		NVARCHAR(250)	  = NULL,
	@Pass			NVARCHAR(250)	  = NULL,
	@FechaCreacion  DATETIMEOFFSET(7) = NULL
)
AS

BEGIN

	--VALIDACIONES
	IF EXISTS (	SELECT TOP 1 Identificador FROM DoubleV.Usuarios WHERE UPPER(Identificador) = UPPER(@Identificador))
		BEGIN
			RAISERROR('Ya existe un usuario con este numero de identificador.', 16, 1)  
			RETURN;
		END

	--AGREGAR
	INSERT INTO [DoubleV].[Usuarios](
		Identificador,
		Usuario,
		Pass,
		FechaCreacion
	)
	VALUES(
		@Identificador,
		@Usuario,
		@Pass,
		@FechaCreacion
	)

END