using Microsoft.Data.SqlClient;
using System.Linq;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using DoubleVAPI.Models.Response;
using DoubleVAPI.DbContexts;

namespace DoubleVAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DoubleVAPIDbContext _context;

        public UsuarioRepository(DoubleVAPIDbContext context)
        {
            _context = context;
        }

        public void CheckUsuario(string user, string pass)
        {

            var procedure = "EXEC [DoubleV].[CheckUsuario] @User, @Pass";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@User", Value = user},
                new SqlParameter { ParameterName = "@Pass", Value = pass}
            };

            _context.Database.ExecuteSqlRaw(procedure, parameters); 
        }

    }
}
