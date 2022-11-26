using DoubleVAPI.Models.Response;

namespace DoubleVAPI.Repositories
{
    public interface IUsuarioRepository
    {
        public void CheckUsuario(string user, string pass);
    }
}
