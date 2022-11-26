namespace DoubleVAPI.Models.Response
{
    public class Persona
    {
        public Guid Identificador { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Email { get; set; }
        public string TipoIdentificacion { get; set; }
        public DateTimeOffset? FechaCreacion { get; set; }
        public string IdentificacionCompleta { get; set; }
        public string NombreCompleto { get; set; }

    }
}
