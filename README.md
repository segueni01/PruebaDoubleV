# FactureProfesoresBACK
Parte BACK de la prueba de profesores de FACTURE

Tener en cuenta que el tipo de las fechas es DateTimeOffset, se le puso un formato de "yyyy-MM-dd"

Pasos a tener en cuenta para correr el proyecto:

NOTA: Este proyecto requiere .net core 5

1. Configurar en el archivo appsettings.json la cadena de conexion de la base de datos que queremos apuntar, esta se encuentra en la variable llamada "DevConexion".

2. En el proyecto hay una carpeta que se llama RecursosDB, alli se encuentran los querys y los Store procedure que debemos ejecutar en nuestra base de datos

  2.1 lo primero es ejecutar lo que se encuentra en la carpeta de RecursosDB/Querys
  
  2.2 Seguido de eso debemos ejecutar los SP que se encuentra en la carpeta RecursosDB/Store Procedure
