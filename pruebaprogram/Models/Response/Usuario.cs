namespace DoubleVAPI.Models.Response
{
    public class Usuarios
    {
        public Guid Identificador { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public DateTimeOffset? FechaCreacion { get; set; }
    }
}
