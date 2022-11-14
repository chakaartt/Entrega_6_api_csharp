

using api_myProjet.model;
using Microsoft.EntityFrameworkCore;

namespace api_myProjet.DataBase
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext (DbContextOptions<UsuarioDbContext>
        options) : base(options) {

        }

        public DbSet<Usuario> Usuarios {get; set; }
    }
}