using DoubleVAPI.Models.Response;
using Microsoft.EntityFrameworkCore;

namespace DoubleVAPI.DbContexts
{
    public class DoubleVAPIDbContext : DbContext
    {
        public DbSet<Persona> Persons { get; set; }
        public DbSet<Usuarios> Users { get; set; }

        public DoubleVAPIDbContext(DbContextOptions<DoubleVAPIDbContext> options) : base(options)   
        { 
            
        }

    }
}
