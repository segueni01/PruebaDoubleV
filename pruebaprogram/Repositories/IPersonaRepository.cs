using DoubleVAPI.Models.Response;
using pruebaprogram.Models.Request;

namespace DoubleVAPI.Repositories
{
    public interface IPersonaRepository
    {

        public List<Persona> GetPersonas();

        public void AddPersona(PersonaRequest persona);

    }
}
