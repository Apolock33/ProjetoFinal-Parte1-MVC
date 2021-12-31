using Microsoft.EntityFrameworkCore;

namespace ProjetoFinal_Web.Models
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {

        }
        public DbSet <Usuario> Usuario { get; set; }
    }
}
