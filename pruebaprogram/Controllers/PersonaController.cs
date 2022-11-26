using DoubleVAPI.Services;
using Microsoft.AspNetCore.Mvc;
using pruebaprogram.Models.Request;

namespace DoubleVAPI.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {

        private readonly IPersonaService _personaService;

        public PersonaController(IPersonaService personaService)
        {
            _personaService = personaService;
        }

        [HttpGet]
        public IActionResult GetPersonas()
        {
            try
            {
                var result = _personaService.GetPersonas();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddPersona([FromBody] PersonaRequest persona)
        {
            try
            {
                _personaService.AddPersona(persona);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
