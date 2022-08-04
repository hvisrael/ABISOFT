using Microsoft.EntityFrameworkCore;

namespace ABISOFT.Models
{
    public class AbisoftContext : DbContext
    {
        public AbisoftContext(DbContextOptions<AbisoftContext> options) : base(options)
        {

        }
        public DbSet<Persona> Personas { get; set; }
    }
}
