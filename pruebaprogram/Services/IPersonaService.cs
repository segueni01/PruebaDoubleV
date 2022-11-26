using DoubleVAPI.Models.Response;
using pruebaprogram.Models.Request;

namespace DoubleVAPI.Services
{
    public interface IPersonaService
    {
        public List<Persona> GetPersonas();
        public void AddPersona(PersonaRequest persona);

    }
}
