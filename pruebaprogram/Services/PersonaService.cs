using DoubleVAPI.Models.Response;
using DoubleVAPI.Repositories;
using pruebaprogram.Models.Request;

namespace DoubleVAPI.Services
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;    

        public PersonaService(IPersonaRepository personaRepository)
        {
            _personaRepository = personaRepository;
        }

        public List<Persona> GetPersonas()
        {
            return _personaRepository.GetPersonas();
        }

        public void AddPersona(PersonaRequest persona)
        {

            _personaRepository.AddPersona(persona);

        }
    }
}
