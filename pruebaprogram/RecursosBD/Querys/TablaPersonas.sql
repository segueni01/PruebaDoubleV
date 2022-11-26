CREATE TABLE [DoubleV].[Personas](
	[Identificador] [uniqueidentifier] NOT NULL,
	[Nombre] [nvarchar](250) NOT NULL,
	[Apellidos] [nvarchar](250) NOT NULL,
	[NumeroIdentificacion] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](250) NOT NULL,
	[TipoIdentificacion] [nvarchar](250) NOT NULL,
	[FechaCreacion] [datetimeoffset](7) NOT NULL,
	[IdentificacionCompleta] [nvarchar](max) NOT NULL,
	[NombreCompleto] [nvarchar](500) NOT NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[Identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]