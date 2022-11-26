
CREATE OR ALTER PROCEDURE [DoubleV].[CreatePersona](
	@Nombre					NVARCHAR(250)	= NULL,
	@Apellidos				NVARCHAR(250)	= NULL,
	@NumeroIdentificacion	NVARCHAR(MAX)	= NULL,
	@Email					NVARCHAR(250)	= NULL,
	@TipoIdentificacion		NVARCHAR(250)	= NULL,
	@User					NVARCHAR(250)	= NULL,
	@Password				NVARCHAR(250)	= NULL
)
AS

BEGIN

	--DECLARACIONES
	DECLARE @ID UNIQUEIDENTIFIER = NEWID();
	DECLARE @FechaActual DATETIMEOFFSET(7) = GETDATE();
	DECLARE @IdentificacionCompleta NVARCHAR(max) = @NumeroIdentificacion + ' - ' +  @TipoIdentificacion;
	DECLARE @NombreCompleto NVARCHAR(500) = @Nombre + ' ' +  @Apellidos;

	--VALIDACIONES
	IF EXISTS (	SELECT TOP 1 NumeroIdentificacion FROM DoubleV.Personas WHERE UPPER(NumeroIdentificacion) = UPPER(@NumeroIdentificacion))
		BEGIN
			RAISERROR('Ya existe una persona con este numero de identificacion.', 16, 1)  
			RETURN;
		END


	--AGREGAR PERSONA
	INSERT INTO [DoubleV].[Personas](
		Identificador,
		Nombre,
		Apellidos,
		NumeroIdentificacion,
		Email,
		TipoIdentificacion,
		FechaCreacion,
		IdentificacionCompleta,
		NombreCompleto
	)
	VALUES(
		@ID,
		@Nombre,
		@Apellidos,
		@NumeroIdentificacion,
		@Email,
		@TipoIdentificacion,
		@FechaActual,
		@IdentificacionCompleta,
		@NombreCompleto
	)

	--AGREGAR USUARIO
	EXEC [DoubleV]. [DoubleV].[CreateUsuario]
		@Identificador  = @ID,
		@Usuario		= @User,
		@Pass			= @Password,
		@FechaCreacion	= @FechaActual

END