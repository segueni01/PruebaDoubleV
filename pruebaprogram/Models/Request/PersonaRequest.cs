using System.ComponentModel.DataAnnotations;

namespace pruebaprogram.Models.Request
{
    public class PersonaRequest
    {

        [Required(ErrorMessage = "{0} es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public string NumeroIdentificacion { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public string Email { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public string TipoIdentificacion { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public string User { get; set; }
        [Required(ErrorMessage = "{0} es requerido")]
        public string Password { get; set; }
    }
}
