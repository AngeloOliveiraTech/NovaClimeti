using Microsoft.EntityFrameworkCore;

namespace NovaClimeti.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Test> Test { get; set; }

    }
}
