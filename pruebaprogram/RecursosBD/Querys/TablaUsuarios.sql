CREATE TABLE [DoubleV].[Usuarios](
	[Identificador] [uniqueidentifier] NOT NULL,
	[Usuario] [nvarchar](max) NOT NULL,
	[Pass] [nvarchar](250) NOT NULL,
	[FechaCreacion] [datetimeoffset](7) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Identificador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]