using DoubleVAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace DoubleVAPI.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet("{user}/{pass}")]
        public IActionResult GetUsuarios(string user, string pass)
        {
            try
            {
                _usuarioService.CheckUsuario(user, pass);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
