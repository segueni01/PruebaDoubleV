using DoubleVAPI.DbContexts;
using DoubleVAPI.Models.Response;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using pruebaprogram.Models.Request;

namespace DoubleVAPI.Repositories
{

    public class PersonaRepository : IPersonaRepository
    {
        private readonly DoubleVAPIDbContext _context;

        public PersonaRepository(DoubleVAPIDbContext context)
        {
            _context = context;
        }
        public List<Persona> GetPersonas()
        {
            var procedure = "EXEC [DoubleV].[PersonasList]";
            var result    = _context.Persons.FromSqlRaw<Persona>(procedure).ToList();

            return result;
        }

        public void AddPersona(PersonaRequest persona)
        {
            var procedure = "EXEC [DoubleV].[CreatePersona] @Nombre, @Apellidos, @NumeroIdentificacion, @Email, @TipoIdentificacion, @User, @Password";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter { ParameterName = "@Nombre",               Value = persona.Nombre},
                new SqlParameter { ParameterName = "@Apellidos",            Value = persona.Apellidos},
                new SqlParameter { ParameterName = "@NumeroIdentificacion", Value = persona.NumeroIdentificacion},
                new SqlParameter { ParameterName = "@Email",                Value = persona.Email},
                new SqlParameter { ParameterName = "@TipoIdentificacion",   Value = persona.TipoIdentificacion},
                new SqlParameter { ParameterName = "@User",                 Value = persona.User},
                new SqlParameter { ParameterName = "@Password",             Value = persona.Password}
            };

            _context.Database.ExecuteSqlRaw(procedure, parameters);
        }

    }
}
