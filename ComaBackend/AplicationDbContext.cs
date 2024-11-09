using ComaBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace ComaBackend
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios {  get; set; }
    }
}
