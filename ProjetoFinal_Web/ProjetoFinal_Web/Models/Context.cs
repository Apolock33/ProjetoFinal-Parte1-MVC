using Microsoft.EntityFrameworkCore;

namespace ProjetoFinal_Web.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet <Usuario> Usuario { get; set; }
    }
}
