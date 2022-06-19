using Microsoft.EntityFrameworkCore;

namespace Ejemplos1.Class
{
    public class HeroContext : DbContext
    {

        public HeroContext(DbContextOptions<HeroContext> options) : base(options) { }
        public DbSet<Hero> Heroes { get; set; }
    }
}
