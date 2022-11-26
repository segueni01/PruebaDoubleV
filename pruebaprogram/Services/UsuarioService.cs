using DoubleVAPI.Repositories;
using Microsoft.IdentityModel.Tokens;

namespace DoubleVAPI.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void CheckUsuario(string user, string pass)
        {

            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            { 
                throw new ArgumentNullException("Usuario o contraseña son requeridos");  
            }

            _usuarioRepository.CheckUsuario(user, pass);    
        }
    }
}
