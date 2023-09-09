using ApiPeliculas.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ApiPeliculas
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Genero> Generos { get; set; }
    }
}
